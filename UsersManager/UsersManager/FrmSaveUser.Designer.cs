namespace UsersManager
{
    partial class FrmSaveUser
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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tbUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbAge = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbLoginID = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbLoginPwd = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbCheckPwd = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 12;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BorderRadius = 4;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(343, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // tbUserName
            // 
            this.tbUserName.BorderRadius = 6;
            this.tbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserName.DefaultText = "";
            this.tbUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserName.DisabledState.Parent = this.tbUserName;
            this.tbUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserName.FocusedState.Parent = this.tbUserName;
            this.tbUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserName.HoverState.Parent = this.tbUserName;
            this.tbUserName.Location = new System.Drawing.Point(89, 39);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.PasswordChar = '\0';
            this.tbUserName.PlaceholderText = "真实姓名";
            this.tbUserName.SelectedText = "";
            this.tbUserName.ShadowDecoration.Parent = this.tbUserName;
            this.tbUserName.Size = new System.Drawing.Size(200, 36);
            this.tbUserName.TabIndex = 0;
            // 
            // tbAge
            // 
            this.tbAge.BorderRadius = 6;
            this.tbAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAge.DefaultText = "";
            this.tbAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAge.DisabledState.Parent = this.tbAge;
            this.tbAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAge.FocusedState.Parent = this.tbAge;
            this.tbAge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAge.HoverState.Parent = this.tbAge;
            this.tbAge.Location = new System.Drawing.Point(89, 98);
            this.tbAge.Name = "tbAge";
            this.tbAge.PasswordChar = '\0';
            this.tbAge.PlaceholderText = "真实年龄";
            this.tbAge.SelectedText = "";
            this.tbAge.ShadowDecoration.Parent = this.tbAge;
            this.tbAge.Size = new System.Drawing.Size(200, 36);
            this.tbAge.TabIndex = 1;
            // 
            // tbLoginID
            // 
            this.tbLoginID.BorderRadius = 6;
            this.tbLoginID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLoginID.DefaultText = "";
            this.tbLoginID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLoginID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLoginID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLoginID.DisabledState.Parent = this.tbLoginID;
            this.tbLoginID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLoginID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLoginID.FocusedState.Parent = this.tbLoginID;
            this.tbLoginID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbLoginID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLoginID.HoverState.Parent = this.tbLoginID;
            this.tbLoginID.Location = new System.Drawing.Point(89, 157);
            this.tbLoginID.Name = "tbLoginID";
            this.tbLoginID.PasswordChar = '\0';
            this.tbLoginID.PlaceholderText = "用户名";
            this.tbLoginID.SelectedText = "";
            this.tbLoginID.ShadowDecoration.Parent = this.tbLoginID;
            this.tbLoginID.Size = new System.Drawing.Size(200, 36);
            this.tbLoginID.TabIndex = 2;
            // 
            // tbLoginPwd
            // 
            this.tbLoginPwd.BorderRadius = 6;
            this.tbLoginPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLoginPwd.DefaultText = "";
            this.tbLoginPwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLoginPwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLoginPwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLoginPwd.DisabledState.Parent = this.tbLoginPwd;
            this.tbLoginPwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLoginPwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLoginPwd.FocusedState.Parent = this.tbLoginPwd;
            this.tbLoginPwd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbLoginPwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLoginPwd.HoverState.Parent = this.tbLoginPwd;
            this.tbLoginPwd.Location = new System.Drawing.Point(89, 216);
            this.tbLoginPwd.Name = "tbLoginPwd";
            this.tbLoginPwd.PasswordChar = '\0';
            this.tbLoginPwd.PlaceholderText = "登录密码";
            this.tbLoginPwd.SelectedText = "";
            this.tbLoginPwd.ShadowDecoration.Parent = this.tbLoginPwd;
            this.tbLoginPwd.Size = new System.Drawing.Size(200, 36);
            this.tbLoginPwd.TabIndex = 3;
            // 
            // tbCheckPwd
            // 
            this.tbCheckPwd.BorderRadius = 6;
            this.tbCheckPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCheckPwd.DefaultText = "";
            this.tbCheckPwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCheckPwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCheckPwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCheckPwd.DisabledState.Parent = this.tbCheckPwd;
            this.tbCheckPwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCheckPwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCheckPwd.FocusedState.Parent = this.tbCheckPwd;
            this.tbCheckPwd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbCheckPwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCheckPwd.HoverState.Parent = this.tbCheckPwd;
            this.tbCheckPwd.Location = new System.Drawing.Point(89, 275);
            this.tbCheckPwd.Name = "tbCheckPwd";
            this.tbCheckPwd.PasswordChar = '\0';
            this.tbCheckPwd.PlaceholderText = "确认密码";
            this.tbCheckPwd.SelectedText = "";
            this.tbCheckPwd.ShadowDecoration.Parent = this.tbCheckPwd;
            this.tbCheckPwd.Size = new System.Drawing.Size(200, 36);
            this.tbCheckPwd.TabIndex = 4;
            // 
            // tbSave
            // 
            this.tbSave.Animated = true;
            this.tbSave.AnimatedGIF = true;
            this.tbSave.BorderRadius = 8;
            this.tbSave.CheckedState.Parent = this.tbSave;
            this.tbSave.CustomImages.Parent = this.tbSave;
            this.tbSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tbSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tbSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tbSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tbSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tbSave.DisabledState.Parent = this.tbSave;
            this.tbSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.tbSave.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(130)))));
            this.tbSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSave.ForeColor = System.Drawing.Color.White;
            this.tbSave.HoverState.Parent = this.tbSave;
            this.tbSave.Location = new System.Drawing.Point(89, 334);
            this.tbSave.Name = "tbSave";
            this.tbSave.ShadowDecoration.Parent = this.tbSave;
            this.tbSave.Size = new System.Drawing.Size(200, 45);
            this.tbSave.TabIndex = 5;
            this.tbSave.Text = "保存";
            this.tbSave.Click += new System.EventHandler(this.tbSave_Click);
            // 
            // FrmSaveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 450);
            this.Controls.Add(this.tbSave);
            this.Controls.Add(this.tbCheckPwd);
            this.Controls.Add(this.tbLoginPwd);
            this.Controls.Add(this.tbLoginID);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSaveUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddUser";
            this.Load += new System.EventHandler(this.FrmSaveUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox tbUserName;
        private Guna.UI2.WinForms.Guna2TextBox tbAge;
        private Guna.UI2.WinForms.Guna2TextBox tbLoginID;
        private Guna.UI2.WinForms.Guna2TextBox tbLoginPwd;
        private Guna.UI2.WinForms.Guna2TextBox tbCheckPwd;
        private Guna.UI2.WinForms.Guna2GradientButton tbSave;
    }
}