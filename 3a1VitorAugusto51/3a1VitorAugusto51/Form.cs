using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3a1VitorAugusto51
{
    public partial class Form1 : Form
    {
        Supermercado objdentista = new Supermercado();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexao objconexao = new Conexao();
            objconexao.Conectar();
            MessageBox.Show("Conectado");

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            objdentista.quantidade = double.Parse(txtquantidade.Text);
            objdentista.produto = txtproduto.Text;
            objdentista.preco = double.Parse(txtpreco.Text);
            objdentista.CadastrarCliente();
            MessageBox.Show("Usuário cadastrado com sucesso");
           

        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            dtgLista.DataSource = objdentista.ListarUsuarios();


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgLista.DataSource = objdentista.ListarUsuarios();
        }

        private void dtgLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtData_Hora_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

