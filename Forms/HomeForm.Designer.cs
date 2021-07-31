
namespace AkritKCFormApplication.Forms
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.loginBtnHomePg = new System.Windows.Forms.Button();
            this.userNameLabelHomePg = new System.Windows.Forms.Label();
            this.PasswordLabelHomePg = new System.Windows.Forms.Label();
            this.reviewBtnHomePg = new System.Windows.Forms.Button();
            this.userNameTxtBxHome = new System.Windows.Forms.TextBox();
            this.passwordTxtBxHm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginBtnHomePg
            // 
            this.loginBtnHomePg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtnHomePg.Location = new System.Drawing.Point(170, 231);
            this.loginBtnHomePg.Name = "loginBtnHomePg";
            this.loginBtnHomePg.Size = new System.Drawing.Size(75, 31);
            this.loginBtnHomePg.TabIndex = 0;
            this.loginBtnHomePg.Text = "Login";
            this.loginBtnHomePg.UseVisualStyleBackColor = true;
            this.loginBtnHomePg.Click += new System.EventHandler(this.loginBtnHomePg_Click);
            // 
            // userNameLabelHomePg
            // 
            this.userNameLabelHomePg.AutoSize = true;
            this.userNameLabelHomePg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabelHomePg.Location = new System.Drawing.Point(7, 148);
            this.userNameLabelHomePg.Name = "userNameLabelHomePg";
            this.userNameLabelHomePg.Size = new System.Drawing.Size(87, 20);
            this.userNameLabelHomePg.TabIndex = 1;
            this.userNameLabelHomePg.Text = "Username:";
            // 
            // PasswordLabelHomePg
            // 
            this.PasswordLabelHomePg.AutoSize = true;
            this.PasswordLabelHomePg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabelHomePg.Location = new System.Drawing.Point(12, 192);
            this.PasswordLabelHomePg.Name = "PasswordLabelHomePg";
            this.PasswordLabelHomePg.Size = new System.Drawing.Size(82, 20);
            this.PasswordLabelHomePg.TabIndex = 2;
            this.PasswordLabelHomePg.Text = "Password:";
            // 
            // reviewBtnHomePg
            // 
            this.reviewBtnHomePg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewBtnHomePg.Location = new System.Drawing.Point(170, 281);
            this.reviewBtnHomePg.Name = "reviewBtnHomePg";
            this.reviewBtnHomePg.Size = new System.Drawing.Size(75, 31);
            this.reviewBtnHomePg.TabIndex = 3;
            this.reviewBtnHomePg.Text = "Review";
            this.reviewBtnHomePg.UseVisualStyleBackColor = true;
            this.reviewBtnHomePg.Click += new System.EventHandler(this.reviewBtnHomePg_Click);
            // 
            // userNameTxtBxHome
            // 
            this.userNameTxtBxHome.Location = new System.Drawing.Point(106, 148);
            this.userNameTxtBxHome.Name = "userNameTxtBxHome";
            this.userNameTxtBxHome.Size = new System.Drawing.Size(213, 20);
            this.userNameTxtBxHome.TabIndex = 4;
            this.userNameTxtBxHome.TextChanged += new System.EventHandler(this.userNameTxtBxHome_TextChanged);
            // 
            // passwordTxtBxHm
            // 
            this.passwordTxtBxHm.Location = new System.Drawing.Point(106, 192);
            this.passwordTxtBxHm.Name = "passwordTxtBxHm";
            this.passwordTxtBxHm.Size = new System.Drawing.Size(213, 20);
            this.passwordTxtBxHm.TabIndex = 5;
            this.passwordTxtBxHm.TextChanged += new System.EventHandler(this.passwordTxtBxHm_TextChanged);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(372, 362);
            this.Controls.Add(this.passwordTxtBxHm);
            this.Controls.Add(this.userNameTxtBxHome);
            this.Controls.Add(this.reviewBtnHomePg);
            this.Controls.Add(this.PasswordLabelHomePg);
            this.Controls.Add(this.userNameLabelHomePg);
            this.Controls.Add(this.loginBtnHomePg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtnHomePg;
        private System.Windows.Forms.Label userNameLabelHomePg;
        private System.Windows.Forms.Label PasswordLabelHomePg;
        private System.Windows.Forms.Button reviewBtnHomePg;
        private System.Windows.Forms.TextBox userNameTxtBxHome;
        private System.Windows.Forms.TextBox passwordTxtBxHm;
    }
}