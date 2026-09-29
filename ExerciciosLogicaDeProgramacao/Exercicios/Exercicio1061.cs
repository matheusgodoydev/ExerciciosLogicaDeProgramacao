namespace ExerciciosLogicaDeProgramacao.Exercicios
{
    public class Exercicio1061
    {
        public string Processar(
            int diaInicio,
            int horaInicio,
            int minInicio,
            int segInicio,
            int diaFim,
            int horaFim,
            int minFim,
            int segFim)
        {
            if (
                (diaInicio < 1 || diaInicio > 28) ||
                (diaFim < 1 || diaFim > 28) ||
                (horaInicio < 0 || horaInicio > 23) ||
                (horaFim < 0 || horaFim > 23) ||
                (minInicio < 0 || minInicio > 59) ||
                (minFim < 0 || minFim > 59) ||
                (segInicio < 0 || segInicio > 59) ||
                (segFim < 0 || segFim > 59)
            )
            {
                return "Data inválida";
            }

            DateTime dataInicio = new DateTime(2000, 1, diaInicio, horaInicio, minInicio, segInicio);
            DateTime dataFim = new DateTime(2000, 1, diaFim, horaFim, minFim, segFim);

            if (dataFim <= dataInicio)
                return "A data fim não deve ser menor que a data de inicio";

            TimeSpan diferenca = dataFim - dataInicio;

            return $"{diferenca.Days} dia(s)\r\n" +
                   $"{diferenca.Hours} hora(s)\r\n" +
                   $"{diferenca.Minutes} minuto(s)\r\n" +
                   $"{diferenca.Seconds} segundo(s)";
        }
    }
}