
namespace ProjectGame
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
            this.column7 = new ProjectGame.Column();
            this.column6 = new ProjectGame.Column();
            this.column5 = new ProjectGame.Column();
            this.column4 = new ProjectGame.Column();
            this.column3 = new ProjectGame.Column();
            this.column2 = new ProjectGame.Column();
            this.column1 = new ProjectGame.Column();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(268, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Červený je na tahu.";
            // 
            // column7
            // 
            this.column7.BackColor = System.Drawing.Color.Gray;
            this.column7.Location = new System.Drawing.Point(665, 87);
            this.column7.Name = "column7";
            this.column7.Size = new System.Drawing.Size(96, 556);
            this.column7.TabIndex = 6;
            this.column7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Column_MouseClick);
            // 
            // column6
            // 
            this.column6.BackColor = System.Drawing.Color.Gray;
            this.column6.Location = new System.Drawing.Point(563, 87);
            this.column6.Name = "column6";
            this.column6.Size = new System.Drawing.Size(96, 556);
            this.column6.TabIndex = 5;
            this.column6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Column_MouseClick);
            // 
            // column5
            // 
            this.column5.BackColor = System.Drawing.Color.Gray;
            this.column5.Location = new System.Drawing.Point(461, 87);
            this.column5.Name = "column5";
            this.column5.Size = new System.Drawing.Size(96, 556);
            this.column5.TabIndex = 4;
            this.column5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Column_MouseClick);
            // 
            // column4
            // 
            this.column4.BackColor = System.Drawing.Color.Gray;
            this.column4.Location = new System.Drawing.Point(359, 87);
            this.column4.Name = "column4";
            this.column4.Size = new System.Drawing.Size(96, 556);
            this.column4.TabIndex = 3;
            this.column4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Column_MouseClick);
            // 
            // column3
            // 
            this.column3.BackColor = System.Drawing.Color.Gray;
            this.column3.Location = new System.Drawing.Point(257, 87);
            this.column3.Name = "column3";
            this.column3.Size = new System.Drawing.Size(96, 556);
            this.column3.TabIndex = 2;
            this.column3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Column_MouseClick);
            // 
            // column2
            // 
            this.column2.BackColor = System.Drawing.Color.Gray;
            this.column2.Location = new System.Drawing.Point(155, 87);
            this.column2.Name = "column2";
            this.column2.Size = new System.Drawing.Size(96, 556);
            this.column2.TabIndex = 1;
            this.column2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Column_MouseClick);
            // 
            // column1
            // 
            this.column1.BackColor = System.Drawing.Color.Gray;
            this.column1.Location = new System.Drawing.Point(53, 87);
            this.column1.Name = "column1";
            this.column1.Size = new System.Drawing.Size(96, 556);
            this.column1.TabIndex = 0;
            this.column1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Column_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 655);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.column7);
            this.Controls.Add(this.column6);
            this.Controls.Add(this.column5);
            this.Controls.Add(this.column4);
            this.Controls.Add(this.column3);
            this.Controls.Add(this.column2);
            this.Controls.Add(this.column1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Column column1;
        private Column column2;
        private Column column3;
        private Column column4;
        private Column column5;
        private Column column6;
        private Column column7;
        private System.Windows.Forms.Label label1;
    }
}

