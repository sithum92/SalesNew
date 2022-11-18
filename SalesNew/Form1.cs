using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesNew
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
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


 

        private void btnNavFood_MouseEnter(object sender, EventArgs e)
        {
            mouseEnter(sender);

        }

        private void btnNavFood_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(sender);
        }

        private void btnNavAlchole_MouseEnter(object sender, EventArgs e)
        {
            mouseEnter(sender);
        }

        private void btnNavAlchole_MouseLeave(object sender, EventArgs e)
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
    }
}
