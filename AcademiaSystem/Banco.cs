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
            conexao = new SQLiteConnection("Data Source =" + Globais.caminhoBanco + Globais.nomeBanco+"; Version = 3;Mode = ReadWrite; new= false;Compress = true;SQLiteJournalModeEnum Mode=off");
            conexao.Open();
            return conexao;
        }

        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_usuarios";
                adapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                adapter.Fill(dt);
                vcon.Close();
                return dt;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static DataTable Dql(string sql)
        {
            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                adapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                adapter.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Dml(string sql, string msgOK = null, string msgERRO = null)
        {
            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                adapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

                if(msgOK != null)
                    MessageBox.Show(msgOK);
                
            }
            catch (Exception ex)
            {
                if (msgERRO != null)
                    MessageBox.Show(msgERRO + "\n" + ex.Message);

                throw ex;
            }
        }
        //F_GestaoUsuarios
        public static DataTable ObterUsuariosIdNome()
        {
            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT N_IDUSUARIO as 'ID Usuário', T_NOMEUSUARIO as 'Nome Usuário' FROM tb_usuarios";
                adapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                adapter.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static DataTable ObterDadosUsuario(string id)
        {
            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_usuarios WHERE N_IDUSUARIO ="+id;
                adapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                adapter.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void AtualizarUsuario(Usuario usuario)
        {
            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_usuarios SET T_NOMEUSUARIO = '"+usuario.nome+"', T_USERNAME = '"+usuario.username+"', T_SENHAUSUARIO = '"+usuario.senha+"', T_STATUSUSUARIO = '"+usuario.status+"', N_NIVELUSUARIO = "+usuario.nivel+" WHERE N_IDUSUARIO = "+usuario.id+"";
                adapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void DeletarUsuario(string id)
        {
            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_usuarios WHERE N_IDUSUARIO =" + id;
                adapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //F_GestaoUsuarios - fim

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
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_usuarios (T_NOMEUSUARIO, T_USERNAME, T_SENHAUSUARIO, T_STATUSUSUARIO, N_NIVELUSUARIO) VALUES (@nome, @username, @senha, @status, @nivel)";
                cmd.Parameters.AddWithValue("@nome", usuario.nome);
                cmd.Parameters.AddWithValue("@username", usuario.username);
                cmd.Parameters.AddWithValue("@senha", usuario.senha);
                cmd.Parameters.AddWithValue("@status", usuario.status);
                cmd.Parameters.AddWithValue("@nivel", usuario.nivel);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo Usuário cadastrado com sucesso!");
                vcon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao cadastrar novo usuario");
                
            }
        }

        //F_NovoUsuario fim

        public static bool ValidarUsername(Usuario usuario)
        {
            bool valid;
            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = $"SELECT T_USERNAME FROM tb_usuarios WHERE T_USERNAME = '{usuario.username}'";
            adapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
            adapter.Fill(dt);
            
            if(dt.Rows.Count > 0)
            {
                valid = true;
            }
            else
            {
                valid = false;
            }
            vcon.Close();
            return valid;
        }
    }
}
