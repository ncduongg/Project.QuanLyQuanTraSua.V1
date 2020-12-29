namespace Project.QuanLyQuanTraSua.v1
{
    partial class frmDL_EditFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDL_EditFood));
            this.txt_Notes = new System.Windows.Forms.RichTextBox();
            this.btn_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.btn_url = new Guna.UI2.WinForms.Guna2Button();
            this.images_box = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gunaLabel18 = new Guna.UI.WinForms.GunaLabel();
            this.cb_Category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nb_quantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txt_priceM = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_nameM = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.ckB_phanloai = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.images_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(291, 393);
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(191, 145);
            this.txt_Notes.TabIndex = 56;
            this.txt_Notes.Text = "Reviews";
            // 
            // btn_Exit
            // 
            this.btn_Exit.CheckedState.Parent = this.btn_Exit;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.CustomImages.Parent = this.btn_Exit;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.HoverState.Parent = this.btn_Exit;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(313, 606);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.ShadowDecoration.Parent = this.btn_Exit;
            this.btn_Exit.Size = new System.Drawing.Size(169, 43);
            this.btn_Exit.TabIndex = 55;
            this.btn_Exit.Text = "Hủy";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.CheckedState.Parent = this.btn_Save;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.CustomImages.Parent = this.btn_Save;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.HoverState.Parent = this.btn_Save;
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.Location = new System.Drawing.Point(138, 606);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.ShadowDecoration.Parent = this.btn_Save;
            this.btn_Save.Size = new System.Drawing.Size(169, 43);
            this.btn_Save.TabIndex = 54;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_url
            // 
            this.btn_url.CheckedState.Parent = this.btn_url;
            this.btn_url.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_url.CustomImages.Parent = this.btn_url;
            this.btn_url.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_url.ForeColor = System.Drawing.Color.White;
            this.btn_url.HoverState.Parent = this.btn_url;
            this.btn_url.Image = ((System.Drawing.Image)(resources.GetObject("btn_url.Image")));
            this.btn_url.ImageSize = new System.Drawing.Size(22, 22);
            this.btn_url.Location = new System.Drawing.Point(77, 548);
            this.btn_url.Name = "btn_url";
            this.btn_url.ShadowDecoration.Parent = this.btn_url;
            this.btn_url.Size = new System.Drawing.Size(208, 27);
            this.btn_url.TabIndex = 53;
            this.btn_url.Text = "File Images...";
            this.btn_url.Click += new System.EventHandler(this.btn_url_Click);
            // 
            // images_box
            // 
            this.images_box.Image = ((System.Drawing.Image)(resources.GetObject("images_box.Image")));
            this.images_box.InitialImage = ((System.Drawing.Image)(resources.GetObject("images_box.InitialImage")));
            this.images_box.Location = new System.Drawing.Point(77, 393);
            this.images_box.Name = "images_box";
            this.images_box.ShadowDecoration.Parent = this.images_box;
            this.images_box.Size = new System.Drawing.Size(208, 149);
            this.images_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.images_box.TabIndex = 52;
            this.images_box.TabStop = false;
            // 
            // gunaLabel18
            // 
            this.gunaLabel18.AutoSize = true;
            this.gunaLabel18.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel18.Location = new System.Drawing.Point(215, 40);
            this.gunaLabel18.Name = "gunaLabel18";
            this.gunaLabel18.Size = new System.Drawing.Size(148, 36);
            this.gunaLabel18.TabIndex = 51;
            this.gunaLabel18.Text = "Edit Food";
            // 
            // cb_Category
            // 
            this.cb_Category.BackColor = System.Drawing.Color.Transparent;
            this.cb_Category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Category.FocusedColor = System.Drawing.Color.Empty;
            this.cb_Category.FocusedState.Parent = this.cb_Category;
            this.cb_Category.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_Category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.HoverState.Parent = this.cb_Category;
            this.cb_Category.ItemHeight = 30;
            this.cb_Category.ItemsAppearance.Parent = this.cb_Category;
            this.cb_Category.Location = new System.Drawing.Point(77, 322);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.ShadowDecoration.Parent = this.cb_Category;
            this.cb_Category.Size = new System.Drawing.Size(208, 36);
            this.cb_Category.TabIndex = 50;
            // 
            // nb_quantity
            // 
            this.nb_quantity.BackColor = System.Drawing.Color.Transparent;
            this.nb_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nb_quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nb_quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nb_quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nb_quantity.DisabledState.Parent = this.nb_quantity;
            this.nb_quantity.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nb_quantity.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nb_quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nb_quantity.FocusedState.Parent = this.nb_quantity;
            this.nb_quantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nb_quantity.Location = new System.Drawing.Point(291, 322);
            this.nb_quantity.Name = "nb_quantity";
            this.nb_quantity.ShadowDecoration.Parent = this.nb_quantity;
            this.nb_quantity.Size = new System.Drawing.Size(191, 36);
            this.nb_quantity.TabIndex = 49;
            // 
            // txt_priceM
            // 
            this.txt_priceM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_priceM.DefaultText = "";
            this.txt_priceM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_priceM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_priceM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_priceM.DisabledState.Parent = this.txt_priceM;
            this.txt_priceM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_priceM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_priceM.FocusedState.Parent = this.txt_priceM;
            this.txt_priceM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_priceM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_priceM.HoverState.Parent = this.txt_priceM;
            this.txt_priceM.Location = new System.Drawing.Point(78, 246);
            this.txt_priceM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_priceM.Name = "txt_priceM";
            this.txt_priceM.PasswordChar = '\0';
            this.txt_priceM.PlaceholderText = "";
            this.txt_priceM.SelectedText = "";
            this.txt_priceM.ShadowDecoration.Parent = this.txt_priceM;
            this.txt_priceM.Size = new System.Drawing.Size(405, 36);
            this.txt_priceM.TabIndex = 48;
            // 
            // txt_nameM
            // 
            this.txt_nameM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nameM.DefaultText = "";
            this.txt_nameM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nameM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nameM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nameM.DisabledState.Parent = this.txt_nameM;
            this.txt_nameM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nameM.Enabled = false;
            this.txt_nameM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nameM.FocusedState.Parent = this.txt_nameM;
            this.txt_nameM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nameM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nameM.HoverState.Parent = this.txt_nameM;
            this.txt_nameM.Location = new System.Drawing.Point(78, 173);
            this.txt_nameM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nameM.Name = "txt_nameM";
            this.txt_nameM.PasswordChar = '\0';
            this.txt_nameM.PlaceholderText = "";
            this.txt_nameM.SelectedText = "";
            this.txt_nameM.ShadowDecoration.Parent = this.txt_nameM;
            this.txt_nameM.Size = new System.Drawing.Size(405, 36);
            this.txt_nameM.TabIndex = 47;
            // 
            // txt_id
            // 
            this.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.DefaultText = "ID sẽ tự động được nhập";
            this.txt_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.DisabledState.Parent = this.txt_id;
            this.txt_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.Enabled = false;
            this.txt_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.FocusedState.Parent = this.txt_id;
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.HoverState.Parent = this.txt_id;
            this.txt_id.Location = new System.Drawing.Point(78, 105);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.PlaceholderText = "";
            this.txt_id.SelectedText = "";
            this.txt_id.SelectionStart = 23;
            this.txt_id.ShadowDecoration.Parent = this.txt_id;
            this.txt_id.Size = new System.Drawing.Size(405, 36);
            this.txt_id.TabIndex = 46;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(281, 299);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(68, 20);
            this.gunaLabel5.TabIndex = 60;
            this.gunaLabel5.Text = "Số lượng";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(74, 299);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(85, 20);
            this.gunaLabel4.TabIndex = 59;
            this.gunaLabel4.Text = "Danh Mục";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(74, 224);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(35, 20);
            this.gunaLabel3.TabIndex = 58;
            this.gunaLabel3.Text = "Giá";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(74, 151);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(74, 20);
            this.gunaLabel2.TabIndex = 57;
            this.gunaLabel2.Text = "Tên Food";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(74, 83);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel1.TabIndex = 61;
            this.gunaLabel1.Text = "ID";
            // 
            // ckB_phanloai
            // 
            this.ckB_phanloai.AutoSize = true;
            this.ckB_phanloai.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckB_phanloai.CheckedState.BorderRadius = 2;
            this.ckB_phanloai.CheckedState.BorderThickness = 0;
            this.ckB_phanloai.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckB_phanloai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckB_phanloai.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckB_phanloai.Location = new System.Drawing.Point(78, 366);
            this.ckB_phanloai.Name = "ckB_phanloai";
            this.ckB_phanloai.Size = new System.Drawing.Size(82, 21);
            this.ckB_phanloai.TabIndex = 62;
            this.ckB_phanloai.Text = "Đồ Uống";
            this.ckB_phanloai.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckB_phanloai.UncheckedState.BorderRadius = 2;
            this.ckB_phanloai.UncheckedState.BorderThickness = 0;
            this.ckB_phanloai.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckB_phanloai.UseVisualStyleBackColor = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(503, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 63;
            // 
            // frmDL_EditFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 688);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.ckB_phanloai);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.txt_Notes);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_url);
            this.Controls.Add(this.images_box);
            this.Controls.Add(this.gunaLabel18);
            this.Controls.Add(this.cb_Category);
            this.Controls.Add(this.nb_quantity);
            this.Controls.Add(this.txt_priceM);
            this.Controls.Add(this.txt_nameM);
            this.Controls.Add(this.txt_id);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDL_EditFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDL_EditFood";
            this.Load += new System.EventHandler(this.frmDL_EditFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.images_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_Notes;
        private Guna.UI2.WinForms.Guna2Button btn_Exit;
        private Guna.UI2.WinForms.Guna2Button btn_Save;
        private Guna.UI2.WinForms.Guna2Button btn_url;
        private Guna.UI2.WinForms.Guna2PictureBox images_box;
        private Guna.UI.WinForms.GunaLabel gunaLabel18;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Category;
        private Guna.UI2.WinForms.Guna2NumericUpDown nb_quantity;
        private Guna.UI2.WinForms.Guna2TextBox txt_priceM;
        private Guna.UI2.WinForms.Guna2TextBox txt_nameM;
        private Guna.UI2.WinForms.Guna2TextBox txt_id;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2CheckBox ckB_phanloai;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}