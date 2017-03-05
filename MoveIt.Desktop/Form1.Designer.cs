namespace MoveIt.Desktop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDistance = new System.Windows.Forms.TextBox();
            this.tbVolume = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblCalculatedRate = new System.Windows.Forms.Label();
            this.cbPiano = new System.Windows.Forms.CheckBox();
            this.tbAtticVolume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAPIAtticVolume = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAPIPiano = new System.Windows.Forms.CheckBox();
            this.btnCalcByAPI = new System.Windows.Forms.Button();
            this.tbAPIBaseVolume = new System.Windows.Forms.TextBox();
            this.tbAPIDistance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAPIRate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Base volume:";
            // 
            // tbDistance
            // 
            this.tbDistance.Location = new System.Drawing.Point(103, 16);
            this.tbDistance.Name = "tbDistance";
            this.tbDistance.Size = new System.Drawing.Size(204, 20);
            this.tbDistance.TabIndex = 2;
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(103, 42);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(204, 20);
            this.tbVolume.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(15, 148);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblCalculatedRate
            // 
            this.lblCalculatedRate.AutoSize = true;
            this.lblCalculatedRate.Location = new System.Drawing.Point(12, 192);
            this.lblCalculatedRate.Name = "lblCalculatedRate";
            this.lblCalculatedRate.Size = new System.Drawing.Size(0, 13);
            this.lblCalculatedRate.TabIndex = 5;
            // 
            // cbPiano
            // 
            this.cbPiano.AutoSize = true;
            this.cbPiano.Location = new System.Drawing.Point(15, 125);
            this.cbPiano.Name = "cbPiano";
            this.cbPiano.Size = new System.Drawing.Size(53, 17);
            this.cbPiano.TabIndex = 6;
            this.cbPiano.Text = "Piano";
            this.cbPiano.UseVisualStyleBackColor = true;
            // 
            // tbAtticVolume
            // 
            this.tbAtticVolume.Location = new System.Drawing.Point(103, 68);
            this.tbAtticVolume.Name = "tbAtticVolume";
            this.tbAtticVolume.Size = new System.Drawing.Size(204, 20);
            this.tbAtticVolume.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Attic volume:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAPIRate);
            this.groupBox1.Controls.Add(this.tbAPIAtticVolume);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbAPIPiano);
            this.groupBox1.Controls.Add(this.btnCalcByAPI);
            this.groupBox1.Controls.Add(this.tbAPIBaseVolume);
            this.groupBox1.Controls.Add(this.tbAPIDistance);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(338, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 247);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "API";
            // 
            // tbAPIAtticVolume
            // 
            this.tbAPIAtticVolume.Location = new System.Drawing.Point(118, 72);
            this.tbAPIAtticVolume.Name = "tbAPIAtticVolume";
            this.tbAPIAtticVolume.Size = new System.Drawing.Size(204, 20);
            this.tbAPIAtticVolume.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Attic volume:";
            // 
            // cbAPIPiano
            // 
            this.cbAPIPiano.AutoSize = true;
            this.cbAPIPiano.Location = new System.Drawing.Point(30, 129);
            this.cbAPIPiano.Name = "cbAPIPiano";
            this.cbAPIPiano.Size = new System.Drawing.Size(53, 17);
            this.cbAPIPiano.TabIndex = 14;
            this.cbAPIPiano.Text = "Piano";
            this.cbAPIPiano.UseVisualStyleBackColor = true;
            // 
            // btnCalcByAPI
            // 
            this.btnCalcByAPI.Location = new System.Drawing.Point(30, 152);
            this.btnCalcByAPI.Name = "btnCalcByAPI";
            this.btnCalcByAPI.Size = new System.Drawing.Size(75, 23);
            this.btnCalcByAPI.TabIndex = 15;
            this.btnCalcByAPI.Text = "Calculate";
            this.btnCalcByAPI.UseVisualStyleBackColor = true;
            this.btnCalcByAPI.Click += new System.EventHandler(this.btnCalcByAPI_Click);
            // 
            // tbAPIBaseVolume
            // 
            this.tbAPIBaseVolume.Location = new System.Drawing.Point(118, 46);
            this.tbAPIBaseVolume.Name = "tbAPIBaseVolume";
            this.tbAPIBaseVolume.Size = new System.Drawing.Size(204, 20);
            this.tbAPIBaseVolume.TabIndex = 12;
            // 
            // tbAPIDistance
            // 
            this.tbAPIDistance.Location = new System.Drawing.Point(118, 20);
            this.tbAPIDistance.Name = "tbAPIDistance";
            this.tbAPIDistance.Size = new System.Drawing.Size(204, 20);
            this.tbAPIDistance.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Base volume:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Distance:";
            // 
            // lblAPIRate
            // 
            this.lblAPIRate.AutoSize = true;
            this.lblAPIRate.Location = new System.Drawing.Point(27, 199);
            this.lblAPIRate.Name = "lblAPIRate";
            this.lblAPIRate.Size = new System.Drawing.Size(0, 13);
            this.lblAPIRate.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 274);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbAtticVolume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPiano);
            this.Controls.Add(this.lblCalculatedRate);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.tbDistance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MoveIt - desktop test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDistance;
        private System.Windows.Forms.TextBox tbVolume;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblCalculatedRate;
        private System.Windows.Forms.CheckBox cbPiano;
        private System.Windows.Forms.TextBox tbAtticVolume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAPIAtticVolume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbAPIPiano;
        private System.Windows.Forms.Button btnCalcByAPI;
        private System.Windows.Forms.TextBox tbAPIBaseVolume;
        private System.Windows.Forms.TextBox tbAPIDistance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAPIRate;
    }
}

