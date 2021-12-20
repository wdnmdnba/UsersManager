namespace UsersManager
{
    partial class FrmLogin
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btncCheck = new Guna.UI2.WinForms.Guna2GradientButton();
            this.clbCloes = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tbPwd = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 12;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.Transparent;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.AnimatedGIF = true;
            this.btnLogin.BorderRadius = 8;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.DisabledState.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(99)))), ((int)(((byte)(171)))));
            this.btnLogin.FillColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(98, 237);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(243, 53);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "登录";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btncCheck
            // 
            this.btncCheck.Animated = true;
            this.btncCheck.AnimatedGIF = true;
            this.btncCheck.BorderRadius = 8;
            this.btncCheck.CheckedState.Parent = this.btncCheck;
            this.btncCheck.CustomImages.Parent = this.btncCheck;
            this.btncCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncCheck.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncCheck.DisabledState.Parent = this.btncCheck;
            this.btncCheck.FillColor = System.Drawing.Color.LightGray;
            this.btncCheck.FillColor2 = System.Drawing.Color.Gray;
            this.btncCheck.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btncCheck.ForeColor = System.Drawing.Color.White;
            this.btncCheck.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btncCheck.HoverState.Parent = this.btncCheck;
            this.btncCheck.Location = new System.Drawing.Point(98, 314);
            this.btncCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncCheck.Name = "btncCheck";
            this.btncCheck.ShadowDecoration.Parent = this.btncCheck;
            this.btncCheck.Size = new System.Drawing.Size(243, 53);
            this.btncCheck.TabIndex = 3;
            this.btncCheck.Text = "注册";
            // 
            // clbCloes
            // 
            this.clbCloes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clbCloes.Animated = true;
            this.clbCloes.BorderRadius = 4;
            this.clbCloes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.clbCloes.HoverState.Parent = this.clbCloes;
            this.clbCloes.IconColor = System.Drawing.Color.White;
            this.clbCloes.Location = new System.Drawing.Point(379, -1);
            this.clbCloes.Name = "clbCloes";
            this.clbCloes.ShadowDecoration.Parent = this.clbCloes;
            this.clbCloes.Size = new System.Drawing.Size(45, 29);
            this.clbCloes.TabIndex = 2;
            // 
            // tbPwd
            // 
            this.tbPwd.BorderRadius = 8;
            this.tbPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPwd.DefaultText = "";
            this.tbPwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPwd.DisabledState.Parent = this.tbPwd;
            this.tbPwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPwd.FocusedState.Parent = this.tbPwd;
            this.tbPwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPwd.HoverState.Parent = this.tbPwd;
            this.tbPwd.IconLeft = global::UsersManager.Properties.Resources.Pwd;
            this.tbPwd.Location = new System.Drawing.Point(98, 154);
            this.tbPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.PasswordChar = '\0';
            this.tbPwd.PlaceholderText = "请输入密码";
            this.tbPwd.SelectedText = "";
            this.tbPwd.ShadowDecoration.Parent = this.tbPwd;
            this.tbPwd.Size = new System.Drawing.Size(243, 52);
            this.tbPwd.TabIndex = 1;
            // 
            // tbUserID
            // 
            this.tbUserID.BorderRadius = 8;
            this.tbUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserID.DefaultText = "";
            this.tbUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserID.DisabledState.Parent = this.tbUserID;
            this.tbUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserID.FocusedState.Parent = this.tbUserID;
            this.tbUserID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserID.HoverState.Parent = this.tbUserID;
            this.tbUserID.IconLeft = global::UsersManager.Properties.Resources.LoginId;
            this.tbUserID.Location = new System.Drawing.Point(98, 71);
            this.tbUserID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.PasswordChar = '\0';
            this.tbUserID.PlaceholderText = "请输入用户名";
            this.tbUserID.SelectedText = "";
            this.tbUserID.ShadowDecoration.Parent = this.tbUserID;
            this.tbUserID.Size = new System.Drawing.Size(243, 52);
            this.tbUserID.TabIndex = 0;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 438);
            this.Controls.Add(this.clbCloes);
            this.Controls.Add(this.btncCheck);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.tbUserID);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TextBox tbUserID;
        private Guna.UI2.WinForms.Guna2TextBox tbPwd;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private Guna.UI2.WinForms.Guna2GradientButton btncCheck;
        private Guna.UI2.WinForms.Guna2ControlBox clbCloes;
    }
}