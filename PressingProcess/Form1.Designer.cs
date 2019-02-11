namespace PressingProcess
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.compute = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.d2 = new System.Windows.Forms.TextBox();
            this.d3 = new System.Windows.Forms.TextBox();
            this.αAngle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.αAngleStep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.d3Step = new System.Windows.Forms.TextBox();
            this.d2Step = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.αAngleEnd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.d3End = new System.Windows.Forms.TextBox();
            this.d2End = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bigRingThikness = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.smallRingThikness = new System.Windows.Forms.TextBox();
            this.stampThikness = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // compute
            // 
            this.compute.Location = new System.Drawing.Point(487, 359);
            this.compute.Margin = new System.Windows.Forms.Padding(5);
            this.compute.Name = "compute";
            this.compute.Size = new System.Drawing.Size(125, 58);
            this.compute.TabIndex = 0;
            this.compute.Text = "Start Compute";
            this.compute.UseVisualStyleBackColor = true;
            this.compute.Click += new System.EventHandler(this.compute_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "d2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "d3";
            // 
            // d2
            // 
            this.d2.Location = new System.Drawing.Point(464, 49);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(100, 29);
            this.d2.TabIndex = 8;
            this.d2.Text = "30";
            // 
            // d3
            // 
            this.d3.Location = new System.Drawing.Point(464, 84);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(100, 29);
            this.d3.TabIndex = 9;
            this.d3.Text = "20";
            // 
            // αAngle
            // 
            this.αAngle.Location = new System.Drawing.Point(464, 119);
            this.αAngle.Name = "αAngle";
            this.αAngle.Size = new System.Drawing.Size(100, 29);
            this.αAngle.TabIndex = 15;
            this.αAngle.Text = "30";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "α";
            // 
            // αAngleStep
            // 
            this.αAngleStep.Location = new System.Drawing.Point(656, 257);
            this.αAngleStep.Name = "αAngleStep";
            this.αAngleStep.Size = new System.Drawing.Size(100, 29);
            this.αAngleStep.TabIndex = 21;
            this.αAngleStep.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 265);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "step α";
            // 
            // d3Step
            // 
            this.d3Step.Location = new System.Drawing.Point(656, 222);
            this.d3Step.Name = "d3Step";
            this.d3Step.Size = new System.Drawing.Size(100, 29);
            this.d3Step.TabIndex = 19;
            this.d3Step.Text = "5";
            // 
            // d2Step
            // 
            this.d2Step.Location = new System.Drawing.Point(656, 187);
            this.d2Step.Name = "d2Step";
            this.d2Step.Size = new System.Drawing.Size(100, 29);
            this.d2Step.TabIndex = 18;
            this.d2Step.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 230);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "step d3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "step d2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Start Data (mm)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(610, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Step for Data (mm)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(610, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 21);
            this.label9.TabIndex = 30;
            this.label9.Text = "End Data (mm)";
            // 
            // αAngleEnd
            // 
            this.αAngleEnd.Location = new System.Drawing.Point(656, 119);
            this.αAngleEnd.Name = "αAngleEnd";
            this.αAngleEnd.Size = new System.Drawing.Size(100, 29);
            this.αAngleEnd.TabIndex = 29;
            this.αAngleEnd.Text = "60";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(583, 127);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "α";
            // 
            // d3End
            // 
            this.d3End.Location = new System.Drawing.Point(656, 84);
            this.d3End.Name = "d3End";
            this.d3End.Size = new System.Drawing.Size(100, 29);
            this.d3End.TabIndex = 27;
            this.d3End.Text = "30";
            // 
            // d2End
            // 
            this.d2End.Location = new System.Drawing.Point(656, 49);
            this.d2End.Name = "d2End";
            this.d2End.Size = new System.Drawing.Size(100, 29);
            this.d2End.TabIndex = 26;
            this.d2End.Text = "35";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(583, 92);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 21);
            this.label11.TabIndex = 25;
            this.label11.Text = "d3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(583, 57);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 21);
            this.label12.TabIndex = 24;
            this.label12.Text = "d2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PressingProcess.Properties.Resources.draw;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 484);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // bigRingThikness
            // 
            this.bigRingThikness.Location = new System.Drawing.Point(464, 257);
            this.bigRingThikness.Name = "bigRingThikness";
            this.bigRingThikness.Size = new System.Drawing.Size(100, 29);
            this.bigRingThikness.TabIndex = 37;
            this.bigRingThikness.Text = "20";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(375, 265);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 21);
            this.label14.TabIndex = 36;
            this.label14.Text = "Big Ring";
            // 
            // smallRingThikness
            // 
            this.smallRingThikness.Location = new System.Drawing.Point(464, 222);
            this.smallRingThikness.Name = "smallRingThikness";
            this.smallRingThikness.Size = new System.Drawing.Size(100, 29);
            this.smallRingThikness.TabIndex = 35;
            this.smallRingThikness.Text = "10";
            // 
            // stampThikness
            // 
            this.stampThikness.Location = new System.Drawing.Point(464, 187);
            this.stampThikness.Name = "stampThikness";
            this.stampThikness.Size = new System.Drawing.Size(100, 29);
            this.stampThikness.TabIndex = 34;
            this.stampThikness.Text = "60";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(375, 230);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 21);
            this.label15.TabIndex = 33;
            this.label15.Text = "Small Ring";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(384, 184);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 21);
            this.label16.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(411, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 21);
            this.label13.TabIndex = 38;
            this.label13.Text = "Thikness (mm)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(375, 195);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 21);
            this.label17.TabIndex = 39;
            this.label17.Text = "Stamp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 511);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bigRingThikness);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.smallRingThikness);
            this.Controls.Add(this.stampThikness);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.αAngleEnd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.d3End);
            this.Controls.Add(this.d2End);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.αAngleStep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.d3Step);
            this.Controls.Add(this.d2Step);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.αAngle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.compute);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiplomaProject";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button compute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox d2;
        private System.Windows.Forms.TextBox d3;
        private System.Windows.Forms.TextBox αAngle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox αAngleStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox d3Step;
        private System.Windows.Forms.TextBox d2Step;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox αAngleEnd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox d3End;
        private System.Windows.Forms.TextBox d2End;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox bigRingThikness;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox smallRingThikness;
        private System.Windows.Forms.TextBox stampThikness;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
    }
}

