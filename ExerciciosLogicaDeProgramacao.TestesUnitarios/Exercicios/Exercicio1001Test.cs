using ExerciciosLogicaDeProgramacao.Exercicios;
using FluentAssertions;

namespace ExerciciosLogicaDeProgramacao.TestesUnitarios
{
    [TestClass]
    public class Exercicio1001Test
    {
        private Exercicio1001 _exercicio1001;

        [TestInitialize]
        public void Setup()
        {
            _exercicio1001 = new Exercicio1001();
        }

        [TestMethod]
        public void AoProcessarDeveRetornarASomaDosDoisNumeros()
        {
            var numA = 10;
            var numB = 5;

            var resultado = _exercicio1001.Processar(numA, numB);

            resultado
                .Should()
                .Be("X = 15");
        }
    }
}
