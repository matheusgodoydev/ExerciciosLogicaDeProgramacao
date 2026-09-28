using ExerciciosLogicaDeProgramacao.Exercicios;
using FluentAssertions;

namespace ExerciciosLogicaDeProgramacao.TestesUnitarios.Exercicios
{
    [TestClass]
    public class Exercicio1047Test
    {
        private Exercicio1047 _exercicio1047;

        [TestInitialize]
        public void Setup()
        {
            _exercicio1047 = new Exercicio1047();
        }

        [TestMethod]
        [DataRow(24, 30, 10, 30)]
        [DataRow(10, 60, 10, 30)]
        [DataRow(10, 30, 24, 30)]
        [DataRow(10, 30, 10, 60)]
        public void AoProcessarDeveValidarHoraEMinutoInvalidos(int horaInicial, int minutoInicual, int horaFinal, int minutoFinal)
        {
            var resultado = _exercicio1047.Processar(horaInicial, minutoInicual, horaFinal, minutoFinal);

            resultado
                .Should()
                .Be("HORARIO INVALIDO");
        }

        [TestMethod]
        public void AoProcessarDeveAtenderCondicao1()
        {
            int horaInicial = 7;
            int minutoInicual = 8;

            int horaFinal = 9;
            int minutoFinal = 10;

            var resultado = _exercicio1047.Processar(horaInicial, minutoInicual, horaFinal, minutoFinal);

            resultado
                .Should()
                .Be("O JOGO DUROU 2 HORA(S) E 2 MINUTO(S)");
        }

        [TestMethod]
        public void AoProcessarDeveAtenderCondicao2()
        {
            int horaInicial = 7;
            int minutoInicual = 7;

            int horaFinal = 7;
            int minutoFinal = 7;

            var resultado = _exercicio1047.Processar(horaInicial, minutoInicual, horaFinal, minutoFinal);

            resultado
                .Should()
                .Be("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
        }

        [TestMethod]
        public void AoProcessarDeveAtenderCondicao3()
        {
            int horaInicial = 7;
            int minutoInicual = 10;

            int horaFinal = 8;
            int minutoFinal = 9;

            var resultado = _exercicio1047.Processar(horaInicial, minutoInicual, horaFinal, minutoFinal);

            resultado
                .Should()
                .Be("O JOGO DUROU 0 HORA(S) E 59 MINUTO(S)");
        }
    }
}
