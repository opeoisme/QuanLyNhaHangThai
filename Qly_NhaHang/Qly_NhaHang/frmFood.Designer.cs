﻿namespace Qly_NhaHang
{
    partial class frmFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFood));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddFood = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteFood = new System.Windows.Forms.ToolStripButton();
            this.btnReloadFood = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateFood = new System.Windows.Forms.ToolStripButton();
            this.btnLoadFood = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nmrPriceFood = new System.Windows.Forms.NumericUpDown();
            this.txbNameFood = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txbIdFood = new Bunifu.UI.WinForms.BunifuTextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gctFood = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idFood = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameFood = new DevExpress.XtraGrid.Columns.GridColumn();
            this.priceFood = new DevExpress.XtraGrid.Columns.GridColumn();
            this.categoryFood = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imgFood = new DevExpress.XtraGrid.Columns.GridColumn();
            this.conditionFood = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPriceFood)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddFood,
            this.btnDeleteFood,
            this.btnReloadFood,
            this.btnUpdateFood,
            this.btnLoadFood});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1944, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddFood
            // 
            this.btnAddFood.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Image = global::Qly_NhaHang.Properties.Resources._299068_add_sign_icon;
            this.btnAddFood.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(88, 29);
            this.btnAddFood.Text = "Thêm";
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Image = global::Qly_NhaHang.Properties.Resources._9004715_cross_delete_remove_cancel_icon;
            this.btnDeleteFood.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(71, 29);
            this.btnDeleteFood.Text = "Xóa";
            // 
            // btnReloadFood
            // 
            this.btnReloadFood.Image = global::Qly_NhaHang.Properties.Resources._5173025_clock_date_internet_refresh_reload_icon;
            this.btnReloadFood.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReloadFood.Name = "btnReloadFood";
            this.btnReloadFood.Size = new System.Drawing.Size(119, 29);
            this.btnReloadFood.Text = "Khôi phục";
            // 
            // btnUpdateFood
            // 
            this.btnUpdateFood.Image = global::Qly_NhaHang.Properties.Resources._8725849_file_upload_icon;
            this.btnUpdateFood.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateFood.Name = "btnUpdateFood";
            this.btnUpdateFood.Size = new System.Drawing.Size(70, 29);
            this.btnUpdateFood.Text = "Sửa";
            // 
            // btnLoadFood
            // 
            this.btnLoadFood.Image = global::Qly_NhaHang.Properties.Resources._100035_restore_system_icon;
            this.btnLoadFood.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadFood.Name = "btnLoadFood";
            this.btnLoadFood.Size = new System.Drawing.Size(76, 29);
            this.btnLoadFood.Text = "Xem";
            this.btnLoadFood.Click += new System.EventHandler(this.btnLoadFood_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.nmrPriceFood);
            this.panel1.Controls.Add(this.txbNameFood);
            this.panel1.Controls.Add(this.txbIdFood);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 659);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1944, 285);
            this.panel1.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 40;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(249, 203);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(289, 243);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(1510, 19);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(289, 243);
            this.bunifuImageButton1.TabIndex = 18;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 40;
            this.bunifuImageButton1.ZoomSpeed = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Được sử dụng",
            "Ngưng bán"});
            this.comboBox2.Location = new System.Drawing.Point(869, 116);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(370, 27);
            this.comboBox2.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(869, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(370, 27);
            this.comboBox1.TabIndex = 16;
            // 
            // nmrPriceFood
            // 
            this.nmrPriceFood.Location = new System.Drawing.Point(158, 190);
            this.nmrPriceFood.Name = "nmrPriceFood";
            this.nmrPriceFood.Size = new System.Drawing.Size(172, 27);
            this.nmrPriceFood.TabIndex = 15;
            // 
            // txbNameFood
            // 
            this.txbNameFood.AcceptsReturn = false;
            this.txbNameFood.AcceptsTab = false;
            this.txbNameFood.AnimationSpeed = 200;
            this.txbNameFood.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbNameFood.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbNameFood.BackColor = System.Drawing.Color.Transparent;
            this.txbNameFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbNameFood.BackgroundImage")));
            this.txbNameFood.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbNameFood.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbNameFood.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbNameFood.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbNameFood.BorderRadius = 10;
            this.txbNameFood.BorderThickness = 1;
            this.txbNameFood.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbNameFood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameFood.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbNameFood.DefaultText = "";
            this.txbNameFood.FillColor = System.Drawing.Color.White;
            this.txbNameFood.HideSelection = true;
            this.txbNameFood.IconLeft = null;
            this.txbNameFood.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameFood.IconPadding = 10;
            this.txbNameFood.IconRight = null;
            this.txbNameFood.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameFood.Lines = new string[0];
            this.txbNameFood.Location = new System.Drawing.Point(156, 112);
            this.txbNameFood.MaxLength = 32767;
            this.txbNameFood.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbNameFood.Modified = false;
            this.txbNameFood.Multiline = false;
            this.txbNameFood.Name = "txbNameFood";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameFood.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbNameFood.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameFood.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameFood.OnIdleState = stateProperties12;
            this.txbNameFood.Padding = new System.Windows.Forms.Padding(3);
            this.txbNameFood.PasswordChar = '\0';
            this.txbNameFood.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbNameFood.PlaceholderText = "Tên sản phẩm...";
            this.txbNameFood.ReadOnly = false;
            this.txbNameFood.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbNameFood.SelectedText = "";
            this.txbNameFood.SelectionLength = 0;
            this.txbNameFood.SelectionStart = 0;
            this.txbNameFood.ShortcutsEnabled = true;
            this.txbNameFood.Size = new System.Drawing.Size(516, 45);
            this.txbNameFood.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbNameFood.TabIndex = 14;
            this.txbNameFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbNameFood.TextMarginBottom = 0;
            this.txbNameFood.TextMarginLeft = 3;
            this.txbNameFood.TextMarginTop = 0;
            this.txbNameFood.TextPlaceholder = "Tên sản phẩm...";
            this.txbNameFood.UseSystemPasswordChar = false;
            this.txbNameFood.WordWrap = true;
            // 
            // txbIdFood
            // 
            this.txbIdFood.AcceptsReturn = false;
            this.txbIdFood.AcceptsTab = false;
            this.txbIdFood.AnimationSpeed = 200;
            this.txbIdFood.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbIdFood.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbIdFood.BackColor = System.Drawing.Color.Transparent;
            this.txbIdFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbIdFood.BackgroundImage")));
            this.txbIdFood.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbIdFood.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbIdFood.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbIdFood.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbIdFood.BorderRadius = 10;
            this.txbIdFood.BorderThickness = 1;
            this.txbIdFood.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbIdFood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdFood.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbIdFood.DefaultText = "";
            this.txbIdFood.FillColor = System.Drawing.Color.White;
            this.txbIdFood.HideSelection = true;
            this.txbIdFood.IconLeft = null;
            this.txbIdFood.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdFood.IconPadding = 10;
            this.txbIdFood.IconRight = null;
            this.txbIdFood.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdFood.Lines = new string[0];
            this.txbIdFood.Location = new System.Drawing.Point(158, 40);
            this.txbIdFood.MaxLength = 32767;
            this.txbIdFood.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbIdFood.Modified = false;
            this.txbIdFood.Multiline = false;
            this.txbIdFood.Name = "txbIdFood";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdFood.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbIdFood.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdFood.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdFood.OnIdleState = stateProperties16;
            this.txbIdFood.Padding = new System.Windows.Forms.Padding(3);
            this.txbIdFood.PasswordChar = '\0';
            this.txbIdFood.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbIdFood.PlaceholderText = "Mã sản phẩm...";
            this.txbIdFood.ReadOnly = false;
            this.txbIdFood.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbIdFood.SelectedText = "";
            this.txbIdFood.SelectionLength = 0;
            this.txbIdFood.SelectionStart = 0;
            this.txbIdFood.ShortcutsEnabled = true;
            this.txbIdFood.Size = new System.Drawing.Size(516, 45);
            this.txbIdFood.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbIdFood.TabIndex = 13;
            this.txbIdFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbIdFood.TextMarginBottom = 0;
            this.txbIdFood.TextMarginLeft = 3;
            this.txbIdFood.TextMarginTop = 0;
            this.txbIdFood.TextPlaceholder = "Mã sản phẩm...";
            this.txbIdFood.UseSystemPasswordChar = false;
            this.txbIdFood.WordWrap = true;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(1387, 46);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(117, 26);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Ảnh minh họa";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(727, 117);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(86, 26);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Tình trạng";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(727, 46);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(119, 26);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Loại sản phẩm";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(33, 186);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 26);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Giá ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(33, 122);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 26);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Tên món ăn";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(33, 51);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 26);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Mã món ăn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gctFood);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1944, 625);
            this.panel2.TabIndex = 2;
            // 
            // gctFood
            // 
            this.gctFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctFood.Location = new System.Drawing.Point(0, 0);
            this.gctFood.MainView = this.gridView1;
            this.gctFood.Name = "gctFood";
            this.gctFood.Size = new System.Drawing.Size(1944, 625);
            this.gctFood.TabIndex = 0;
            this.gctFood.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idFood,
            this.nameFood,
            this.priceFood,
            this.categoryFood,
            this.imgFood,
            this.conditionFood});
            this.gridView1.GridControl = this.gctFood;
            this.gridView1.Name = "gridView1";
            // 
            // idFood
            // 
            this.idFood.Caption = "Mã món ăn";
            this.idFood.FieldName = "id_Food";
            this.idFood.MinWidth = 30;
            this.idFood.Name = "idFood";
            this.idFood.Visible = true;
            this.idFood.VisibleIndex = 0;
            this.idFood.Width = 112;
            // 
            // nameFood
            // 
            this.nameFood.Caption = "Tên món ăn";
            this.nameFood.FieldName = "name_Food";
            this.nameFood.MinWidth = 30;
            this.nameFood.Name = "nameFood";
            this.nameFood.Visible = true;
            this.nameFood.VisibleIndex = 1;
            this.nameFood.Width = 112;
            // 
            // priceFood
            // 
            this.priceFood.Caption = "Giá món (vnđ)";
            this.priceFood.FieldName = "price_Food";
            this.priceFood.MinWidth = 30;
            this.priceFood.Name = "priceFood";
            this.priceFood.Visible = true;
            this.priceFood.VisibleIndex = 2;
            this.priceFood.Width = 112;
            // 
            // categoryFood
            // 
            this.categoryFood.Caption = "Loại món ăn";
            this.categoryFood.FieldName = "id_Category";
            this.categoryFood.MinWidth = 30;
            this.categoryFood.Name = "categoryFood";
            this.categoryFood.Visible = true;
            this.categoryFood.VisibleIndex = 5;
            this.categoryFood.Width = 112;
            // 
            // imgFood
            // 
            this.imgFood.Caption = "Ảnh minh họa";
            this.imgFood.FieldName = "image_Food";
            this.imgFood.MinWidth = 30;
            this.imgFood.Name = "imgFood";
            this.imgFood.Visible = true;
            this.imgFood.VisibleIndex = 3;
            this.imgFood.Width = 112;
            // 
            // conditionFood
            // 
            this.conditionFood.Caption = "Tình trạng";
            this.conditionFood.FieldName = "condition_Food";
            this.conditionFood.MinWidth = 30;
            this.conditionFood.Name = "conditionFood";
            this.conditionFood.Visible = true;
            this.conditionFood.VisibleIndex = 4;
            this.conditionFood.Width = 112;
            // 
            // frmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 944);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmFood";
            this.Text = "Danh sách món ăn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFood_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPriceFood)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddFood;
        private System.Windows.Forms.ToolStripButton btnDeleteFood;
        private System.Windows.Forms.ToolStripButton btnReloadFood;
        private System.Windows.Forms.ToolStripButton btnUpdateFood;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton btnLoadFood;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gctFood;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn idFood;
        private DevExpress.XtraGrid.Columns.GridColumn nameFood;
        private DevExpress.XtraGrid.Columns.GridColumn priceFood;
        private DevExpress.XtraGrid.Columns.GridColumn imgFood;
        private DevExpress.XtraGrid.Columns.GridColumn conditionFood;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Bunifu.UI.WinForms.BunifuTextBox txbIdFood;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown nmrPriceFood;
        private Bunifu.UI.WinForms.BunifuTextBox txbNameFood;
        private DevExpress.XtraGrid.Columns.GridColumn categoryFood;
    }
}