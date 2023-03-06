using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Titular
{
    public class Cliente
    {
        //essas sao propriedades publicas q vao manipular campos privados
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

    }
}
