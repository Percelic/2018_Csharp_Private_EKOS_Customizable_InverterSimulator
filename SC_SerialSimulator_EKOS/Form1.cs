using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace SC_SerialSimulator_EKOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            global.gwLogLib = new GW_LogLib(this);


            ComboBox_SerialPort.Items.Clear();
            ComboBox_SerialPort.Items.AddRange(global.gwSerialCommLib.GW_findSerialPorts().ToArray<string>());


        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button_AddEvent_Click(object sender, EventArgs e)
        {
            //ListBox_Log.Items.Add(new GW_LogLib.MyListBoxRowItem(Color.Green,"AddEvent"));
            global.gwEventCommLib.AddEventRow(EventRow_Panel);
        }

        private void Button_SaveEventList_Click(object sender, EventArgs e)
        {
            ListBox_Log.Items.Add(new GW_LogLib.MyListBoxRowItem(Color.Red, "SaveEventList"));
        }

        private void Button_LoadEventList_Click(object sender, EventArgs e)
        {
            ListBox_Log.Items.Add(new GW_LogLib.MyListBoxRowItem(Color.Blue, "LoadEventList"));
        }

        private void ListBox_Log_DrawItem(object sender, DrawItemEventArgs e)
        {

            /* OwnerDraw 모드에서 행 선택 시 행 전체 Background 색칠 */

            //if (e.Index < 0) return;

            //if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            //{
            //    e = new DrawItemEventArgs(e.Graphics,
            //                                e.Font,
            //                                e.Bounds,
            //                                e.Index,
            //                                e.State ^ DrawItemState.Selected,
            //                                e.ForeColor,
            //                                Color.SkyBlue);


            //    e.DrawBackground();
            //    e.Graphics.DrawString(ListBox_Log.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            //    e.DrawFocusRectangle();
            //}

            /* --------------------------------------------------- */


            /*  OwnerDraw 모드에서 행 단위로 글씨에 색상 입히기  */

            //GW_EventCommLib.MyListBoxRowItem item = ListBox_Log.Items[e.Index] as GW_EventCommLib.MyListBoxRowItem;

            //    if (item != null)
            //    {
            //        e.Graphics.DrawString(
            //                                  item.itemString,
            //                                  ListBox_Log.Font,
            //                                  new SolidBrush(item.itemColor),
            //                                  0,
            //                                  e.Index * ListBox_Log.ItemHeight
            //        );
            //    }

            /* -------------------------------------------------- */
        }

        private void Button_SerialOpen_Click(object sender, EventArgs e)
        {
            if (ComboBox_SerialPort.SelectedItem != null)
            {

                GW_SerialCommLib.stSerialInfo stSerial = new GW_SerialCommLib.stSerialInfo();

                stSerial.portName = ComboBox_SerialPort.SelectedItem.ToString();
                stSerial.baudRate = Int32.Parse(GroupBox_Baudrate.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text);
                stSerial.dataBit = Int32.Parse(GroupBox_Databit.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text);
                stSerial.stopBit = GroupBox_Stopbit.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text.Equals("1") ? System.IO.Ports.StopBits.One :
                                    GroupBox_Stopbit.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text.Equals("1.5") ? System.IO.Ports.StopBits.OnePointFive :
                                    GroupBox_Stopbit.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text.Equals("2") ? System.IO.Ports.StopBits.Two : System.IO.Ports.StopBits.None;

                stSerial.parity = GroupBox_Paritybit.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text.Equals("None") ? System.IO.Ports.Parity.None :
                                    GroupBox_Paritybit.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text.Equals("Odd") ? System.IO.Ports.Parity.Odd :
                                    GroupBox_Paritybit.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text.Equals("Even") ? System.IO.Ports.Parity.Even : System.IO.Ports.Parity.None;


                if (global.gwSerialCommLib.GW_connectSerialPort(stSerial).Equals(1))
                {
                    try
                    {
                        Serialstatus_Indicator.BackColor = Color.Lime;

                        ComboBox_SerialPort.Enabled = false;
                        Button_SerialOpen.Enabled = false;
                        Button_SerialRefresh.Enabled = false;

                        GroupBox_Baudrate.Enabled = false;
                        GroupBox_Databit.Enabled = false;
                        GroupBox_Stopbit.Enabled = false;
                        GroupBox_Paritybit.Enabled = false;
                        GroupBox_Inverter.Enabled = false;

                    }
                    catch (UnauthorizedAccessException uae)
                    {
                        Debug.WriteLine("Serial Port Open Denied :: " + uae.ToString());
                    }
                }

            }
        }

        private void Button_SerialClose_Click(object sender, EventArgs e)
        {
            global.gwSerialCommLib.GW_closeSerialPort();

            Serialstatus_Indicator.BackColor = Color.Red;
            ComboBox_SerialPort.Enabled = true;
            Button_SerialOpen.Enabled = true;
            Button_SerialRefresh.Enabled = true;

            GroupBox_Baudrate.Enabled = true;
            GroupBox_Databit.Enabled = true;
            GroupBox_Stopbit.Enabled = true;
            GroupBox_Paritybit.Enabled = true;
            GroupBox_Inverter.Enabled = true;
        }

        private void Button_SerialRefresh_Click(object sender, EventArgs e)
        {
            ComboBox_SerialPort.Items.Clear();
            ComboBox_SerialPort.Items.AddRange(global.gwSerialCommLib.GW_findSerialPorts().ToArray<string>());
        }

        private void CheckBox_bIDissingle_CheckedChanged(object sender, EventArgs e)
        {
            
            global.gwEventCommLib.Toggle_AllDeviceID(!((CheckBox)sender).Checked);
            
            /*  단독 사용 아닐 경우, 단독 사용 ID 잠금                 */
            //TextBox_SingleDeviceID.Enabled = ((CheckBox)sender).Checked;
        }

        delegate ListBox CrossThreadSafetyGetListbox();

        private ListBox GetListBox_Log()
        {
            return ListBox_Log;
        }

        private void Button_LogInit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("로그를 정말 초기화하시겠습니까?", "로그 초기화", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch(dr)
            {
                case DialogResult.Yes:
                    ListBox_Log.Items.Clear();
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
