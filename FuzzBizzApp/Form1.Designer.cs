namespace FuzzBizzApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbStart = new System.Windows.Forms.TextBox();
            this.tbStopp = new System.Windows.Forms.TextBox();
            this.tbUt = new System.Windows.Forms.TextBox();
            this.SUbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbStart
            // 
            this.tbStart.Location = new System.Drawing.Point(103, 67);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(150, 31);
            this.tbStart.TabIndex = 0;
            // 
            // tbStopp
            // 
            this.tbStopp.Location = new System.Drawing.Point(541, 67);
            this.tbStopp.Name = "tbStopp";
            this.tbStopp.Size = new System.Drawing.Size(150, 31);
            this.tbStopp.TabIndex = 1;
            // 
            // tbUt
            // 
            this.tbUt.Location = new System.Drawing.Point(103, 156);
            this.tbUt.Multiline = true;
            this.tbUt.Name = "tbUt";
            this.tbUt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbUt.Size = new System.Drawing.Size(588, 231);
            this.tbUt.TabIndex = 2;
            // 
            // SUbutton
            // 
            this.SUbutton.Location = new System.Drawing.Point(346, 64);
            this.SUbutton.Name = "SUbutton";
            this.SUbutton.Size = new System.Drawing.Size(112, 34);
            this.SUbutton.TabIndex = 3;
            this.SUbutton.Text = "&Skriv ut";
            this.SUbutton.UseVisualStyleBackColor = true;
            this.SUbutton.Click += new System.EventHandler(this.SUbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stopp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SUbutton);
            this.Controls.Add(this.tbUt);
            this.Controls.Add(this.tbStopp);
            this.Controls.Add(this.tbStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbStart;
        private TextBox tbStopp;
        private TextBox tbUt;
        private Button SUbutton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}