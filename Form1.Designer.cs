namespace sharp7_deneme_plc_connect
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
            this.label_act_ref = new System.Windows.Forms.Label();
            this.textBox_act_ref = new System.Windows.Forms.TextBox();
            this.label_set_ref = new System.Windows.Forms.Label();
            this.textBox_set_ref = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button_arti_eksi = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_nokta = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_new_ref = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label_ip_and_err = new System.Windows.Forms.Label();
            this.textBox_ip_add = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.label1_status = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_status1 = new System.Windows.Forms.Label();
            this.label_temp = new System.Windows.Forms.Label();
            this.textBox_temp = new System.Windows.Forms.TextBox();
            this.label_set_press_max = new System.Windows.Forms.Label();
            this.label_set_press_min = new System.Windows.Forms.Label();
            this.label_laser = new System.Windows.Forms.Label();
            this.textBox_laser = new System.Windows.Forms.TextBox();
            this.textBox_set_press_min = new System.Windows.Forms.TextBox();
            this.textBox_set_press_max = new System.Windows.Forms.TextBox();
            this.label_set_temp_max = new System.Windows.Forms.Label();
            this.textBox_set_temp_max = new System.Windows.Forms.TextBox();
            this.m1_state = new System.Windows.Forms.Button();
            this.m2_state = new System.Windows.Forms.Button();
            this.m3_state = new System.Windows.Forms.Button();
            this.start_m1_pb = new System.Windows.Forms.Button();
            this.start_m3_pb = new System.Windows.Forms.Button();
            this.start_m2_pb = new System.Windows.Forms.Button();
            this.stop_m1_pb = new System.Windows.Forms.Button();
            this.stop_m2_pb = new System.Windows.Forms.Button();
            this.stop_m3_pb = new System.Windows.Forms.Button();
            this.progressBar_press = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar_temp = new System.Windows.Forms.ProgressBar();
            this.progressBar_laser_mm = new System.Windows.Forms.ProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_act_ref
            // 
            this.label_act_ref.AutoSize = true;
            this.label_act_ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_act_ref.Location = new System.Drawing.Point(12, 14);
            this.label_act_ref.Name = "label_act_ref";
            this.label_act_ref.Size = new System.Drawing.Size(80, 20);
            this.label_act_ref.TabIndex = 0;
            this.label_act_ref.Text = "Pressure";
            // 
            // textBox_act_ref
            // 
            this.textBox_act_ref.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_act_ref.Enabled = false;
            this.textBox_act_ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_act_ref.Location = new System.Drawing.Point(158, 7);
            this.textBox_act_ref.MaxLength = 4;
            this.textBox_act_ref.Name = "textBox_act_ref";
            this.textBox_act_ref.ReadOnly = true;
            this.textBox_act_ref.Size = new System.Drawing.Size(103, 32);
            this.textBox_act_ref.TabIndex = 1;
            this.textBox_act_ref.Text = "0";
            this.textBox_act_ref.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_set_ref
            // 
            this.label_set_ref.AutoSize = true;
            this.label_set_ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_set_ref.Location = new System.Drawing.Point(12, 179);
            this.label_set_ref.Name = "label_set_ref";
            this.label_set_ref.Size = new System.Drawing.Size(124, 20);
            this.label_set_ref.TabIndex = 2;
            this.label_set_ref.Text = "Set Temp. Min";
            // 
            // textBox_set_ref
            // 
            this.textBox_set_ref.AcceptsReturn = true;
            this.textBox_set_ref.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_set_ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_set_ref.Location = new System.Drawing.Point(158, 172);
            this.textBox_set_ref.MaxLength = 4;
            this.textBox_set_ref.Name = "textBox_set_ref";
            this.textBox_set_ref.Size = new System.Drawing.Size(103, 32);
            this.textBox_set_ref.TabIndex = 3;
            this.textBox_set_ref.Text = "0";
            this.textBox_set_ref.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(424, 128);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 45);
            this.button7.TabIndex = 4;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(488, 128);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 45);
            this.button8.TabIndex = 5;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(552, 128);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 45);
            this.button9.TabIndex = 6;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(552, 179);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 45);
            this.button6.TabIndex = 9;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(488, 179);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 45);
            this.button5.TabIndex = 8;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(424, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 45);
            this.button4.TabIndex = 7;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_arti_eksi
            // 
            this.button_arti_eksi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_arti_eksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_arti_eksi.Location = new System.Drawing.Point(552, 281);
            this.button_arti_eksi.Name = "button_arti_eksi";
            this.button_arti_eksi.Size = new System.Drawing.Size(60, 45);
            this.button_arti_eksi.TabIndex = 12;
            this.button_arti_eksi.Text = "+/-";
            this.button_arti_eksi.UseVisualStyleBackColor = true;
            this.button_arti_eksi.Click += new System.EventHandler(this.button_arti_eksi_Click);
            // 
            // button_0
            // 
            this.button_0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_0.Location = new System.Drawing.Point(488, 281);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(60, 45);
            this.button_0.TabIndex = 11;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_nokta
            // 
            this.button_nokta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_nokta.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_nokta.Location = new System.Drawing.Point(424, 281);
            this.button_nokta.Name = "button_nokta";
            this.button_nokta.Size = new System.Drawing.Size(60, 45);
            this.button_nokta.TabIndex = 10;
            this.button_nokta.Text = ",";
            this.button_nokta.UseVisualStyleBackColor = true;
            this.button_nokta.Click += new System.EventHandler(this.button_nokta_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(552, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 45);
            this.button3.TabIndex = 15;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(488, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 45);
            this.button2.TabIndex = 14;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(424, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_new_ref
            // 
            this.button_new_ref.Enabled = false;
            this.button_new_ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_new_ref.Location = new System.Drawing.Point(424, 332);
            this.button_new_ref.Name = "button_new_ref";
            this.button_new_ref.Size = new System.Drawing.Size(92, 46);
            this.button_new_ref.TabIndex = 16;
            this.button_new_ref.Text = "APPLY NEW REFERANCE";
            this.button_new_ref.UseVisualStyleBackColor = true;
            this.button_new_ref.Click += new System.EventHandler(this.button_new_ref_Click);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_delete.Location = new System.Drawing.Point(520, 332);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(92, 46);
            this.button_delete.TabIndex = 17;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label_ip_and_err
            // 
            this.label_ip_and_err.AutoSize = true;
            this.label_ip_and_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ip_and_err.Location = new System.Drawing.Point(426, 386);
            this.label_ip_and_err.Name = "label_ip_and_err";
            this.label_ip_and_err.Size = new System.Drawing.Size(156, 20);
            this.label_ip_and_err.TabIndex = 18;
            this.label_ip_and_err.Text = "PLC IP ADDRESS";
            this.label_ip_and_err.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_ip_add
            // 
            this.textBox_ip_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_ip_add.Location = new System.Drawing.Point(424, 409);
            this.textBox_ip_add.MaxLength = 15;
            this.textBox_ip_add.Name = "textBox_ip_add";
            this.textBox_ip_add.Size = new System.Drawing.Size(186, 29);
            this.textBox_ip_add.TabIndex = 19;
            this.textBox_ip_add.Text = "10.0.0.165";
            this.textBox_ip_add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_connect
            // 
            this.button_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_connect.Location = new System.Drawing.Point(424, 444);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(89, 29);
            this.button_connect.TabIndex = 20;
            this.button_connect.Text = "CONNECT";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Enabled = false;
            this.button_disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_disconnect.Location = new System.Drawing.Point(518, 444);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(92, 29);
            this.button_disconnect.TabIndex = 21;
            this.button_disconnect.Text = "DISCONNECT";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // label1_status
            // 
            this.label1_status.AutoSize = true;
            this.label1_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1_status.Location = new System.Drawing.Point(427, 482);
            this.label1_status.Name = "label1_status";
            this.label1_status.Size = new System.Drawing.Size(64, 13);
            this.label1_status.TabIndex = 22;
            this.label1_status.Text = "STATUS :";
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_status1
            // 
            this.label_status1.AutoSize = true;
            this.label_status1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_status1.Location = new System.Drawing.Point(485, 482);
            this.label_status1.Name = "label_status1";
            this.label_status1.Size = new System.Drawing.Size(0, 13);
            this.label_status1.TabIndex = 23;
            // 
            // label_temp
            // 
            this.label_temp.AutoSize = true;
            this.label_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_temp.Location = new System.Drawing.Point(12, 47);
            this.label_temp.Name = "label_temp";
            this.label_temp.Size = new System.Drawing.Size(101, 20);
            this.label_temp.TabIndex = 24;
            this.label_temp.Text = "Temprature";
            // 
            // textBox_temp
            // 
            this.textBox_temp.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_temp.Enabled = false;
            this.textBox_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_temp.Location = new System.Drawing.Point(158, 40);
            this.textBox_temp.MaxLength = 4;
            this.textBox_temp.Name = "textBox_temp";
            this.textBox_temp.ReadOnly = true;
            this.textBox_temp.Size = new System.Drawing.Size(103, 32);
            this.textBox_temp.TabIndex = 25;
            this.textBox_temp.Text = "0";
            this.textBox_temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_set_press_max
            // 
            this.label_set_press_max.AutoSize = true;
            this.label_set_press_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_set_press_max.Location = new System.Drawing.Point(12, 146);
            this.label_set_press_max.Name = "label_set_press_max";
            this.label_set_press_max.Size = new System.Drawing.Size(129, 20);
            this.label_set_press_max.TabIndex = 26;
            this.label_set_press_max.Text = "Set Press. Max";
            // 
            // label_set_press_min
            // 
            this.label_set_press_min.AutoSize = true;
            this.label_set_press_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_set_press_min.Location = new System.Drawing.Point(12, 113);
            this.label_set_press_min.Name = "label_set_press_min";
            this.label_set_press_min.Size = new System.Drawing.Size(125, 20);
            this.label_set_press_min.TabIndex = 27;
            this.label_set_press_min.Text = "Set Press. Min";
            // 
            // label_laser
            // 
            this.label_laser.AutoSize = true;
            this.label_laser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_laser.Location = new System.Drawing.Point(12, 80);
            this.label_laser.Name = "label_laser";
            this.label_laser.Size = new System.Drawing.Size(91, 20);
            this.label_laser.TabIndex = 28;
            this.label_laser.Text = "Laser (mt)";
            // 
            // textBox_laser
            // 
            this.textBox_laser.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_laser.Enabled = false;
            this.textBox_laser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_laser.Location = new System.Drawing.Point(158, 73);
            this.textBox_laser.MaxLength = 4;
            this.textBox_laser.Name = "textBox_laser";
            this.textBox_laser.ReadOnly = true;
            this.textBox_laser.Size = new System.Drawing.Size(103, 32);
            this.textBox_laser.TabIndex = 29;
            this.textBox_laser.Text = "0";
            this.textBox_laser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_set_press_min
            // 
            this.textBox_set_press_min.AcceptsReturn = true;
            this.textBox_set_press_min.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_set_press_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_set_press_min.Location = new System.Drawing.Point(158, 106);
            this.textBox_set_press_min.MaxLength = 4;
            this.textBox_set_press_min.Name = "textBox_set_press_min";
            this.textBox_set_press_min.Size = new System.Drawing.Size(103, 32);
            this.textBox_set_press_min.TabIndex = 30;
            this.textBox_set_press_min.Text = "0";
            this.textBox_set_press_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_set_press_max
            // 
            this.textBox_set_press_max.AcceptsReturn = true;
            this.textBox_set_press_max.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_set_press_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_set_press_max.Location = new System.Drawing.Point(158, 139);
            this.textBox_set_press_max.MaxLength = 4;
            this.textBox_set_press_max.Name = "textBox_set_press_max";
            this.textBox_set_press_max.Size = new System.Drawing.Size(103, 32);
            this.textBox_set_press_max.TabIndex = 31;
            this.textBox_set_press_max.Text = "0";
            this.textBox_set_press_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_set_temp_max
            // 
            this.label_set_temp_max.AutoSize = true;
            this.label_set_temp_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_set_temp_max.Location = new System.Drawing.Point(12, 212);
            this.label_set_temp_max.Name = "label_set_temp_max";
            this.label_set_temp_max.Size = new System.Drawing.Size(128, 20);
            this.label_set_temp_max.TabIndex = 32;
            this.label_set_temp_max.Text = "Set Temp. Max";
            // 
            // textBox_set_temp_max
            // 
            this.textBox_set_temp_max.AcceptsReturn = true;
            this.textBox_set_temp_max.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_set_temp_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_set_temp_max.Location = new System.Drawing.Point(158, 205);
            this.textBox_set_temp_max.MaxLength = 4;
            this.textBox_set_temp_max.Name = "textBox_set_temp_max";
            this.textBox_set_temp_max.Size = new System.Drawing.Size(103, 32);
            this.textBox_set_temp_max.TabIndex = 33;
            this.textBox_set_temp_max.Text = "0";
            this.textBox_set_temp_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m1_state
            // 
            this.m1_state.Enabled = false;
            this.m1_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.m1_state.Location = new System.Drawing.Point(158, 246);
            this.m1_state.Name = "m1_state";
            this.m1_state.Size = new System.Drawing.Size(33, 32);
            this.m1_state.TabIndex = 34;
            this.m1_state.Text = "M1 ";
            this.m1_state.UseVisualStyleBackColor = true;
            // 
            // m2_state
            // 
            this.m2_state.Enabled = false;
            this.m2_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.m2_state.Location = new System.Drawing.Point(158, 284);
            this.m2_state.Name = "m2_state";
            this.m2_state.Size = new System.Drawing.Size(33, 32);
            this.m2_state.TabIndex = 35;
            this.m2_state.Text = "M2";
            this.m2_state.UseVisualStyleBackColor = true;
            // 
            // m3_state
            // 
            this.m3_state.Enabled = false;
            this.m3_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.m3_state.Location = new System.Drawing.Point(158, 322);
            this.m3_state.Name = "m3_state";
            this.m3_state.Size = new System.Drawing.Size(33, 32);
            this.m3_state.TabIndex = 36;
            this.m3_state.Text = "M3";
            this.m3_state.UseVisualStyleBackColor = true;
            // 
            // start_m1_pb
            // 
            this.start_m1_pb.Enabled = false;
            this.start_m1_pb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.start_m1_pb.Location = new System.Drawing.Point(12, 246);
            this.start_m1_pb.Name = "start_m1_pb";
            this.start_m1_pb.Size = new System.Drawing.Size(67, 32);
            this.start_m1_pb.TabIndex = 37;
            this.start_m1_pb.Text = "START";
            this.start_m1_pb.UseVisualStyleBackColor = true;
            this.start_m1_pb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.start_m1_pb_MouseDown);
            // 
            // start_m3_pb
            // 
            this.start_m3_pb.Enabled = false;
            this.start_m3_pb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.start_m3_pb.Location = new System.Drawing.Point(13, 322);
            this.start_m3_pb.Name = "start_m3_pb";
            this.start_m3_pb.Size = new System.Drawing.Size(67, 32);
            this.start_m3_pb.TabIndex = 38;
            this.start_m3_pb.Text = "START";
            this.start_m3_pb.UseVisualStyleBackColor = true;
            // 
            // start_m2_pb
            // 
            this.start_m2_pb.Enabled = false;
            this.start_m2_pb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.start_m2_pb.Location = new System.Drawing.Point(13, 284);
            this.start_m2_pb.Name = "start_m2_pb";
            this.start_m2_pb.Size = new System.Drawing.Size(67, 32);
            this.start_m2_pb.TabIndex = 39;
            this.start_m2_pb.Text = "START";
            this.start_m2_pb.UseVisualStyleBackColor = true;
            this.start_m2_pb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.start_m2_pb_MouseDown);
            // 
            // stop_m1_pb
            // 
            this.stop_m1_pb.Enabled = false;
            this.stop_m1_pb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stop_m1_pb.Location = new System.Drawing.Point(85, 246);
            this.stop_m1_pb.Name = "stop_m1_pb";
            this.stop_m1_pb.Size = new System.Drawing.Size(67, 32);
            this.stop_m1_pb.TabIndex = 40;
            this.stop_m1_pb.Text = "STOP";
            this.stop_m1_pb.UseVisualStyleBackColor = true;
            this.stop_m1_pb.Click += new System.EventHandler(this.stop_m1_pb_Click);
            // 
            // stop_m2_pb
            // 
            this.stop_m2_pb.Enabled = false;
            this.stop_m2_pb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stop_m2_pb.Location = new System.Drawing.Point(85, 284);
            this.stop_m2_pb.Name = "stop_m2_pb";
            this.stop_m2_pb.Size = new System.Drawing.Size(67, 32);
            this.stop_m2_pb.TabIndex = 41;
            this.stop_m2_pb.Text = "STOP";
            this.stop_m2_pb.UseVisualStyleBackColor = true;
            this.stop_m2_pb.Click += new System.EventHandler(this.stop_m2_pb_Click);
            // 
            // stop_m3_pb
            // 
            this.stop_m3_pb.Enabled = false;
            this.stop_m3_pb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stop_m3_pb.Location = new System.Drawing.Point(85, 322);
            this.stop_m3_pb.Name = "stop_m3_pb";
            this.stop_m3_pb.Size = new System.Drawing.Size(67, 32);
            this.stop_m3_pb.TabIndex = 42;
            this.stop_m3_pb.Text = "STOP";
            this.stop_m3_pb.UseVisualStyleBackColor = true;
            // 
            // progressBar_press
            // 
            this.progressBar_press.Location = new System.Drawing.Point(267, 7);
            this.progressBar_press.Name = "progressBar_press";
            this.progressBar_press.Size = new System.Drawing.Size(343, 32);
            this.progressBar_press.Step = 1;
            this.progressBar_press.TabIndex = 45;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 506);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 44;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // progressBar_temp
            // 
            this.progressBar_temp.Location = new System.Drawing.Point(267, 40);
            this.progressBar_temp.Maximum = 190;
            this.progressBar_temp.Name = "progressBar_temp";
            this.progressBar_temp.Size = new System.Drawing.Size(343, 32);
            this.progressBar_temp.Step = 1;
            this.progressBar_temp.TabIndex = 45;
            // 
            // progressBar_laser_mm
            // 
            this.progressBar_laser_mm.Location = new System.Drawing.Point(267, 73);
            this.progressBar_laser_mm.Name = "progressBar_laser_mm";
            this.progressBar_laser_mm.Size = new System.Drawing.Size(343, 32);
            this.progressBar_laser_mm.TabIndex = 46;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 528);
            this.Controls.Add(this.progressBar_laser_mm);
            this.Controls.Add(this.progressBar_temp);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.progressBar_press);
            this.Controls.Add(this.stop_m3_pb);
            this.Controls.Add(this.stop_m2_pb);
            this.Controls.Add(this.stop_m1_pb);
            this.Controls.Add(this.start_m2_pb);
            this.Controls.Add(this.start_m3_pb);
            this.Controls.Add(this.start_m1_pb);
            this.Controls.Add(this.m3_state);
            this.Controls.Add(this.m2_state);
            this.Controls.Add(this.m1_state);
            this.Controls.Add(this.textBox_set_temp_max);
            this.Controls.Add(this.label_set_temp_max);
            this.Controls.Add(this.textBox_set_press_max);
            this.Controls.Add(this.textBox_set_press_min);
            this.Controls.Add(this.textBox_laser);
            this.Controls.Add(this.label_laser);
            this.Controls.Add(this.label_set_press_min);
            this.Controls.Add(this.label_set_press_max);
            this.Controls.Add(this.textBox_temp);
            this.Controls.Add(this.label_temp);
            this.Controls.Add(this.label_status1);
            this.Controls.Add(this.label1_status);
            this.Controls.Add(this.button_disconnect);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.textBox_ip_add);
            this.Controls.Add(this.label_ip_and_err);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_new_ref);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_arti_eksi);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_nokta);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox_set_ref);
            this.Controls.Add(this.label_set_ref);
            this.Controls.Add(this.textBox_act_ref);
            this.Controls.Add(this.label_act_ref);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_act_ref;
        private System.Windows.Forms.TextBox textBox_act_ref;
        private System.Windows.Forms.Label label_set_ref;
        private System.Windows.Forms.TextBox textBox_set_ref;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_arti_eksi;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_nokta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_new_ref;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label_ip_and_err;
        private System.Windows.Forms.TextBox textBox_ip_add;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.Label label1_status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_status1;
        private System.Windows.Forms.Label label_temp;
        private System.Windows.Forms.TextBox textBox_temp;
        private System.Windows.Forms.Label label_set_press_max;
        private System.Windows.Forms.Label label_set_press_min;
        private System.Windows.Forms.Label label_laser;
        private System.Windows.Forms.TextBox textBox_laser;
        private System.Windows.Forms.TextBox textBox_set_press_min;
        private System.Windows.Forms.TextBox textBox_set_press_max;
        private System.Windows.Forms.Label label_set_temp_max;
        private System.Windows.Forms.TextBox textBox_set_temp_max;
        private System.Windows.Forms.Button m1_state;
        private System.Windows.Forms.Button m2_state;
        private System.Windows.Forms.Button m3_state;
        private System.Windows.Forms.Button start_m1_pb;
        private System.Windows.Forms.Button start_m3_pb;
        private System.Windows.Forms.Button start_m2_pb;
        private System.Windows.Forms.Button stop_m1_pb;
        private System.Windows.Forms.Button stop_m2_pb;
        private System.Windows.Forms.Button stop_m3_pb;
        private System.Windows.Forms.ProgressBar progressBar_press;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ProgressBar progressBar_temp;
        private System.Windows.Forms.ProgressBar progressBar_laser_mm;
    }
}

