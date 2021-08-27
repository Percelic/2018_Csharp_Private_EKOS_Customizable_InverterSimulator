namespace SC_SerialSimulator_EKOS
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox_Baudrate = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.GroupBox_Databit = new System.Windows.Forms.GroupBox();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.GroupBox_Stopbit = new System.Windows.Forms.GroupBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.GroupBox_Paritybit = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Serialstatus_Indicator = new System.Windows.Forms.PictureBox();
            this.Button_SerialRefresh = new System.Windows.Forms.Button();
            this.ComboBox_SerialPort = new System.Windows.Forms.ComboBox();
            this.Button_SerialClose = new System.Windows.Forms.Button();
            this.Button_SerialOpen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_AddEvent = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.EventRow_Panel = new System.Windows.Forms.Panel();
            this.GroupBox_Inverter = new System.Windows.Forms.GroupBox();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ListBox_Log = new System.Windows.Forms.ListBox();
            this.Button_SaveEventList = new System.Windows.Forms.Button();
            this.Button_LoadEventList = new System.Windows.Forms.Button();
            this.Button_AllEventRemove = new System.Windows.Forms.Button();
            this.Button_LogInit = new System.Windows.Forms.Button();
            this.GroupBox_Baudrate.SuspendLayout();
            this.GroupBox_Databit.SuspendLayout();
            this.GroupBox_Stopbit.SuspendLayout();
            this.GroupBox_Paritybit.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Serialstatus_Indicator)).BeginInit();
            this.GroupBox_Inverter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox_Baudrate
            // 
            this.GroupBox_Baudrate.Controls.Add(this.radioButton5);
            this.GroupBox_Baudrate.Controls.Add(this.radioButton6);
            this.GroupBox_Baudrate.Controls.Add(this.radioButton7);
            this.GroupBox_Baudrate.Controls.Add(this.radioButton4);
            this.GroupBox_Baudrate.Controls.Add(this.radioButton3);
            this.GroupBox_Baudrate.Controls.Add(this.radioButton2);
            this.GroupBox_Baudrate.Controls.Add(this.radioButton1);
            this.GroupBox_Baudrate.Font = new System.Drawing.Font("맑은 고딕", 11.25F);
            this.GroupBox_Baudrate.Location = new System.Drawing.Point(326, 12);
            this.GroupBox_Baudrate.Name = "GroupBox_Baudrate";
            this.GroupBox_Baudrate.Size = new System.Drawing.Size(235, 150);
            this.GroupBox_Baudrate.TabIndex = 2;
            this.GroupBox_Baudrate.TabStop = false;
            this.GroupBox_Baudrate.Text = "BaudRate";
            this.GroupBox_Baudrate.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton5.Location = new System.Drawing.Point(125, 25);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(67, 24);
            this.radioButton5.TabIndex = 7;
            this.radioButton5.Text = "38400";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton6.Location = new System.Drawing.Point(125, 55);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(67, 24);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.Text = "57600";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton7.Location = new System.Drawing.Point(125, 85);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(75, 24);
            this.radioButton7.TabIndex = 5;
            this.radioButton7.Text = "115200";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton4.Location = new System.Drawing.Point(25, 115);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(67, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "19200";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton3.Location = new System.Drawing.Point(25, 85);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "14400";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton2.Location = new System.Drawing.Point(25, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "9600";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton1.Location = new System.Drawing.Point(25, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "4800";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // GroupBox_Databit
            // 
            this.GroupBox_Databit.Controls.Add(this.radioButton11);
            this.GroupBox_Databit.Controls.Add(this.radioButton12);
            this.GroupBox_Databit.Controls.Add(this.radioButton13);
            this.GroupBox_Databit.Controls.Add(this.radioButton14);
            this.GroupBox_Databit.Font = new System.Drawing.Font("맑은 고딕", 11.25F);
            this.GroupBox_Databit.Location = new System.Drawing.Point(569, 12);
            this.GroupBox_Databit.Name = "GroupBox_Databit";
            this.GroupBox_Databit.Size = new System.Drawing.Size(120, 150);
            this.GroupBox_Databit.TabIndex = 8;
            this.GroupBox_Databit.TabStop = false;
            this.GroupBox_Databit.Text = "DataBit";
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Checked = true;
            this.radioButton11.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton11.Location = new System.Drawing.Point(22, 115);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(35, 24);
            this.radioButton11.TabIndex = 3;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "8";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton12.Location = new System.Drawing.Point(22, 85);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(35, 24);
            this.radioButton12.TabIndex = 2;
            this.radioButton12.Text = "7";
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.radioButton12_CheckedChanged);
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton13.Location = new System.Drawing.Point(22, 55);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(35, 24);
            this.radioButton13.TabIndex = 1;
            this.radioButton13.Text = "6";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton14.Location = new System.Drawing.Point(22, 25);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(35, 24);
            this.radioButton14.TabIndex = 0;
            this.radioButton14.Text = "5";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // GroupBox_Stopbit
            // 
            this.GroupBox_Stopbit.Controls.Add(this.radioButton9);
            this.GroupBox_Stopbit.Controls.Add(this.radioButton10);
            this.GroupBox_Stopbit.Controls.Add(this.radioButton15);
            this.GroupBox_Stopbit.Font = new System.Drawing.Font("맑은 고딕", 11.25F);
            this.GroupBox_Stopbit.Location = new System.Drawing.Point(694, 12);
            this.GroupBox_Stopbit.Name = "GroupBox_Stopbit";
            this.GroupBox_Stopbit.Size = new System.Drawing.Size(125, 150);
            this.GroupBox_Stopbit.TabIndex = 9;
            this.GroupBox_Stopbit.TabStop = false;
            this.GroupBox_Stopbit.Text = "StopBit";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton9.Location = new System.Drawing.Point(24, 85);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(35, 24);
            this.radioButton9.TabIndex = 2;
            this.radioButton9.Text = "2";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton10.Location = new System.Drawing.Point(24, 55);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(46, 24);
            this.radioButton10.TabIndex = 1;
            this.radioButton10.Text = "1.5";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Checked = true;
            this.radioButton15.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton15.Location = new System.Drawing.Point(24, 25);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(35, 24);
            this.radioButton15.TabIndex = 0;
            this.radioButton15.TabStop = true;
            this.radioButton15.Text = "1";
            this.radioButton15.UseVisualStyleBackColor = true;
            // 
            // GroupBox_Paritybit
            // 
            this.GroupBox_Paritybit.Controls.Add(this.radioButton8);
            this.GroupBox_Paritybit.Controls.Add(this.radioButton16);
            this.GroupBox_Paritybit.Controls.Add(this.radioButton17);
            this.GroupBox_Paritybit.Font = new System.Drawing.Font("맑은 고딕", 11.25F);
            this.GroupBox_Paritybit.Location = new System.Drawing.Point(825, 12);
            this.GroupBox_Paritybit.Name = "GroupBox_Paritybit";
            this.GroupBox_Paritybit.Size = new System.Drawing.Size(177, 150);
            this.GroupBox_Paritybit.TabIndex = 10;
            this.GroupBox_Paritybit.TabStop = false;
            this.GroupBox_Paritybit.Text = "ParityBit";
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton8.Location = new System.Drawing.Point(20, 85);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(59, 24);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.Text = "Even";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton16.Location = new System.Drawing.Point(20, 55);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(57, 24);
            this.radioButton16.TabIndex = 1;
            this.radioButton16.Text = "Odd";
            this.radioButton16.UseVisualStyleBackColor = true;
            // 
            // radioButton17
            // 
            this.radioButton17.AutoSize = true;
            this.radioButton17.Checked = true;
            this.radioButton17.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton17.Location = new System.Drawing.Point(20, 25);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(64, 24);
            this.radioButton17.TabIndex = 0;
            this.radioButton17.TabStop = true;
            this.radioButton17.Text = "None";
            this.radioButton17.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Serialstatus_Indicator);
            this.groupBox5.Controls.Add(this.Button_SerialRefresh);
            this.groupBox5.Controls.Add(this.ComboBox_SerialPort);
            this.groupBox5.Controls.Add(this.Button_SerialClose);
            this.groupBox5.Controls.Add(this.Button_SerialOpen);
            this.groupBox5.Font = new System.Drawing.Font("맑은 고딕", 11.25F);
            this.groupBox5.Location = new System.Drawing.Point(10, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(311, 150);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Serial Port ";
            // 
            // Serialstatus_Indicator
            // 
            this.Serialstatus_Indicator.BackColor = System.Drawing.Color.Red;
            this.Serialstatus_Indicator.Location = new System.Drawing.Point(30, 50);
            this.Serialstatus_Indicator.Name = "Serialstatus_Indicator";
            this.Serialstatus_Indicator.Size = new System.Drawing.Size(28, 28);
            this.Serialstatus_Indicator.TabIndex = 48;
            this.Serialstatus_Indicator.TabStop = false;
            // 
            // Button_SerialRefresh
            // 
            this.Button_SerialRefresh.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_SerialRefresh.Location = new System.Drawing.Point(168, 50);
            this.Button_SerialRefresh.Name = "Button_SerialRefresh";
            this.Button_SerialRefresh.Size = new System.Drawing.Size(126, 28);
            this.Button_SerialRefresh.TabIndex = 47;
            this.Button_SerialRefresh.Text = "재검색";
            this.Button_SerialRefresh.UseVisualStyleBackColor = true;
            this.Button_SerialRefresh.Click += new System.EventHandler(this.Button_SerialRefresh_Click);
            // 
            // ComboBox_SerialPort
            // 
            this.ComboBox_SerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_SerialPort.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ComboBox_SerialPort.FormattingEnabled = true;
            this.ComboBox_SerialPort.Items.AddRange(new object[] {
            "COM1"});
            this.ComboBox_SerialPort.Location = new System.Drawing.Point(58, 50);
            this.ComboBox_SerialPort.Name = "ComboBox_SerialPort";
            this.ComboBox_SerialPort.Size = new System.Drawing.Size(93, 28);
            this.ComboBox_SerialPort.TabIndex = 46;
            // 
            // Button_SerialClose
            // 
            this.Button_SerialClose.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_SerialClose.Location = new System.Drawing.Point(168, 99);
            this.Button_SerialClose.Name = "Button_SerialClose";
            this.Button_SerialClose.Size = new System.Drawing.Size(126, 28);
            this.Button_SerialClose.TabIndex = 45;
            this.Button_SerialClose.Text = "닫 기";
            this.Button_SerialClose.UseVisualStyleBackColor = true;
            this.Button_SerialClose.Click += new System.EventHandler(this.Button_SerialClose_Click);
            // 
            // Button_SerialOpen
            // 
            this.Button_SerialOpen.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_SerialOpen.Location = new System.Drawing.Point(30, 99);
            this.Button_SerialOpen.Name = "Button_SerialOpen";
            this.Button_SerialOpen.Size = new System.Drawing.Size(121, 28);
            this.Button_SerialOpen.TabIndex = 44;
            this.Button_SerialOpen.Text = "열 기";
            this.Button_SerialOpen.UseVisualStyleBackColor = true;
            this.Button_SerialOpen.Click += new System.EventHandler(this.Button_SerialOpen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(80, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Dev. ID [1]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(238, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Address [2] ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(406, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Req. Size [2] ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(714, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Data [ (Req.Size * 2) ] ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(765, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "응 답";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(260, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "요 청";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_AddEvent
            // 
            this.Button_AddEvent.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_AddEvent.Location = new System.Drawing.Point(10, 448);
            this.Button_AddEvent.Name = "Button_AddEvent";
            this.Button_AddEvent.Size = new System.Drawing.Size(102, 30);
            this.Button_AddEvent.TabIndex = 44;
            this.Button_AddEvent.Text = "이벤트 추가";
            this.Button_AddEvent.UseVisualStyleBackColor = true;
            this.Button_AddEvent.Click += new System.EventHandler(this.Button_AddEvent_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(15, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "활성";
            // 
            // EventRow_Panel
            // 
            this.EventRow_Panel.AutoScroll = true;
            this.EventRow_Panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EventRow_Panel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EventRow_Panel.Location = new System.Drawing.Point(10, 299);
            this.EventRow_Panel.Name = "EventRow_Panel";
            this.EventRow_Panel.Size = new System.Drawing.Size(992, 143);
            this.EventRow_Panel.TabIndex = 50;
            // 
            // GroupBox_Inverter
            // 
            this.GroupBox_Inverter.Controls.Add(this.radioButton18);
            this.GroupBox_Inverter.Font = new System.Drawing.Font("맑은 고딕", 11.25F);
            this.GroupBox_Inverter.Location = new System.Drawing.Point(10, 166);
            this.GroupBox_Inverter.Name = "GroupBox_Inverter";
            this.GroupBox_Inverter.Size = new System.Drawing.Size(992, 65);
            this.GroupBox_Inverter.TabIndex = 54;
            this.GroupBox_Inverter.TabStop = false;
            this.GroupBox_Inverter.Text = "인버터";
            // 
            // radioButton18
            // 
            this.radioButton18.AutoSize = true;
            this.radioButton18.Checked = true;
            this.radioButton18.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton18.Location = new System.Drawing.Point(25, 25);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(72, 24);
            this.radioButton18.TabIndex = 0;
            this.radioButton18.TabStop = true;
            this.radioButton18.Text = "에코스";
            this.radioButton18.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::SC_SerialSimulator_EKOS.Properties.Resources.recvArrow;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(548, 243);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 22);
            this.pictureBox6.TabIndex = 55;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox3.Location = new System.Drawing.Point(625, 263);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(310, 2);
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox2.Location = new System.Drawing.Point(65, 265);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(440, 2);
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(11, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 2);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ListBox_Log
            // 
            this.ListBox_Log.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ListBox_Log.FormattingEnabled = true;
            this.ListBox_Log.ItemHeight = 20;
            this.ListBox_Log.Location = new System.Drawing.Point(11, 485);
            this.ListBox_Log.Name = "ListBox_Log";
            this.ListBox_Log.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBox_Log.Size = new System.Drawing.Size(992, 204);
            this.ListBox_Log.TabIndex = 57;
            this.ListBox_Log.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_Log_DrawItem);
            // 
            // Button_SaveEventList
            // 
            this.Button_SaveEventList.Enabled = false;
            this.Button_SaveEventList.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_SaveEventList.Location = new System.Drawing.Point(864, 448);
            this.Button_SaveEventList.Name = "Button_SaveEventList";
            this.Button_SaveEventList.Size = new System.Drawing.Size(140, 30);
            this.Button_SaveEventList.TabIndex = 58;
            this.Button_SaveEventList.Text = "이벤트 목록 저장";
            this.Button_SaveEventList.UseVisualStyleBackColor = true;
            this.Button_SaveEventList.Click += new System.EventHandler(this.Button_SaveEventList_Click);
            // 
            // Button_LoadEventList
            // 
            this.Button_LoadEventList.Enabled = false;
            this.Button_LoadEventList.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_LoadEventList.Location = new System.Drawing.Point(685, 448);
            this.Button_LoadEventList.Name = "Button_LoadEventList";
            this.Button_LoadEventList.Size = new System.Drawing.Size(170, 30);
            this.Button_LoadEventList.TabIndex = 59;
            this.Button_LoadEventList.Text = "이벤트 목록 불러오기";
            this.Button_LoadEventList.UseVisualStyleBackColor = true;
            this.Button_LoadEventList.Click += new System.EventHandler(this.Button_LoadEventList_Click);
            // 
            // Button_AllEventRemove
            // 
            this.Button_AllEventRemove.Enabled = false;
            this.Button_AllEventRemove.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_AllEventRemove.Location = new System.Drawing.Point(118, 448);
            this.Button_AllEventRemove.Name = "Button_AllEventRemove";
            this.Button_AllEventRemove.Size = new System.Drawing.Size(132, 30);
            this.Button_AllEventRemove.TabIndex = 64;
            this.Button_AllEventRemove.Text = "이벤트 전체 삭제";
            this.Button_AllEventRemove.UseVisualStyleBackColor = true;
            // 
            // Button_LogInit
            // 
            this.Button_LogInit.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_LogInit.Location = new System.Drawing.Point(864, 694);
            this.Button_LogInit.Name = "Button_LogInit";
            this.Button_LogInit.Size = new System.Drawing.Size(140, 30);
            this.Button_LogInit.TabIndex = 65;
            this.Button_LogInit.Text = "로그 초기화";
            this.Button_LogInit.UseVisualStyleBackColor = true;
            this.Button_LogInit.Click += new System.EventHandler(this.Button_LogInit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.Button_LogInit);
            this.Controls.Add(this.Button_AllEventRemove);
            this.Controls.Add(this.Button_LoadEventList);
            this.Controls.Add(this.Button_SaveEventList);
            this.Controls.Add(this.ListBox_Log);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Button_AddEvent);
            this.Controls.Add(this.GroupBox_Inverter);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.EventRow_Panel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.GroupBox_Paritybit);
            this.Controls.Add(this.GroupBox_Stopbit);
            this.Controls.Add(this.GroupBox_Databit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.GroupBox_Baudrate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "Form1";
            this.Text = "SC-EKOS Simulator (vDevelop)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox_Baudrate.ResumeLayout(false);
            this.GroupBox_Baudrate.PerformLayout();
            this.GroupBox_Databit.ResumeLayout(false);
            this.GroupBox_Databit.PerformLayout();
            this.GroupBox_Stopbit.ResumeLayout(false);
            this.GroupBox_Stopbit.PerformLayout();
            this.GroupBox_Paritybit.ResumeLayout(false);
            this.GroupBox_Paritybit.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Serialstatus_Indicator)).EndInit();
            this.GroupBox_Inverter.ResumeLayout(false);
            this.GroupBox_Inverter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GroupBox_Baudrate;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox GroupBox_Databit;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.GroupBox GroupBox_Stopbit;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.GroupBox GroupBox_Paritybit;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.RadioButton radioButton17;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Button_SerialRefresh;
        private System.Windows.Forms.ComboBox ComboBox_SerialPort;
        private System.Windows.Forms.Button Button_SerialClose;
        private System.Windows.Forms.Button Button_SerialOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_AddEvent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel EventRow_Panel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox GroupBox_Inverter;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Windows.Forms.PictureBox Serialstatus_Indicator;
        private System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.ListBox ListBox_Log;
        private System.Windows.Forms.Button Button_SaveEventList;
        private System.Windows.Forms.Button Button_LoadEventList;
        private System.Windows.Forms.Button Button_AllEventRemove;
        private System.Windows.Forms.Button Button_LogInit;
    }
}

