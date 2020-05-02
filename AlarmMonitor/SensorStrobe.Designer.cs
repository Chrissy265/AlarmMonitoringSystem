namespace AlarmMonitor
{
    partial class SensorStrobe
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
            this.SensorText = new System.Windows.Forms.TextBox();
            this.btnTrigger = new System.Windows.Forms.Button();
            this.HeatCheckBox = new System.Windows.Forms.CheckBox();
            this.SmokeCheckBox = new System.Windows.Forms.CheckBox();
            this.FireCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SensorText
            // 
            this.SensorText.Location = new System.Drawing.Point(46, 33);
            this.SensorText.Name = "SensorText";
            this.SensorText.Size = new System.Drawing.Size(86, 20);
            this.SensorText.TabIndex = 0;
            this.SensorText.Text = "Sensor Strobe ";
            this.SensorText.TextChanged += new System.EventHandler(this.SensorText_TextChanged);
            // 
            // btnTrigger
            // 
            this.btnTrigger.Location = new System.Drawing.Point(46, 243);
            this.btnTrigger.Name = "btnTrigger";
            this.btnTrigger.Size = new System.Drawing.Size(200, 66);
            this.btnTrigger.TabIndex = 1;
            this.btnTrigger.Text = "Trigger";
            this.btnTrigger.UseVisualStyleBackColor = true;
            // 
            // HeatCheckBox
            // 
            this.HeatCheckBox.AutoSize = true;
            this.HeatCheckBox.Location = new System.Drawing.Point(46, 91);
            this.HeatCheckBox.Name = "HeatCheckBox";
            this.HeatCheckBox.Size = new System.Drawing.Size(49, 17);
            this.HeatCheckBox.TabIndex = 3;
            this.HeatCheckBox.Text = "Heat";
            this.HeatCheckBox.UseVisualStyleBackColor = true;
            // 
            // SmokeCheckBox
            // 
            this.SmokeCheckBox.AutoSize = true;
            this.SmokeCheckBox.Location = new System.Drawing.Point(46, 136);
            this.SmokeCheckBox.Name = "SmokeCheckBox";
            this.SmokeCheckBox.Size = new System.Drawing.Size(59, 17);
            this.SmokeCheckBox.TabIndex = 4;
            this.SmokeCheckBox.Text = "Smoke";
            this.SmokeCheckBox.UseVisualStyleBackColor = true;
            // 
            // FireCheckBox
            // 
            this.FireCheckBox.AutoSize = true;
            this.FireCheckBox.Location = new System.Drawing.Point(46, 174);
            this.FireCheckBox.Name = "FireCheckBox";
            this.FireCheckBox.Size = new System.Drawing.Size(43, 17);
            this.FireCheckBox.TabIndex = 5;
            this.FireCheckBox.Text = "Fire";
            this.FireCheckBox.UseVisualStyleBackColor = true;
            // 
            // SensorStrobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 348);
            this.Controls.Add(this.FireCheckBox);
            this.Controls.Add(this.SmokeCheckBox);
            this.Controls.Add(this.HeatCheckBox);
            this.Controls.Add(this.btnTrigger);
            this.Controls.Add(this.SensorText);
            this.Name = "SensorStrobe";
            this.Text = "SensorStrobe";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SensorStrobe_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SensorText;
        private System.Windows.Forms.Button btnTrigger;
        private System.Windows.Forms.CheckBox HeatCheckBox;
        private System.Windows.Forms.CheckBox SmokeCheckBox;
        private System.Windows.Forms.CheckBox FireCheckBox;
    }
}