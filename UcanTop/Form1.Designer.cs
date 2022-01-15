
namespace UcanTop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.Button();
            this.kontrol = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(34, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 535);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(736, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "3";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(37, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(638, 27);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(645, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 536);
            this.label4.TabIndex = 0;
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.MediumBlue;
            this.ball.Location = new System.Drawing.Point(351, 238);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(17, 18);
            this.ball.TabIndex = 3;
            this.ball.UseVisualStyleBackColor = false;
            // 
            // kontrol
            // 
            this.kontrol.BackColor = System.Drawing.Color.DimGray;
            this.kontrol.Location = new System.Drawing.Point(305, 522);
            this.kontrol.Name = "kontrol";
            this.kontrol.Size = new System.Drawing.Size(90, 23);
            this.kontrol.TabIndex = 4;
            this.kontrol.UseVisualStyleBackColor = false;
            this.kontrol.Click += new System.EventHandler(this.Form1_Load);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumBlue;
            this.button3.Location = new System.Drawing.Point(712, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(18, 18);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.kontrol);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ball;
        private System.Windows.Forms.Button kontrol;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
    }
}

