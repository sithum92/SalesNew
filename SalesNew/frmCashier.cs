using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace SalesNew
{
    public partial class frmCashier : MetroFramework.Forms.MetroForm
    {
        public frmCashier()
        {
            InitializeComponent();
        }

        private void mouseEnter(object e)
        {
            var button = (IconButton)e;

            button.BackColor = ColorTranslator.FromHtml("#E8E9EB");
            button.IconColor = ColorTranslator.FromHtml("#EF7712");
            button.ForeColor = ColorTranslator.FromHtml("#EF7712");
        }

        private void mouseLeave(object e)
        {
            var button = (IconButton)e;

            button.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            button.IconColor = ColorTranslator.FromHtml("#4d5156");
            button.ForeColor = ColorTranslator.FromHtml("#4d5156");
        }

        private void btnNavAll_MouseEnter(object sender, EventArgs e)
        {
            mouseEnter(sender);
        }

        private void btnNavAll_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(sender);
        }

        private void btnNavFood_MouseEnter(object sender, EventArgs e)
        {
            mouseEnter(sender);
        }

        private void btnNavFood_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(sender);
        }

        private void btnNavAlcohol_MouseEnter(object sender, EventArgs e)
        {
            mouseEnter(sender);
        }

        private void btnNavAlcohol_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(sender);
        }

        private void btnNavColdDrinks_MouseEnter(object sender, EventArgs e)
        {
            mouseEnter(sender);
        }

        private void btnNavColdDrinks_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(sender);
        }

        private void btnNavHotDrinks_MouseEnter(object sender, EventArgs e)
        {
            mouseEnter(sender);
        }

        private void btnNavHotDrinks_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(sender);
        }
    }
}
