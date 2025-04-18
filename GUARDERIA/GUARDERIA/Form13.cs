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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gUARDERIADataSet8.SALON' Puede moverla o quitarla según sea necesario.
            this.sALONTableAdapter.Fill(this.gUARDERIADataSet8.SALON);

            this.reportViewer1.RefreshReport();
        }
    }
}
