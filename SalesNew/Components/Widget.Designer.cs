
namespace SalesNew.Components
{
    partial class Widget
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Widget));
            this.pbDisplay = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDisplay
            // 
            this.pbDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbDisplay.BackColor = System.Drawing.Color.Transparent;
            this.pbDisplay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbDisplay.BackgroundImage")));
            this.pbDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbDisplay.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pbDisplay.IconColor = System.Drawing.SystemColors.ControlText;
            this.pbDisplay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbDisplay.IconSize = 66;
            this.pbDisplay.Location = new System.Drawing.Point(203, 72);
            this.pbDisplay.Margin = new System.Windows.Forms.Padding(5);
            this.pbDisplay.Name = "pbDisplay";
            this.pbDisplay.Padding = new System.Windows.Forms.Padding(2);
            this.pbDisplay.Size = new System.Drawing.Size(67, 66);
            this.pbDisplay.TabIndex = 7;
            this.pbDisplay.TabStop = false;
            this.pbDisplay.Click += new System.EventHandler(this.pbDisplay_Click);
            this.pbDisplay.MouseEnter += new System.EventHandler(this.pbDisplay_MouseEnter);
            this.pbDisplay.MouseLeave += new System.EventHandler(this.pbDisplay_MouseLeave);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(2);
            this.lblTitle.Size = new System.Drawing.Size(204, 40);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Ranch Burger";
            this.lblTitle.MouseEnter += new System.EventHandler(this.lbName_MouseEnter);
            this.lblTitle.MouseLeave += new System.EventHandler(this.lbName_MouseLeave);
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Red;
            this.lblId.Location = new System.Drawing.Point(80, 72);
            this.lblId.Margin = new System.Windows.Forms.Padding(2);
            this.lblId.Name = "lblId";
            this.lblId.Padding = new System.Windows.Forms.Padding(2);
            this.lblId.Size = new System.Drawing.Size(46, 35);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "ID";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Coral;
            this.lblPrice.Location = new System.Drawing.Point(33, 120);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Padding = new System.Windows.Forms.Padding(2);
            this.lblPrice.Size = new System.Drawing.Size(93, 35);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "$ 1.75";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            this.lblPrice.MouseEnter += new System.EventHandler(this.lbPrice_MouseEnter);
            this.lblPrice.MouseLeave += new System.EventHandler(this.lbPrice_MouseLeave);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(272, 26);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(46, 17);
            this.lblCategory.TabIndex = 9;
            this.lblCategory.Text = "label1";
            // 
            // Widget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.pbDisplay);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Widget";
            this.Size = new System.Drawing.Size(344, 202);
            this.Load += new System.EventHandler(this.Widget_Load);
            this.Click += new System.EventHandler(this.Widget_Click);
            this.MouseEnter += new System.EventHandler(this.Widget_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Widget_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox pbDisplay;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
    }
}
