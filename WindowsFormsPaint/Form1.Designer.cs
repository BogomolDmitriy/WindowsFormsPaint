
namespace WindowsFormsPaint
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
            this.button1 = new System.Windows.Forms.Button();
            this.Indicator = new System.Windows.Forms.Label();
            this.PointA = new System.Windows.Forms.GroupBox();
            this.numericUpDownPointAY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownPointAX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownPointBY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownPointBX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PointA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointAX)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointBY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointBX)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // Indicator
            // 
            this.Indicator.AutoSize = true;
            this.Indicator.Location = new System.Drawing.Point(34, 36);
            this.Indicator.Name = "Indicator";
            this.Indicator.Size = new System.Drawing.Size(35, 13);
            this.Indicator.TabIndex = 1;
            this.Indicator.Text = "label1";
            // 
            // PointA
            // 
            this.PointA.Controls.Add(this.numericUpDownPointAY);
            this.PointA.Controls.Add(this.label2);
            this.PointA.Controls.Add(this.numericUpDownPointAX);
            this.PointA.Controls.Add(this.label1);
            this.PointA.Location = new System.Drawing.Point(12, 19);
            this.PointA.Name = "PointA";
            this.PointA.Size = new System.Drawing.Size(162, 87);
            this.PointA.TabIndex = 2;
            this.PointA.TabStop = false;
            this.PointA.Text = "Point A";
            // 
            // numericUpDownPointAY
            // 
            this.numericUpDownPointAY.Location = new System.Drawing.Point(26, 54);
            this.numericUpDownPointAY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPointAY.Name = "numericUpDownPointAY";
            this.numericUpDownPointAY.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPointAY.TabIndex = 4;
            this.numericUpDownPointAY.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownPointAY.ValueChanged += new System.EventHandler(this.numericUpDownPointAX_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            // 
            // numericUpDownPointAX
            // 
            this.numericUpDownPointAX.Location = new System.Drawing.Point(26, 23);
            this.numericUpDownPointAX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPointAX.Name = "numericUpDownPointAX";
            this.numericUpDownPointAX.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPointAX.TabIndex = 2;
            this.numericUpDownPointAX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownPointAX.ValueChanged += new System.EventHandler(this.numericUpDownPointAX_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownPointBY);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDownPointBX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 81);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Point B";
            // 
            // numericUpDownPointBY
            // 
            this.numericUpDownPointBY.Location = new System.Drawing.Point(26, 54);
            this.numericUpDownPointBY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPointBY.Name = "numericUpDownPointBY";
            this.numericUpDownPointBY.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPointBY.TabIndex = 4;
            this.numericUpDownPointBY.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpDownPointBY.ValueChanged += new System.EventHandler(this.numericUpDownPointAX_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y";
            // 
            // numericUpDownPointBX
            // 
            this.numericUpDownPointBX.Location = new System.Drawing.Point(26, 23);
            this.numericUpDownPointBX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPointBX.Name = "numericUpDownPointBX";
            this.numericUpDownPointBX.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPointBX.TabIndex = 2;
            this.numericUpDownPointBX.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownPointBX.ValueChanged += new System.EventHandler(this.numericUpDownPointAX_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "X";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.PointA);
            this.groupBox2.Location = new System.Drawing.Point(602, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 200);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Indicator);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.PointA.ResumeLayout(false);
            this.PointA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointAX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointBY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointBX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Indicator;
        private System.Windows.Forms.GroupBox PointA;
        private System.Windows.Forms.NumericUpDown numericUpDownPointAY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownPointAX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownPointBY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownPointBX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

