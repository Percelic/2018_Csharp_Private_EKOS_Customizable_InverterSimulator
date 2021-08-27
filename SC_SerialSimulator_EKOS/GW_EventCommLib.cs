using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace SC_SerialSimulator_EKOS
{
    class GW_EventCommLib
    {
        private static List<GW_EventRow> List_GwEventRow;
        

        public GW_EventCommLib()
        {
            List_GwEventRow = new List<GW_EventRow>();
        }

        public struct GW_stEventRowData
        {
            /* Idx (1~255)          ( 1 Byte ) */ public byte        byteIdx;
            /* 활성 값               ( 1 Bit ) */ public bool        bEnable;
            /* (RECV) 장치 ID       ( 1 Byte ) */ public byte        byteDeviceID;
            /* (RECV) 주소 offset  ( 2 Bytes ) */ public ushort      usAddress;
            /* (RECV) 요청 번지수  ( 2 Bytes ) */ public ushort      usReqSize;
            /* (RECV) 송신 데이터  ( 8 Bytes ) */ public ulong       ulData;
        };

        public class GW_EventRow
        {
                /* 이벤트 Row Panel */              Panel       Row_EventPanel;
            
                /*    활성 Checkbox  */             CheckBox    Row_Checkbox_Enable;
            
                /*   0x(1) Label    */              Label       Row_0x_1;
                /*   (RECV)Device ID TextBox   */   TextBox     Row_Recv_Tbx_DeviceID;
            
                /*   0x(1) Label    */              Label       Row_0x_2;
                /*   (RECV)Address TextBox     */   TextBox     Row_Recv_Tbx_Address;
            
                /*   0x(1) Label    */              Label       Row_0x_3;
                /*   (RECV)Request Size TextBox */  TextBox     Row_Recv_Tbx_ReqSize;
            
                /*   0x(1) Label    */              Label       Row_0x_4;
                /*   (SEND)Data TextBox        */   TextBox     Row_Send_Tbx_Data;
            
                /*   Remove Button             */   Button      Row_Btn_Remove;

                                                    GW_stEventRowData stData;


            public GW_EventRow(Control parentCtrl,Point pt)
            {
                Row_EventPanel = new Panel();
                Row_Checkbox_Enable = new CheckBox();
                Row_0x_1 = new Label();
                Row_0x_2 = new Label();
                Row_0x_3 = new Label();
                Row_0x_4 = new Label();
                Row_Recv_Tbx_DeviceID = new TextBox();
                Row_Recv_Tbx_Address = new TextBox();
                Row_Recv_Tbx_ReqSize = new TextBox();
                Row_Send_Tbx_Data = new TextBox();
                Row_Btn_Remove = new Button();

                stData = new GW_stEventRowData();

                //Row_EventPanel.Name = "Row_Panel_1";
                Row_EventPanel.Size = new System.Drawing.Size(970, 35);
                //Row_Panel.TabIndex = 46;
                Row_EventPanel.BackColor = Color.LightGray;

                if (pt.Equals(null))
                {
                    Row_EventPanel.Location = new System.Drawing.Point(2, 2);
                }
                else
                {
                    Row_EventPanel.Location = new System.Drawing.Point(pt.X, pt.Y);
                }


                /*      활 성 (Checkbox)       */
                Row_Checkbox_Enable.AutoSize = true;
                Row_Checkbox_Enable.Location = new System.Drawing.Point(14, 13);
                Row_Checkbox_Enable.Name = "";
                Row_Checkbox_Enable.Size = new System.Drawing.Size(15, 14);
                Row_Checkbox_Enable.Checked = true;
                //Row_Checkbox_Enable.TabIndex 
                Row_Checkbox_Enable.UseVisualStyleBackColor = true;


                /*      Dev.ID [ 1 Byte ]         */
                Row_0x_1.AutoSize = true;
                Row_0x_1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                Row_0x_1.Location = new System.Drawing.Point(75, 8);
                Row_0x_1.Name = "0x_1";
                Row_0x_1.Size = new System.Drawing.Size(24, 20);
                //Row_0x_1.TabIndex = 48;
                Row_0x_1.Text = "0x";


                Row_Recv_Tbx_DeviceID.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                Row_Recv_Tbx_DeviceID.ForeColor = System.Drawing.Color.Red;
                Row_Recv_Tbx_DeviceID.Location = new System.Drawing.Point(100, 5);
                Row_Recv_Tbx_DeviceID.MaxLength = 2;
                //Row_Recv_Tbx_DeviceID.Name = "Tbx_DeviceID_1";
                Row_Recv_Tbx_DeviceID.Size = new System.Drawing.Size(32, 27);
                //Row_Recv_Tbx_DeviceID.TabIndex = 23;
                Row_Recv_Tbx_DeviceID.CharacterCasing = CharacterCasing.Upper;
                Row_Recv_Tbx_DeviceID.Text = "01";
                Row_Recv_Tbx_DeviceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;


                /*       Address [ 2 Bytes ]       */
                Row_0x_2.AutoSize = true;
                Row_0x_2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                Row_0x_2.Location = new System.Drawing.Point(230, 8);
                //Row_0x_2.Name = "0x_2";
                Row_0x_2.Size = new System.Drawing.Size(24, 20);
                //Row_0x_2.TabIndex = 48;
                Row_0x_2.Text = "0x";


                Row_Recv_Tbx_Address.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                Row_Recv_Tbx_Address.Location = new System.Drawing.Point(255, 5);
                Row_Recv_Tbx_Address.MaxLength = 4;
                //Row_Recv_Tbx_Address.Name = "Tbx_Address_1";
                Row_Recv_Tbx_Address.Size = new System.Drawing.Size(40, 27);
                //Row_Recv_Tbx_Address.TabIndex = 25;
                Row_Recv_Tbx_Address.CharacterCasing = CharacterCasing.Upper;
                Row_Recv_Tbx_Address.Text = "0000";
                Row_Recv_Tbx_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;


                /*       Req. Size [ 2 Bytes ]     */
                Row_0x_3.AutoSize = true;
                Row_0x_3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                Row_0x_3.Location = new System.Drawing.Point(400, 8);
                //Row_0x_3.Name = "0x_3";
                Row_0x_3.Size = new System.Drawing.Size(24, 20);
                //Row_0x_3.TabIndex = 48;
                Row_0x_3.Text = "0x";


                Row_Recv_Tbx_ReqSize.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                Row_Recv_Tbx_ReqSize.Location = new System.Drawing.Point(425, 5);
                Row_Recv_Tbx_ReqSize.MaxLength = 4;
                //Row_Recv_Tbx_ReqSize.Name = "Tbx_ReqSize_1";
                Row_Recv_Tbx_ReqSize.Size = new System.Drawing.Size(40, 27);
                Row_Recv_Tbx_ReqSize.CharacterCasing = CharacterCasing.Upper;
                //Row_Recv_Tbx_ReqSize.TabIndex = 27;
                Row_Recv_Tbx_ReqSize.Text = "0004";
                Row_Recv_Tbx_ReqSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;


                /*       Data [8 Bytes]            */
                Row_0x_4.AutoSize = true;
                Row_0x_4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                Row_0x_4.Location = new System.Drawing.Point(680, 8);
                //Row_0x_4.Name = "0x_4";
                Row_0x_4.Size = new System.Drawing.Size(24, 20);
                //Row_0x_4.TabIndex = 48;
                Row_0x_4.Text = "0x";


                Row_Send_Tbx_Data.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                Row_Send_Tbx_Data.Location = new System.Drawing.Point(705, 5);
                Row_Send_Tbx_Data.MaxLength = 32;
                //Row_Send_Tbx_Data.Name = "Tbx_Data_1";
                Row_Send_Tbx_Data.Size = new System.Drawing.Size(220, 27);
                Row_Send_Tbx_Data.CharacterCasing = CharacterCasing.Upper;
                Row_Send_Tbx_Data.TabIndex = 43;
                Row_Send_Tbx_Data.Text = "00 00 00 00 00 00 00 00";


                /*      Btn_Remove */
                Row_Btn_Remove.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                Row_Btn_Remove.Location = new System.Drawing.Point(931, 5);
                //Row_Btn_Remove.Name = "Btn_Remove_1";
                Row_Btn_Remove.Size = new System.Drawing.Size(27, 27);
                Row_Btn_Remove.TabIndex = 50;
                Row_Btn_Remove.Text = "X";
                Row_Btn_Remove.TextAlign = ContentAlignment.MiddleCenter;
                Row_Btn_Remove.UseVisualStyleBackColor = true;
                Row_Btn_Remove.Click += new System.EventHandler(RemoveButton_Event);

                parentCtrl.Controls.Add(Row_EventPanel);

                Row_EventPanel.Controls.Add(Row_Checkbox_Enable);
                Row_EventPanel.Controls.Add(Row_0x_1);
                Row_EventPanel.Controls.Add(Row_Recv_Tbx_DeviceID);
                Row_EventPanel.Controls.Add(Row_0x_2);
                Row_EventPanel.Controls.Add(Row_Recv_Tbx_Address);
                Row_EventPanel.Controls.Add(Row_0x_3);
                Row_EventPanel.Controls.Add(Row_Recv_Tbx_ReqSize);
                Row_EventPanel.Controls.Add(Row_0x_4);
                Row_EventPanel.Controls.Add(Row_Send_Tbx_Data);
                Row_EventPanel.Controls.Add(Row_Btn_Remove);

                

            }

            public GW_EventRow(Point pt, GW_stEventRowData stData)
            {
                Row_EventPanel = new Panel();

                if (!pt.Equals(null))
                {
                    Row_EventPanel.Location = new System.Drawing.Point(2, 2);
                }
                else
                {
                    Row_EventPanel.Location = new System.Drawing.Point(pt.X,pt.Y);
                }

                Row_EventPanel.Name = "Row_Panel_1";
                Row_EventPanel.Size = new System.Drawing.Size(970, 35);
                //Row_EventPanel.TabIndex = 46;
                Row_EventPanel.BackColor = Color.LightGray;


                /*      활 성 (Checkbox)       */
                Row_Checkbox_Enable.AutoSize = true;
                Row_Checkbox_Enable.Location = new System.Drawing.Point(14, 13);
                Row_Checkbox_Enable.Name = "";
                Row_Checkbox_Enable.Size = new System.Drawing.Size(15, 14);
                //Row_Checkbox_Enable.TabIndex 
                Row_Checkbox_Enable.UseVisualStyleBackColor = true;


                /*      Dev.ID [ 1 Byte ]         */
                Row_0x_1.AutoSize = true;
                Row_0x_1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                Row_0x_1.Location = new System.Drawing.Point(75, 8);
                Row_0x_1.Name = "0x_1";
                Row_0x_1.Size = new System.Drawing.Size(24, 20);
                //Row_0x_1.TabIndex = 48;
                Row_0x_1.Text = "0x";


                Row_Recv_Tbx_DeviceID.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                Row_Recv_Tbx_DeviceID.ForeColor = System.Drawing.Color.Red;
                Row_Recv_Tbx_DeviceID.Location = new System.Drawing.Point(100, 5);
                Row_Recv_Tbx_DeviceID.MaxLength = 2;
                Row_Recv_Tbx_DeviceID.Name = "Tbx_DeviceID_1";
                Row_Recv_Tbx_DeviceID.Size = new System.Drawing.Size(32, 27);
                //Row_Recv_Tbx_DeviceID.TabIndex = 23;
                Row_Recv_Tbx_DeviceID.Text = "";
                Row_Recv_Tbx_DeviceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;


                /*       Address [ 2 Bytes ]       */
                Row_0x_2.AutoSize = true;
                Row_0x_2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                Row_0x_2.Location = new System.Drawing.Point(230, 8);
                Row_0x_2.Name = "0x_2";
                Row_0x_2.Size = new System.Drawing.Size(24, 20);
                //Row_0x_2.TabIndex = 48;
                Row_0x_2.Text = "0x";


                Row_Recv_Tbx_Address.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                Row_Recv_Tbx_Address.Location = new System.Drawing.Point(255, 5);
                Row_Recv_Tbx_Address.MaxLength = 4;
                Row_Recv_Tbx_Address.Name = "Tbx_Address_1";
                Row_Recv_Tbx_Address.Size = new System.Drawing.Size(40, 27);
                //Row_Recv_Tbx_Address.TabIndex = 25;
                Row_Recv_Tbx_Address.Text = "";
                Row_Recv_Tbx_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;


                /*       Req. Size [ 2 Bytes ]     */
                Row_0x_3.AutoSize = true;
                Row_0x_3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                Row_0x_3.Location = new System.Drawing.Point(400, 8);
                Row_0x_3.Name = "0x_3";
                Row_0x_3.Size = new System.Drawing.Size(24, 20);
                //Row_0x_3.TabIndex = 48;
                Row_0x_3.Text = "0x";


                Row_Recv_Tbx_ReqSize.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                Row_Recv_Tbx_ReqSize.Location = new System.Drawing.Point(425, 5);
                Row_Recv_Tbx_ReqSize.MaxLength = 4;
                Row_Recv_Tbx_ReqSize.Name = "Tbx_ReqSize_1";
                Row_Recv_Tbx_ReqSize.Size = new System.Drawing.Size(40, 27);
                //Row_Recv_Tbx_ReqSize.TabIndex = 27;
                Row_Recv_Tbx_ReqSize.Text = "";
                Row_Recv_Tbx_ReqSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;


                /*       Data [8 Bytes]            */
                Row_0x_4.AutoSize = true;
                Row_0x_4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                Row_0x_4.Location = new System.Drawing.Point(680, 8);
                Row_0x_4.Name = "0x_4";
                Row_0x_4.Size = new System.Drawing.Size(24, 20);
                //Row_0x_4.TabIndex = 48;
                Row_0x_4.Text = "0x";


                Row_Send_Tbx_Data.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                Row_Send_Tbx_Data.Location = new System.Drawing.Point(705, 5);
                Row_Send_Tbx_Data.MaxLength = 20;
                Row_Send_Tbx_Data.Name = "Tbx_Data_1";
                Row_Send_Tbx_Data.Size = new System.Drawing.Size(220, 27);
                Row_Send_Tbx_Data.TabIndex = 43;
                Row_Send_Tbx_Data.Text = "";


                /*      Btn_Remove */
                Row_Btn_Remove.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                Row_Btn_Remove.Location = new System.Drawing.Point(931, 5);
                Row_Btn_Remove.Name = "Btn_Remove_1";
                Row_Btn_Remove.Size = new System.Drawing.Size(27, 27);
                Row_Btn_Remove.TabIndex = 50;
                Row_Btn_Remove.Text = "X";
                Row_Btn_Remove.UseVisualStyleBackColor = true;
                Row_Btn_Remove.Click += new System.EventHandler(RemoveButton_Event);

                Row_EventPanel.Controls.Add(Row_Checkbox_Enable);
                Row_EventPanel.Controls.Add(Row_0x_1);
                Row_EventPanel.Controls.Add(Row_Recv_Tbx_DeviceID);
                Row_EventPanel.Controls.Add(Row_0x_2);
                Row_EventPanel.Controls.Add(Row_Recv_Tbx_Address);
                Row_EventPanel.Controls.Add(Row_0x_3);
                Row_EventPanel.Controls.Add(Row_Recv_Tbx_ReqSize);
                Row_EventPanel.Controls.Add(Row_0x_4);
                Row_EventPanel.Controls.Add(Row_Send_Tbx_Data);
                Row_EventPanel.Controls.Add(Row_Btn_Remove);
            }

            private void RemoveButton_Event(object sender, EventArgs e)
            {
                RemoveEventRow();
                RefreshEventRowPos(List_GwEventRow);
            }

            private void RefreshEventRowPos(List<GW_EventRow> list)
            {
                foreach(GW_EventRow r in list)
                {
                    r.Row_EventPanel.Location = new Point(2, (list.IndexOf(r) * 37) - ((Panel)r.Row_EventPanel.Parent).VerticalScroll.Value);
                }
            }

            private void RemoveEventRow()
            {
                // 1. 이벤트 처리기 추가 내용을 제거
                Row_Btn_Remove.Click -= new System.EventHandler(RemoveButton_Event);

                // 2. 이벤트 Row의 부모 Panel로부터 해당 Row를 제거
                this.Row_EventPanel.Parent.Controls.Remove(Row_EventPanel);

                // 3. Dispose 호출하여 리소스 해제
                Row_EventPanel.Dispose();

                // 4. List<string> 변수에서 해당 항목 제거
                List_GwEventRow.Remove(this);
            }

            public bool GetEventRowEnable()
            {
                return Row_Checkbox_Enable.Checked;
            }

            public void Toggle_DeviceID(bool b)
            {
                this.Row_Recv_Tbx_DeviceID.Enabled = b;
            }

            public byte[] MakeRecvProtocol()
            {
                byte[] _byteToRecv = new byte[8];
                int _nValue;

                /* DeviceID ( 1 Byte )      */  _byteToRecv[0] = byte.Parse(Row_Recv_Tbx_DeviceID.Text); stData.byteDeviceID = _byteToRecv[0];

                /* Function Code ( 1 Byte ) */
                _byteToRecv[1] = 0x04;

                /* Address      ( 2 Bytes ) */
                Debug.Print(" Addr :{0}", Row_Recv_Tbx_Address.Text);
                _nValue = Int32.Parse(Row_Recv_Tbx_Address.Text, System.Globalization.NumberStyles.HexNumber);
                stData.usAddress = Convert.ToByte(_nValue);
                _byteToRecv[2] = Convert.ToByte(_nValue >> 8);
                _byteToRecv[3] = Convert.ToByte(_nValue & 0xFF);
                
                /* Req. Size    ( 2 Bytes ) */
                Debug.Print(" ReqSize : {0}",Row_Recv_Tbx_ReqSize.Text);
                _nValue = Int32.Parse(Row_Recv_Tbx_ReqSize.Text, System.Globalization.NumberStyles.HexNumber);
                stData.usReqSize = Convert.ToByte(_nValue);
                _byteToRecv[4] = Convert.ToByte(_nValue >> 8);
                _byteToRecv[5] = Convert.ToByte(_nValue & 0xFF);
                
                // | (_byteToRecv[3]);

                /* Request Size ( 2 Bytes ) */
                
                //_byteToRecv[3] = byte.Parse(Row_Recv_Tbx_ReqSize.Text) & 0x00FF;

                return _byteToRecv;
            }

            public byte[] MakeSendProtocol()
            {
                byte[] _byteToSend = new byte[5 + (stData.usReqSize * 2)];

                /* Device ID        */        _byteToSend[0] = stData.byteDeviceID;
                /* Function Code    */        _byteToSend[1] = 0x04;
                /* Send Data Size   */        _byteToSend[2] = Convert.ToByte(stData.usReqSize * 2);
                /* Data             */

                stData.ulData = ulong.Parse(Row_Send_Tbx_Data.Text.Replace(" ", ""), System.Globalization.NumberStyles.HexNumber);
                for (int i = 0; i < _byteToSend[2]; i++) {
                    _byteToSend[3 + i] = Convert.ToByte(stData.ulData >> (8 * ((_byteToSend[2] - 1) - i) ) & 0xFF);
                }

                byte[] _byteToCRC16Calc = new byte[3 + (stData.usReqSize * 2)];

                Array.Copy(_byteToSend, _byteToCRC16Calc, _byteToCRC16Calc.Length);

                ushort _usSendCRC16 = global.CRC16(_byteToCRC16Calc);
                _byteToSend[_byteToSend.Length - 2] = Convert.ToByte((_usSendCRC16) & 0xFF);
                _byteToSend[_byteToSend.Length - 1] = Convert.ToByte((_usSendCRC16 >> 8) & 0xFF);

                return _byteToSend;
            }
        }


        public void Toggle_AllDeviceID(bool b)
        {
            foreach (GW_EventRow r in List_GwEventRow)
            { 
                r.Toggle_DeviceID(b);
            }
        }

        public void AddEventRow(Control parentCtrl)
        {
            List_GwEventRow.Add(new GW_EventRow(parentCtrl, new Point(2, (List_GwEventRow.Count * 37) - ((Panel)parentCtrl).VerticalScroll.Value)));
            System.Diagnostics.Debug.Print("List_GwEventRow : {0}, (List_GwEventRow.Count * 35) + 2 : {1} \n", List_GwEventRow.Count, (List_GwEventRow.Count * 37) - ((Panel)parentCtrl).VerticalScroll.Value);
        }

        public void EventCheck(byte[] _recvMsg)
        {
            foreach(GW_EventRow r in List_GwEventRow)
            {
                byte[] _cmpByteArr = new byte[6];
                byte[] _cmpByteArr2 = new byte[6];

                Array.Copy(_recvMsg, _cmpByteArr, 6);
                Array.Copy(r.MakeRecvProtocol(), _cmpByteArr2, 6);

                if (r.GetEventRowEnable() && _cmpByteArr.SequenceEqual(_cmpByteArr2))
                {
                    global.gwSerialCommLib.GW_SendDataToSerialPort(r.MakeSendProtocol());
                }
            }
        }

        
    }
}
