namespace RobotoFormApplication
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBoxIpl_depth_original = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.pictureBoxIpl_color_original = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_iRobotSensroData = new System.Windows.Forms.TextBox();
            this.textBox_iRobotTurnSpeed = new System.Windows.Forms.TextBox();
            this.textBox_iRobot_ForwadSpeed = new System.Windows.Forms.TextBox();
            this.button_iRobot_Turn = new System.Windows.Forms.Button();
            this.button_iRobot_Stop = new System.Windows.Forms.Button();
            this.button_iRobot_forward = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox_Servo2Speed = new System.Windows.Forms.TextBox();
            this.textBox_Servo2Target = new System.Windows.Forms.TextBox();
            this.button_Servo2 = new System.Windows.Forms.Button();
            this.textBox_Servo1Speed = new System.Windows.Forms.TextBox();
            this.textBox_Servo1Target = new System.Windows.Forms.TextBox();
            this.button_Servo1 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox_Speak = new System.Windows.Forms.TextBox();
            this.button_Speak = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl_depth_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl_color_original)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 521);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.pictureBoxIpl_depth_original);
            this.tabPage1.Controls.Add(this.pictureBoxIpl_color_original);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBoxIpl_depth_original
            // 
            this.pictureBoxIpl_depth_original.Location = new System.Drawing.Point(3, 236);
            this.pictureBoxIpl_depth_original.Name = "pictureBoxIpl_depth_original";
            this.pictureBoxIpl_depth_original.Size = new System.Drawing.Size(436, 253);
            this.pictureBoxIpl_depth_original.TabIndex = 1;
            this.pictureBoxIpl_depth_original.TabStop = false;
            // 
            // pictureBoxIpl_color_original
            // 
            this.pictureBoxIpl_color_original.Location = new System.Drawing.Point(7, 7);
            this.pictureBoxIpl_color_original.Name = "pictureBoxIpl_color_original";
            this.pictureBoxIpl_color_original.Size = new System.Drawing.Size(432, 223);
            this.pictureBoxIpl_color_original.TabIndex = 0;
            this.pictureBoxIpl_color_original.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox_iRobotSensroData);
            this.tabPage2.Controls.Add(this.textBox_iRobotTurnSpeed);
            this.tabPage2.Controls.Add(this.textBox_iRobot_ForwadSpeed);
            this.tabPage2.Controls.Add(this.button_iRobot_Turn);
            this.tabPage2.Controls.Add(this.button_iRobot_Stop);
            this.tabPage2.Controls.Add(this.button_iRobot_forward);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // textBox_iRobotSensroData
            // 
            this.textBox_iRobotSensroData.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_iRobotSensroData.Location = new System.Drawing.Point(248, 30);
            this.textBox_iRobotSensroData.Multiline = true;
            this.textBox_iRobotSensroData.Name = "textBox_iRobotSensroData";
            this.textBox_iRobotSensroData.Size = new System.Drawing.Size(378, 393);
            this.textBox_iRobotSensroData.TabIndex = 6;
            // 
            // textBox_iRobotTurnSpeed
            // 
            this.textBox_iRobotTurnSpeed.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_iRobotTurnSpeed.Location = new System.Drawing.Point(114, 81);
            this.textBox_iRobotTurnSpeed.Multiline = true;
            this.textBox_iRobotTurnSpeed.Name = "textBox_iRobotTurnSpeed";
            this.textBox_iRobotTurnSpeed.Size = new System.Drawing.Size(128, 45);
            this.textBox_iRobotTurnSpeed.TabIndex = 5;
            this.textBox_iRobotTurnSpeed.Text = "20.0";
            // 
            // textBox_iRobot_ForwadSpeed
            // 
            this.textBox_iRobot_ForwadSpeed.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_iRobot_ForwadSpeed.Location = new System.Drawing.Point(114, 30);
            this.textBox_iRobot_ForwadSpeed.Multiline = true;
            this.textBox_iRobot_ForwadSpeed.Name = "textBox_iRobot_ForwadSpeed";
            this.textBox_iRobot_ForwadSpeed.Size = new System.Drawing.Size(128, 45);
            this.textBox_iRobot_ForwadSpeed.TabIndex = 4;
            this.textBox_iRobot_ForwadSpeed.Text = "20.0";
            this.textBox_iRobot_ForwadSpeed.TextChanged += new System.EventHandler(this.textBox_iRobot_ForwadSpeed_TextChanged);
            // 
            // button_iRobot_Turn
            // 
            this.button_iRobot_Turn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_iRobot_Turn.Location = new System.Drawing.Point(6, 81);
            this.button_iRobot_Turn.Name = "button_iRobot_Turn";
            this.button_iRobot_Turn.Size = new System.Drawing.Size(101, 45);
            this.button_iRobot_Turn.TabIndex = 3;
            this.button_iRobot_Turn.Text = "Turn";
            this.button_iRobot_Turn.UseVisualStyleBackColor = true;
            this.button_iRobot_Turn.Click += new System.EventHandler(this.button_iRobot_Turn_Click);
            // 
            // button_iRobot_Stop
            // 
            this.button_iRobot_Stop.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_iRobot_Stop.Location = new System.Drawing.Point(6, 132);
            this.button_iRobot_Stop.Name = "button_iRobot_Stop";
            this.button_iRobot_Stop.Size = new System.Drawing.Size(101, 45);
            this.button_iRobot_Stop.TabIndex = 2;
            this.button_iRobot_Stop.Text = "Stop";
            this.button_iRobot_Stop.UseVisualStyleBackColor = true;
            this.button_iRobot_Stop.Click += new System.EventHandler(this.button_iRobot_Stop_Click);
            // 
            // button_iRobot_forward
            // 
            this.button_iRobot_forward.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_iRobot_forward.Location = new System.Drawing.Point(6, 30);
            this.button_iRobot_forward.Name = "button_iRobot_forward";
            this.button_iRobot_forward.Size = new System.Drawing.Size(101, 45);
            this.button_iRobot_forward.TabIndex = 0;
            this.button_iRobot_forward.Text = "Forward";
            this.button_iRobot_forward.UseVisualStyleBackColor = true;
            this.button_iRobot_forward.Click += new System.EventHandler(this.button_iRobot_forward_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox_Servo2Speed);
            this.tabPage3.Controls.Add(this.textBox_Servo2Target);
            this.tabPage3.Controls.Add(this.button_Servo2);
            this.tabPage3.Controls.Add(this.textBox_Servo1Speed);
            this.tabPage3.Controls.Add(this.textBox_Servo1Target);
            this.tabPage3.Controls.Add(this.button_Servo1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(785, 495);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox_Servo2Speed
            // 
            this.textBox_Servo2Speed.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_Servo2Speed.Location = new System.Drawing.Point(248, 99);
            this.textBox_Servo2Speed.Multiline = true;
            this.textBox_Servo2Speed.Name = "textBox_Servo2Speed";
            this.textBox_Servo2Speed.Size = new System.Drawing.Size(128, 45);
            this.textBox_Servo2Speed.TabIndex = 10;
            this.textBox_Servo2Speed.Text = "200";
            // 
            // textBox_Servo2Target
            // 
            this.textBox_Servo2Target.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_Servo2Target.Location = new System.Drawing.Point(114, 99);
            this.textBox_Servo2Target.Multiline = true;
            this.textBox_Servo2Target.Name = "textBox_Servo2Target";
            this.textBox_Servo2Target.Size = new System.Drawing.Size(128, 45);
            this.textBox_Servo2Target.TabIndex = 9;
            this.textBox_Servo2Target.Text = "2024";
            // 
            // button_Servo2
            // 
            this.button_Servo2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Servo2.Location = new System.Drawing.Point(6, 99);
            this.button_Servo2.Name = "button_Servo2";
            this.button_Servo2.Size = new System.Drawing.Size(101, 45);
            this.button_Servo2.TabIndex = 8;
            this.button_Servo2.Text = "Servo2";
            this.button_Servo2.UseVisualStyleBackColor = true;
            this.button_Servo2.Click += new System.EventHandler(this.button_Servo2_Click);
            // 
            // textBox_Servo1Speed
            // 
            this.textBox_Servo1Speed.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_Servo1Speed.Location = new System.Drawing.Point(248, 48);
            this.textBox_Servo1Speed.Multiline = true;
            this.textBox_Servo1Speed.Name = "textBox_Servo1Speed";
            this.textBox_Servo1Speed.Size = new System.Drawing.Size(128, 45);
            this.textBox_Servo1Speed.TabIndex = 7;
            this.textBox_Servo1Speed.Text = "200";
            // 
            // textBox_Servo1Target
            // 
            this.textBox_Servo1Target.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_Servo1Target.Location = new System.Drawing.Point(114, 48);
            this.textBox_Servo1Target.Multiline = true;
            this.textBox_Servo1Target.Name = "textBox_Servo1Target";
            this.textBox_Servo1Target.Size = new System.Drawing.Size(128, 45);
            this.textBox_Servo1Target.TabIndex = 6;
            this.textBox_Servo1Target.Text = "2024";
            // 
            // button_Servo1
            // 
            this.button_Servo1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Servo1.Location = new System.Drawing.Point(6, 48);
            this.button_Servo1.Name = "button_Servo1";
            this.button_Servo1.Size = new System.Drawing.Size(101, 45);
            this.button_Servo1.TabIndex = 5;
            this.button_Servo1.Text = "Servo1";
            this.button_Servo1.UseVisualStyleBackColor = true;
            this.button_Servo1.Click += new System.EventHandler(this.button_Servo1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox_Speak);
            this.tabPage4.Controls.Add(this.button_Speak);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(785, 495);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox_Speak
            // 
            this.textBox_Speak.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_Speak.Location = new System.Drawing.Point(111, 6);
            this.textBox_Speak.Multiline = true;
            this.textBox_Speak.Name = "textBox_Speak";
            this.textBox_Speak.Size = new System.Drawing.Size(612, 45);
            this.textBox_Speak.TabIndex = 8;
            this.textBox_Speak.Text = "Hello. How may I help you?";
            // 
            // button_Speak
            // 
            this.button_Speak.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Speak.Location = new System.Drawing.Point(3, 6);
            this.button_Speak.Name = "button_Speak";
            this.button_Speak.Size = new System.Drawing.Size(101, 45);
            this.button_Speak.TabIndex = 7;
            this.button_Speak.Text = "Speak";
            this.button_Speak.UseVisualStyleBackColor = true;
            this.button_Speak.Click += new System.EventHandler(this.button_Speak_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(445, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 393);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 546);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.onFormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl_depth_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl_color_original)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl_color_original;
        private System.Windows.Forms.TabPage tabPage2;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl_depth_original;
        private System.Windows.Forms.TextBox textBox_iRobotTurnSpeed;
        private System.Windows.Forms.TextBox textBox_iRobot_ForwadSpeed;
        private System.Windows.Forms.Button button_iRobot_Turn;
        private System.Windows.Forms.Button button_iRobot_Stop;
        private System.Windows.Forms.Button button_iRobot_forward;
        private System.Windows.Forms.TextBox textBox_iRobotSensroData;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox_Servo2Speed;
        private System.Windows.Forms.TextBox textBox_Servo2Target;
        private System.Windows.Forms.Button button_Servo2;
        private System.Windows.Forms.TextBox textBox_Servo1Speed;
        private System.Windows.Forms.TextBox textBox_Servo1Target;
        private System.Windows.Forms.Button button_Servo1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox_Speak;
        private System.Windows.Forms.Button button_Speak;
        private System.Windows.Forms.TextBox textBox1;
    }
}

