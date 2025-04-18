using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUARDERIA
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gUARDERIADataSet7.NINO' Puede moverla o quitarla según sea necesario.
            this.nINOTableAdapter.Fill(this.gUARDERIADataSet7.NINO);

            this.reportViewer1.RefreshReport();
        }
    }
}
