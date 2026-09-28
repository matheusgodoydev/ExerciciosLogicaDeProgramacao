namespace ExerciciosLogicaDeProgramacao.Exercicios
{
    public class Exercicio1047
    {
        public string Processar(int horaInicial, int minutoInicial, int horaFinal, int minutoFinal)
        {
            if (
                horaInicial < 0 ||
                horaInicial > 23 ||
                horaFinal < 0 ||
                horaFinal > 23 ||
                minutoInicial < 0 ||
                minutoInicial > 59 ||
                minutoFinal < 0 ||
                minutoFinal > 59
            )
                return "HORARIO INVALIDO";

            TimeSpan inicio = new TimeSpan(0, horaInicial, minutoInicial, 0);
            TimeSpan fim = new TimeSpan(0, horaFinal, minutoFinal, 0);

            if (fim <= inicio)
            {
                fim = fim.Add(TimeSpan.FromHours(24));
            }

            TimeSpan duracao = fim - inicio;

            int horas = (int)duracao.TotalHours;
            int minutos = duracao.Minutes;

            return $"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)";
        }
    }
}
