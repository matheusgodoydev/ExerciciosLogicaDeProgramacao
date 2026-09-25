namespace ExerciciosLogicaDeProgramacao.Exercicios
{
    public class Exercicio1035
    {
        /* Teste de Seleção 1 - 1035

        Leia 4 números inteiros A, B, C e D.
        Então, se B for maior que C e D for maior que A, 
        e se a soma de C e D for maior que a soma de A e B, 
        e se C e D forem valores positivos e se A for par, 
        escreva a mensagem “Valores aceitos”. 
        
        Caso contrário, escreva a mensagem “Valores não aceitos”.

        Exemplos de entrada e saída:

        Entrada: 5 6 7 8
        Saída: Valores nao aceitos

        Entrada: 2 3 2 6
        Saída: Valores aceitos

        */

        public string Processar(int numA, int numB, int numC, int numD)
        {
            if (
                (numB > numC) &&
                (numD > numA) &&
                ((numC + numD) > (numA + numB)) &&
                (numC > 0) &&
                (numD > 0) &&
                (numA % 2 == 0)
            )
                return "Valores aceitos";
            else
                return "Valores não aceitos";
        }
    }
}
