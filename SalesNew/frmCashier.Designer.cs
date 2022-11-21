
namespace SalesNew
{
    partial class frmCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new MetroFramework.Controls.MetroPanel();
            this.pcbResturent = new FontAwesome.Sharp.IconPictureBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.panelCanvas = new MetroFramework.Controls.MetroPanel();
            this.panelWidget = new MetroFramework.Controls.MetroPanel();
            this.flPanelWidget = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMiddleTop = new MetroFramework.Controls.MetroPanel();
            this.txtIDSearch = new MetroFramework.Controls.MetroTextBox();
            this.panelRight = new MetroFramework.Controls.MetroPanel();
            this.gridItems = new MetroFramework.Controls.MetroGrid();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelRightBottom = new MetroFramework.Controls.MetroPanel();
            this.txtCashReceived = new MetroFramework.Controls.MetroTextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.panelRightTop = new MetroFramework.Controls.MetroPanel();
            this.btnClearAll = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panelNav = new MetroFramework.Controls.MetroPanel();
            this.btnNavHotDrinks = new FontAwesome.Sharp.IconButton();
            this.btnNavColdDrinks = new FontAwesome.Sharp.IconButton();
            this.btnNavAlcohol = new FontAwesome.Sharp.IconButton();
            this.btnNavFood = new FontAwesome.Sharp.IconButton();
            this.btnNavAll = new FontAwesome.Sharp.IconButton();
            this.lbBusinessName = new System.Windows.Forms.Label();
            this.gridTop = new MetroFramework.Controls.MetroGrid();
            this.txtNameSearch = new MetroFramework.Controls.MetroTextBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResturent)).BeginInit();
            this.panelCanvas.SuspendLayout();
            this.panelWidget.SuspendLayout();
            this.panelMiddleTop.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
            this.panelRightBottom.SuspendLayout();
            this.panelRightTop.SuspendLayout();
            this.panelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTop)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.panelMain.Controls.Add(this.pcbResturent);
            this.panelMain.Controls.Add(this.lblDateTime);
            this.panelMain.Controls.Add(this.panelCanvas);
            this.panelMain.Controls.Add(this.lbBusinessName);
            this.panelMain.Controls.Add(this.gridTop);
            this.panelMain.HorizontalScrollbarBarColor = true;
            this.panelMain.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMain.HorizontalScrollbarSize = 10;
            this.panelMain.Location = new System.Drawing.Point(1, 6);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1838, 955);
            this.panelMain.TabIndex = 0;
            this.panelMain.UseCustomBackColor = true;
            this.panelMain.UseCustomForeColor = true;
            this.panelMain.UseStyleColors = true;
            this.panelMain.VerticalScrollbarBarColor = true;
            this.panelMain.VerticalScrollbarHighlightOnWheel = false;
            this.panelMain.VerticalScrollbarSize = 10;
            // 
            // pcbResturent
            // 
            this.pcbResturent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.pcbResturent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbResturent.BackgroundImage")));
            this.pcbResturent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbResturent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pcbResturent.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pcbResturent.IconColor = System.Drawing.SystemColors.ControlText;
            this.pcbResturent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pcbResturent.IconSize = 34;
            this.pcbResturent.Location = new System.Drawing.Point(31, 16);
            this.pcbResturent.Name = "pcbResturent";
            this.pcbResturent.Size = new System.Drawing.Size(114, 34);
            this.pcbResturent.TabIndex = 9;
            this.pcbResturent.TabStop = false;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDateTime.Location = new System.Drawing.Point(1518, 18);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(232, 29);
            this.lblDateTime.TabIndex = 8;
            this.lblDateTime.Text = "18/11/2022 - 9.28PM";
            // 
            // panelCanvas
            // 
            this.panelCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCanvas.Controls.Add(this.panelWidget);
            this.panelCanvas.Controls.Add(this.panelMiddleTop);
            this.panelCanvas.Controls.Add(this.panelRight);
            this.panelCanvas.Controls.Add(this.panelNav);
            this.panelCanvas.HorizontalScrollbarBarColor = true;
            this.panelCanvas.HorizontalScrollbarHighlightOnWheel = false;
            this.panelCanvas.HorizontalScrollbarSize = 10;
            this.panelCanvas.Location = new System.Drawing.Point(22, 57);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(1786, 878);
            this.panelCanvas.TabIndex = 7;
            this.panelCanvas.VerticalScrollbarBarColor = true;
            this.panelCanvas.VerticalScrollbarHighlightOnWheel = false;
            this.panelCanvas.VerticalScrollbarSize = 10;
            // 
            // panelWidget
            // 
            this.panelWidget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWidget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWidget.Controls.Add(this.flPanelWidget);
            this.panelWidget.HorizontalScrollbarBarColor = true;
            this.panelWidget.HorizontalScrollbarHighlightOnWheel = false;
            this.panelWidget.HorizontalScrollbarSize = 10;
            this.panelWidget.Location = new System.Drawing.Point(326, 107);
            this.panelWidget.Name = "panelWidget";
            this.panelWidget.Size = new System.Drawing.Size(501, 767);
            this.panelWidget.TabIndex = 5;
            this.panelWidget.VerticalScrollbarBarColor = true;
            this.panelWidget.VerticalScrollbarHighlightOnWheel = false;
            this.panelWidget.VerticalScrollbarSize = 10;
            // 
            // flPanelWidget
            // 
            this.flPanelWidget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flPanelWidget.BackColor = System.Drawing.Color.White;
            this.flPanelWidget.Location = new System.Drawing.Point(20, 20);
            this.flPanelWidget.Name = "flPanelWidget";
            this.flPanelWidget.Size = new System.Drawing.Size(457, 722);
            this.flPanelWidget.TabIndex = 6;
            // 
            // panelMiddleTop
            // 
            this.panelMiddleTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMiddleTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMiddleTop.Controls.Add(this.txtNameSearch);
            this.panelMiddleTop.Controls.Add(this.txtIDSearch);
            this.panelMiddleTop.HorizontalScrollbarBarColor = true;
            this.panelMiddleTop.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMiddleTop.HorizontalScrollbarSize = 10;
            this.panelMiddleTop.Location = new System.Drawing.Point(326, 1);
            this.panelMiddleTop.Name = "panelMiddleTop";
            this.panelMiddleTop.Size = new System.Drawing.Size(499, 106);
            this.panelMiddleTop.TabIndex = 4;
            this.panelMiddleTop.VerticalScrollbarBarColor = true;
            this.panelMiddleTop.VerticalScrollbarHighlightOnWheel = false;
            this.panelMiddleTop.VerticalScrollbarSize = 10;
            // 
            // txtIDSearch
            // 
            this.txtIDSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtIDSearch.CustomButton.Image = null;
            this.txtIDSearch.CustomButton.Location = new System.Drawing.Point(164, 2);
            this.txtIDSearch.CustomButton.Name = "";
            this.txtIDSearch.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtIDSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIDSearch.CustomButton.TabIndex = 1;
            this.txtIDSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIDSearch.CustomButton.UseSelectable = true;
            this.txtIDSearch.CustomButton.Visible = false;
            this.txtIDSearch.DisplayIcon = true;
            this.txtIDSearch.Icon = global::SalesNew.Properties.Resources.icons8_search_50;
            this.txtIDSearch.IconRight = true;
            this.txtIDSearch.Lines = new string[0];
            this.txtIDSearch.Location = new System.Drawing.Point(20, 29);
            this.txtIDSearch.MaxLength = 32767;
            this.txtIDSearch.Multiline = true;
            this.txtIDSearch.Name = "txtIDSearch";
            this.txtIDSearch.PasswordChar = '\0';
            this.txtIDSearch.PromptText = "ID Search";
            this.txtIDSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIDSearch.SelectedText = "";
            this.txtIDSearch.SelectionLength = 0;
            this.txtIDSearch.SelectionStart = 0;
            this.txtIDSearch.ShortcutsEnabled = true;
            this.txtIDSearch.Size = new System.Drawing.Size(212, 50);
            this.txtIDSearch.TabIndex = 5;
            this.txtIDSearch.UseSelectable = true;
            this.txtIDSearch.WaterMark = "ID Search";
            this.txtIDSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIDSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIDSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtIDSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.gridItems);
            this.panelRight.Controls.Add(this.panelRightBottom);
            this.panelRight.Controls.Add(this.panelRightTop);
            this.panelRight.HorizontalScrollbarBarColor = true;
            this.panelRight.HorizontalScrollbarHighlightOnWheel = false;
            this.panelRight.HorizontalScrollbarSize = 10;
            this.panelRight.Location = new System.Drawing.Point(826, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(957, 875);
            this.panelRight.TabIndex = 3;
            this.panelRight.VerticalScrollbarBarColor = true;
            this.panelRight.VerticalScrollbarHighlightOnWheel = false;
            this.panelRight.VerticalScrollbarSize = 10;
            // 
            // gridItems
            // 
            this.gridItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.gridItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.gridItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Qty,
            this.cost,
            this.Delete});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridItems.DefaultCellStyle = dataGridViewCellStyle13;
            this.gridItems.EnableHeadersVisualStyles = false;
            this.gridItems.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridItems.Location = new System.Drawing.Point(4, 109);
            this.gridItems.Name = "gridItems";
            this.gridItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.gridItems.RowHeadersVisible = false;
            this.gridItems.RowHeadersWidth = 51;
            this.gridItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridItems.RowTemplate.Height = 24;
            this.gridItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridItems.Size = new System.Drawing.Size(948, 426);
            this.gridItems.TabIndex = 4;
            // 
            // Item
            // 
            this.Item.FillWeight = 186.3507F;
            this.Item.HeaderText = "ITEM";
            this.Item.MinimumWidth = 10;
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.FillWeight = 64.17112F;
            this.Qty.HeaderText = "QTY";
            this.Qty.MinimumWidth = 4;
            this.Qty.Name = "Qty";
            this.Qty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Qty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cost
            // 
            this.cost.FillWeight = 72.09407F;
            this.cost.HeaderText = "COST";
            this.cost.MinimumWidth = 6;
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 77.38411F;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.HeaderText = "Remove";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Remove";
            // 
            // panelRightBottom
            // 
            this.panelRightBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRightBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRightBottom.Controls.Add(this.txtCashReceived);
            this.panelRightBottom.Controls.Add(this.lblBalance);
            this.panelRightBottom.Controls.Add(this.label5);
            this.panelRightBottom.Controls.Add(this.label4);
            this.panelRightBottom.Controls.Add(this.lblTotal);
            this.panelRightBottom.Controls.Add(this.label1);
            this.panelRightBottom.Controls.Add(this.btnSave);
            this.panelRightBottom.HorizontalScrollbarBarColor = true;
            this.panelRightBottom.HorizontalScrollbarHighlightOnWheel = false;
            this.panelRightBottom.HorizontalScrollbarSize = 10;
            this.panelRightBottom.Location = new System.Drawing.Point(3, 541);
            this.panelRightBottom.Name = "panelRightBottom";
            this.panelRightBottom.Size = new System.Drawing.Size(952, 329);
            this.panelRightBottom.TabIndex = 3;
            this.panelRightBottom.VerticalScrollbarBarColor = true;
            this.panelRightBottom.VerticalScrollbarHighlightOnWheel = false;
            this.panelRightBottom.VerticalScrollbarSize = 10;
            // 
            // txtCashReceived
            // 
            this.txtCashReceived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtCashReceived.CustomButton.Image = null;
            this.txtCashReceived.CustomButton.Location = new System.Drawing.Point(171, 2);
            this.txtCashReceived.CustomButton.Name = "";
            this.txtCashReceived.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtCashReceived.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCashReceived.CustomButton.TabIndex = 1;
            this.txtCashReceived.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCashReceived.CustomButton.UseSelectable = true;
            this.txtCashReceived.CustomButton.Visible = false;
            this.txtCashReceived.Lines = new string[0];
            this.txtCashReceived.Location = new System.Drawing.Point(688, 102);
            this.txtCashReceived.MaxLength = 32767;
            this.txtCashReceived.Multiline = true;
            this.txtCashReceived.Name = "txtCashReceived";
            this.txtCashReceived.PasswordChar = '\0';
            this.txtCashReceived.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCashReceived.SelectedText = "";
            this.txtCashReceived.SelectionLength = 0;
            this.txtCashReceived.SelectionStart = 0;
            this.txtCashReceived.ShortcutsEnabled = true;
            this.txtCashReceived.Size = new System.Drawing.Size(209, 40);
            this.txtCashReceived.TabIndex = 5;
            this.txtCashReceived.UseSelectable = true;
            this.txtCashReceived.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCashReceived.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.White;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(683, 161);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(100, 29);
            this.lblBalance.TabIndex = 10;
            this.lblBalance.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cash Received";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(682, 38);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(81, 36);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(15, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(914, 83);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Pay";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            // 
            // panelRightTop
            // 
            this.panelRightTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRightTop.Controls.Add(this.btnClearAll);
            this.panelRightTop.Controls.Add(this.label2);
            this.panelRightTop.HorizontalScrollbarBarColor = true;
            this.panelRightTop.HorizontalScrollbarHighlightOnWheel = false;
            this.panelRightTop.HorizontalScrollbarSize = 10;
            this.panelRightTop.Location = new System.Drawing.Point(0, -1);
            this.panelRightTop.Name = "panelRightTop";
            this.panelRightTop.Size = new System.Drawing.Size(952, 86);
            this.panelRightTop.TabIndex = 2;
            this.panelRightTop.VerticalScrollbarBarColor = true;
            this.panelRightTop.VerticalScrollbarHighlightOnWheel = false;
            this.panelRightTop.VerticalScrollbarSize = 10;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearAll.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Location = new System.Drawing.Point(763, 29);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(171, 49);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseCustomBackColor = true;
            this.btnClearAll.UseCustomForeColor = true;
            this.btnClearAll.UseSelectable = true;
            this.btnClearAll.UseStyleColors = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Current Order";
            // 
            // panelNav
            // 
            this.panelNav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelNav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNav.Controls.Add(this.btnNavHotDrinks);
            this.panelNav.Controls.Add(this.btnNavColdDrinks);
            this.panelNav.Controls.Add(this.btnNavAlcohol);
            this.panelNav.Controls.Add(this.btnNavFood);
            this.panelNav.Controls.Add(this.btnNavAll);
            this.panelNav.HorizontalScrollbarBarColor = true;
            this.panelNav.HorizontalScrollbarHighlightOnWheel = false;
            this.panelNav.HorizontalScrollbarSize = 10;
            this.panelNav.Location = new System.Drawing.Point(3, 1);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(325, 874);
            this.panelNav.TabIndex = 2;
            this.panelNav.VerticalScrollbarBarColor = true;
            this.panelNav.VerticalScrollbarHighlightOnWheel = false;
            this.panelNav.VerticalScrollbarSize = 10;
            // 
            // btnNavHotDrinks
            // 
            this.btnNavHotDrinks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavHotDrinks.BackColor = System.Drawing.Color.White;
            this.btnNavHotDrinks.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNavHotDrinks.FlatAppearance.BorderSize = 0;
            this.btnNavHotDrinks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.btnNavHotDrinks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.btnNavHotDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavHotDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavHotDrinks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(154)))), ((int)(((byte)(170)))));
            this.btnNavHotDrinks.IconChar = FontAwesome.Sharp.IconChar.Coffee;
            this.btnNavHotDrinks.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(154)))), ((int)(((byte)(170)))));
            this.btnNavHotDrinks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNavHotDrinks.IconSize = 60;
            this.btnNavHotDrinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavHotDrinks.Location = new System.Drawing.Point(5, 483);
            this.btnNavHotDrinks.Margin = new System.Windows.Forms.Padding(0);
            this.btnNavHotDrinks.Name = "btnNavHotDrinks";
            this.btnNavHotDrinks.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnNavHotDrinks.Size = new System.Drawing.Size(314, 114);
            this.btnNavHotDrinks.TabIndex = 17;
            this.btnNavHotDrinks.Tag = "HotDrinks";
            this.btnNavHotDrinks.Text = "Hot Drinks";
            this.btnNavHotDrinks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNavHotDrinks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavHotDrinks.UseVisualStyleBackColor = false;
            this.btnNavHotDrinks.MouseEnter += new System.EventHandler(this.btnNavHotDrinks_MouseEnter);
            this.btnNavHotDrinks.MouseLeave += new System.EventHandler(this.btnNavHotDrinks_MouseLeave);
            // 
            // btnNavColdDrinks
            // 
            this.btnNavColdDrinks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavColdDrinks.BackColor = System.Drawing.Color.White;
            this.btnNavColdDrinks.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNavColdDrinks.FlatAppearance.BorderSize = 0;
            this.btnNavColdDrinks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.btnNavColdDrinks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.btnNavColdDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavColdDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavColdDrinks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(154)))), ((int)(((byte)(170)))));
            this.btnNavColdDrinks.IconChar = FontAwesome.Sharp.IconChar.BottleWater;
            this.btnNavColdDrinks.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(154)))), ((int)(((byte)(170)))));
            this.btnNavColdDrinks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNavColdDrinks.IconSize = 60;
            this.btnNavColdDrinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavColdDrinks.Location = new System.Drawing.Point(5, 369);
            this.btnNavColdDrinks.Margin = new System.Windows.Forms.Padding(0);
            this.btnNavColdDrinks.Name = "btnNavColdDrinks";
            this.btnNavColdDrinks.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnNavColdDrinks.Size = new System.Drawing.Size(314, 114);
            this.btnNavColdDrinks.TabIndex = 16;
            this.btnNavColdDrinks.Tag = "ColdDrinks";
            this.btnNavColdDrinks.Text = "Cold Drinks";
            this.btnNavColdDrinks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNavColdDrinks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavColdDrinks.UseVisualStyleBackColor = false;
            this.btnNavColdDrinks.MouseEnter += new System.EventHandler(this.btnNavColdDrinks_MouseEnter);
            this.btnNavColdDrinks.MouseLeave += new System.EventHandler(this.btnNavColdDrinks_MouseLeave);
            // 
            // btnNavAlcohol
            // 
            this.btnNavAlcohol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavAlcohol.BackColor = System.Drawing.Color.White;
            this.btnNavAlcohol.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNavAlcohol.FlatAppearance.BorderSize = 0;
            this.btnNavAlcohol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.btnNavAlcohol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.btnNavAlcohol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAlcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavAlcohol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(154)))), ((int)(((byte)(170)))));
            this.btnNavAlcohol.IconChar = FontAwesome.Sharp.IconChar.WineGlass;
            this.btnNavAlcohol.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(154)))), ((int)(((byte)(170)))));
            this.btnNavAlcohol.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNavAlcohol.IconSize = 60;
            this.btnNavAlcohol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAlcohol.Location = new System.Drawing.Point(5, 255);
            this.btnNavAlcohol.Margin = new System.Windows.Forms.Padding(0);
            this.btnNavAlcohol.Name = "btnNavAlcohol";
            this.btnNavAlcohol.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnNavAlcohol.Size = new System.Drawing.Size(314, 114);
            this.btnNavAlcohol.TabIndex = 15;
            this.btnNavAlcohol.Tag = "Alcohol";
            this.btnNavAlcohol.Text = "Alcohol";
            this.btnNavAlcohol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNavAlcohol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavAlcohol.UseVisualStyleBackColor = false;
            this.btnNavAlcohol.MouseEnter += new System.EventHandler(this.btnNavAlcohol_MouseEnter);
            this.btnNavAlcohol.MouseLeave += new System.EventHandler(this.btnNavAlcohol_MouseLeave);
            // 
            // btnNavFood
            // 
            this.btnNavFood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavFood.BackColor = System.Drawing.Color.White;
            this.btnNavFood.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNavFood.FlatAppearance.BorderSize = 0;
            this.btnNavFood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.btnNavFood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.btnNavFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(154)))), ((int)(((byte)(170)))));
            this.btnNavFood.IconChar = FontAwesome.Sharp.IconChar.Burger;
            this.btnNavFood.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(154)))), ((int)(((byte)(170)))));
            this.btnNavFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNavFood.IconSize = 60;
            this.btnNavFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavFood.Location = new System.Drawing.Point(5, 141);
            this.btnNavFood.Margin = new System.Windows.Forms.Padding(0);
            this.btnNavFood.Name = "btnNavFood";
            this.btnNavFood.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnNavFood.Size = new System.Drawing.Size(314, 114);
            this.btnNavFood.TabIndex = 14;
            this.btnNavFood.Tag = "Food";
            this.btnNavFood.Text = "Food";
            this.btnNavFood.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNavFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavFood.UseVisualStyleBackColor = false;
            this.btnNavFood.MouseEnter += new System.EventHandler(this.btnNavFood_MouseEnter);
            this.btnNavFood.MouseLeave += new System.EventHandler(this.btnNavFood_MouseLeave);
            // 
            // btnNavAll
            // 
            this.btnNavAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavAll.BackColor = System.Drawing.Color.White;
            this.btnNavAll.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNavAll.FlatAppearance.BorderSize = 0;
            this.btnNavAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.btnNavAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.btnNavAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(154)))), ((int)(((byte)(170)))));
            this.btnNavAll.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            this.btnNavAll.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(154)))), ((int)(((byte)(170)))));
            this.btnNavAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNavAll.IconSize = 60;
            this.btnNavAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAll.Location = new System.Drawing.Point(1, 27);
            this.btnNavAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnNavAll.Name = "btnNavAll";
            this.btnNavAll.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnNavAll.Size = new System.Drawing.Size(318, 114);
            this.btnNavAll.TabIndex = 13;
            this.btnNavAll.Tag = "AllItems";
            this.btnNavAll.Text = "All Items";
            this.btnNavAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNavAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavAll.UseVisualStyleBackColor = false;
            this.btnNavAll.MouseEnter += new System.EventHandler(this.btnNavAll_MouseEnter);
            this.btnNavAll.MouseLeave += new System.EventHandler(this.btnNavAll_MouseLeave);
            // 
            // lbBusinessName
            // 
            this.lbBusinessName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbBusinessName.AutoSize = true;
            this.lbBusinessName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.lbBusinessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBusinessName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbBusinessName.Location = new System.Drawing.Point(166, 22);
            this.lbBusinessName.Name = "lbBusinessName";
            this.lbBusinessName.Size = new System.Drawing.Size(176, 29);
            this.lbBusinessName.TabIndex = 6;
            this.lbBusinessName.Text = "Cafe SriLanaka";
            // 
            // gridTop
            // 
            this.gridTop.AllowUserToResizeRows = false;
            this.gridTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.gridTop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTop.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridTop.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTop.DefaultCellStyle = dataGridViewCellStyle9;
            this.gridTop.EnableHeadersVisualStyles = false;
            this.gridTop.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridTop.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridTop.Location = new System.Drawing.Point(0, 3);
            this.gridTop.Name = "gridTop";
            this.gridTop.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTop.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridTop.RowHeadersWidth = 51;
            this.gridTop.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridTop.RowTemplate.Height = 24;
            this.gridTop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTop.Size = new System.Drawing.Size(1835, 60);
            this.gridTop.TabIndex = 2;
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtNameSearch.CustomButton.Image = null;
            this.txtNameSearch.CustomButton.Location = new System.Drawing.Point(179, 2);
            this.txtNameSearch.CustomButton.Name = "";
            this.txtNameSearch.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtNameSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameSearch.CustomButton.TabIndex = 1;
            this.txtNameSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameSearch.CustomButton.UseSelectable = true;
            this.txtNameSearch.CustomButton.Visible = false;
            this.txtNameSearch.DisplayIcon = true;
            this.txtNameSearch.Icon = global::SalesNew.Properties.Resources.icons8_search_50;
            this.txtNameSearch.IconRight = true;
            this.txtNameSearch.Lines = new string[0];
            this.txtNameSearch.Location = new System.Drawing.Point(250, 29);
            this.txtNameSearch.MaxLength = 32767;
            this.txtNameSearch.Multiline = true;
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.PasswordChar = '\0';
            this.txtNameSearch.PromptText = "Name Search";
            this.txtNameSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameSearch.SelectedText = "";
            this.txtNameSearch.SelectionLength = 0;
            this.txtNameSearch.SelectionStart = 0;
            this.txtNameSearch.ShortcutsEnabled = true;
            this.txtNameSearch.Size = new System.Drawing.Size(227, 50);
            this.txtNameSearch.TabIndex = 6;
            this.txtNameSearch.UseSelectable = true;
            this.txtNameSearch.WaterMark = "Name Search";
            this.txtNameSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1842, 964);
            this.ControlBox = false;
            this.Controls.Add(this.panelMain);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCashier";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCashier_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResturent)).EndInit();
            this.panelCanvas.ResumeLayout(false);
            this.panelWidget.ResumeLayout(false);
            this.panelMiddleTop.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
            this.panelRightBottom.ResumeLayout(false);
            this.panelRightBottom.PerformLayout();
            this.panelRightTop.ResumeLayout(false);
            this.panelRightTop.PerformLayout();
            this.panelNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelMain;
        private MetroFramework.Controls.MetroGrid gridTop;
        private System.Windows.Forms.Label lbBusinessName;
        private System.Windows.Forms.Label lblDateTime;
        private MetroFramework.Controls.MetroPanel panelCanvas;
        private MetroFramework.Controls.MetroPanel panelNav;
        private FontAwesome.Sharp.IconButton btnNavAll;
        private FontAwesome.Sharp.IconButton btnNavFood;
        private FontAwesome.Sharp.IconButton btnNavAlcohol;
        private FontAwesome.Sharp.IconButton btnNavColdDrinks;
        private FontAwesome.Sharp.IconButton btnNavHotDrinks;
        private MetroFramework.Controls.MetroPanel panelRight;
        private MetroFramework.Controls.MetroPanel panelRightTop;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton btnClearAll;
        private MetroFramework.Controls.MetroPanel panelRightBottom;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroPanel panelMiddleTop;
        private MetroFramework.Controls.MetroGrid gridItems;
        private FontAwesome.Sharp.IconPictureBox pcbResturent;
        private MetroFramework.Controls.MetroTextBox txtIDSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewComboBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private MetroFramework.Controls.MetroTextBox txtCashReceived;
        private MetroFramework.Controls.MetroPanel panelWidget;
        private System.Windows.Forms.FlowLayoutPanel flPanelWidget;
        private MetroFramework.Controls.MetroTextBox txtNameSearch;
    }
}