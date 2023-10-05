using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoCadastroDeClientes.Models
{
    public static class Estados
    {
        public static string Acre = "Acre";
        public static string Alagoas = "Alagoas";
        public static string Amapá = "Amapá";
        public static string Amazonas = "Amazonas";
        public static string Bahia = "Bahia";
        public static string Ceará = "Ceará";
        public static string EspíritoSanto = "Espírito Santo";
        public static string Goiás = "Goiás";
        public static string Maranhão = "Maranhão";
        public static string MatoGrosso = "Mato Grosso";
        public static string MatoGrossoDoSul = "Mato Grosso do Sul";
        public static string MinasGerais = "Minas Gerais";
        public static string Pará = "Pará";
        public static string Paraíba = "Paraíba";
        public static string Paraná = "Paraná";
        public static string Pernambuco = "Pernambuco";
        public static string Piauí = "Piauí";
        public static string RioDeJaneiro = "Rio de Janeiro";
        public static string RioGrandeDoNorte = "Rio Grande do Norte";
        public static string RioGrandeDoSul = "Rio Grande do Sul";
        public static string Rondônia = "Rondônia";
        public static string Roraima = "Roraima";
        public static string SantaCatarina = "Santa Catarina";
        public static string SãoPaulo = "São Paulo";
        public static string Sergipe = "Sergipe";
        public static string Tocantins = "Tocantins";

        public static List<string> GetEstados()
        {
            List<string> estados = new List<string>();
            Type tipoEstados = typeof(Estados);
            FieldInfo[] campos = tipoEstados.GetFields(BindingFlags.Public | BindingFlags.Static);
             
            foreach (FieldInfo campo in campos)
            {
               estados.Add(campo.GetValue(null) as string);
    
            }


            return estados;
        }
    }

}
