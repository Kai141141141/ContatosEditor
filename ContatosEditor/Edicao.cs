using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContatosEditor
{
    public partial class Edicao : Form
    {
        int Idselecionado=0;
        public Edicao() {

        InitializeComponent();
        Contatos contatos = new Contatos();
        dvgEdicao.DataSource = contatos.ListarTudo();
        }
        private void grbEditar_Enter(object sender, EventArgs e)
        {

        }

        private void btnCadastroo_Click(object sender, EventArgs e)
        {

            // Instanciar o usuário:
            Contatos contatos = new Contatos();
            // Obter os valores dos campos:
            contatos.Nome = txbNomeCad.Text;
            contatos.email = txbEmailcadastronovo.Text;
            contatos.telefone = int.Parse(txbTelCadastro.Text.ToString());
            contatos.data_aniversario = DateTime.Parse(dtpAniversario.Text);

            if (contatos.Cadastrar() == true)
            {
                MessageBox.Show("Contato cadastrado!");
                // Limpar os campos:
                txbNomeCad.Clear();
                txbEmailcadastronovo.Clear();
                txbTelCadastro.Clear();
               
                // Atualizar o dgv:
                dvgEdicao.DataSource = contatos.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar contato!");
            }
        }

        

        private void BtnEditarr_Click(object sender, EventArgs e)
        {
            Contatos contatos = new Contatos();

            // Obter os valores dos txbs:

            contatos.Nome = txbNomeEdit.Text;
            contatos.email = TxbEmailEdit.Text;
            contatos.telefone = int.Parse(txbTellEdit.Text);
            contatos.id = Idselecionado;
            

            // Editar:
            if (contatos.Modificar() == true)
            {
                MessageBox.Show("Contato modificado!", "Sucesso!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                // Atualizar o dgv:
                dvgEdicao.DataSource = contatos.ListarTudo();
                // Limpar os campos de edição:
                TxbEmailEdit.Clear();
                txbNomeEdit.Clear();
               txbTellEdit.Clear();
                // Desabilitar os grbs:
                grbEditar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Falha ao modificar contato!", "Falha!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Contatos contatos = new Contatos();
            contatos.id = Idselecionado;
            // Confirmar a exclusão:
            var r = MessageBox.Show("Tem certeza que deseja remover?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Apagar:
                if (contatos.Apagar() == true)
                {
                    MessageBox.Show("Usuário removido!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Atualizar o dgv:
                    dvgEdicao.DataSource = contatos.ListarTudo();
                    // Limpar os campos de edição:
                    TxbEmailEdit.Clear();
                   txbNomeEdit.Clear();
                    txbTellEdit.Clear();
                   
                   
                    // Desabilitar os grbs:
                    grbEditar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Falha ao remover contato!", "Falha!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dvgEdicao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obter a linha:
            int linhaselecionada = dvgEdicao.CurrentCell.RowIndex;

            //Armazenar os dados da linha selecionada:
            var linha = dvgEdicao.Rows[linhaselecionada];

            txbNomeEdi.Text = linha.Cells[1].Value.ToString();
             txbEmailEdi.Text = linha.Cells[2].Value.ToString();
            txbTellEdit.Text = linha.Cells[3].Value.ToString();
           



            //Armazenar ID selecionado na variavel global:
            Idselecionado = (int)linha.Cells[0].Value;
        }

        private void Edicao_Load(object sender, EventArgs e)
        {

        }

        private void dtpAniversario_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txbTelCadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void dvgEdicao_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Obter a linha:
            int linhaselecionada = dvgEdicao.CurrentCell.RowIndex;

            //Armazenar os dados da linha selecionada:
            var linha = dvgEdicao.Rows[linhaselecionada];

            txbNomeEdit.Text = linha.Cells[1].Value.ToString();
            TxbEmailEdit.Text = linha.Cells[2].Value.ToString();
            txbTellEdit.Text = linha.Cells[3].Value.ToString();
           


            //Armazenar ID selecionado na variavel global:
            Idselecionado = (int)linha.Cells[0].Value;
        }
    }
    }




       