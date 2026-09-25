namespace ExerciciosLogicaDeProgramacao.Exercicios
{
    public class Exercicio1001
    {
        /* Extremamente básico - 1001
        
        Leia duas variáveis, chamadas A e B , e some-as, atribuindo o resultado à variável X. 
        Imprima X como mostrado abaixo. 
        Imprima a linha final após o resultado; caso contrário, você receberá um erro de apresentação.

        Entrada: 10, 9
        Saída: "X = 19"

        Entrada: -10, 4
        Saída: "X = -6"  
        
        Entrada: 15, -7
        Saída: "X = 8"

        */

        public string Processar(int numA, int numB)
        {
            return $"X = {numA + numB}";
        }
    }
}
