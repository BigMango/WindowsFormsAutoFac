namespace WindowsFormsAutoFac
{
    partial class FormSecond
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
            this.btnService1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnService1
            // 
            this.btnService1.Location = new System.Drawing.Point(185, 100);
            this.btnService1.Name = "btnService1";
            this.btnService1.Size = new System.Drawing.Size(203, 23);
            this.btnService1.TabIndex = 0;
            this.btnService1.Text = "Service1";
            this.btnService1.UseVisualStyleBackColor = true;
            this.btnService1.Click += new System.EventHandler(this.BtnService1_Click);
            // 
            // FormSecond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnService1);
            this.Name = "FormSecond";
            this.Text = "FormSecond";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnService1;
    }
}