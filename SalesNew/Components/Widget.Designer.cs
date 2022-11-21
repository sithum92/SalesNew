
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
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
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
            this.pbDisplay.MouseEnter += new System.EventHandler(this.pbDisplay_MouseEnter);
            this.pbDisplay.MouseLeave += new System.EventHandler(this.pbDisplay_MouseLeave);
            // 
            // lbPrice
            // 
            this.lbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.Coral;
            this.lbPrice.Location = new System.Drawing.Point(33, 120);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(2);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Padding = new System.Windows.Forms.Padding(2);
            this.lbPrice.Size = new System.Drawing.Size(93, 35);
            this.lbPrice.TabIndex = 6;
            this.lbPrice.Text = "$ 1.75";
            this.lbPrice.MouseEnter += new System.EventHandler(this.lbPrice_MouseEnter);
            this.lbPrice.MouseLeave += new System.EventHandler(this.lbPrice_MouseLeave);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(15, 15);
            this.lbName.Margin = new System.Windows.Forms.Padding(2);
            this.lbName.Name = "lbName";
            this.lbName.Padding = new System.Windows.Forms.Padding(2);
            this.lbName.Size = new System.Drawing.Size(255, 50);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Ranch Burger";
            this.lbName.MouseEnter += new System.EventHandler(this.lbName_MouseEnter);
            this.lbName.MouseLeave += new System.EventHandler(this.lbName_MouseLeave);
            // 
            // Widget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pbDisplay);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Widget";
            this.Size = new System.Drawing.Size(344, 202);
            this.MouseEnter += new System.EventHandler(this.Widget_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Widget_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox pbDisplay;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbName;
    }
}
