using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaClientes
{
    //menu principal
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCliente cad = new FrmCadCliente();
            cad.TopLevel = false;
            cad.AutoScroll = true;
            cad.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel1.Controls.Add(cad);
            cad.Show();
        }
    }
}
