using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEndereco.Model
{
    public class Endereco
    {
        public string? Logradouro { get; private set; }
        public string? Numero { get; private set; }

        public Endereco(string endereco) 
        {
            string[] arrEndereco = endereco.Split(' ');
            Logradouro = arrEndereco[0];
            Numero = arrEndereco[1];

        }

    }
}
