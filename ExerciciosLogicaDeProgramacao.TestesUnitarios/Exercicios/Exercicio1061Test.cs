using ExerciciosLogicaDeProgramacao.Exercicios;
using FluentAssertions;

namespace ExerciciosLogicaDeProgramacao.TestesUnitarios.Exercicios
{
    [TestClass]
    public class Exercicio1061Test
    {
        private Exercicio1061 _exercicio1061;

        [TestInitialize]
        public void Setup()
        {
            _exercicio1061 = new Exercicio1061();
        }

        [TestMethod]
        [DataRow(45, 8, 12, 23, 9, 6, 13, 23, "Data inválida")]
        [DataRow(5, 8, 12, 23, 1, 6, 13, 23, "A data fim não deve ser menor que a data de inicio")]
        [DataRow(5,8,12,23,9,6,13,23,"3 dia(s)\r\n22 hora(s)\r\n1 minuto(s)\r\n0 segundo(s)")]
        public void AoProcessarDeveAtenderCondicao(
            int diaInicio,
            int horaInicio,
            int minInicio,
            int segInicio,
            int diaFim,
            int horaFim,
            int minFim,
            int segFim,
            string condicao)
        {
            var resultado = _exercicio1061.Processar(diaInicio, horaInicio, minInicio, segInicio, diaFim, horaFim, minFim, segFim);

            resultado
                .Should()
                .Be(condicao);
        }
    }
}
