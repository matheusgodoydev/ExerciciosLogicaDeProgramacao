namespace ExerciciosLogicaDeProgramacao.Exercicios
{
    public class Exercicio1045
    {
        public string Processar(double numA, double numB, double numC)
        {
            var listaNumAleatorio = new List<double> { numA, numB, numC };

            var listaNumOrdemDecrescente = listaNumAleatorio
                .OrderByDescending(x => x)
                .ToList();

            numA = listaNumOrdemDecrescente[0];
            numB = listaNumOrdemDecrescente[1];
            numC = listaNumOrdemDecrescente[2];

            var listaRespostas = new List<string>();

            if (numA >= numB + numC)
            {
                listaRespostas.Add("NAO FORMA TRIANGULO");
                return string.Join("\n", listaRespostas);
            }

            if (Math.Pow(numA, 2) == Math.Pow(numB, 2) + Math.Pow(numC, 2))
                listaRespostas.Add("TRIANGULO RETANGULO");

            if (Math.Pow(numA, 2) > Math.Pow(numB, 2) + Math.Pow(numC, 2))
                listaRespostas.Add("TRIANGULO OBTUSANGULO");

            if (Math.Pow(numA, 2) < Math.Pow(numB, 2) + Math.Pow(numC, 2))
                listaRespostas.Add("TRIANGULO ACUTANGULO");

            if (numA == numB && numA == numC)
                listaRespostas.Add("TRIANGULO EQUILATERO");

            if (
                (numA == numB && numA != numC) ||
                (numA == numC && numA != numB) ||
                (numB == numC && numB != numA)
            )
                listaRespostas.Add("TRIANGULO ISOSCELES");

            return string.Join("\n", listaRespostas);
        }
    }
}
