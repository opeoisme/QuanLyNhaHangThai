namespace Qly_NhaHang
{
    partial class ListTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListTable));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTableGuest = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnTableEmpty = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnTableSet = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1944, 55);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh mục bàn";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::Qly_NhaHang.Properties.Resources.icons8_left_50;
            this.btnBack.Location = new System.Drawing.Point(3, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 47);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 1;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1944, 1004);
            this.panel2.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnTableGuest);
            this.flowLayoutPanel1.Controls.Add(this.btnTableEmpty);
            this.flowLayoutPanel1.Controls.Add(this.btnTableSet);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1944, 77);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnTableGuest
            // 
            this.btnTableGuest.AllowAnimations = true;
            this.btnTableGuest.AllowMouseEffects = true;
            this.btnTableGuest.AllowToggling = false;
            this.btnTableGuest.AnimationSpeed = 200;
            this.btnTableGuest.AutoGenerateColors = false;
            this.btnTableGuest.AutoRoundBorders = false;
            this.btnTableGuest.AutoSizeLeftIcon = true;
            this.btnTableGuest.AutoSizeRightIcon = true;
            this.btnTableGuest.BackColor = System.Drawing.Color.Transparent;
            this.btnTableGuest.BackColor1 = System.Drawing.Color.Teal;
            this.btnTableGuest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTableGuest.BackgroundImage")));
            this.btnTableGuest.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTableGuest.ButtonText = "Bàn có khách";
            this.btnTableGuest.ButtonTextMarginLeft = 0;
            this.btnTableGuest.ColorContrastOnClick = 45;
            this.btnTableGuest.ColorContrastOnHover = 45;
            this.btnTableGuest.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnTableGuest.CustomizableEdges = borderEdges4;
            this.btnTableGuest.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTableGuest.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTableGuest.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTableGuest.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTableGuest.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnTableGuest.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableGuest.ForeColor = System.Drawing.Color.White;
            this.btnTableGuest.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTableGuest.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnTableGuest.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnTableGuest.IconMarginLeft = 11;
            this.btnTableGuest.IconPadding = 10;
            this.btnTableGuest.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTableGuest.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnTableGuest.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnTableGuest.IconSize = 25;
            this.btnTableGuest.IdleBorderColor = System.Drawing.Color.Teal;
            this.btnTableGuest.IdleBorderRadius = 15;
            this.btnTableGuest.IdleBorderThickness = 1;
            this.btnTableGuest.IdleFillColor = System.Drawing.Color.Teal;
            this.btnTableGuest.IdleIconLeftImage = null;
            this.btnTableGuest.IdleIconRightImage = null;
            this.btnTableGuest.IndicateFocus = false;
            this.btnTableGuest.Location = new System.Drawing.Point(3, 3);
            this.btnTableGuest.Name = "btnTableGuest";
            this.btnTableGuest.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTableGuest.OnDisabledState.BorderRadius = 15;
            this.btnTableGuest.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTableGuest.OnDisabledState.BorderThickness = 1;
            this.btnTableGuest.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTableGuest.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTableGuest.OnDisabledState.IconLeftImage = null;
            this.btnTableGuest.OnDisabledState.IconRightImage = null;
            this.btnTableGuest.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnTableGuest.onHoverState.BorderRadius = 15;
            this.btnTableGuest.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTableGuest.onHoverState.BorderThickness = 1;
            this.btnTableGuest.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnTableGuest.onHoverState.ForeColor = System.Drawing.Color.Teal;
            this.btnTableGuest.onHoverState.IconLeftImage = null;
            this.btnTableGuest.onHoverState.IconRightImage = null;
            this.btnTableGuest.OnIdleState.BorderColor = System.Drawing.Color.Teal;
            this.btnTableGuest.OnIdleState.BorderRadius = 15;
            this.btnTableGuest.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTableGuest.OnIdleState.BorderThickness = 1;
            this.btnTableGuest.OnIdleState.FillColor = System.Drawing.Color.Teal;
            this.btnTableGuest.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnTableGuest.OnIdleState.IconLeftImage = null;
            this.btnTableGuest.OnIdleState.IconRightImage = null;
            this.btnTableGuest.OnPressedState.BorderColor = System.Drawing.Color.Teal;
            this.btnTableGuest.OnPressedState.BorderRadius = 15;
            this.btnTableGuest.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTableGuest.OnPressedState.BorderThickness = 1;
            this.btnTableGuest.OnPressedState.FillColor = System.Drawing.Color.Teal;
            this.btnTableGuest.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnTableGuest.OnPressedState.IconLeftImage = null;
            this.btnTableGuest.OnPressedState.IconRightImage = null;
            this.btnTableGuest.Size = new System.Drawing.Size(173, 67);
            this.btnTableGuest.TabIndex = 32;
            this.btnTableGuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTableGuest.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTableGuest.TextMarginLeft = 0;
            this.btnTableGuest.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnTableGuest.UseDefaultRadiusAndThickness = true;
            // 
            // btnTableEmpty
            // 
            this.btnTableEmpty.AllowAnimations = true;
            this.btnTableEmpty.AllowMouseEffects = true;
            this.btnTableEmpty.AllowToggling = false;
            this.btnTableEmpty.AnimationSpeed = 200;
            this.btnTableEmpty.AutoGenerateColors = false;
            this.btnTableEmpty.AutoRoundBorders = false;
            this.btnTableEmpty.AutoSizeLeftIcon = true;
            this.btnTableEmpty.AutoSizeRightIcon = true;
            this.btnTableEmpty.BackColor = System.Drawing.Color.Transparent;
            this.btnTableEmpty.BackColor1 = System.Drawing.Color.Teal;
            this.btnTableEmpty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTableEmpty.BackgroundImage")));
            this.btnTableEmpty.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTableEmpty.ButtonText = "Bàn trống";
            this.btnTableEmpty.ButtonTextMarginLeft = 0;
            this.btnTableEmpty.ColorContrastOnClick = 45;
            this.btnTableEmpty.ColorContrastOnHover = 45;
            this.btnTableEmpty.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnTableEmpty.CustomizableEdges = borderEdges5;
            this.btnTableEmpty.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTableEmpty.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTableEmpty.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTableEmpty.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTableEmpty.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnTableEmpty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableEmpty.ForeColor = System.Drawing.Color.White;
            this.btnTableEmpty.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTableEmpty.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnTableEmpty.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnTableEmpty.IconMarginLeft = 11;
            this.btnTableEmpty.IconPadding = 10;
            this.btnTableEmpty.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTableEmpty.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnTableEmpty.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnTableEmpty.IconSize = 25;
            this.btnTableEmpty.IdleBorderColor = System.Drawing.Color.Teal;
            this.btnTableEmpty.IdleBorderRadius = 15;
            this.btnTableEmpty.IdleBorderThickness = 1;
            this.btnTableEmpty.IdleFillColor = System.Drawing.Color.Teal;
            this.btnTableEmpty.IdleIconLeftImage = null;
            this.btnTableEmpty.IdleIconRightImage = null;
            this.btnTableEmpty.IndicateFocus = false;
            this.btnTableEmpty.Location = new System.Drawing.Point(182, 3);
            this.btnTableEmpty.Name = "btnTableEmpty";
            this.btnTableEmpty.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTableEmpty.OnDisabledState.BorderRadius = 15;
            this.btnTableEmpty.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTableEmpty.OnDisabledState.BorderThickness = 1;
            this.btnTableEmpty.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTableEmpty.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTableEmpty.OnDisabledState.IconLeftImage = null;
            this.btnTableEmpty.OnDisabledState.IconRightImage = null;
            this.btnTableEmpty.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnTableEmpty.onHoverState.BorderRadius = 15;
            this.btnTableEmpty.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTableEmpty.onHoverState.BorderThickness = 1;
            this.btnTableEmpty.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnTableEmpty.onHoverState.ForeColor = System.Drawing.Color.Teal;
            this.btnTableEmpty.onHoverState.IconLeftImage = null;
            this.btnTableEmpty.onHoverState.IconRightImage = null;
            this.btnTableEmpty.OnIdleState.BorderColor = System.Drawing.Color.Teal;
            this.btnTableEmpty.OnIdleState.BorderRadius = 15;
            this.btnTableEmpty.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTableEmpty.OnIdleState.BorderThickness = 1;
            this.btnTableEmpty.OnIdleState.FillColor = System.Drawing.Color.Teal;
            this.btnTableEmpty.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnTableEmpty.OnIdleState.IconLeftImage = null;
            this.btnTableEmpty.OnIdleState.IconRightImage = null;
            this.btnTableEmpty.OnPressedState.BorderColor = System.Drawing.Color.Teal;
            this.btnTableEmpty.OnPressedState.BorderRadius = 15;
            this.btnTableEmpty.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTableEmpty.OnPressedState.BorderThickness = 1;
            this.btnTableEmpty.OnPressedState.FillColor = System.Drawing.Color.Teal;
            this.btnTableEmpty.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnTableEmpty.OnPressedState.IconLeftImage = null;
            this.btnTableEmpty.OnPressedState.IconRightImage = null;
            this.btnTableEmpty.Size = new System.Drawing.Size(173, 67);
            this.btnTableEmpty.TabIndex = 33;
            this.btnTableEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTableEmpty.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTableEmpty.TextMarginLeft = 0;
            this.btnTableEmpty.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnTableEmpty.UseDefaultRadiusAndThickness = true;
            // 
            // btnTableSet
            // 
            this.btnTableSet.AllowAnimations = true;
            this.btnTableSet.AllowMouseEffects = true;
            this.btnTableSet.AllowToggling = false;
            this.btnTableSet.AnimationSpeed = 200;
            this.btnTableSet.AutoGenerateColors = false;
            this.btnTableSet.AutoRoundBorders = false;
            this.btnTableSet.AutoSizeLeftIcon = true;
            this.btnTableSet.AutoSizeRightIcon = true;
            this.btnTableSet.BackColor = System.Drawing.Color.Transparent;
            this.btnTableSet.BackColor1 = System.Drawing.Color.Teal;
            this.btnTableSet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTableSet.BackgroundImage")));
            this.btnTableSet.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTableSet.ButtonText = "Bàn đã đặt";
            this.btnTableSet.ButtonTextMarginLeft = 0;
            this.btnTableSet.ColorContrastOnClick = 45;
            this.btnTableSet.ColorContrastOnHover = 45;
            this.btnTableSet.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnTableSet.CustomizableEdges = borderEdges6;
            this.btnTableSet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTableSet.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTableSet.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTableSet.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTableSet.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnTableSet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableSet.ForeColor = System.Drawing.Color.White;
            this.btnTableSet.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTableSet.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnTableSet.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnTableSet.IconMarginLeft = 11;
            this.btnTableSet.IconPadding = 10;
            this.btnTableSet.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTableSet.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnTableSet.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnTableSet.IconSize = 25;
            this.btnTableSet.IdleBorderColor = System.Drawing.Color.Teal;
            this.btnTableSet.IdleBorderRadius = 15;
            this.btnTableSet.IdleBorderThickness = 1;
            this.btnTableSet.IdleFillColor = System.Drawing.Color.Teal;
            this.btnTableSet.IdleIconLeftImage = null;
            this.btnTableSet.IdleIconRightImage = null;
            this.btnTableSet.IndicateFocus = false;
            this.btnTableSet.Location = new System.Drawing.Point(361, 3);
            this.btnTableSet.Name = "btnTableSet";
            this.btnTableSet.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTableSet.OnDisabledState.BorderRadius = 15;
            this.btnTableSet.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTableSet.OnDisabledState.BorderThickness = 1;
            this.btnTableSet.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTableSet.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTableSet.OnDisabledState.IconLeftImage = null;
            this.btnTableSet.OnDisabledState.IconRightImage = null;
            this.btnTableSet.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnTableSet.onHoverState.BorderRadius = 15;
            this.btnTableSet.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTableSet.onHoverState.BorderThickness = 1;
            this.btnTableSet.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnTableSet.onHoverState.ForeColor = System.Drawing.Color.Teal;
            this.btnTableSet.onHoverState.IconLeftImage = null;
            this.btnTableSet.onHoverState.IconRightImage = null;
            this.btnTableSet.OnIdleState.BorderColor = System.Drawing.Color.Teal;
            this.btnTableSet.OnIdleState.BorderRadius = 15;
            this.btnTableSet.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTableSet.OnIdleState.BorderThickness = 1;
            this.btnTableSet.OnIdleState.FillColor = System.Drawing.Color.Teal;
            this.btnTableSet.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnTableSet.OnIdleState.IconLeftImage = null;
            this.btnTableSet.OnIdleState.IconRightImage = null;
            this.btnTableSet.OnPressedState.BorderColor = System.Drawing.Color.Teal;
            this.btnTableSet.OnPressedState.BorderRadius = 15;
            this.btnTableSet.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTableSet.OnPressedState.BorderThickness = 1;
            this.btnTableSet.OnPressedState.FillColor = System.Drawing.Color.Teal;
            this.btnTableSet.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnTableSet.OnPressedState.IconLeftImage = null;
            this.btnTableSet.OnPressedState.IconRightImage = null;
            this.btnTableSet.Size = new System.Drawing.Size(173, 67);
            this.btnTableSet.TabIndex = 34;
            this.btnTableSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTableSet.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTableSet.TextMarginLeft = 0;
            this.btnTableSet.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnTableSet.UseDefaultRadiusAndThickness = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 77);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1944, 927);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // ListTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 1059);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ListTable";
            this.Text = "Danh mục bàn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnTableGuest;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnTableEmpty;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnTableSet;
    }
}