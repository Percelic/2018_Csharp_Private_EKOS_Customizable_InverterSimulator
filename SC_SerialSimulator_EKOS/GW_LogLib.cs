using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SC_SerialSimulator_EKOS
{
    class GW_LogLib
    {
        Form1 form1 = null;

        /* 1. define Variable Parts ----------------------------------------- */

        private bool bTimestamp = true;
        private ListBox lb_Log = new ListBox();



        /* 2. Method Parts -------------------------------------------------- */

        public void SetLogOpt()
        {

        }

        public void Append_Log(string sMsgID,byte[] byteArr)
        {
            string _logString = "";

            foreach(byte _b in byteArr)
            {
               _logString += string.Format("{0:X02}",_b);
               _logString += " ";
            }

            /* 크로스 스레드 에러 발생 */
            form1.ListBox_Log.Invoke(new Action(delegate
            {
                if (form1.ListBox_Log.Items.Count > 10240)
                    form1.ListBox_Log.Items.Clear();

                form1.ListBox_Log.Items.Insert(0,"[" + DateTime.Now.ToString("yy-MM-dd_HH:mm:ss") + "]\t " + sMsgID + _logString);
            }));            
        }

        /* 3. Class Parts --------------------------------------------------- */
        public GW_LogLib(Form1 form1)
        {
            this.form1 = form1;
        }

        public class MyListBoxRowItem
        {
            public MyListBoxRowItem(Color c, string m)
            {
                itemColor = c;
                itemString = m;
            }

            public Color itemColor { get; set; }
            public string itemString { get; set; }
        }
    }
}
