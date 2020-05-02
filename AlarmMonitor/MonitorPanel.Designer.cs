namespace AlarmMonitor
{
    partial class MonitorPanel
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numPad = new System.Windows.Forms.Panel();
            this.btnUserSettings = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.displayPanel = new System.Windows.Forms.ListView();
            this.btnSensor1 = new System.Windows.Forms.Button();
            this.firehazard_listView = new System.Windows.Forms.ListView();
            this.btnSensor2 = new System.Windows.Forms.Button();
            this.btnSensor3 = new System.Windows.Forms.Button();
            this.textBoxTriggerSensors = new System.Windows.Forms.TextBox();
            this.timer_ToEnterPin = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_turnOffAlarm = new System.Windows.Forms.Timer(this.components);
            this.numPad.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(411, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Alarm Monitor Panel";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numPad
            // 
            this.numPad.Controls.Add(this.btnUserSettings);
            this.numPad.Controls.Add(this.btnBack);
            this.numPad.Controls.Add(this.btnEnter);
            this.numPad.Controls.Add(this.btnZero);
            this.numPad.Controls.Add(this.btnNine);
            this.numPad.Controls.Add(this.btn8);
            this.numPad.Controls.Add(this.btnSeven);
            this.numPad.Controls.Add(this.btnSix);
            this.numPad.Controls.Add(this.btnFive);
            this.numPad.Controls.Add(this.btnFour);
            this.numPad.Controls.Add(this.btnThree);
            this.numPad.Controls.Add(this.btnTwo);
            this.numPad.Controls.Add(this.btnOne);
            this.numPad.Location = new System.Drawing.Point(386, 239);
            this.numPad.Name = "numPad";
            this.numPad.Size = new System.Drawing.Size(432, 236);
            this.numPad.TabIndex = 1;
            // 
            // btnUserSettings
            // 
            this.btnUserSettings.Location = new System.Drawing.Point(174, 203);
            this.btnUserSettings.Name = "btnUserSettings";
            this.btnUserSettings.Size = new System.Drawing.Size(75, 23);
            this.btnUserSettings.TabIndex = 9;
            this.btnUserSettings.Text = "Settings";
            this.btnUserSettings.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(16, 172);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(315, 172);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 10;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(174, 172);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(75, 23);
            this.btnZero.TabIndex = 9;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(315, 123);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(75, 23);
            this.btnNine.TabIndex = 8;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(174, 123);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 23);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(16, 123);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(75, 23);
            this.btnSeven.TabIndex = 6;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(315, 65);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(75, 23);
            this.btnSix.TabIndex = 5;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(174, 65);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(75, 23);
            this.btnFive.TabIndex = 4;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(16, 65);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(75, 23);
            this.btnFour.TabIndex = 3;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(315, 12);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(75, 23);
            this.btnThree.TabIndex = 2;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(174, 12);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(75, 23);
            this.btnTwo.TabIndex = 1;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(16, 12);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(75, 23);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // displayPanel
            // 
            this.displayPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.displayPanel.HideSelection = false;
            this.displayPanel.Location = new System.Drawing.Point(386, 63);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(222, 170);
            this.displayPanel.TabIndex = 2;
            this.displayPanel.UseCompatibleStateImageBehavior = false;
            this.displayPanel.SelectedIndexChanged += new System.EventHandler(this.displayPanel_SelectedIndexChanged);
            // 
            // btnSensor1
            // 
            this.btnSensor1.Location = new System.Drawing.Point(24, 63);
            this.btnSensor1.Name = "btnSensor1";
            this.btnSensor1.Size = new System.Drawing.Size(80, 25);
            this.btnSensor1.TabIndex = 4;
            this.btnSensor1.Text = "Sensor 1";
            this.btnSensor1.UseVisualStyleBackColor = true;
            this.btnSensor1.Click += new System.EventHandler(this.btnSensor1_Click);
            // 
            // firehazard_listView
            // 
            this.firehazard_listView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.firehazard_listView.HideSelection = false;
            this.firehazard_listView.Location = new System.Drawing.Point(604, 63);
            this.firehazard_listView.Name = "firehazard_listView";
            this.firehazard_listView.Size = new System.Drawing.Size(202, 170);
            this.firehazard_listView.TabIndex = 5;
            this.firehazard_listView.UseCompatibleStateImageBehavior = false;
            this.firehazard_listView.SelectedIndexChanged += new System.EventHandler(this.firehazard_listView_SelectedIndexChanged);
            // 
            // btnSensor2
            // 
            this.btnSensor2.Location = new System.Drawing.Point(24, 137);
            this.btnSensor2.Name = "btnSensor2";
            this.btnSensor2.Size = new System.Drawing.Size(75, 23);
            this.btnSensor2.TabIndex = 6;
            this.btnSensor2.Text = "Sensor 2";
            this.btnSensor2.UseVisualStyleBackColor = true;
            this.btnSensor2.Click += new System.EventHandler(this.btnSensor2_Click);
            // 
            // btnSensor3
            // 
            this.btnSensor3.Location = new System.Drawing.Point(24, 209);
            this.btnSensor3.Name = "btnSensor3";
            this.btnSensor3.Size = new System.Drawing.Size(75, 23);
            this.btnSensor3.TabIndex = 7;
            this.btnSensor3.Text = "Sensor 3";
            this.btnSensor3.UseVisualStyleBackColor = true;
            this.btnSensor3.Click += new System.EventHandler(this.btnSensor3_Click);
            // 
            // textBoxTriggerSensors
            // 
            this.textBoxTriggerSensors.Location = new System.Drawing.Point(20, 25);
            this.textBoxTriggerSensors.Name = "textBoxTriggerSensors";
            this.textBoxTriggerSensors.Size = new System.Drawing.Size(131, 20);
            this.textBoxTriggerSensors.TabIndex = 8;
            this.textBoxTriggerSensors.Text = "Trigger Sensors";
            // 
            // timer_turnOffAlarm
            // 
            this.timer_turnOffAlarm.Tick += new System.EventHandler(this.btnSensor1_Click);
            // 
            // MonitorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 477);
            this.Controls.Add(this.textBoxTriggerSensors);
            this.Controls.Add(this.btnSensor3);
            this.Controls.Add(this.btnSensor2);
            this.Controls.Add(this.firehazard_listView);
            this.Controls.Add(this.btnSensor1);
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.numPad);
            this.Controls.Add(this.textBox1);
            this.Name = "MonitorPanel";
            this.Text = "Alarm Monitor Panel";
            this.numPad.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel numPad;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.ListView displayPanel;
        private System.Windows.Forms.Button btnSensor1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ListView firehazard_listView;
        private System.Windows.Forms.Button btnUserSettings;
        private System.Windows.Forms.Button btnSensor2;
        private System.Windows.Forms.Button btnSensor3;
        private System.Windows.Forms.TextBox textBoxTriggerSensors;
        private System.Windows.Forms.Timer timer_ToEnterPin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer_turnOffAlarm;
    }
}

