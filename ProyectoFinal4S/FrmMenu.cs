using System;
using System.Windows.Forms;

namespace ProyectoFinal4S.ProyectoFinal4S
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnAPI_Click(object sender, EventArgs e)
        {
            Form form = new FrmAPI();
            form.Show();
            Hide();
        }

        private void btnDataSet_Click(object sender, EventArgs e)
        {
            Form form = new FrmDataSet();
            form.Show();
            Hide();
        }
    }
}