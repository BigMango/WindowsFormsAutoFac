namespace WindowsFormsAutoFac
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnService1 = new System.Windows.Forms.Button();
            this.btnService2 = new System.Windows.Forms.Button();
            this.btnServicePureClass = new System.Windows.Forms.Button();
            this.btnService1SetUserName = new System.Windows.Forms.Button();
            this.edtService1UserName = new System.Windows.Forms.TextBox();
            this.btnSecondForms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnService1
            // 
            this.btnService1.Location = new System.Drawing.Point(39, 39);
            this.btnService1.Name = "btnService1";
            this.btnService1.Size = new System.Drawing.Size(75, 23);
            this.btnService1.TabIndex = 0;
            this.btnService1.Text = "Service1";
            this.btnService1.UseVisualStyleBackColor = true;
            this.btnService1.Click += new System.EventHandler(this.BtnService1_Click);
            // 
            // btnService2
            // 
            this.btnService2.Location = new System.Drawing.Point(255, 39);
            this.btnService2.Name = "btnService2";
            this.btnService2.Size = new System.Drawing.Size(75, 23);
            this.btnService2.TabIndex = 1;
            this.btnService2.Text = "Service2";
            this.btnService2.UseVisualStyleBackColor = true;
            this.btnService2.Click += new System.EventHandler(this.BtnService2_Click);
            // 
            // btnServicePureClass
            // 
            this.btnServicePureClass.Location = new System.Drawing.Point(433, 39);
            this.btnServicePureClass.Name = "btnServicePureClass";
            this.btnServicePureClass.Size = new System.Drawing.Size(144, 23);
            this.btnServicePureClass.TabIndex = 2;
            this.btnServicePureClass.Text = "ServicePureClass";
            this.btnServicePureClass.UseVisualStyleBackColor = true;
            this.btnServicePureClass.Click += new System.EventHandler(this.BtnServicePureClass_Click);
            // 
            // btnService1SetUserName
            // 
            this.btnService1SetUserName.Location = new System.Drawing.Point(39, 93);
            this.btnService1SetUserName.Name = "btnService1SetUserName";
            this.btnService1SetUserName.Size = new System.Drawing.Size(86, 23);
            this.btnService1SetUserName.TabIndex = 3;
            this.btnService1SetUserName.Text = "SetUserName";
            this.btnService1SetUserName.UseVisualStyleBackColor = true;
            this.btnService1SetUserName.Click += new System.EventHandler(this.BtnService1SetUserName_Click);
            // 
            // edtService1UserName
            // 
            this.edtService1UserName.Location = new System.Drawing.Point(132, 95);
            this.edtService1UserName.Name = "edtService1UserName";
            this.edtService1UserName.Size = new System.Drawing.Size(79, 20);
            this.edtService1UserName.TabIndex = 4;
            // 
            // btnSecondForms
            // 
            this.btnSecondForms.Location = new System.Drawing.Point(39, 233);
            this.btnSecondForms.Name = "btnSecondForms";
            this.btnSecondForms.Size = new System.Drawing.Size(177, 23);
            this.btnSecondForms.TabIndex = 5;
            this.btnSecondForms.Text = "Second Forms";
            this.btnSecondForms.UseVisualStyleBackColor = true;
            this.btnSecondForms.Click += new System.EventHandler(this.BtnSecondForms_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSecondForms);
            this.Controls.Add(this.edtService1UserName);
            this.Controls.Add(this.btnService1SetUserName);
            this.Controls.Add(this.btnServicePureClass);
            this.Controls.Add(this.btnService2);
            this.Controls.Add(this.btnService1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnService1;
        private System.Windows.Forms.Button btnService2;
        private System.Windows.Forms.Button btnServicePureClass;
        private System.Windows.Forms.Button btnService1SetUserName;
        private System.Windows.Forms.TextBox edtService1UserName;
        private System.Windows.Forms.Button btnSecondForms;
    }
}

