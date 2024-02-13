global using Xunit;
using DesafioEndereco.Model;

namespace DesafioEndereco.Tests
{
    public class ConversaoDeEnderecosTests
    {
        //[Fact]

        [Theory]
        [InlineData("Miritiba 339", "Miritiba")]
        [InlineData("Baba�u 500", "Baba�u")]
        [InlineData("Cambu� 804B", "Cambu�")]
        [InlineData("Rio Branco 23", "Rio Branco")]
        [InlineData("Quirino dos Santos 23 b", "Quirino dos Santos")]
        [InlineData("4, Rue de la R�publique", "Rue de la R�publique")]
        [InlineData("100 Broadway Av", "Broadway Av")]
        [InlineData("Calle Sagasta, 26", "Calle Sagasta")]
        [InlineData("Calle 44 No 1991", "Calle 44")]


        public void DeveReceberStringERetornarLogradouroFormatado(string stringEntrada, string logradouroFormatado)
        {
            //act
            Endereco endereco = new Endereco(stringEntrada);

            //assert
            Assert.Equal(logradouroFormatado, endereco.Logradouro);
        }

        [Theory]
        [InlineData("Miritiba 339", "339")]
        [InlineData("Baba�u 500", "500")]
        [InlineData("Cambu� 804B", "804B")]
        [InlineData("Rio Branco 23", "23")]
        [InlineData("Quirino dos Santos 23 b", "23 b")]
        [InlineData("4, Rue de la R�publique", "4")]
        [InlineData("100 Broadway Av", "100")]
        [InlineData("Calle Sagasta, 26", "26")]
        [InlineData("Calle 44 No 1991", "No 1991")]


        public void DeveReceberStringERetornarNumeroFormatado(string stringEntrada, string numeroFormatado)
        {
            //act
            Endereco endereco = new Endereco(stringEntrada);

            //assert
            Assert.Equal(numeroFormatado, endereco.Numero);
        }
    }
}