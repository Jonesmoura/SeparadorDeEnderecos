
using System.Text.RegularExpressions;

namespace DesafioEndereco.Model
{
    public class Endereco
    {
        public string Logradouro { get; private set; } = String.Empty;
        public string Numero { get; private set; } = String.Empty;

        public Endereco(string endereco) 
        {

            if (Char.IsNumber(endereco[0]))
            {
                Regex RE = new Regex(@"\d+");
                Match theMatch = RE.Match(endereco);
                Numero = theMatch.ToString();
                Logradouro = endereco.Substring(Numero.Length).Replace(",", "").Trim();

            }
            else
            {
                Regex RE = new Regex(@"((?i)No \d+.[a-z| ]*$)|((?i)Nº \d+[a-z| ]*$)|(\d+(?i)[a-z| ]*$)", RegexOptions.RightToLeft);
                Match theMatch = RE.Match(endereco);
                Numero = theMatch.ToString();
                Logradouro = endereco.Substring(0, endereco.LastIndexOf(theMatch.ToString())).Replace(",", "").Trim();
            }

        }

    }
}
