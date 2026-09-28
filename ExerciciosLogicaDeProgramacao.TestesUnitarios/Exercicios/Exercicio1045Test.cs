using ExerciciosLogicaDeProgramacao.Exercicios;
using FluentAssertions;

namespace ExerciciosLogicaDeProgramacao.TestesUnitarios.Exercicios
{
    [TestClass]
    public class Exercicio1045Test
    {
        private Exercicio1045 _exercicio1045;

        [TestInitialize]
        public void Setup()
        {
            _exercicio1045 = new Exercicio1045();
        }

        [TestMethod]
        public void AoProcessarDeveAtenderCondicao1()
        {
            double numA = 7.0;
            double numB = 5.0;
            double numC = 7.0;

            var resultado = _exercicio1045.Processar(numA, numB, numC);

            resultado
                .Should()
                .Be("TRIANGULO ACUTANGULO\nTRIANGULO ISOSCELES");
        }

        [TestMethod]
        public void AoProcessarDeveAtenderCondicao2()
        {
            double numA = 6.0;
            double numB = 6.0;
            double numC = 10.0;

            var resultado = _exercicio1045.Processar(numA, numB, numC);

            resultado
                .Should()
                .Be("TRIANGULO OBTUSANGULO\nTRIANGULO ISOSCELES");
        }

        [TestMethod]
        public void AoProcessarDeveAtenderCondicao3()
        {
            double numA = 6.0;
            double numB = 6.0;
            double numC = 6.0;

            var resultado = _exercicio1045.Processar(numA, numB, numC);

            resultado
                .Should()
                .Be("TRIANGULO ACUTANGULO\nTRIANGULO EQUILATERO");
        }

        [TestMethod]
        public void AoProcessarDeveAtenderCondicao4()
        {
            double numA = 5.0;
            double numB = 7.0;
            double numC = 2.0;

            var resultado = _exercicio1045.Processar(numA, numB, numC);

            resultado
                .Should()
                .Be("NAO FORMA TRIANGULO");
        }

        [TestMethod]
        public void AoProcessarDeveAtenderCondicao5()
        {
            double numA = 6.0;
            double numB = 8.0;
            double numC = 10.0;

            var resultado = _exercicio1045.Processar(numA, numB, numC);

            resultado
                .Should()
                .Be("TRIANGULO RETANGULO");
        }
    }
}
