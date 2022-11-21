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
        public Widget()
        {
            InitializeComponent();
        }


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
    }
}
