namespace ExerciciosLogicaDeProgramacao.Exercicios
{
    public class Exercicio1002
    {
        /* Área de um círculo - 1002

        Leia a entrada como um valor de ponto flutuante (dupla precisão), que é a variável R.

        Calcule a área do círculo usando a fórmula:
        A = π * R²

        Considere π = 3,14159.

        Imprima "A=" seguido do resultado com 4 casas decimais.

        Exemplos de entrada e saída:

        Entrada: 2,00
        Saída: A=12,5664

        Entrada: 100,64
        Saída: A=31819,3103

        Entrada: 150,00
        Saída: A=70685,7750

        */

        public string Processar(double raio)
        {
            double pi = 3.14159;
            double area = pi * Math.Pow(raio, 2);

            return $"A={area:F4}";
        }
    }
}
