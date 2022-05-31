using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_Odejda_dlya_rychek.Forms
{
    public partial class AddMaterial : Form
    {
        public AddMaterial()
        {
            InitializeComponent();
        }

        private void AddMaterial_Load(object sender, EventArgs e)
        {
            verhnayaPanel.BackColor = ColorTranslator.FromHtml("#B3F4E9");
            nijnyaPanel.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            nazad.BackColor = ColorTranslator.FromHtml("#B3F4E9");
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }
    }
}
