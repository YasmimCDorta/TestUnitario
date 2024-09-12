using CalculadoraExemplo;

namespace Caculadora.Teste
{
    public class CalculadoraTeste
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(5, CalculadoraExemplo.Calculadora.Somar(2, 3));
        }

        [Fact]
        public void Subtrair()
        {
            Assert.Equal(3, CalculadoraExemplo.Calculadora.Subtrair(6, 3));
        }

        [Fact]
        public void Dividir()
        {
            Assert.Equal(5, CalculadoraExemplo.Calculadora.Dividir(10, 2));
        }

        [Fact]
        public void Mutiplicar()
        {
            Assert.Equal(8, CalculadoraExemplo.Calculadora.Mutiplicar(2, 4));
        }
    }
}