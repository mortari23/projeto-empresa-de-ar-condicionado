using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class contrato
    {
        public int contratoID { get; set; }
        public int? clienteID { get; set; }
        public string descricao_contrato { get; set; }
        public decimal? valor_contrato { get; set; }
        public string tipo_contrato { get; set; }
        public DateTime? data_contrato { get; set; }
        public DateTime? final_contrato { get; set; }
    }
}
