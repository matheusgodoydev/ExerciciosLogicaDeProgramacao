using ExerciciosLogicaDeProgramacao.Exercicios;
using FluentAssertions;

namespace ExerciciosLogicaDeProgramacao.TestesUnitarios.Exercicios
{
    [TestClass]
    public class Exercicio1035Test
    {
        private Exercicio1035 _exercicio1035;

        [TestInitialize]
        public void Setup()
        {
            _exercicio1035 = new Exercicio1035();
        }

        [TestMethod]
        public void AoProcessarDeveRetonarMensagemDeValoresNaoAceitos()
        {
            int numA = 5;
            int numB = 6;
            int numC = 7;
            int numD = 8;

            var resultado = _exercicio1035.Processar(numA, numB, numC, numD);

            resultado
                .Should()
                .Be("Valores não aceitos");
        }

        [TestMethod]
        public void AoProcessarDeveRetonarMensagemDeValoresAceitos()
        {
            int numA = 2;
            int numB = 3;
            int numC = 2;
            int numD = 6;

            var resultado = _exercicio1035.Processar(numA, numB, numC, numD);

            resultado
                .Should()
                .Be("Valores aceitos");
        }
    }
}
