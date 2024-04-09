namespace Aula_21_O.Objetos_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atividade caracterizador triangulos, Academia do Programador!\n");

            triangulos trianguloDoDesafio = new triangulos();

            trianguloDoDesafio.arestaA = 5;
            trianguloDoDesafio.arestaB = 5;
            trianguloDoDesafio.arestaC = 3;

            trianguloDoDesafio.calculoTriangulo();
            trianguloDoDesafio.caracterizaTriangulo();
            Console.WriteLine("\n\n\n");
            triangulos meuTriangulo = new triangulos();

            meuTriangulo.arestaA = inputValor<double>("Digite o tamanho da primeira aresta: ");
            meuTriangulo.arestaB = inputValor<double>("Digite o tamanho da segunda aresta: ");
            meuTriangulo.arestaC = inputValor<double>("Digite o tamanho da terceira aresta: ");

            meuTriangulo.calculoTriangulo();
            meuTriangulo.caracterizaTriangulo();

        }

        #region Métodos

        public static TipagemDinamica inputValor<TipagemDinamica>(string texto)
        {
            Console.WriteLine(texto);

            string input = Console.ReadLine();

            try
            {
                return (TipagemDinamica)Convert.ChangeType(input, typeof(TipagemDinamica));
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato inválido!");
                return inputValor<TipagemDinamica>(texto);
            }
        }
        #endregion

        #region Objetos
        public class triangulos
        {

            public double arestaA;
            public double arestaB;
            public double arestaC;
            public void calculoTriangulo()
            {

                double calculoVolume = ((arestaA * 2) * arestaB * arestaC) / 2;
                double calculoVolumeAbs = Math.Abs(calculoVolume);

                double calculoArea = arestaA * arestaB;
                Console.WriteLine($"A área do triangulo é: {calculoArea:N0}cm²");
                Console.WriteLine($"O volume do triangulo é: {calculoVolumeAbs:N0}cm³");
            }

            public void caracterizaTriangulo()
            {
                string definicaoTriangulo;

                if ((arestaA + arestaB) < arestaC || (arestaB + arestaC) < arestaA || (arestaC + arestaA) < arestaB)
                {
                    Console.WriteLine($"O triangulo é inválido!");
                }
                else
                {
                    if (arestaA != arestaB && arestaB != arestaC)
                    {

                        definicaoTriangulo = "Escaleno";

                    }
                    else if (arestaA == arestaB && arestaB != arestaC || arestaB == arestaC && arestaC != arestaA || arestaC == arestaA && arestaA != arestaB)
                    {
                        definicaoTriangulo = "Isóceles";
                    }
                    else
                    {
                        definicaoTriangulo = "equilátero";
                    }

                    Console.WriteLine($"O triangulo é caracterizado como: Triangulo {definicaoTriangulo}");
                }
            }

        }


        #endregion
    }
}
