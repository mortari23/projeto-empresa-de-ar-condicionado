using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Cliente
    {
        // Código 
        public int clienteID { get; set; }

        public string nome_cliente { get; set; }

        public string telefone_cliente { get; set; }

        public string cpf_clienete { get; set; }

        public string endereco_cliente { get; set; }

        public string gmail_cliente { get; set; }

        public string cidade_cliente { get; set; }

        public string CEP_cliente { get; set; }

        public string bairro_cliente { get; set; }

        public string numero_casa { get; set; }

        public string complemento_cliente { get; set;}


        // Public : Publico
        // String : Texto -> Varchar do banco de dados
        // Int : Inteiro
        // GET - SET : Permite Ler e atribuir valores na 'variavel'
    }
}
