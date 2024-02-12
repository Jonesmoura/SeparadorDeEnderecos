global using Xunit;
using DesafioEndereco.Model;

namespace DesafioEndereco.Tests
{
    public class ConversaoDeEnderecosTests
    {
        //[Fact]

        [Theory]
        [InlineData("Miritiba 339","Miritiba")]
        [InlineData("Baba�u 500", "Baba�u")]
        [InlineData("Cambu� 804B", "Cambu�")]

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


        public void DeveReceberStringERetornarNumeroFormatado(string stringEntrada, string numeroFormatado)
        {
            //act
            Endereco endereco = new Endereco(stringEntrada);

            //assert
            Assert.Equal(numeroFormatado, endereco.Numero);
        }
    }
}