namespace Connect_Four
{
	partial class GameForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Board = new System.Windows.Forms.Button();
			this.R0C5 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.R0C3 = new System.Windows.Forms.Button();
			this.button16 = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.button18 = new System.Windows.Forms.Button();
			this.button19 = new System.Windows.Forms.Button();
			this.button20 = new System.Windows.Forms.Button();
			this.R1C2 = new System.Windows.Forms.Button();
			this.R0C2 = new System.Windows.Forms.Button();
			this.button23 = new System.Windows.Forms.Button();
			this.button24 = new System.Windows.Forms.Button();
			this.button25 = new System.Windows.Forms.Button();
			this.button26 = new System.Windows.Forms.Button();
			this.button27 = new System.Windows.Forms.Button();
			this.button28 = new System.Windows.Forms.Button();
			this.R0C4 = new System.Windows.Forms.Button();
			this.button30 = new System.Windows.Forms.Button();
			this.button31 = new System.Windows.Forms.Button();
			this.button32 = new System.Windows.Forms.Button();
			this.button33 = new System.Windows.Forms.Button();
			this.button34 = new System.Windows.Forms.Button();
			this.R1C1 = new System.Windows.Forms.Button();
			this.R0C1 = new System.Windows.Forms.Button();
			this.button37 = new System.Windows.Forms.Button();
			this.R0C0 = new System.Windows.Forms.Button();
			this.button44 = new System.Windows.Forms.Button();
			this.R1C0 = new System.Windows.Forms.Button();
			this.button45 = new System.Windows.Forms.Button();
			this.button46 = new System.Windows.Forms.Button();
			this.button47 = new System.Windows.Forms.Button();
			this.button48 = new System.Windows.Forms.Button();
			this.SettingPanel = new System.Windows.Forms.Panel();
			this.SpeedTrackBar = new System.Windows.Forms.TrackBar();
			this.cb_Uncloseable = new System.Windows.Forms.CheckBox();
			this.cb_Notification = new System.Windows.Forms.CheckBox();
			this.cb_Music = new System.Windows.Forms.CheckBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.ApplyButton = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.chk_AI = new System.Windows.Forms.CheckBox();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.boardColorPicker = new System.Windows.Forms.ColorDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SettingPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(76, 10);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(405, 66);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// Board
			// 
			this.Board.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.Board.Enabled = false;
			this.Board.Location = new System.Drawing.Point(5, 89);
			this.Board.Margin = new System.Windows.Forms.Padding(2);
			this.Board.Name = "Board";
			this.Board.Size = new System.Drawing.Size(560, 512);
			this.Board.TabIndex = 1;
			this.Board.UseVisualStyleBackColor = false;
			// 
			// R0C5
			// 
			this.R0C5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
			this.R0C5.Location = new System.Drawing.Point(22, 110);
			this.R0C5.Margin = new System.Windows.Forms.Padding(2);
			this.R0C5.Name = "R0C5";
			this.R0C5.Size = new System.Drawing.Size(52, 57);
			this.R0C5.TabIndex = 2;
			this.R0C5.UseVisualStyleBackColor = true;
			this.R0C5.Click += new System.EventHandler(this.R1_clicked);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
			this.button3.Location = new System.Drawing.Point(100, 110);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(52, 57);
			this.button3.TabIndex = 3;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.R2_click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
			this.button4.Location = new System.Drawing.Point(179, 110);
			this.button4.Margin = new System.Windows.Forms.Padding(2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(52, 57);
			this.button4.TabIndex = 4;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.R3_click);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
			this.button5.Location = new System.Drawing.Point(258, 110);
			this.button5.Margin = new System.Windows.Forms.Padding(2);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(52, 57);
			this.button5.TabIndex = 5;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.R4_click);
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
			this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button6.Location = new System.Drawing.Point(337, 110);
			this.button6.Margin = new System.Windows.Forms.Padding(2);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(52, 57);
			this.button6.TabIndex = 6;
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.R5_click);
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
			this.button7.Location = new System.Drawing.Point(416, 110);
			this.button7.Margin = new System.Windows.Forms.Padding(2);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(52, 57);
			this.button7.TabIndex = 7;
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.R6_click);
			// 
			// button8
			// 
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
			this.button8.Location = new System.Drawing.Point(494, 110);
			this.button8.Margin = new System.Windows.Forms.Padding(2);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(52, 57);
			this.button8.TabIndex = 8;
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.R7_click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(494, 274);
			this.button9.Margin = new System.Windows.Forms.Padding(2);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(52, 57);
			this.button9.TabIndex = 15;
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.R7_click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(416, 274);
			this.button10.Margin = new System.Windows.Forms.Padding(2);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(52, 57);
			this.button10.TabIndex = 14;
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.R6_click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(337, 274);
			this.button11.Margin = new System.Windows.Forms.Padding(2);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(52, 57);
			this.button11.TabIndex = 13;
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.R5_click);
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(258, 274);
			this.button12.Margin = new System.Windows.Forms.Padding(2);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(52, 57);
			this.button12.TabIndex = 12;
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.R4_click);
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(179, 274);
			this.button13.Margin = new System.Windows.Forms.Padding(2);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(52, 57);
			this.button13.TabIndex = 11;
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new System.EventHandler(this.R3_click);
			// 
			// button14
			// 
			this.button14.Location = new System.Drawing.Point(100, 274);
			this.button14.Margin = new System.Windows.Forms.Padding(2);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(52, 57);
			this.button14.TabIndex = 10;
			this.button14.UseVisualStyleBackColor = true;
			this.button14.Click += new System.EventHandler(this.R2_click);
			// 
			// R0C3
			// 
			this.R0C3.Location = new System.Drawing.Point(22, 274);
			this.R0C3.Margin = new System.Windows.Forms.Padding(2);
			this.R0C3.Name = "R0C3";
			this.R0C3.Size = new System.Drawing.Size(52, 57);
			this.R0C3.TabIndex = 9;
			this.R0C3.UseVisualStyleBackColor = true;
			this.R0C3.Click += new System.EventHandler(this.R1_clicked);
			// 
			// button16
			// 
			this.button16.Location = new System.Drawing.Point(494, 355);
			this.button16.Margin = new System.Windows.Forms.Padding(2);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(52, 57);
			this.button16.TabIndex = 22;
			this.button16.UseVisualStyleBackColor = true;
			this.button16.Click += new System.EventHandler(this.R7_click);
			// 
			// button17
			// 
			this.button17.Location = new System.Drawing.Point(416, 355);
			this.button17.Margin = new System.Windows.Forms.Padding(2);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(52, 57);
			this.button17.TabIndex = 21;
			this.button17.UseVisualStyleBackColor = true;
			this.button17.Click += new System.EventHandler(this.R6_click);
			// 
			// button18
			// 
			this.button18.Location = new System.Drawing.Point(337, 355);
			this.button18.Margin = new System.Windows.Forms.Padding(2);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(52, 57);
			this.button18.TabIndex = 20;
			this.button18.UseVisualStyleBackColor = true;
			this.button18.Click += new System.EventHandler(this.R5_click);
			// 
			// button19
			// 
			this.button19.Location = new System.Drawing.Point(258, 355);
			this.button19.Margin = new System.Windows.Forms.Padding(2);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(52, 57);
			this.button19.TabIndex = 19;
			this.button19.UseVisualStyleBackColor = true;
			this.button19.Click += new System.EventHandler(this.R4_click);
			// 
			// button20
			// 
			this.button20.Location = new System.Drawing.Point(179, 355);
			this.button20.Margin = new System.Windows.Forms.Padding(2);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(52, 57);
			this.button20.TabIndex = 18;
			this.button20.UseVisualStyleBackColor = true;
			this.button20.Click += new System.EventHandler(this.R3_click);
			// 
			// R1C2
			// 
			this.R1C2.Location = new System.Drawing.Point(100, 355);
			this.R1C2.Margin = new System.Windows.Forms.Padding(2);
			this.R1C2.Name = "R1C2";
			this.R1C2.Size = new System.Drawing.Size(52, 57);
			this.R1C2.TabIndex = 17;
			this.R1C2.UseVisualStyleBackColor = true;
			this.R1C2.Click += new System.EventHandler(this.R2_click);
			// 
			// R0C2
			// 
			this.R0C2.Location = new System.Drawing.Point(22, 355);
			this.R0C2.Margin = new System.Windows.Forms.Padding(2);
			this.R0C2.Name = "R0C2";
			this.R0C2.Size = new System.Drawing.Size(52, 57);
			this.R0C2.TabIndex = 16;
			this.R0C2.UseVisualStyleBackColor = true;
			this.R0C2.Click += new System.EventHandler(this.R1_clicked);
			// 
			// button23
			// 
			this.button23.Location = new System.Drawing.Point(494, 191);
			this.button23.Margin = new System.Windows.Forms.Padding(2);
			this.button23.Name = "button23";
			this.button23.Size = new System.Drawing.Size(52, 57);
			this.button23.TabIndex = 29;
			this.button23.UseVisualStyleBackColor = true;
			this.button23.Click += new System.EventHandler(this.R7_click);
			// 
			// button24
			// 
			this.button24.Location = new System.Drawing.Point(416, 191);
			this.button24.Margin = new System.Windows.Forms.Padding(2);
			this.button24.Name = "button24";
			this.button24.Size = new System.Drawing.Size(52, 57);
			this.button24.TabIndex = 28;
			this.button24.UseVisualStyleBackColor = true;
			this.button24.Click += new System.EventHandler(this.R6_click);
			// 
			// button25
			// 
			this.button25.Location = new System.Drawing.Point(337, 191);
			this.button25.Margin = new System.Windows.Forms.Padding(2);
			this.button25.Name = "button25";
			this.button25.Size = new System.Drawing.Size(52, 57);
			this.button25.TabIndex = 27;
			this.button25.UseVisualStyleBackColor = true;
			this.button25.Click += new System.EventHandler(this.R5_click);
			// 
			// button26
			// 
			this.button26.Location = new System.Drawing.Point(258, 191);
			this.button26.Margin = new System.Windows.Forms.Padding(2);
			this.button26.Name = "button26";
			this.button26.Size = new System.Drawing.Size(52, 57);
			this.button26.TabIndex = 26;
			this.button26.UseVisualStyleBackColor = true;
			this.button26.Click += new System.EventHandler(this.R4_click);
			// 
			// button27
			// 
			this.button27.Location = new System.Drawing.Point(179, 191);
			this.button27.Margin = new System.Windows.Forms.Padding(2);
			this.button27.Name = "button27";
			this.button27.Size = new System.Drawing.Size(52, 57);
			this.button27.TabIndex = 25;
			this.button27.UseVisualStyleBackColor = true;
			this.button27.Click += new System.EventHandler(this.R3_click);
			// 
			// button28
			// 
			this.button28.Location = new System.Drawing.Point(100, 191);
			this.button28.Margin = new System.Windows.Forms.Padding(2);
			this.button28.Name = "button28";
			this.button28.Size = new System.Drawing.Size(52, 57);
			this.button28.TabIndex = 24;
			this.button28.UseVisualStyleBackColor = true;
			this.button28.Click += new System.EventHandler(this.R2_click);
			// 
			// R0C4
			// 
			this.R0C4.Location = new System.Drawing.Point(22, 191);
			this.R0C4.Margin = new System.Windows.Forms.Padding(2);
			this.R0C4.Name = "R0C4";
			this.R0C4.Size = new System.Drawing.Size(52, 57);
			this.R0C4.TabIndex = 23;
			this.R0C4.UseVisualStyleBackColor = true;
			this.R0C4.Click += new System.EventHandler(this.R1_clicked);
			// 
			// button30
			// 
			this.button30.Location = new System.Drawing.Point(494, 439);
			this.button30.Margin = new System.Windows.Forms.Padding(2);
			this.button30.Name = "button30";
			this.button30.Size = new System.Drawing.Size(52, 57);
			this.button30.TabIndex = 36;
			this.button30.UseVisualStyleBackColor = true;
			this.button30.Click += new System.EventHandler(this.R7_click);
			// 
			// button31
			// 
			this.button31.Location = new System.Drawing.Point(416, 439);
			this.button31.Margin = new System.Windows.Forms.Padding(2);
			this.button31.Name = "button31";
			this.button31.Size = new System.Drawing.Size(52, 57);
			this.button31.TabIndex = 35;
			this.button31.UseVisualStyleBackColor = true;
			this.button31.Click += new System.EventHandler(this.R6_click);
			// 
			// button32
			// 
			this.button32.Location = new System.Drawing.Point(337, 439);
			this.button32.Margin = new System.Windows.Forms.Padding(2);
			this.button32.Name = "button32";
			this.button32.Size = new System.Drawing.Size(52, 57);
			this.button32.TabIndex = 34;
			this.button32.UseVisualStyleBackColor = true;
			this.button32.Click += new System.EventHandler(this.R5_click);
			// 
			// button33
			// 
			this.button33.Location = new System.Drawing.Point(258, 439);
			this.button33.Margin = new System.Windows.Forms.Padding(2);
			this.button33.Name = "button33";
			this.button33.Size = new System.Drawing.Size(52, 57);
			this.button33.TabIndex = 33;
			this.button33.UseVisualStyleBackColor = true;
			this.button33.Click += new System.EventHandler(this.R4_click);
			// 
			// button34
			// 
			this.button34.Location = new System.Drawing.Point(179, 439);
			this.button34.Margin = new System.Windows.Forms.Padding(2);
			this.button34.Name = "button34";
			this.button34.Size = new System.Drawing.Size(52, 57);
			this.button34.TabIndex = 32;
			this.button34.UseVisualStyleBackColor = true;
			this.button34.Click += new System.EventHandler(this.R3_click);
			// 
			// R1C1
			// 
			this.R1C1.Location = new System.Drawing.Point(100, 439);
			this.R1C1.Margin = new System.Windows.Forms.Padding(2);
			this.R1C1.Name = "R1C1";
			this.R1C1.Size = new System.Drawing.Size(52, 57);
			this.R1C1.TabIndex = 31;
			this.R1C1.UseVisualStyleBackColor = true;
			this.R1C1.Click += new System.EventHandler(this.R2_click);
			// 
			// R0C1
			// 
			this.R0C1.Location = new System.Drawing.Point(22, 439);
			this.R0C1.Margin = new System.Windows.Forms.Padding(2);
			this.R0C1.Name = "R0C1";
			this.R0C1.Size = new System.Drawing.Size(52, 57);
			this.R0C1.TabIndex = 30;
			this.R0C1.UseVisualStyleBackColor = true;
			this.R0C1.Click += new System.EventHandler(this.R1_clicked);
			// 
			// button37
			// 
			this.button37.Location = new System.Drawing.Point(494, 522);
			this.button37.Margin = new System.Windows.Forms.Padding(2);
			this.button37.Name = "button37";
			this.button37.Size = new System.Drawing.Size(52, 57);
			this.button37.TabIndex = 43;
			this.button37.UseVisualStyleBackColor = true;
			this.button37.Click += new System.EventHandler(this.R7_click);
			// 
			// R0C0
			// 
			this.R0C0.Location = new System.Drawing.Point(22, 522);
			this.R0C0.Margin = new System.Windows.Forms.Padding(2);
			this.R0C0.Name = "R0C0";
			this.R0C0.Size = new System.Drawing.Size(52, 57);
			this.R0C0.TabIndex = 37;
			this.R0C0.UseVisualStyleBackColor = true;
			this.R0C0.Click += new System.EventHandler(this.R1_clicked);
			// 
			// button44
			// 
			this.button44.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button44.Location = new System.Drawing.Point(494, 11);
			this.button44.Margin = new System.Windows.Forms.Padding(2);
			this.button44.Name = "button44";
			this.button44.Size = new System.Drawing.Size(65, 28);
			this.button44.TabIndex = 44;
			this.button44.Text = "Settings";
			this.button44.UseVisualStyleBackColor = true;
			this.button44.Click += new System.EventHandler(this.button44_Click);
			// 
			// R1C0
			// 
			this.R1C0.Location = new System.Drawing.Point(100, 522);
			this.R1C0.Margin = new System.Windows.Forms.Padding(2);
			this.R1C0.Name = "R1C0";
			this.R1C0.Size = new System.Drawing.Size(52, 57);
			this.R1C0.TabIndex = 37;
			this.R1C0.UseVisualStyleBackColor = true;
			this.R1C0.Click += new System.EventHandler(this.R2_click);
			// 
			// button45
			// 
			this.button45.Location = new System.Drawing.Point(179, 522);
			this.button45.Margin = new System.Windows.Forms.Padding(2);
			this.button45.Name = "button45";
			this.button45.Size = new System.Drawing.Size(52, 57);
			this.button45.TabIndex = 38;
			this.button45.UseVisualStyleBackColor = true;
			this.button45.Click += new System.EventHandler(this.R3_click);
			// 
			// button46
			// 
			this.button46.Location = new System.Drawing.Point(258, 522);
			this.button46.Margin = new System.Windows.Forms.Padding(2);
			this.button46.Name = "button46";
			this.button46.Size = new System.Drawing.Size(52, 57);
			this.button46.TabIndex = 39;
			this.button46.UseVisualStyleBackColor = true;
			this.button46.Click += new System.EventHandler(this.R4_click);
			// 
			// button47
			// 
			this.button47.Location = new System.Drawing.Point(337, 522);
			this.button47.Margin = new System.Windows.Forms.Padding(2);
			this.button47.Name = "button47";
			this.button47.Size = new System.Drawing.Size(52, 57);
			this.button47.TabIndex = 40;
			this.button47.UseVisualStyleBackColor = true;
			this.button47.Click += new System.EventHandler(this.R5_click);
			// 
			// button48
			// 
			this.button48.Location = new System.Drawing.Point(416, 522);
			this.button48.Margin = new System.Windows.Forms.Padding(2);
			this.button48.Name = "button48";
			this.button48.Size = new System.Drawing.Size(52, 57);
			this.button48.TabIndex = 41;
			this.button48.UseVisualStyleBackColor = true;
			this.button48.Click += new System.EventHandler(this.R6_click);
			// 
			// SettingPanel
			// 
			this.SettingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SettingPanel.Controls.Add(this.SpeedTrackBar);
			this.SettingPanel.Controls.Add(this.cb_Uncloseable);
			this.SettingPanel.Controls.Add(this.cb_Notification);
			this.SettingPanel.Controls.Add(this.cb_Music);
			this.SettingPanel.Controls.Add(this.comboBox1);
			this.SettingPanel.Controls.Add(this.ApplyButton);
			this.SettingPanel.Location = new System.Drawing.Point(76, 172);
			this.SettingPanel.Margin = new System.Windows.Forms.Padding(2);
			this.SettingPanel.Name = "SettingPanel";
			this.SettingPanel.Size = new System.Drawing.Size(400, 213);
			this.SettingPanel.TabIndex = 45;
			this.SettingPanel.Visible = false;
			// 
			// SpeedTrackBar
			// 
			this.SpeedTrackBar.Cursor = System.Windows.Forms.Cursors.Default;
			this.SpeedTrackBar.Location = new System.Drawing.Point(229, 9);
			this.SpeedTrackBar.Name = "SpeedTrackBar";
			this.SpeedTrackBar.Size = new System.Drawing.Size(162, 45);
			this.SpeedTrackBar.TabIndex = 5;
			this.SpeedTrackBar.Value = 5;
			this.SpeedTrackBar.Visible = false;
			this.SpeedTrackBar.Scroll += new System.EventHandler(this.SpeedTrackBar_Scroll);
			// 
			// cb_Uncloseable
			// 
			this.cb_Uncloseable.AutoSize = true;
			this.cb_Uncloseable.Checked = true;
			this.cb_Uncloseable.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cb_Uncloseable.Location = new System.Drawing.Point(10, 81);
			this.cb_Uncloseable.Margin = new System.Windows.Forms.Padding(2);
			this.cb_Uncloseable.Name = "cb_Uncloseable";
			this.cb_Uncloseable.Size = new System.Drawing.Size(79, 17);
			this.cb_Uncloseable.TabIndex = 4;
			this.cb_Uncloseable.Text = "Unclosable";
			this.cb_Uncloseable.UseVisualStyleBackColor = true;
			// 
			// cb_Notification
			// 
			this.cb_Notification.AutoSize = true;
			this.cb_Notification.Location = new System.Drawing.Point(10, 60);
			this.cb_Notification.Margin = new System.Windows.Forms.Padding(2);
			this.cb_Notification.Name = "cb_Notification";
			this.cb_Notification.Size = new System.Drawing.Size(109, 17);
			this.cb_Notification.TabIndex = 3;
			this.cb_Notification.Text = "Notification Menu";
			this.cb_Notification.UseVisualStyleBackColor = true;
			// 
			// cb_Music
			// 
			this.cb_Music.AutoSize = true;
			this.cb_Music.Location = new System.Drawing.Point(10, 37);
			this.cb_Music.Margin = new System.Windows.Forms.Padding(2);
			this.cb_Music.Name = "cb_Music";
			this.cb_Music.Size = new System.Drawing.Size(81, 17);
			this.cb_Music.TabIndex = 2;
			this.cb_Music.Text = "Music Mute";
			this.cb_Music.UseVisualStyleBackColor = true;
			this.cb_Music.CheckedChanged += new System.EventHandler(this.Cb_Music_CheckedChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Black",
            "White",
            "Default",
            "Rainbow",
            "Custom"});
			this.comboBox1.Location = new System.Drawing.Point(10, 11);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(208, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.Text = "Select Board Colour";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
			this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
			// 
			// ApplyButton
			// 
			this.ApplyButton.Location = new System.Drawing.Point(329, 171);
			this.ApplyButton.Margin = new System.Windows.Forms.Padding(2);
			this.ApplyButton.Name = "ApplyButton";
			this.ApplyButton.Size = new System.Drawing.Size(63, 29);
			this.ApplyButton.TabIndex = 0;
			this.ApplyButton.Text = "Apply";
			this.ApplyButton.UseVisualStyleBackColor = true;
			this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(5, 11);
			this.btnClear.Margin = new System.Windows.Forms.Padding(2);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(65, 28);
			this.btnClear.TabIndex = 46;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.BtnClear_Click_1);
			// 
			// chk_AI
			// 
			this.chk_AI.AutoSize = true;
			this.chk_AI.Location = new System.Drawing.Point(485, 44);
			this.chk_AI.Margin = new System.Windows.Forms.Padding(2);
			this.chk_AI.Name = "chk_AI";
			this.chk_AI.Size = new System.Drawing.Size(92, 17);
			this.chk_AI.TabIndex = 47;
			this.chk_AI.Text = "Player V.S PC";
			this.chk_AI.UseVisualStyleBackColor = true;
			this.chk_AI.CheckedChanged += new System.EventHandler(this.Chk_AI_CheckedChanged);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// GameForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 611);
			this.Controls.Add(this.SettingPanel);
			this.Controls.Add(this.chk_AI);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.button44);
			this.Controls.Add(this.button37);
			this.Controls.Add(this.button48);
			this.Controls.Add(this.button47);
			this.Controls.Add(this.button46);
			this.Controls.Add(this.button45);
			this.Controls.Add(this.R1C0);
			this.Controls.Add(this.R0C0);
			this.Controls.Add(this.button30);
			this.Controls.Add(this.button31);
			this.Controls.Add(this.button32);
			this.Controls.Add(this.button33);
			this.Controls.Add(this.button34);
			this.Controls.Add(this.R1C1);
			this.Controls.Add(this.R0C1);
			this.Controls.Add(this.button23);
			this.Controls.Add(this.button24);
			this.Controls.Add(this.button25);
			this.Controls.Add(this.button26);
			this.Controls.Add(this.button27);
			this.Controls.Add(this.button28);
			this.Controls.Add(this.R0C4);
			this.Controls.Add(this.button16);
			this.Controls.Add(this.button17);
			this.Controls.Add(this.button18);
			this.Controls.Add(this.button19);
			this.Controls.Add(this.button20);
			this.Controls.Add(this.R1C2);
			this.Controls.Add(this.R0C2);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button13);
			this.Controls.Add(this.button14);
			this.Controls.Add(this.R0C3);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.R0C5);
			this.Controls.Add(this.Board);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "GameForm";
			this.Opacity = 0D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Connect 4Four";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
			this.Load += new System.EventHandler(this.GameForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.SettingPanel.ResumeLayout(false);
			this.SettingPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button R0C5;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button R0C3;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Button R1C2;
		private System.Windows.Forms.Button R0C2;
		private System.Windows.Forms.Button button23;
		private System.Windows.Forms.Button button24;
		private System.Windows.Forms.Button button25;
		private System.Windows.Forms.Button button26;
		private System.Windows.Forms.Button button27;
		private System.Windows.Forms.Button button28;
		private System.Windows.Forms.Button R0C4;
		private System.Windows.Forms.Button button30;
		private System.Windows.Forms.Button button31;
		private System.Windows.Forms.Button button32;
		private System.Windows.Forms.Button button33;
		private System.Windows.Forms.Button button34;
		private System.Windows.Forms.Button R1C1;
		private System.Windows.Forms.Button R0C1;
		private System.Windows.Forms.Button button37;
		private System.Windows.Forms.Button R0C0;
		private System.Windows.Forms.Button button44;
		public System.Windows.Forms.Button Board;
		private System.Windows.Forms.Button R1C0;
		private System.Windows.Forms.Button button45;
		private System.Windows.Forms.Button button46;
		private System.Windows.Forms.Button button47;
		private System.Windows.Forms.Button button48;
		private System.Windows.Forms.Panel SettingPanel;
		private System.Windows.Forms.Button ApplyButton;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.CheckBox chk_AI;
		private System.Windows.Forms.CheckBox cb_Music;
		private System.Windows.Forms.CheckBox cb_Notification;
		private System.Windows.Forms.CheckBox cb_Uncloseable;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.TrackBar SpeedTrackBar;
		private System.Windows.Forms.ColorDialog boardColorPicker;
	}
}

