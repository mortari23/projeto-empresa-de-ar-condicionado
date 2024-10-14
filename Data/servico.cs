using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class servico
    {
        public int servicoID {  get; set; } 
        public int clienteID { get; set; }
        public int funcionarioID {  get; set; }
        public DateTime data_servico { get; set; }
        public decimal valor_servico { get; set; }
        public string descricao_servico { get; set; }
        public string descricao_contrato { get; set; }
        public decimal valor_contrato{ get; set; }
        public string tipo_contrato { get; set; }

    }
}
