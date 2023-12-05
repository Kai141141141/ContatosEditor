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
        public Edicao() {
        InitializeComponent();
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
            contatos.telefone = int.Parse(txbTelCadastro.ToString());
            contatos.data_aniversario = DateTime.Parse(txbDataCadastro.Text);

            if (contatos.Cadastrar() == true)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
                // Limpar os campos:
                txbNomeCad.Clear();
                txbEmailcadastronovo.Clear();
                txbTelCadas.Clear();
                txbDataCadastro.Clear();
                // Atualizar o dgv:
                dataGridView1.DataSource = contatos.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar usuário!");
            }
        }

        

        private void BtnEditarr_Click(object sender, EventArgs e)
        {
            Contatos contatos = new Contatos();

            // Obter os valores dos txbs:

            contatos.Nome = txbNomeEdi.Text;
            contatos.email = txbEmailEdi.Text;
            contatos.telefone = int.Parse(txbTellEdit.Text);
            

            // Editar:
            if (contatos.Modificar() == true)
            {
                MessageBox.Show("Usuário modificado!", "Sucesso!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                // Atualizar o dgv:
                dataGridView1.DataSource = contatos.ListarTudo();
                // Limpar os campos de edição:
                txbEmailEdi.Clear();
                txbNomeEdi.Clear();
               txbTellEdit.Clear();
                // Desabilitar os grbs:
                grbEditar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Falha ao modificar usuário!", "Falha!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Contatos contatos = new Contatos();
           
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
                    dataGridView1.DataSource = contatos.ListarTudo();
                    // Limpar os campos de edição:
                    txbEmailEdi.Clear();
                    txbNomeEdi.Clear();
                    txbTellEdit.Clear();
                   
                   
                    // Desabilitar os grbs:
                    grbEditar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Falha ao remover usuário!", "Falha!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    }




       