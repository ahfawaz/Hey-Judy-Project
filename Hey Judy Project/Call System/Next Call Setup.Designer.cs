namespace Call_System
{
    partial class Next_Call_Setup
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CallerID = new System.Windows.Forms.TextBox();
            this.CallerNumber = new System.Windows.Forms.TextBox();
            this.Duration_Hours = new System.Windows.Forms.NumericUpDown();
            this.Duration_Mins = new System.Windows.Forms.NumericUpDown();
            this.Duration_Secs = new System.Windows.Forms.NumericUpDown();
            this.StartAt_Secs = new System.Windows.Forms.NumericUpDown();
            this.StartAt_Mins = new System.Windows.Forms.NumericUpDown();
            this.StartAt_Hours = new System.Windows.Forms.NumericUpDown();
            this.WaitTime_Secs = new System.Windows.Forms.NumericUpDown();
            this.WaitTime_Mins = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Okay_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Duration_Hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duration_Mins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duration_Secs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartAt_Secs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartAt_Mins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartAt_Hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitTime_Secs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitTime_Mins)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caller Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Caller Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Call Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Time Start At";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Time  Delay";
            // 
            // CallerID
            // 
            this.CallerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CallerID.Location = new System.Drawing.Point(215, 40);
            this.CallerID.Name = "CallerID";
            this.CallerID.Size = new System.Drawing.Size(380, 31);
            this.CallerID.TabIndex = 1;
            this.CallerID.Text = "Unknown Caller";
            this.CallerID.TextChanged += new System.EventHandler(this.CallerNumber_TextChanged);
            // 
            // CallerNumber
            // 
            this.CallerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CallerNumber.Location = new System.Drawing.Point(215, 80);
            this.CallerNumber.Name = "CallerNumber";
            this.CallerNumber.Size = new System.Drawing.Size(380, 31);
            this.CallerNumber.TabIndex = 1;
            this.CallerNumber.Text = "Unkown Number";
            this.CallerNumber.TextChanged += new System.EventHandler(this.CallerNumber_TextChanged);
            // 
            // Duration_Hours
            // 
            this.Duration_Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration_Hours.Location = new System.Drawing.Point(84, 20);
            this.Duration_Hours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Duration_Hours.Name = "Duration_Hours";
            this.Duration_Hours.Size = new System.Drawing.Size(49, 31);
            this.Duration_Hours.TabIndex = 2;
            // 
            // Duration_Mins
            // 
            this.Duration_Mins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration_Mins.Location = new System.Drawing.Point(203, 21);
            this.Duration_Mins.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Duration_Mins.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Duration_Mins.Name = "Duration_Mins";
            this.Duration_Mins.Size = new System.Drawing.Size(50, 31);
            this.Duration_Mins.TabIndex = 2;
            this.Duration_Mins.ValueChanged += new System.EventHandler(this.Duration_Changed);
            // 
            // Duration_Secs
            // 
            this.Duration_Secs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration_Secs.Location = new System.Drawing.Point(325, 20);
            this.Duration_Secs.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Duration_Secs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Duration_Secs.Name = "Duration_Secs";
            this.Duration_Secs.Size = new System.Drawing.Size(49, 31);
            this.Duration_Secs.TabIndex = 2;
            this.Duration_Secs.ValueChanged += new System.EventHandler(this.Duration_Changed);
            // 
            // StartAt_Secs
            // 
            this.StartAt_Secs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartAt_Secs.Location = new System.Drawing.Point(325, 77);
            this.StartAt_Secs.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.StartAt_Secs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.StartAt_Secs.Name = "StartAt_Secs";
            this.StartAt_Secs.Size = new System.Drawing.Size(49, 31);
            this.StartAt_Secs.TabIndex = 3;
            this.StartAt_Secs.ValueChanged += new System.EventHandler(this.TimeStart_Changed);
            // 
            // StartAt_Mins
            // 
            this.StartAt_Mins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartAt_Mins.Location = new System.Drawing.Point(203, 77);
            this.StartAt_Mins.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.StartAt_Mins.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.StartAt_Mins.Name = "StartAt_Mins";
            this.StartAt_Mins.Size = new System.Drawing.Size(50, 31);
            this.StartAt_Mins.TabIndex = 4;
            this.StartAt_Mins.ValueChanged += new System.EventHandler(this.TimeStart_Changed);
            // 
            // StartAt_Hours
            // 
            this.StartAt_Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartAt_Hours.Location = new System.Drawing.Point(84, 77);
            this.StartAt_Hours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.StartAt_Hours.Name = "StartAt_Hours";
            this.StartAt_Hours.Size = new System.Drawing.Size(49, 31);
            this.StartAt_Hours.TabIndex = 5;
            this.StartAt_Hours.ValueChanged += new System.EventHandler(this.TimeStart_Changed);
            // 
            // WaitTime_Secs
            // 
            this.WaitTime_Secs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaitTime_Secs.Location = new System.Drawing.Point(325, 138);
            this.WaitTime_Secs.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.WaitTime_Secs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.WaitTime_Secs.Name = "WaitTime_Secs";
            this.WaitTime_Secs.Size = new System.Drawing.Size(49, 31);
            this.WaitTime_Secs.TabIndex = 6;
            this.WaitTime_Secs.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.WaitTime_Secs.ValueChanged += new System.EventHandler(this.WaitTime_Secs_ValueChanged);
            // 
            // WaitTime_Mins
            // 
            this.WaitTime_Mins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaitTime_Mins.Location = new System.Drawing.Point(203, 138);
            this.WaitTime_Mins.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.WaitTime_Mins.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.WaitTime_Mins.Name = "WaitTime_Mins";
            this.WaitTime_Mins.Size = new System.Drawing.Size(50, 31);
            this.WaitTime_Mins.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Hours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(139, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mins";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(139, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Mins";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(259, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Secs";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(259, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Secs";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(259, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 25);
            this.label12.TabIndex = 10;
            this.label12.Text = "Secs";
            // 
            // Okay_Button
            // 
            this.Okay_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Okay_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Okay_Button.Location = new System.Drawing.Point(146, 362);
            this.Okay_Button.Name = "Okay_Button";
            this.Okay_Button.Size = new System.Drawing.Size(139, 61);
            this.Okay_Button.TabIndex = 11;
            this.Okay_Button.Text = "OK";
            this.Okay_Button.UseVisualStyleBackColor = true;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Button.Location = new System.Drawing.Point(322, 362);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(139, 61);
            this.Cancel_Button.TabIndex = 12;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(139, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 25);
            this.label13.TabIndex = 9;
            this.label13.Text = "Mins";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.StartAt_Hours);
            this.groupBox1.Controls.Add(this.StartAt_Mins);
            this.groupBox1.Controls.Add(this.Duration_Hours);
            this.groupBox1.Controls.Add(this.StartAt_Secs);
            this.groupBox1.Controls.Add(this.Duration_Mins);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Duration_Secs);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.WaitTime_Secs);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.WaitTime_Mins);
            this.groupBox1.Location = new System.Drawing.Point(215, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 198);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // Next_Call_Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 489);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Okay_Button);
            this.Controls.Add(this.CallerNumber);
            this.Controls.Add(this.CallerID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Next_Call_Setup";
            this.Text = "Next Call Setup";
            ((System.ComponentModel.ISupportInitialize)(this.Duration_Hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duration_Mins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duration_Secs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartAt_Secs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartAt_Mins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartAt_Hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitTime_Secs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitTime_Mins)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CallerID;
        private System.Windows.Forms.TextBox CallerNumber;
        private System.Windows.Forms.NumericUpDown Duration_Hours;
        private System.Windows.Forms.NumericUpDown Duration_Mins;
        private System.Windows.Forms.NumericUpDown Duration_Secs;
        private System.Windows.Forms.NumericUpDown StartAt_Secs;
        private System.Windows.Forms.NumericUpDown StartAt_Mins;
        private System.Windows.Forms.NumericUpDown StartAt_Hours;
        private System.Windows.Forms.NumericUpDown WaitTime_Secs;
        private System.Windows.Forms.NumericUpDown WaitTime_Mins;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Okay_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}