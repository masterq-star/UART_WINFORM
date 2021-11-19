namespace HP_software
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.tab_control = new MetroSet_UI.Controls.MetroSetTabControl();
            this.metroSetSetTabPage1 = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.roundPanel2 = new RoundPanel();
            this.tb_receive_data = new System.Windows.Forms.RichTextBox();
            this.btn_send_data = new MetroSet_UI.Controls.MetroSetButton();
            this.tb_send_data = new System.Windows.Forms.TextBox();
            this.vbButton1 = new CustomButton.VBButton();
            this.roundPanel1 = new RoundPanel();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.cbb_port_name = new MetroSet_UI.Controls.MetroSetComboBox();
            this.cbb_stop_bits = new MetroSet_UI.Controls.MetroSetComboBox();
            this.cbb_baudrate = new MetroSet_UI.Controls.MetroSetComboBox();
            this.cbb_parity_bits = new MetroSet_UI.Controls.MetroSetComboBox();
            this.cbb_datasize = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetSetTabPage2 = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.btn_test_json = new System.Windows.Forms.Button();
            this.tbjson = new System.Windows.Forms.TextBox();
            this.test_receive_data = new System.Windows.Forms.RichTextBox();
            this.metroSetSetTabPage3 = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.ucWave1 = new HZH_Controls.Controls.UCWave();
            this.spinner_test = new MetroFramework.Controls.MetroProgressSpinner();
            this.ucProcessWave2 = new HZH_Controls.Controls.UCProcessWave();
            this.ucProcessWave1 = new HZH_Controls.Controls.UCProcessWave();
            this.metroSetSetTabPage4 = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.metroSetSetTabPage5 = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NewPort = new System.IO.Ports.SerialPort(this.components);
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tab_control.SuspendLayout();
            this.metroSetSetTabPage1.SuspendLayout();
            this.roundPanel2.SuspendLayout();
            this.roundPanel1.SuspendLayout();
            this.metroSetSetTabPage2.SuspendLayout();
            this.metroSetSetTabPage3.SuspendLayout();
            this.metroSetSetTabPage4.SuspendLayout();
            this.metroSetSetTabPage5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(857, 3);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // tab_control
            // 
            this.tab_control.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_control.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.tab_control.AnimateTime = 200;
            this.tab_control.BackgroundColor = System.Drawing.Color.White;
            this.tab_control.Controls.Add(this.metroSetSetTabPage1);
            this.tab_control.Controls.Add(this.metroSetSetTabPage2);
            this.tab_control.Controls.Add(this.metroSetSetTabPage3);
            this.tab_control.Controls.Add(this.metroSetSetTabPage4);
            this.tab_control.Controls.Add(this.metroSetSetTabPage5);
            this.tab_control.Cursor = System.Windows.Forms.Cursors.Default;
            this.tab_control.IsDerivedStyle = true;
            this.tab_control.ItemSize = new System.Drawing.Size(100, 38);
            this.tab_control.Location = new System.Drawing.Point(0, 86);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 2;
            this.tab_control.SelectedTextColor = System.Drawing.Color.White;
            this.tab_control.Size = new System.Drawing.Size(961, 452);
            this.tab_control.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_control.Speed = 100;
            this.tab_control.Style = MetroSet_UI.Enums.Style.Light;
            this.tab_control.StyleManager = null;
            this.tab_control.TabIndex = 1;
            this.tab_control.TabStyle = MetroSet_UI.Enums.TabStyle.Style2;
            this.tab_control.ThemeAuthor = "Narwin";
            this.tab_control.ThemeName = "MetroLite";
            this.tab_control.UnselectedTextColor = System.Drawing.Color.Gray;
            this.tab_control.UseAnimation = false;
            // 
            // metroSetSetTabPage1
            // 
            this.metroSetSetTabPage1.BaseColor = System.Drawing.Color.White;
            this.metroSetSetTabPage1.Controls.Add(this.roundPanel2);
            this.metroSetSetTabPage1.Controls.Add(this.vbButton1);
            this.metroSetSetTabPage1.Controls.Add(this.roundPanel1);
            this.metroSetSetTabPage1.Font = null;
            this.metroSetSetTabPage1.ImageIndex = 0;
            this.metroSetSetTabPage1.ImageKey = null;
            this.metroSetSetTabPage1.IsDerivedStyle = true;
            this.metroSetSetTabPage1.Location = new System.Drawing.Point(4, 42);
            this.metroSetSetTabPage1.Name = "metroSetSetTabPage1";
            this.metroSetSetTabPage1.Size = new System.Drawing.Size(953, 406);
            this.metroSetSetTabPage1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetSetTabPage1.StyleManager = null;
            this.metroSetSetTabPage1.TabIndex = 0;
            this.metroSetSetTabPage1.Text = "Connect device";
            this.metroSetSetTabPage1.ThemeAuthor = "Narwin";
            this.metroSetSetTabPage1.ThemeName = "MetroLite";
            this.metroSetSetTabPage1.ToolTipText = null;
            // 
            // roundPanel2
            // 
            this.roundPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundPanel2.BackColor = System.Drawing.Color.Transparent;
            this.roundPanel2.Controls.Add(this.tb_receive_data);
            this.roundPanel2.Controls.Add(this.btn_send_data);
            this.roundPanel2.Controls.Add(this.tb_send_data);
            this.roundPanel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.roundPanel2.Location = new System.Drawing.Point(429, 24);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Radious = 25;
            this.roundPanel2.Size = new System.Drawing.Size(516, 357);
            this.roundPanel2.TabIndex = 6;
            this.roundPanel2.TabStop = false;
            this.roundPanel2.Text = "Data ";
            this.roundPanel2.TitleBackColor = System.Drawing.Color.SteelBlue;
            this.roundPanel2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.roundPanel2.TitleForeColor = System.Drawing.Color.White;
            this.roundPanel2.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // tb_receive_data
            // 
            this.tb_receive_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_receive_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_receive_data.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_receive_data.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_receive_data.Location = new System.Drawing.Point(15, 40);
            this.tb_receive_data.Name = "tb_receive_data";
            this.tb_receive_data.ReadOnly = true;
            this.tb_receive_data.Size = new System.Drawing.Size(486, 255);
            this.tb_receive_data.TabIndex = 7;
            this.tb_receive_data.Text = "";
            this.tb_receive_data.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tb_receive_data_MouseMove);
            // 
            // btn_send_data
            // 
            this.btn_send_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_send_data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_send_data.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_send_data.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_send_data.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_send_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_send_data.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_send_data.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_send_data.HoverTextColor = System.Drawing.Color.White;
            this.btn_send_data.IsDerivedStyle = true;
            this.btn_send_data.Location = new System.Drawing.Point(415, 301);
            this.btn_send_data.Name = "btn_send_data";
            this.btn_send_data.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_send_data.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_send_data.NormalTextColor = System.Drawing.Color.White;
            this.btn_send_data.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_send_data.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_send_data.PressTextColor = System.Drawing.Color.White;
            this.btn_send_data.Size = new System.Drawing.Size(86, 23);
            this.btn_send_data.Style = MetroSet_UI.Enums.Style.Light;
            this.btn_send_data.StyleManager = null;
            this.btn_send_data.TabIndex = 6;
            this.btn_send_data.Text = "send";
            this.btn_send_data.ThemeAuthor = "Narwin";
            this.btn_send_data.ThemeName = "MetroLite";
            this.btn_send_data.Click += new System.EventHandler(this.btn_send_data_Click);
            // 
            // tb_send_data
            // 
            this.tb_send_data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_send_data.Location = new System.Drawing.Point(15, 301);
            this.tb_send_data.Name = "tb_send_data";
            this.tb_send_data.Size = new System.Drawing.Size(394, 23);
            this.tb_send_data.TabIndex = 5;
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.vbButton1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.vbButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton1.BorderRadius = 20;
            this.vbButton1.BorderSize = 0;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.ForeColor = System.Drawing.Color.White;
            this.vbButton1.Location = new System.Drawing.Point(142, 319);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(150, 40);
            this.vbButton1.TabIndex = 3;
            this.vbButton1.Text = "Connect";
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            this.vbButton1.Click += new System.EventHandler(this.vbButton1_Click);
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundPanel1.Controls.Add(this.metroSetLabel5);
            this.roundPanel1.Controls.Add(this.metroSetLabel3);
            this.roundPanel1.Controls.Add(this.metroSetLabel2);
            this.roundPanel1.Controls.Add(this.metroSetLabel4);
            this.roundPanel1.Controls.Add(this.metroSetLabel1);
            this.roundPanel1.Controls.Add(this.cbb_port_name);
            this.roundPanel1.Controls.Add(this.cbb_stop_bits);
            this.roundPanel1.Controls.Add(this.cbb_baudrate);
            this.roundPanel1.Controls.Add(this.cbb_parity_bits);
            this.roundPanel1.Controls.Add(this.cbb_datasize);
            this.roundPanel1.Location = new System.Drawing.Point(43, 24);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Radious = 25;
            this.roundPanel1.Size = new System.Drawing.Size(339, 277);
            this.roundPanel1.TabIndex = 2;
            this.roundPanel1.TabStop = false;
            this.roundPanel1.Text = "Information Port";
            this.roundPanel1.TitleBackColor = System.Drawing.Color.SteelBlue;
            this.roundPanel1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundPanel1.TitleForeColor = System.Drawing.Color.White;
            this.roundPanel1.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(40, 142);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 5;
            this.metroSetLabel5.Text = "Data size";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(40, 225);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 5;
            this.metroSetLabel3.Text = "Stop bits";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(40, 101);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 5;
            this.metroSetLabel2.Text = "Baud rate";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(40, 183);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 5;
            this.metroSetLabel4.Text = "Parity Bits";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(40, 59);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 4;
            this.metroSetLabel1.Text = "Port name";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // cbb_port_name
            // 
            this.cbb_port_name.AllowDrop = true;
            this.cbb_port_name.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbb_port_name.BackColor = System.Drawing.Color.Transparent;
            this.cbb_port_name.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cbb_port_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbb_port_name.CausesValidation = false;
            this.cbb_port_name.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbb_port_name.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cbb_port_name.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cbb_port_name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_port_name.DropDownHeight = 100;
            this.cbb_port_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_port_name.DropDownWidth = 100;
            this.cbb_port_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbb_port_name.FormattingEnabled = true;
            this.cbb_port_name.IntegralHeight = false;
            this.cbb_port_name.IsDerivedStyle = true;
            this.cbb_port_name.ItemHeight = 20;
            this.cbb_port_name.Location = new System.Drawing.Point(155, 56);
            this.cbb_port_name.Name = "cbb_port_name";
            this.cbb_port_name.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cbb_port_name.SelectedItemForeColor = System.Drawing.Color.White;
            this.cbb_port_name.Size = new System.Drawing.Size(149, 26);
            this.cbb_port_name.Style = MetroSet_UI.Enums.Style.Light;
            this.cbb_port_name.StyleManager = null;
            this.cbb_port_name.TabIndex = 0;
            this.cbb_port_name.ThemeAuthor = "Narwin";
            this.cbb_port_name.ThemeName = "MetroLite";
            // 
            // cbb_stop_bits
            // 
            this.cbb_stop_bits.AllowDrop = true;
            this.cbb_stop_bits.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbb_stop_bits.BackColor = System.Drawing.Color.Transparent;
            this.cbb_stop_bits.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cbb_stop_bits.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbb_stop_bits.CausesValidation = false;
            this.cbb_stop_bits.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbb_stop_bits.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cbb_stop_bits.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cbb_stop_bits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_stop_bits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_stop_bits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbb_stop_bits.FormattingEnabled = true;
            this.cbb_stop_bits.IsDerivedStyle = true;
            this.cbb_stop_bits.ItemHeight = 20;
            this.cbb_stop_bits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cbb_stop_bits.Location = new System.Drawing.Point(155, 222);
            this.cbb_stop_bits.Name = "cbb_stop_bits";
            this.cbb_stop_bits.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cbb_stop_bits.SelectedItemForeColor = System.Drawing.Color.White;
            this.cbb_stop_bits.Size = new System.Drawing.Size(149, 26);
            this.cbb_stop_bits.Style = MetroSet_UI.Enums.Style.Light;
            this.cbb_stop_bits.StyleManager = null;
            this.cbb_stop_bits.TabIndex = 2;
            this.cbb_stop_bits.ThemeAuthor = "Narwin";
            this.cbb_stop_bits.ThemeName = "MetroLite";
            // 
            // cbb_baudrate
            // 
            this.cbb_baudrate.AllowDrop = true;
            this.cbb_baudrate.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbb_baudrate.BackColor = System.Drawing.Color.Transparent;
            this.cbb_baudrate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cbb_baudrate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbb_baudrate.CausesValidation = false;
            this.cbb_baudrate.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbb_baudrate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cbb_baudrate.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cbb_baudrate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_baudrate.DropDownHeight = 100;
            this.cbb_baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_baudrate.DropDownWidth = 100;
            this.cbb_baudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbb_baudrate.FormattingEnabled = true;
            this.cbb_baudrate.IntegralHeight = false;
            this.cbb_baudrate.IsDerivedStyle = true;
            this.cbb_baudrate.ItemHeight = 20;
            this.cbb_baudrate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "28800",
            "38400",
            "57600",
            "76800",
            "115200",
            "230400",
            "460800",
            "57600",
            "921600"});
            this.cbb_baudrate.Location = new System.Drawing.Point(155, 98);
            this.cbb_baudrate.Name = "cbb_baudrate";
            this.cbb_baudrate.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cbb_baudrate.SelectedItemForeColor = System.Drawing.Color.White;
            this.cbb_baudrate.Size = new System.Drawing.Size(149, 26);
            this.cbb_baudrate.Style = MetroSet_UI.Enums.Style.Light;
            this.cbb_baudrate.StyleManager = null;
            this.cbb_baudrate.TabIndex = 2;
            this.cbb_baudrate.ThemeAuthor = "Narwin";
            this.cbb_baudrate.ThemeName = "MetroLite";
            // 
            // cbb_parity_bits
            // 
            this.cbb_parity_bits.AllowDrop = true;
            this.cbb_parity_bits.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbb_parity_bits.BackColor = System.Drawing.Color.Transparent;
            this.cbb_parity_bits.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cbb_parity_bits.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbb_parity_bits.CausesValidation = false;
            this.cbb_parity_bits.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbb_parity_bits.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cbb_parity_bits.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cbb_parity_bits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_parity_bits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_parity_bits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbb_parity_bits.FormattingEnabled = true;
            this.cbb_parity_bits.IsDerivedStyle = true;
            this.cbb_parity_bits.ItemHeight = 20;
            this.cbb_parity_bits.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark"});
            this.cbb_parity_bits.Location = new System.Drawing.Point(155, 180);
            this.cbb_parity_bits.Name = "cbb_parity_bits";
            this.cbb_parity_bits.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cbb_parity_bits.SelectedItemForeColor = System.Drawing.Color.White;
            this.cbb_parity_bits.Size = new System.Drawing.Size(149, 26);
            this.cbb_parity_bits.Style = MetroSet_UI.Enums.Style.Light;
            this.cbb_parity_bits.StyleManager = null;
            this.cbb_parity_bits.TabIndex = 2;
            this.cbb_parity_bits.ThemeAuthor = "Narwin";
            this.cbb_parity_bits.ThemeName = "MetroLite";
            // 
            // cbb_datasize
            // 
            this.cbb_datasize.AllowDrop = true;
            this.cbb_datasize.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbb_datasize.BackColor = System.Drawing.Color.Transparent;
            this.cbb_datasize.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cbb_datasize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbb_datasize.CausesValidation = false;
            this.cbb_datasize.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbb_datasize.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cbb_datasize.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cbb_datasize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_datasize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_datasize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbb_datasize.FormattingEnabled = true;
            this.cbb_datasize.IsDerivedStyle = true;
            this.cbb_datasize.ItemHeight = 20;
            this.cbb_datasize.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cbb_datasize.Location = new System.Drawing.Point(155, 139);
            this.cbb_datasize.Name = "cbb_datasize";
            this.cbb_datasize.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cbb_datasize.SelectedItemForeColor = System.Drawing.Color.White;
            this.cbb_datasize.Size = new System.Drawing.Size(149, 26);
            this.cbb_datasize.Style = MetroSet_UI.Enums.Style.Light;
            this.cbb_datasize.StyleManager = null;
            this.cbb_datasize.TabIndex = 3;
            this.cbb_datasize.ThemeAuthor = "Narwin";
            this.cbb_datasize.ThemeName = "MetroLite";
            // 
            // metroSetSetTabPage2
            // 
            this.metroSetSetTabPage2.BaseColor = System.Drawing.Color.White;
            this.metroSetSetTabPage2.Controls.Add(this.btn_test_json);
            this.metroSetSetTabPage2.Controls.Add(this.tbjson);
            this.metroSetSetTabPage2.Controls.Add(this.test_receive_data);
            this.metroSetSetTabPage2.Font = null;
            this.metroSetSetTabPage2.ImageIndex = 0;
            this.metroSetSetTabPage2.ImageKey = null;
            this.metroSetSetTabPage2.IsDerivedStyle = true;
            this.metroSetSetTabPage2.Location = new System.Drawing.Point(4, 42);
            this.metroSetSetTabPage2.Name = "metroSetSetTabPage2";
            this.metroSetSetTabPage2.Size = new System.Drawing.Size(953, 406);
            this.metroSetSetTabPage2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetSetTabPage2.StyleManager = null;
            this.metroSetSetTabPage2.TabIndex = 1;
            this.metroSetSetTabPage2.Text = "View Chart";
            this.metroSetSetTabPage2.ThemeAuthor = "Narwin";
            this.metroSetSetTabPage2.ThemeName = "MetroLite";
            this.metroSetSetTabPage2.ToolTipText = null;
            // 
            // btn_test_json
            // 
            this.btn_test_json.Location = new System.Drawing.Point(805, 57);
            this.btn_test_json.Name = "btn_test_json";
            this.btn_test_json.Size = new System.Drawing.Size(75, 23);
            this.btn_test_json.TabIndex = 2;
            this.btn_test_json.Text = "button1";
            this.btn_test_json.UseVisualStyleBackColor = true;
            this.btn_test_json.Click += new System.EventHandler(this.btn_test_json_Click);
            // 
            // tbjson
            // 
            this.tbjson.Location = new System.Drawing.Point(164, 57);
            this.tbjson.Name = "tbjson";
            this.tbjson.Size = new System.Drawing.Size(620, 23);
            this.tbjson.TabIndex = 1;
            // 
            // test_receive_data
            // 
            this.test_receive_data.Location = new System.Drawing.Point(164, 125);
            this.test_receive_data.Name = "test_receive_data";
            this.test_receive_data.Size = new System.Drawing.Size(620, 239);
            this.test_receive_data.TabIndex = 0;
            this.test_receive_data.Text = "";
            // 
            // metroSetSetTabPage3
            // 
            this.metroSetSetTabPage3.BaseColor = System.Drawing.Color.White;
            this.metroSetSetTabPage3.Controls.Add(this.groupBox6);
            this.metroSetSetTabPage3.Controls.Add(this.ucWave1);
            this.metroSetSetTabPage3.Controls.Add(this.spinner_test);
            this.metroSetSetTabPage3.Controls.Add(this.ucProcessWave2);
            this.metroSetSetTabPage3.Controls.Add(this.ucProcessWave1);
            this.metroSetSetTabPage3.Font = null;
            this.metroSetSetTabPage3.ImageIndex = 0;
            this.metroSetSetTabPage3.ImageKey = null;
            this.metroSetSetTabPage3.IsDerivedStyle = true;
            this.metroSetSetTabPage3.Location = new System.Drawing.Point(4, 42);
            this.metroSetSetTabPage3.Name = "metroSetSetTabPage3";
            this.metroSetSetTabPage3.Size = new System.Drawing.Size(953, 406);
            this.metroSetSetTabPage3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetSetTabPage3.StyleManager = null;
            this.metroSetSetTabPage3.TabIndex = 2;
            this.metroSetSetTabPage3.Text = "simulation";
            this.metroSetSetTabPage3.ThemeAuthor = "Narwin";
            this.metroSetSetTabPage3.ThemeName = "MetroLite";
            this.metroSetSetTabPage3.ToolTipText = null;
            // 
            // ucWave1
            // 
            this.ucWave1.Location = new System.Drawing.Point(0, 240);
            this.ucWave1.Name = "ucWave1";
            this.ucWave1.Size = new System.Drawing.Size(320, 59);
            this.ucWave1.TabIndex = 6;
            this.ucWave1.WaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ucWave1.WaveHeight = 10;
            this.ucWave1.WaveSleep = 20;
            this.ucWave1.WaveWidth = 150;
            // 
            // spinner_test
            // 
            this.spinner_test.BackColor = System.Drawing.Color.White;
            this.spinner_test.Location = new System.Drawing.Point(115, 175);
            this.spinner_test.Maximum = 100;
            this.spinner_test.Name = "spinner_test";
            this.spinner_test.Size = new System.Drawing.Size(76, 71);
            this.spinner_test.Speed = 2F;
            this.spinner_test.TabIndex = 5;
            this.spinner_test.Theme = MetroFramework.MetroThemeStyle.Light;
            this.spinner_test.UseSelectable = true;
            // 
            // ucProcessWave2
            // 
            this.ucProcessWave2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucProcessWave2.ConerRadius = 0;
            this.ucProcessWave2.FillColor = System.Drawing.Color.Empty;
            this.ucProcessWave2.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucProcessWave2.ForeColor = System.Drawing.Color.Black;
            this.ucProcessWave2.IsRadius = false;
            this.ucProcessWave2.IsRectangle = true;
            this.ucProcessWave2.IsShowRect = true;
            this.ucProcessWave2.Location = new System.Drawing.Point(198, 90);
            this.ucProcessWave2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucProcessWave2.MaxValue = 100;
            this.ucProcessWave2.Name = "ucProcessWave2";
            this.ucProcessWave2.RectColor = System.Drawing.Color.White;
            this.ucProcessWave2.RectWidth = 4;
            this.ucProcessWave2.Size = new System.Drawing.Size(99, 156);
            this.ucProcessWave2.TabIndex = 2;
            this.ucProcessWave2.Value = 0;
            this.ucProcessWave2.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            // 
            // ucProcessWave1
            // 
            this.ucProcessWave1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ucProcessWave1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucProcessWave1.ConerRadius = 0;
            this.ucProcessWave1.FillColor = System.Drawing.Color.Empty;
            this.ucProcessWave1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucProcessWave1.ForeColor = System.Drawing.Color.Black;
            this.ucProcessWave1.IsRadius = false;
            this.ucProcessWave1.IsRectangle = true;
            this.ucProcessWave1.IsShowRect = false;
            this.ucProcessWave1.Location = new System.Drawing.Point(33, 134);
            this.ucProcessWave1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucProcessWave1.MaxValue = 100;
            this.ucProcessWave1.Name = "ucProcessWave1";
            this.ucProcessWave1.RectColor = System.Drawing.Color.White;
            this.ucProcessWave1.RectWidth = 4;
            this.ucProcessWave1.Size = new System.Drawing.Size(75, 112);
            this.ucProcessWave1.TabIndex = 1;
            this.ucProcessWave1.Value = 0;
            this.ucProcessWave1.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            // 
            // metroSetSetTabPage4
            // 
            this.metroSetSetTabPage4.BaseColor = System.Drawing.Color.White;
            this.metroSetSetTabPage4.Controls.Add(this.groupBox5);
            this.metroSetSetTabPage4.Controls.Add(this.groupBox4);
            this.metroSetSetTabPage4.Font = null;
            this.metroSetSetTabPage4.ImageIndex = 0;
            this.metroSetSetTabPage4.ImageKey = null;
            this.metroSetSetTabPage4.IsDerivedStyle = true;
            this.metroSetSetTabPage4.Location = new System.Drawing.Point(4, 42);
            this.metroSetSetTabPage4.Name = "metroSetSetTabPage4";
            this.metroSetSetTabPage4.Size = new System.Drawing.Size(953, 406);
            this.metroSetSetTabPage4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetSetTabPage4.StyleManager = null;
            this.metroSetSetTabPage4.TabIndex = 3;
            this.metroSetSetTabPage4.Text = "Pan teacher";
            this.metroSetSetTabPage4.ThemeAuthor = "Narwin";
            this.metroSetSetTabPage4.ThemeName = "MetroLite";
            this.metroSetSetTabPage4.ToolTipText = null;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(15, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(278, 206);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(299, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(630, 360);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // metroSetSetTabPage5
            // 
            this.metroSetSetTabPage5.BaseColor = System.Drawing.Color.White;
            this.metroSetSetTabPage5.Controls.Add(this.groupBox3);
            this.metroSetSetTabPage5.Controls.Add(this.groupBox2);
            this.metroSetSetTabPage5.Font = null;
            this.metroSetSetTabPage5.ImageIndex = 0;
            this.metroSetSetTabPage5.ImageKey = null;
            this.metroSetSetTabPage5.IsDerivedStyle = true;
            this.metroSetSetTabPage5.Location = new System.Drawing.Point(4, 42);
            this.metroSetSetTabPage5.Name = "metroSetSetTabPage5";
            this.metroSetSetTabPage5.Size = new System.Drawing.Size(953, 406);
            this.metroSetSetTabPage5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetSetTabPage5.StyleManager = null;
            this.metroSetSetTabPage5.TabIndex = 4;
            this.metroSetSetTabPage5.Text = "Pan Student";
            this.metroSetSetTabPage5.ThemeAuthor = "Narwin";
            this.metroSetSetTabPage5.ThemeName = "MetroLite";
            this.metroSetSetTabPage5.ToolTipText = null;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(15, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 206);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(299, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 360);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // NewPort
            // 
            this.NewPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.NewPort_DataReceived);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton1);
            this.groupBox6.Location = new System.Drawing.Point(352, 40);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(338, 349);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "machine status";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Enabled = false;
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(89, 322);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(116, 21);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Connect satus";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.tab_control);
            this.Controls.Add(this.metroSetControlBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HydroPower software";
            this.TextAlign = MetroSet_UI.Enums.TextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_control.ResumeLayout(false);
            this.metroSetSetTabPage1.ResumeLayout(false);
            this.roundPanel2.ResumeLayout(false);
            this.roundPanel2.PerformLayout();
            this.roundPanel1.ResumeLayout(false);
            this.metroSetSetTabPage2.ResumeLayout(false);
            this.metroSetSetTabPage2.PerformLayout();
            this.metroSetSetTabPage3.ResumeLayout(false);
            this.metroSetSetTabPage4.ResumeLayout(false);
            this.metroSetSetTabPage5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage1;
        private MetroSet_UI.Controls.MetroSetComboBox cbb_stop_bits;
        private MetroSet_UI.Controls.MetroSetComboBox cbb_parity_bits;
        private MetroSet_UI.Controls.MetroSetComboBox cbb_datasize;
        private MetroSet_UI.Controls.MetroSetComboBox cbb_baudrate;
        private MetroSet_UI.Controls.MetroSetComboBox cbb_port_name;
        private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage2;
        private RoundPanel roundPanel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private CustomButton.VBButton vbButton1;
        private RoundPanel roundPanel2;
        private System.Windows.Forms.TextBox tb_send_data;
        private MetroSet_UI.Controls.MetroSetButton btn_send_data;
        private System.IO.Ports.SerialPort NewPort;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.RichTextBox tb_receive_data;
        private System.Windows.Forms.RichTextBox test_receive_data;
        private System.Windows.Forms.Button btn_test_json;
        private System.Windows.Forms.TextBox tbjson;
        private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage3;
        private HZH_Controls.Controls.UCProcessWave ucProcessWave1;
        private HZH_Controls.Controls.UCProcessWave ucProcessWave2;
        private MetroFramework.Controls.MetroProgressSpinner spinner_test;
        private HZH_Controls.Controls.UCWave ucWave1;
        private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage4;
        private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroSet_UI.Controls.MetroSetTabControl tab_control;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

