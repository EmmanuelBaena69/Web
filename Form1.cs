using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void pbxNext_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void pbxRecargar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void pbxHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtBuscador.Text);
        }

        private void txtBuscador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
        }
    }
}
