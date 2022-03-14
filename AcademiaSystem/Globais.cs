using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaSystem
{
    class Globais
    {
        public static string versao = "1.0";
        public static bool logado = false;
        public static int nivel = 0;
        // public static string caminho = System.Environment.CurrentDirectory;
        public static string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string nomeBanco = "bd_academia.db";
        public static string caminhoBanco = caminho+@"\BD\";
        public static string caminhoFotos = caminho + @"\foto\";
    }
}
