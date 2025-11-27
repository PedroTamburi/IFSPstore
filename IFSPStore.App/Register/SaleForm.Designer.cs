namespace IFSPStore.App.Register
{
    partial class SaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleForm));
            mtbId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            grbProducts = new GroupBox();
            lblValue = new ReaLTaiizor.Controls.MaterialLabel();
            lblQtdItens = new ReaLTaiizor.Controls.MaterialLabel();
            btnAdd = new ReaLTaiizor.Controls.MaterialButton();
            mtbTotalValue = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            mtbQuantity = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            mtbUnitaryValue = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            mcbProduct = new ReaLTaiizor.Controls.MaterialComboBox();
            dataGridViewItens = new DataGridView();
            mcbCustomer = new ReaLTaiizor.Controls.MaterialComboBox();
            mcbSalesman = new ReaLTaiizor.Controls.MaterialComboBox();
            mtbSaleDate = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tabPageRegister.SuspendLayout();
            tabControlRegister.SuspendLayout();
            tabPageList.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            grbProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItens).BeginInit();
            SuspendLayout();
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(mtbSaleDate);
            tabPageRegister.Controls.Add(mcbSalesman);
            tabPageRegister.Controls.Add(mcbCustomer);
            tabPageRegister.Controls.Add(grbProducts);
            tabPageRegister.Controls.Add(mtbId);
            tabPageRegister.Margin = new Padding(3, 5, 3, 5);
            tabPageRegister.Padding = new Padding(3, 5, 3, 5);
            tabPageRegister.Size = new Size(728, 578);
            tabPageRegister.Controls.SetChildIndex(panel1, 0);
            tabPageRegister.Controls.SetChildIndex(mtbId, 0);
            tabPageRegister.Controls.SetChildIndex(grbProducts, 0);
            tabPageRegister.Controls.SetChildIndex(mcbCustomer, 0);
            tabPageRegister.Controls.SetChildIndex(mcbSalesman, 0);
            tabPageRegister.Controls.SetChildIndex(mtbSaleDate, 0);
            // 
            // btnSave
            // 
            btnSave.Location = new Point(635, 18);
            btnSave.Margin = new Padding(5, 8, 5, 8);
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(550, 18);
            btnCancel.Margin = new Padding(5, 8, 5, 8);
            // 
            // btnNew
            // 
            btnNew.Location = new Point(428, 24);
            btnNew.Margin = new Padding(5, 8, 5, 8);
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(423, 24);
            btnDelete.Margin = new Padding(5, 8, 5, 8);
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(515, 24);
            btnEdit.Margin = new Padding(5, 8, 5, 8);
            // 
            // tabControlRegister
            // 
            tabControlRegister.Location = new Point(3, 113);
            tabControlRegister.Margin = new Padding(3, 5, 3, 5);
            tabControlRegister.Size = new Size(736, 613);
            // 
            // tabPageList
            // 
            tabPageList.Margin = new Padding(3, 4, 3, 4);
            tabPageList.Padding = new Padding(3, 4, 3, 4);
            // 
            // imageListRegister
            // 
            imageListRegister.ImageStream = (ImageListStreamer)resources.GetObject("imageListRegister.ImageStream");
            imageListRegister.Images.SetKeyName(0, "form.png");
            imageListRegister.Images.SetKeyName(1, "search.png");
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 312);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Size = new Size(583, 73);
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 500);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Size = new Size(722, 73);
            // 
            // mtbId
            // 
            mtbId.AnimateReadOnly = false;
            mtbId.AutoCompleteMode = AutoCompleteMode.None;
            mtbId.AutoCompleteSource = AutoCompleteSource.None;
            mtbId.BackgroundImageLayout = ImageLayout.None;
            mtbId.CharacterCasing = CharacterCasing.Normal;
            mtbId.Depth = 0;
            mtbId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbId.HideSelection = true;
            mtbId.Hint = "Id";
            mtbId.LeadingIcon = null;
            mtbId.Location = new Point(576, 8);
            mtbId.Margin = new Padding(3, 4, 3, 4);
            mtbId.MaxLength = 32767;
            mtbId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbId.Name = "mtbId";
            mtbId.PasswordChar = '\0';
            mtbId.PrefixSuffixText = null;
            mtbId.ReadOnly = true;
            mtbId.RightToLeft = RightToLeft.No;
            mtbId.SelectedText = "";
            mtbId.SelectionLength = 0;
            mtbId.SelectionStart = 0;
            mtbId.ShortcutsEnabled = true;
            mtbId.Size = new Size(122, 48);
            mtbId.TabIndex = 2;
            mtbId.TabStop = false;
            mtbId.TextAlign = HorizontalAlignment.Left;
            mtbId.TrailingIcon = null;
            mtbId.UseSystemPasswordChar = false;
            // 
            // grbProducts
            // 
            grbProducts.Controls.Add(lblValue);
            grbProducts.Controls.Add(lblQtdItens);
            grbProducts.Controls.Add(btnAdd);
            grbProducts.Controls.Add(mtbTotalValue);
            grbProducts.Controls.Add(mtbQuantity);
            grbProducts.Controls.Add(mtbUnitaryValue);
            grbProducts.Controls.Add(mcbProduct);
            grbProducts.Controls.Add(dataGridViewItens);
            grbProducts.Location = new Point(7, 155);
            grbProducts.Margin = new Padding(3, 4, 3, 4);
            grbProducts.Name = "grbProducts";
            grbProducts.Padding = new Padding(3, 4, 3, 4);
            grbProducts.Size = new Size(695, 335);
            grbProducts.TabIndex = 4;
            grbProducts.TabStop = false;
            grbProducts.Text = "Sale Products";
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Depth = 0;
            lblValue.FlatStyle = FlatStyle.Flat;
            lblValue.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblValue.Location = new Point(507, 305);
            lblValue.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(99, 19);
            lblValue.TabIndex = 8;
            lblValue.Text = "Total Value: 0";
            // 
            // lblQtdItens
            // 
            lblQtdItens.AutoSize = true;
            lblQtdItens.Depth = 0;
            lblQtdItens.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblQtdItens.Location = new Point(6, 301);
            lblQtdItens.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblQtdItens.Name = "lblQtdItens";
            lblQtdItens.Size = new Size(137, 19);
            lblQtdItens.TabIndex = 7;
            lblQtdItens.Text = "Product Quantity: 0";
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAdd.Location = new Point(614, 33);
            btnAdd.Margin = new Padding(5, 8, 5, 8);
            btnAdd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(64, 36);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdicionar_Click;
            // 
            // mtbTotalValue
            // 
            mtbTotalValue.AnimateReadOnly = false;
            mtbTotalValue.AutoCompleteMode = AutoCompleteMode.None;
            mtbTotalValue.AutoCompleteSource = AutoCompleteSource.None;
            mtbTotalValue.BackgroundImageLayout = ImageLayout.None;
            mtbTotalValue.CharacterCasing = CharacterCasing.Normal;
            mtbTotalValue.Depth = 0;
            mtbTotalValue.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbTotalValue.HideSelection = true;
            mtbTotalValue.Hint = "Total Value";
            mtbTotalValue.LeadingIcon = null;
            mtbTotalValue.Location = new Point(465, 29);
            mtbTotalValue.Margin = new Padding(3, 4, 3, 4);
            mtbTotalValue.MaxLength = 32767;
            mtbTotalValue.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbTotalValue.Name = "mtbTotalValue";
            mtbTotalValue.PasswordChar = '\0';
            mtbTotalValue.PrefixSuffixText = null;
            mtbTotalValue.ReadOnly = true;
            mtbTotalValue.RightToLeft = RightToLeft.No;
            mtbTotalValue.SelectedText = "";
            mtbTotalValue.SelectionLength = 0;
            mtbTotalValue.SelectionStart = 0;
            mtbTotalValue.ShortcutsEnabled = true;
            mtbTotalValue.Size = new Size(130, 48);
            mtbTotalValue.TabIndex = 3;
            mtbTotalValue.TabStop = false;
            mtbTotalValue.TextAlign = HorizontalAlignment.Left;
            mtbTotalValue.TrailingIcon = null;
            mtbTotalValue.UseSystemPasswordChar = false;
            // 
            // mtbQuantity
            // 
            mtbQuantity.AnimateReadOnly = false;
            mtbQuantity.AutoCompleteMode = AutoCompleteMode.None;
            mtbQuantity.AutoCompleteSource = AutoCompleteSource.None;
            mtbQuantity.BackgroundImageLayout = ImageLayout.None;
            mtbQuantity.CharacterCasing = CharacterCasing.Normal;
            mtbQuantity.Depth = 0;
            mtbQuantity.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbQuantity.HideSelection = true;
            mtbQuantity.Hint = "Quantity";
            mtbQuantity.LeadingIcon = null;
            mtbQuantity.Location = new Point(371, 29);
            mtbQuantity.Margin = new Padding(3, 4, 3, 4);
            mtbQuantity.MaxLength = 32767;
            mtbQuantity.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbQuantity.Name = "mtbQuantity";
            mtbQuantity.PasswordChar = '\0';
            mtbQuantity.PrefixSuffixText = null;
            mtbQuantity.ReadOnly = false;
            mtbQuantity.RightToLeft = RightToLeft.No;
            mtbQuantity.SelectedText = "";
            mtbQuantity.SelectionLength = 0;
            mtbQuantity.SelectionStart = 0;
            mtbQuantity.ShortcutsEnabled = true;
            mtbQuantity.Size = new Size(87, 48);
            mtbQuantity.TabIndex = 2;
            mtbQuantity.TabStop = false;
            mtbQuantity.TextAlign = HorizontalAlignment.Left;
            mtbQuantity.TrailingIcon = null;
            mtbQuantity.UseSystemPasswordChar = false;
            mtbQuantity.Leave += txtQuantidade_Leave;
            // 
            // mtbUnitaryValue
            // 
            mtbUnitaryValue.AnimateReadOnly = false;
            mtbUnitaryValue.AutoCompleteMode = AutoCompleteMode.None;
            mtbUnitaryValue.AutoCompleteSource = AutoCompleteSource.None;
            mtbUnitaryValue.BackgroundImageLayout = ImageLayout.None;
            mtbUnitaryValue.CharacterCasing = CharacterCasing.Normal;
            mtbUnitaryValue.Depth = 0;
            mtbUnitaryValue.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbUnitaryValue.HideSelection = true;
            mtbUnitaryValue.Hint = "Unit. Value";
            mtbUnitaryValue.LeadingIcon = null;
            mtbUnitaryValue.Location = new Point(262, 29);
            mtbUnitaryValue.Margin = new Padding(3, 4, 3, 4);
            mtbUnitaryValue.MaxLength = 32767;
            mtbUnitaryValue.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbUnitaryValue.Name = "mtbUnitaryValue";
            mtbUnitaryValue.PasswordChar = '\0';
            mtbUnitaryValue.PrefixSuffixText = null;
            mtbUnitaryValue.ReadOnly = false;
            mtbUnitaryValue.RightToLeft = RightToLeft.No;
            mtbUnitaryValue.SelectedText = "";
            mtbUnitaryValue.SelectionLength = 0;
            mtbUnitaryValue.SelectionStart = 0;
            mtbUnitaryValue.ShortcutsEnabled = true;
            mtbUnitaryValue.Size = new Size(103, 48);
            mtbUnitaryValue.TabIndex = 1;
            mtbUnitaryValue.TabStop = false;
            mtbUnitaryValue.TextAlign = HorizontalAlignment.Left;
            mtbUnitaryValue.TrailingIcon = null;
            mtbUnitaryValue.UseSystemPasswordChar = false;
            mtbUnitaryValue.Leave += txtVlUnitario_Leave;
            // 
            // mcbProduct
            // 
            mcbProduct.AutoResize = false;
            mcbProduct.BackColor = Color.FromArgb(255, 255, 255);
            mcbProduct.Depth = 0;
            mcbProduct.DrawMode = DrawMode.OwnerDrawVariable;
            mcbProduct.DropDownHeight = 174;
            mcbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            mcbProduct.DropDownWidth = 121;
            mcbProduct.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            mcbProduct.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcbProduct.FormattingEnabled = true;
            mcbProduct.Hint = "Product";
            mcbProduct.IntegralHeight = false;
            mcbProduct.ItemHeight = 43;
            mcbProduct.Location = new Point(3, 28);
            mcbProduct.Margin = new Padding(3, 4, 3, 4);
            mcbProduct.MaxDropDownItems = 4;
            mcbProduct.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mcbProduct.Name = "mcbProduct";
            mcbProduct.Size = new Size(251, 49);
            mcbProduct.StartIndex = 0;
            mcbProduct.TabIndex = 0;
            // 
            // dataGridViewItens
            // 
            dataGridViewItens.AllowUserToAddRows = false;
            dataGridViewItens.AllowUserToDeleteRows = false;
            dataGridViewItens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItens.Location = new Point(3, 101);
            dataGridViewItens.Margin = new Padding(3, 4, 3, 4);
            dataGridViewItens.MultiSelect = false;
            dataGridViewItens.Name = "dataGridViewItens";
            dataGridViewItens.ReadOnly = true;
            dataGridViewItens.RowHeadersWidth = 51;
            dataGridViewItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewItens.Size = new Size(689, 200);
            dataGridViewItens.TabIndex = 5;
            // 
            // mcbCustomer
            // 
            mcbCustomer.AutoResize = false;
            mcbCustomer.BackColor = Color.FromArgb(255, 255, 255);
            mcbCustomer.Depth = 0;
            mcbCustomer.DrawMode = DrawMode.OwnerDrawVariable;
            mcbCustomer.DropDownHeight = 174;
            mcbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            mcbCustomer.DropDownWidth = 121;
            mcbCustomer.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            mcbCustomer.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcbCustomer.FormattingEnabled = true;
            mcbCustomer.Hint = "Salesman";
            mcbCustomer.IntegralHeight = false;
            mcbCustomer.ItemHeight = 43;
            mcbCustomer.Location = new Point(10, 81);
            mcbCustomer.Margin = new Padding(3, 4, 3, 4);
            mcbCustomer.MaxDropDownItems = 4;
            mcbCustomer.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mcbCustomer.Name = "mcbCustomer";
            mcbCustomer.Size = new Size(687, 49);
            mcbCustomer.StartIndex = 0;
            mcbCustomer.TabIndex = 3;
            // 
            // mcbSalesman
            // 
            mcbSalesman.AutoResize = false;
            mcbSalesman.BackColor = Color.FromArgb(255, 255, 255);
            mcbSalesman.Depth = 0;
            mcbSalesman.DrawMode = DrawMode.OwnerDrawVariable;
            mcbSalesman.DropDownHeight = 174;
            mcbSalesman.DropDownStyle = ComboBoxStyle.DropDownList;
            mcbSalesman.DropDownWidth = 121;
            mcbSalesman.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            mcbSalesman.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcbSalesman.FormattingEnabled = true;
            mcbSalesman.Hint = "User/Salesman";
            mcbSalesman.IntegralHeight = false;
            mcbSalesman.ItemHeight = 43;
            mcbSalesman.Location = new Point(240, 7);
            mcbSalesman.Margin = new Padding(3, 4, 3, 4);
            mcbSalesman.MaxDropDownItems = 4;
            mcbSalesman.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mcbSalesman.Name = "mcbSalesman";
            mcbSalesman.Size = new Size(329, 49);
            mcbSalesman.StartIndex = 0;
            mcbSalesman.TabIndex = 1;
            // 
            // mtbSaleDate
            // 
            mtbSaleDate.AllowPromptAsInput = true;
            mtbSaleDate.AnimateReadOnly = false;
            mtbSaleDate.AsciiOnly = false;
            mtbSaleDate.BackgroundImageLayout = ImageLayout.None;
            mtbSaleDate.BeepOnError = false;
            mtbSaleDate.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            mtbSaleDate.Depth = 0;
            mtbSaleDate.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbSaleDate.HidePromptOnLeave = false;
            mtbSaleDate.HideSelection = true;
            mtbSaleDate.Hint = "Sale Date";
            mtbSaleDate.InsertKeyMode = InsertKeyMode.Default;
            mtbSaleDate.LeadingIcon = null;
            mtbSaleDate.Location = new Point(10, 9);
            mtbSaleDate.Margin = new Padding(3, 4, 3, 4);
            mtbSaleDate.Mask = "99/99/9999";
            mtbSaleDate.MaxLength = 32767;
            mtbSaleDate.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbSaleDate.Name = "mtbSaleDate";
            mtbSaleDate.PasswordChar = '\0';
            mtbSaleDate.PrefixSuffixText = null;
            mtbSaleDate.PromptChar = '_';
            mtbSaleDate.ReadOnly = false;
            mtbSaleDate.RejectInputOnFirstFailure = false;
            mtbSaleDate.ResetOnPrompt = true;
            mtbSaleDate.ResetOnSpace = true;
            mtbSaleDate.RightToLeft = RightToLeft.No;
            mtbSaleDate.SelectedText = "";
            mtbSaleDate.SelectionLength = 0;
            mtbSaleDate.SelectionStart = 0;
            mtbSaleDate.ShortcutsEnabled = true;
            mtbSaleDate.Size = new Size(223, 48);
            mtbSaleDate.SkipLiterals = true;
            mtbSaleDate.TabIndex = 0;
            mtbSaleDate.TabStop = false;
            mtbSaleDate.Text = "  /  /";
            mtbSaleDate.TextAlign = HorizontalAlignment.Center;
            mtbSaleDate.TextMaskFormat = MaskFormat.IncludeLiterals;
            mtbSaleDate.TrailingIcon = null;
            mtbSaleDate.UseSystemPasswordChar = false;
            mtbSaleDate.ValidatingType = null;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 731);
            Location = new Point(0, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "SaleForm";
            Padding = new Padding(3, 113, 3, 5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sale Register";
            tabPageRegister.ResumeLayout(false);
            tabControlRegister.ResumeLayout(false);
            tabPageList.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grbProducts.ResumeLayout(false);
            grbProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItens).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbId;
        private GroupBox grbProducts;
        private DataGridView dataGridViewItens;
        private ReaLTaiizor.Controls.MaterialComboBox mcbSalesman;
        private ReaLTaiizor.Controls.MaterialComboBox mcbCustomer;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mtbSaleDate;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbUnitaryValue;
        private ReaLTaiizor.Controls.MaterialComboBox mcbProduct;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbTotalValue;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbQuantity;
        private ReaLTaiizor.Controls.MaterialButton btnAdd;
        private ReaLTaiizor.Controls.MaterialLabel lblValue;
        private ReaLTaiizor.Controls.MaterialLabel lblQtdItens;
    }
}