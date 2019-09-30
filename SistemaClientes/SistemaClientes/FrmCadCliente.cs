using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dados;
using Dados.bdAtaFinalTableAdapters;

namespace SistemaClientes
{
    public partial class FrmCadCliente : Form
    {
        bdAtaFinal Bd;
        tbl_clienteTableAdapter Adp_Cliente;
        public FrmCadCliente()
        {
            InitializeComponent();
            Bd = new bdAtaFinal();
            Adp_Cliente = new  tbl_clienteTableAdapter();
        }

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidaOsTextBox();
        }
        private void ValidaOsTextBox()
        {
            int erros = 0;
            erros += Validacao(txtpai, txtMae);
            erros += Validacao(cpfpai, cpfmae);
            erros += Validacao(txtRG);
            if (erros > 0)
            {
                MessageBox.Show("preencha os campos obrigatórios");
                return;
            }

            int resul = Adp_Cliente.CadCliente(txtpai.Text, txtMae.Text, cpfpai.Text, cpfmae.Text, fonepai.Text, fonemae.Text, txtendereco.Text, txtnumero.Text, txtbairro.Text, txtcomplemento.Text, txtcidade.Text, txtestado.Text, txtcep.Text, 0, txtRG.Text);
            MessageBox.Show(resul.ToString());
        }
        private int Validacao(TextBox txt1, TextBox txt2)
        {
            if (txt1.Text == "")
            {
                if (txt2.Text == "")
                {
                    txt1.Focus();
                    lblmae.ForeColor = Color.Lime;
                    lblpai.ForeColor = Color.Lime;
                    return 1;
                }
            }
            if (txt2.Text == "")
            {
                if (txt1.Text == "")
                {
                    txt2.Focus();
                    lblmae.ForeColor = Color.Lime;
                    lblpai.ForeColor = Color.Lime;
                    return 1;
                }
            }
            return 0;
        }

        private int Validacao(MaskedTextBox txt1, MaskedTextBox txt2)
        {
            if (txt1.Text == "   ,   ,   -")
            {
                if (txt2.Text == "   ,   ,   -")
                {
                    txt1.Focus();
                    lblcpfpai.ForeColor = Color.Lime;
                    lblcpfmae.ForeColor = Color.Lime;
                    return 1;
                }
            }
            if (txt2.Text == "   ,   ,   -")
            {
                if (txt1.Text == "   ,   ,   -")
                {
                    txt2.Focus();
                    lblcpfpai.ForeColor = Color.Lime;
                    lblcpfmae.ForeColor = Color.Lime;
                    return 1;

                }
            }
            return 0;
           
        }
        private int Validacao(TextBox txt)
        {
            if (txt.Text == "")
            {
                txt.Focus();
                lblrg.ForeColor = Color.Lime;
                return 1;

            }
            return 0;
        }

        private void txtpai_Validated(object sender, EventArgs e)
        {
            if (txtpai.Text != "")
            {
                Bd.tbl_cliente.Rows.Clear();
                Adp_Cliente.Select_Pelo_Nome_Pai(Bd.tbl_cliente, txtpai.Text);
                if (Bd.tbl_cliente.Rows.Count > 0)
                {
                    MessageBox.Show("Já existe um pai com este nome cadastrado\nCC = " + Bd.tbl_cliente.Rows[0]["id_cliente"].ToString());
                    txtpai.Clear();
                    txtpai.Focus();
                }

            }
        }

        private void txtMae_Validated(object sender, EventArgs e)
        {
            if (txtMae.Text != "")
            {
                Bd.tbl_cliente.Rows.Clear();
                Adp_Cliente.Select_Pelo_Nome_Mae(Bd.tbl_cliente, txtMae.Text);
                if (Bd.tbl_cliente.Rows.Count > 0)
                {
                    MessageBox.Show("Já existe um mae com este nome cadastrado\nCC = " + Bd.tbl_cliente.Rows[0]["id_cliente"].ToString());
                    txtMae.Clear();
                    txtMae.Focus();
                }

            }
        }
    }
}
