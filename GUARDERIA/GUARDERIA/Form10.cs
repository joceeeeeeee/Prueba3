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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gUARDERIADataSet5.EXPEDIENTE' Puede moverla o quitarla según sea necesario.
            this.eXPEDIENTETableAdapter1.Fill(this.gUARDERIADataSet5.EXPEDIENTE);
            // TODO: esta línea de código carga datos en la tabla 'eXPEDATA.EXPEDIENTE' Puede moverla o quitarla según sea necesario.
            this.eXPEDIENTETableAdapter.Fill(this.eXPEDATA.EXPEDIENTE);

            this.reportViewer1.RefreshReport();
        }
    }
}
