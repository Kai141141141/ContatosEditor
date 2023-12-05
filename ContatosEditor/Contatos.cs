using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ContatosEditor
{
    internal class Contatos
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string email { get; set; }
        public int telefone { get; set; }
        public DateTime data_aniversario { get; set; }


        public DataTable ListarTudo()
        {
            string comando = "SELECT * FROM contatos";

            ConexaoBanco conexaoBD = new ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            DataTable tabela = new DataTable();
            MySqlCommand cmd = new MySqlCommand(comando, con);


            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;


        }

        public bool Cadastrar()
        {
            string comando = "INSERT INTO contatos (nome, email, telefone, data_aniversario) " +
                "VALUES  (@nome, @email, @telefone, @data_aniversario)";
            ConexaoBanco conexaoBD = new ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@data_aniversario", data_aniversario);
            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
        public bool Apagar()
        {
            string comando = "DELETE FROM contatos WHERE id = @id";
            ConexaoBanco conexaoBD = new ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }

        public bool Modificar()
        {
            string comando = "UPDATE contatos SET nome = @nome, " +
                "email= @email, telefone = @telefone WHERE id = @id";
            ConexaoBanco conexaoBD = new ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Prepare();


            //try
            //{
            if (cmd.ExecuteNonQuery() == 0)
            {
                conexaoBD.Desconectar(con);
                return false;
            }
            else
            {
                conexaoBD.Desconectar(con);
                return true;
            }
            //}
            //    catch
            //    {
            //        conexaoBD.Desconectar(con);
            //        return false;
            //    }
        }
    }
}






   