using ExerciciosLogicaDeProgramacao.Exercicios;
using FluentAssertions;

namespace ExerciciosLogicaDeProgramacao.TestesUnitarios.Exercicios
{
    [TestClass]
    public class Exercicio1002Test
    {
        private Exercicio1002 _exercicio1002;

        [TestInitialize]
        public void Setup()
        {
            _exercicio1002 = new Exercicio1002();
        }

        [TestMethod]
        public void AoProcessarDeveRetornarValorDaAreaDoCirculo()
        {
            double raio = 100.64;

            var resultado = _exercicio1002.Processar(raio);

            resultado
                .Should()
                .Be("A=31819,3103");
        }
    }
}
