namespace Email_Code
{
    partial class Email
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Email));
            this.btn_sendCode = new System.Windows.Forms.Button();
            this.btn_checkcode = new System.Windows.Forms.Button();
            this.txt_usr = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_sendCode
            // 
            this.btn_sendCode.Location = new System.Drawing.Point(47, 12);
            this.btn_sendCode.Name = "btn_sendCode";
            this.btn_sendCode.Size = new System.Drawing.Size(378, 76);
            this.btn_sendCode.TabIndex = 0;
            this.btn_sendCode.Text = "Send Code";
            this.btn_sendCode.UseVisualStyleBackColor = true;
            this.btn_sendCode.Click += new System.EventHandler(this.btn_sendCode_Click);
            // 
            // btn_checkcode
            // 
            this.btn_checkcode.Location = new System.Drawing.Point(239, 125);
            this.btn_checkcode.Name = "btn_checkcode";
            this.btn_checkcode.Size = new System.Drawing.Size(186, 53);
            this.btn_checkcode.TabIndex = 1;
            this.btn_checkcode.Text = "Check Code";
            this.btn_checkcode.UseVisualStyleBackColor = true;
            this.btn_checkcode.Click += new System.EventHandler(this.btn_checkcode_Click);
            // 
            // txt_usr
            // 
            this.txt_usr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usr.Location = new System.Drawing.Point(47, 125);
            this.txt_usr.Multiline = true;
            this.txt_usr.Name = "txt_usr";
            this.txt_usr.Size = new System.Drawing.Size(174, 53);
            this.txt_usr.TabIndex = 2;
            // 
            // lbl_result
            // 
            this.lbl_result.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_result.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_result.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl_result.Location = new System.Drawing.Point(0, 181);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(469, 99);
            this.lbl_result.TabIndex = 3;
            this.lbl_result.Text = "Result";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(469, 280);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.txt_usr);
            this.Controls.Add(this.btn_checkcode);
            this.Controls.Add(this.btn_sendCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Email";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sendCode;
        private System.Windows.Forms.Button btn_checkcode;
        private System.Windows.Forms.TextBox txt_usr;
        private System.Windows.Forms.Label lbl_result;
    }
}
