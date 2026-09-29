using ExerciciosLogicaDeProgramacao.Exercicios;
using FluentAssertions;

namespace ExerciciosLogicaDeProgramacao.TestesUnitarios.Exercicios
{
    [TestClass]
    public class Exercicio1050Test
    {
        private Exercicio1050 _exercicio1050;

        [TestInitialize]
        public void Setup()
        {
            _exercicio1050 = new Exercicio1050();
        }

        [TestMethod]
        [DataRow(61, "Brasilia")]
        [DataRow(71, "Salvador")]
        [DataRow(11, "Sao Paulo")]
        [DataRow(21, "Rio de Janeiro")]
        [DataRow(32, "Juiz de Fora")]
        [DataRow(19, "Campinas")]
        [DataRow(27, "Vitoria")]
        [DataRow(31, "Belo Horizonte")]
        [DataRow(90, "DDD não encontrado")]
        public void AoProcessarDeveAtenderCondicao(int num, string cidade)
        {
            var resultado = _exercicio1050.Processar(num);

            resultado
                .Should()
                .Be(cidade);
        }
    }
}
