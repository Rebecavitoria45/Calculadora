

using calc;

namespace TestProject1
    {
        public class UnitTest1
        {

            public Calculadora construirClasse()
            {
                string data = "22/03/2024";
                Calculadora calc = new Calculadora("22/03/2024");
                return calc;
            }
            [Theory]
            [InlineData(10, 20, 30)]
            public void TestSomar(int val1, int val2, int resultado)
            {
                Calculadora calc = construirClasse();

                int resultadoCalc = calc.somar(val1, val2);

                Assert.Equal(resultado, resultadoCalc);
            }

            [Theory]
            [InlineData(3, 5, 15)]
            public void TestMult(int val1, int val2, int resultado)
            {
                Calculadora calc = construirClasse();

                int resultadoCalc = calc.multiplicar(val1, val2);

                Assert.Equal(resultado, resultadoCalc);
            }

            [Theory]
            [InlineData(20, 4, 5)]
            [InlineData(2, 2, 1)]
            public void Testdividi(int val1, int val2, int resultado)
            {
                Calculadora calc = construirClasse();

                int resultadoCalc = calc.dividir(val1, val2);

                Assert.Equal(resultado, resultadoCalc);
            }

            [Theory]
            [InlineData(5, 2, 3)]
            [InlineData(2, 1, 1)]
            public void Testsub(int val1, int val2, int resultado)
            {
                Calculadora calc = construirClasse();

                int resultadoCalc = calc.subtrair(val1, val2);

                Assert.Equal(resultado, resultadoCalc);
            }

            [Fact]
            public void TestarHistorico()
            {
                Calculadora calc = construirClasse();
                calc.somar(1, 2);
                calc.somar(2, 2);
                calc.somar(3, 2);
                calc.somar(4, 2);

                var lista = calc.historico();
                Assert.NotEmpty(lista);
                Assert.Equal(3, lista.Count);
            }

        }
    }
