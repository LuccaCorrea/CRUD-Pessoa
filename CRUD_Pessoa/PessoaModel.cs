using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Pessoa
{
    public class PessoaModel
    {
        public int ClientId { get; set; }
        public string Nome { get; set; }
        public decimal Renda { get; set; }
        public int Cpf { get; set; }
        public string Data { get; set; }
    }    

}
