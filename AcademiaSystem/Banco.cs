using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AcademiaSystem
{
    internal class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source = D:\\REPOSITÓRIO\\SistemaDeAcademia\\AcademiaSystem\\BD\\bd_academia.db");
            conexao.Open();
            return conexao;
        }

        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_usuarios";
                    adapter = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    adapter.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }

        }
        public static DataTable Consulta(string sql)
        {
            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    adapter = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    adapter.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }

        //F_NovoUsuario
        public static void NovoUsuario(Usuario usuario)
        {
           if(ValidarUsername(usuario))
            {
                MessageBox.Show("Username já existe");
                return;
            }

            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO tb_usuarios (T_NOMEUSUARIO, T_USERNAME, T_SENHAUSUARIO, T_STATUSUSUARIO, N_NIVELUSUARIO) VALUES (@nome, @username, @senha, @status, @nivel)";
                cmd.Parameters.AddWithValue("@nome", usuario.nome);
                cmd.Parameters.AddWithValue("@username", usuario.username);
                cmd.Parameters.AddWithValue("@senha", usuario.senha);
                cmd.Parameters.AddWithValue("@status", usuario.status);
                cmd.Parameters.AddWithValue("@nivel", usuario.nivel);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo Usuário cadastrado com sucesso!");
                ConexaoBanco().Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao cadastrar novo usuario");
                ConexaoBanco().Close();
            }
        }

        //F_NovoUsuario fim

        public static bool ValidarUsername(Usuario usuario)
        {
            bool valid;
            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = $"SELECT T_USERNAME FROM tb_usuarios WHERE T_USERNAME = '{usuario.username}'";
            adapter = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
            adapter.Fill(dt);
            
            if(dt.Rows.Count > 0)
            {
                valid = true;
            }
            else
            {
                valid = false;
            }

            return valid;
        }
    }
}
