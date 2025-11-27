namespace IFSPStore.App.Register
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            tbName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbLogin = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbPasswordVisible = new CheckBox();
            tabPageRegister.SuspendLayout();
            tabControlRegister.SuspendLayout();
            tabPageList.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(cbPasswordVisible);
            tabPageRegister.Controls.Add(tbPassword);
            tabPageRegister.Controls.Add(tbLogin);
            tabPageRegister.Controls.Add(tbEmail);
            tabPageRegister.Controls.Add(tbId);
            tabPageRegister.Controls.Add(tbName);
            tabPageRegister.Size = new Size(785, 412);
            tabPageRegister.Controls.SetChildIndex(panel1, 0);
            tabPageRegister.Controls.SetChildIndex(tbName, 0);
            tabPageRegister.Controls.SetChildIndex(tbId, 0);
            tabPageRegister.Controls.SetChildIndex(tbEmail, 0);
            tabPageRegister.Controls.SetChildIndex(tbLogin, 0);
            tabPageRegister.Controls.SetChildIndex(tbPassword, 0);
            tabPageRegister.Controls.SetChildIndex(cbPasswordVisible, 0);
            // 
            // btnSave
            // 
            btnSave.Location = new Point(695, 13);
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(610, 13);
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(793, 447);
            // 
            // tabPageList
            // 
            tabPageList.Size = new Size(785, 412);
            // 
            // imageListRegister
            // 
            imageListRegister.ImageStream = (ImageListStreamer)resources.GetObject("imageListRegister.ImageStream");
            imageListRegister.Images.SetKeyName(0, "form.png");
            imageListRegister.Images.SetKeyName(1, "search.png");
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 354);
            panel2.Size = new Size(779, 55);
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 354);
            panel1.Size = new Size(779, 55);
            // 
            // tbName
            // 
            tbName.AnimateReadOnly = false;
            tbName.AutoCompleteMode = AutoCompleteMode.None;
            tbName.AutoCompleteSource = AutoCompleteSource.None;
            tbName.BackgroundImageLayout = ImageLayout.None;
            tbName.CharacterCasing = CharacterCasing.Normal;
            tbName.Depth = 0;
            tbName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbName.HideSelection = true;
            tbName.Hint = "Name";
            tbName.LeadingIcon = null;
            tbName.Location = new Point(18, 23);
            tbName.MaxLength = 32767;
            tbName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbName.Name = "tbName";
            tbName.PasswordChar = '\0';
            tbName.PrefixSuffixText = null;
            tbName.ReadOnly = false;
            tbName.RightToLeft = RightToLeft.No;
            tbName.SelectedText = "";
            tbName.SelectionLength = 0;
            tbName.SelectionStart = 0;
            tbName.ShortcutsEnabled = true;
            tbName.Size = new Size(584, 48);
            tbName.TabIndex = 3;
            tbName.TabStop = false;
            tbName.TextAlign = HorizontalAlignment.Left;
            tbName.TrailingIcon = null;
            tbName.UseSystemPasswordChar = false;
            // 
            // tbId
            // 
            tbId.AnimateReadOnly = false;
            tbId.AutoCompleteMode = AutoCompleteMode.None;
            tbId.AutoCompleteSource = AutoCompleteSource.None;
            tbId.BackgroundImageLayout = ImageLayout.None;
            tbId.CharacterCasing = CharacterCasing.Normal;
            tbId.Depth = 0;
            tbId.Enabled = false;
            tbId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbId.HideSelection = true;
            tbId.Hint = "Id";
            tbId.LeadingIcon = null;
            tbId.Location = new Point(638, 22);
            tbId.MaxLength = 32767;
            tbId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbId.Name = "tbId";
            tbId.PasswordChar = '\0';
            tbId.PrefixSuffixText = null;
            tbId.ReadOnly = true;
            tbId.RightToLeft = RightToLeft.No;
            tbId.SelectedText = "";
            tbId.SelectionLength = 0;
            tbId.SelectionStart = 0;
            tbId.ShortcutsEnabled = true;
            tbId.Size = new Size(122, 48);
            tbId.TabIndex = 4;
            tbId.TabStop = false;
            tbId.TextAlign = HorizontalAlignment.Left;
            tbId.TrailingIcon = null;
            tbId.UseSystemPasswordChar = false;
            // 
            // tbEmail
            // 
            tbEmail.AnimateReadOnly = false;
            tbEmail.AutoCompleteMode = AutoCompleteMode.None;
            tbEmail.AutoCompleteSource = AutoCompleteSource.None;
            tbEmail.BackgroundImageLayout = ImageLayout.None;
            tbEmail.CharacterCasing = CharacterCasing.Normal;
            tbEmail.Depth = 0;
            tbEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbEmail.HideSelection = true;
            tbEmail.Hint = "Email";
            tbEmail.LeadingIcon = null;
            tbEmail.Location = new Point(18, 90);
            tbEmail.MaxLength = 32767;
            tbEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbEmail.Name = "tbEmail";
            tbEmail.PasswordChar = '\0';
            tbEmail.PrefixSuffixText = null;
            tbEmail.ReadOnly = false;
            tbEmail.RightToLeft = RightToLeft.No;
            tbEmail.SelectedText = "";
            tbEmail.SelectionLength = 0;
            tbEmail.SelectionStart = 0;
            tbEmail.ShortcutsEnabled = true;
            tbEmail.Size = new Size(742, 48);
            tbEmail.TabIndex = 5;
            tbEmail.TabStop = false;
            tbEmail.TextAlign = HorizontalAlignment.Left;
            tbEmail.TrailingIcon = null;
            tbEmail.UseSystemPasswordChar = false;
            // 
            // tbLogin
            // 
            tbLogin.AnimateReadOnly = false;
            tbLogin.AutoCompleteMode = AutoCompleteMode.None;
            tbLogin.AutoCompleteSource = AutoCompleteSource.None;
            tbLogin.BackgroundImageLayout = ImageLayout.None;
            tbLogin.CharacterCasing = CharacterCasing.Normal;
            tbLogin.Depth = 0;
            tbLogin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbLogin.HideSelection = true;
            tbLogin.Hint = "Login";
            tbLogin.LeadingIcon = null;
            tbLogin.Location = new Point(18, 157);
            tbLogin.MaxLength = 32767;
            tbLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbLogin.Name = "tbLogin";
            tbLogin.PasswordChar = '\0';
            tbLogin.PrefixSuffixText = null;
            tbLogin.ReadOnly = false;
            tbLogin.RightToLeft = RightToLeft.No;
            tbLogin.SelectedText = "";
            tbLogin.SelectionLength = 0;
            tbLogin.SelectionStart = 0;
            tbLogin.ShortcutsEnabled = true;
            tbLogin.Size = new Size(383, 48);
            tbLogin.TabIndex = 6;
            tbLogin.TabStop = false;
            tbLogin.TextAlign = HorizontalAlignment.Left;
            tbLogin.TrailingIcon = null;
            tbLogin.UseSystemPasswordChar = false;
            // 
            // tbPassword
            // 
            tbPassword.AnimateReadOnly = false;
            tbPassword.AutoCompleteMode = AutoCompleteMode.None;
            tbPassword.AutoCompleteSource = AutoCompleteSource.None;
            tbPassword.BackgroundImageLayout = ImageLayout.None;
            tbPassword.CharacterCasing = CharacterCasing.Normal;
            tbPassword.Depth = 0;
            tbPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbPassword.HideSelection = true;
            tbPassword.Hint = "Password";
            tbPassword.LeadingIcon = null;
            tbPassword.Location = new Point(423, 157);
            tbPassword.MaxLength = 32767;
            tbPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '●';
            tbPassword.PrefixSuffixText = null;
            tbPassword.ReadOnly = false;
            tbPassword.RightToLeft = RightToLeft.No;
            tbPassword.SelectedText = "";
            tbPassword.SelectionLength = 0;
            tbPassword.SelectionStart = 0;
            tbPassword.ShortcutsEnabled = true;
            tbPassword.Size = new Size(339, 48);
            tbPassword.TabIndex = 7;
            tbPassword.TabStop = false;
            tbPassword.TextAlign = HorizontalAlignment.Left;
            tbPassword.TrailingIcon = null;
            tbPassword.UseSystemPasswordChar = false;
            // 
            // cbPasswordVisible
            // 
            cbPasswordVisible.AutoSize = true;
            cbPasswordVisible.Location = new Point(622, 211);
            cbPasswordVisible.Name = "cbPasswordVisible";
            cbPasswordVisible.Size = new Size(140, 24);
            cbPasswordVisible.TabIndex = 8;
            cbPasswordVisible.Text = "password visible";
            cbPasswordVisible.UseVisualStyleBackColor = true;
            cbPasswordVisible.CheckedChanged += cbPasswordVisible_CheckedChanged;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 514);
            Location = new Point(0, 0);
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            tabPageRegister.ResumeLayout(false);
            tabPageRegister.PerformLayout();
            tabControlRegister.ResumeLayout(false);
            tabPageList.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbPassword;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbLogin;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbEmail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbName;
        private CheckBox cbPasswordVisible;
        private ReaLTaiizor.Controls.CheckBox checkBox1;
    }
}