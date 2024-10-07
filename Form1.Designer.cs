namespace WinFormsApp4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtBox1 = new System.Windows.Forms.Label();
            this.txtBox2 = new System.Windows.Forms.Label();
            this.txtBox3 = new System.Windows.Forms.Label();
            this.txtBox4 = new System.Windows.Forms.Label();
            this.txtBox5 = new System.Windows.Forms.Label();
            this.txtBox6 = new System.Windows.Forms.Label();
            this.txtBox7 = new System.Windows.Forms.Label();
            this.txtBox8 = new System.Windows.Forms.Label();
            
            this.txtMass1 = new System.Windows.Forms.TextBox();
            this.txtMass2 = new System.Windows.Forms.TextBox();
            
            this.txtSpeed1 = new System.Windows.Forms.TextBox();
            this.txtSpeed2 = new System.Windows.Forms.TextBox();
            
            this.txtAngle1 = new System.Windows.Forms.TextBox();
            this.txtAngle2 = new System.Windows.Forms.TextBox();
            
            this.txtContainerWidth = new System.Windows.Forms.TextBox();
            this.txtContainerHeight = new System.Windows.Forms.TextBox();
            
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // txtMass1
            // 
            this.txtBox1.Location = new System.Drawing.Point(10, 10);
            this.txtBox1.Text = "Масса 1";
            this.txtBox1.BackColor = Color.White;
            this.txtBox1.Size = new Size(50, 15);
            
            this.txtMass1.Location = new System.Drawing.Point(10, 25);
            this.txtMass1.Name = "txtMass1";
            this.txtMass1.Size = new System.Drawing.Size(50, 20);
            this.txtMass1.TabIndex = 0;
            this.txtMass1.Text = "1";

            // 
            // txtMass2
            // 
            this.txtBox2.Location = new System.Drawing.Point(80, 10);
            this.txtBox2.Text = "Масса 2";
            this.txtBox2.BackColor = Color.White;
            this.txtBox2.Size = new Size(50, 15);
            
            this.txtMass2.Location = new System.Drawing.Point(80, 25);
            this.txtMass2.Name = "txtMass2";
            this.txtMass2.Size = new System.Drawing.Size(50, 20);
            this.txtMass2.TabIndex = 1;
            this.txtMass2.Text = "2";

            // 
            // txtSpeed1
            // 
            this.txtBox3.Location = new System.Drawing.Point(10, 50);
            this.txtBox3.Text = "Скорость 1";
            this.txtBox3.BackColor = Color.White;
            this.txtBox3.Size = new Size(70, 15);
            
            this.txtSpeed1.Location = new System.Drawing.Point(10, 65);
            this.txtSpeed1.Name = "txtSpeed1";
            this.txtSpeed1.Size = new System.Drawing.Size(50, 20);
            this.txtSpeed1.TabIndex = 2;
            this.txtSpeed1.Text = "50";

            // 
            // txtSpeed2
            // 
            this.txtBox4.Location = new System.Drawing.Point(80, 50);
            this.txtBox4.Text = "Скорость 2";
            this.txtBox4.BackColor = Color.White;
            this.txtBox4.Size = new Size(70, 15);
            
            this.txtSpeed2.Location = new System.Drawing.Point(80, 65);
            this.txtSpeed2.Name = "txtSpeed2";
            this.txtSpeed2.Size = new System.Drawing.Size(50, 20);
            this.txtSpeed2.TabIndex = 3;
            this.txtSpeed2.Text = "20";
            
            // 
            // txtAngle1
            // 
            this.txtBox5.Location = new System.Drawing.Point(10, 90);
            this.txtBox5.Text = "Угол 1";
            this.txtBox5.BackColor = Color.White;
            this.txtBox5.Size = new Size(70, 15);
            
            this.txtAngle1.Location = new System.Drawing.Point(10, 105);
            this.txtAngle1.Name = "txtAngle1";
            this.txtAngle1.Size = new System.Drawing.Size(50, 20);
            this.txtAngle1.TabIndex = 4;
            this.txtAngle1.Text = "45";

            // 
            // txtAngle2
            // 
            this.txtBox6.Location = new System.Drawing.Point(80, 90);
            this.txtBox6.Text = "Угол 2";
            this.txtBox6.BackColor = Color.White;
            this.txtBox6.Size = new Size(70, 15);
            
            this.txtAngle2.Location = new System.Drawing.Point(80, 105);
            this.txtAngle2.Name = "txtAngle2";
            this.txtAngle2.Size = new System.Drawing.Size(50, 20);
            this.txtAngle2.TabIndex = 5;
            this.txtAngle2.Text = "120";

            // 
            // txtContainerWidth
            // 
            this.txtBox7.Location = new System.Drawing.Point(10, 130);
            this.txtBox7.Text = "Ширина";
            this.txtBox7.BackColor = Color.White;
            this.txtBox7.Size = new Size(70, 15);
            
            this.txtContainerWidth.Location = new System.Drawing.Point(10, 145);
            this.txtContainerWidth.Name = "txtContainerWidth";
            this.txtContainerWidth.Size = new System.Drawing.Size(50, 20);
            this.txtContainerWidth.TabIndex = 6;
            this.txtContainerWidth.Text = "800";

            // 
            // txtContainerHeight
            // 
            this.txtBox8.Location = new System.Drawing.Point(80, 130);
            this.txtBox8.Text = "Высота";
            this.txtBox8.BackColor = Color.White;
            this.txtBox8.Size = new Size(70, 15);
            
            this.txtContainerHeight.Location = new System.Drawing.Point(80, 145);
            this.txtContainerHeight.Name = "txtContainerHeight";
            this.txtContainerHeight.Size = new System.Drawing.Size(50, 20);
            this.txtContainerHeight.TabIndex = 7;
            this.txtContainerHeight.Text = "600";

            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(20, 170);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 30);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 300);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtContainerHeight);
            this.Controls.Add(this.txtContainerWidth);
            this.Controls.Add(this.txtAngle2);
            this.Controls.Add(this.txtAngle1);
            this.Controls.Add(this.txtSpeed2);
            this.Controls.Add(this.txtSpeed1);
            this.Controls.Add(this.txtMass2);
            this.Controls.Add(this.txtMass1);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.txtBox4);
            this.Controls.Add(this.txtBox5);
            this.Controls.Add(this.txtBox6);
            this.Controls.Add(this.txtBox7);
            this.Controls.Add(this.txtBox8);
            this.Name = "Form1";
            this.Text = "Визуализация абсолютно упругого нецентрального соударения двух тел с разными массами";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtMass1;
        private System.Windows.Forms.TextBox txtMass2;
        private System.Windows.Forms.TextBox txtSpeed1;
        private System.Windows.Forms.TextBox txtSpeed2;
        private System.Windows.Forms.TextBox txtAngle1;
        private System.Windows.Forms.TextBox txtAngle2;
        private System.Windows.Forms.TextBox txtContainerWidth;
        private System.Windows.Forms.TextBox txtContainerHeight;
        private System.Windows.Forms.Button btnStart;
    }
}
