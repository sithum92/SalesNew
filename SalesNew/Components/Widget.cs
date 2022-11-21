using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesNew.Components
{
    public partial class Widget : UserControl
    {
       
        private categories _category;
        public event EventHandler onSelect = null;
        public Widget()
        {
            InitializeComponent();
      
    }

        public enum categories { Food,Alcohol,ColdDrinks,HotDrinks,Desserts}

        public categories Categorie { get => _category; set => _category = value; }
        public string Id { get => lblId.Text; set => lblId.Text = value; }
        public string Title { get => lblTitle.Text; set => lblTitle.Text = value; }
        public string Price { get => lblPrice.Text; set => lblPrice.Text = value; }
        public Image Picture { get => pbDisplay.Image; set => pbDisplay.Image = value; }

        #region mouseEvents
        private void mouseEnter(object e)
        {
            var widget = (Widget)e;

            widget.BackColor = ColorTranslator.FromHtml("#E8E9EB");
        }


        private void mouseLeave(object e)
        {
            var widget = (Widget)e;

            widget.BackColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void labelMouseEnter(object e)
        {
            var label = (Label)e;

            label.BackColor = ColorTranslator.FromHtml("#E8E9EB");
            mouseEnter(this);
        }


        private void labelMouseLeave(object e)
        {
            var label = (Label)e;

            label.BackColor = ColorTranslator.FromHtml("#0000ffff");
        }



        private void pictureMouseEnter(object e)
        {
            var picture = (FontAwesome.Sharp.IconPictureBox)e;

            picture.BackColor = ColorTranslator.FromHtml("#E8E9EB");
            mouseEnter(this);
        }


        private void pictureMouseLeave(object e)
        {
            var picture = (FontAwesome.Sharp.IconPictureBox)e;

            picture.BackColor = ColorTranslator.FromHtml("#0000ffff");
        }

        private void Widget_MouseEnter(object sender, EventArgs e)
        {
            mouseEnter(sender);
        }

        private void Widget_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(sender);
        }

        private void pbDisplay_MouseEnter(object sender, EventArgs e)
        {
            pictureMouseEnter(sender);
        }

        private void pbDisplay_MouseLeave(object sender, EventArgs e)
        {
            pictureMouseLeave(sender);
        }

        private void lbName_MouseEnter(object sender, EventArgs e)
        {
            labelMouseEnter(sender);
        }

        private void lbName_MouseLeave(object sender, EventArgs e)
        {
            labelMouseLeave(sender);
        }

        private void lbPrice_MouseEnter(object sender, EventArgs e)
        {
            labelMouseEnter(sender);
        }

        private void lbPrice_MouseLeave(object sender, EventArgs e)
        {
            labelMouseLeave(sender);
        }

        private void pbDisplay_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        #endregion

        private void Widget_Load(object sender, EventArgs e)
        {
            lblCategory.Text = _category.ToString();
        }

   

        private void Widget_Click(object sender, EventArgs e)
        {

        }

        private void lbPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
