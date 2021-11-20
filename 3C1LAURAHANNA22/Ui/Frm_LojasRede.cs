using _3C1LAURAHANNA22.BLL;
using _3C1LAURAHANNA22.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3C1LAURAHANNA22
{
    public partial class Frm_LojasRede : Form
    {
        LojasRedeBLL medbll = new LojasRedeBLL();
        LojasRedeDTO meddto = new LojasRedeDTO();

        public Frm_LojasRede()
        {
            InitializeComponent();
        }

        private void Frm_LojasRede_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            meddto.Codigo = txtCodigo.Text;
            meddto.Produto = txtProduto.Text;
            medbll.Inserir(meddto);

            MessageBox.Show("Cadastrado com sucesso!", "Lojas Rede", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCodigo.Clear();
            txtProduto.Clear();
            txtPreco.Clear();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            meddto.Codigo = int.Parse(txtCodigo.Text);

            medbll.Excluir(meddto);

            MessageBox.Show("Excluído com sucesso!", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            medbll.Listar();

            txtCodigo.Clear();
            txtProduto.Clear();
            txtPreco.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            meddto.Codigo = int.Parse(txtCodigo.Text);
            meddto.Produto = txtProduto.Text;
            meddto.Preco = txtPreco.Text;

            medbll.Editar(meddto);

            MessageBox.Show("Alterado com sucesso!", "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            medbll.Listar();

            txtCodigo.Clear();
            txtProduto.Clear();
            txtPreco.Clear();
        }
    }
}
