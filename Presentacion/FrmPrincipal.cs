using ModeloParcial.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloParcial
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void nuevaOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNuevaOrden().ShowDialog();
        }

        private void consultarOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsultarOrdenes().ShowDialog();
        }

        private void reporteStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmReporteStock().ShowDialog();
        }
    }
}
