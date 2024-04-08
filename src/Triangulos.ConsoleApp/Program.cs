namespace Aula_21_O.Objetos_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atividade caracterizador triangulos, Academia do Programador!\n");

            triangulos novoTriangulo = new triangulos();

            novoTriangulo.arestaA = inputValor<double>("Digite o tamanho da primeira aresta: ");
            novoTriangulo.arestaB = inputValor<double>("Digite o tamanho da segunda aresta: ");
            novoTriangulo.arestaC = inputValor<double>("Digite o tamanho da terceira aresta: ");

            novoTriangulo.calculoTriangulo();
            novoTriangulo.caracterizaTriangulo();

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

                double calculoVolume = arestaA * arestaB * arestaC;

                double calculoArea = arestaA * arestaB;
                Console.WriteLine($"A área do triangulo é: {calculoArea}cm²");
                Console.WriteLine($"O volume do triangulo é: {calculoVolume}cm³");
            }

            public void caracterizaTriangulo()
            {

                string definicaoTriangulo = "";

                if ((arestaA + arestaB) < arestaC || (arestaB + arestaC) < arestaA || (arestaC + arestaA) < arestaB)
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

                Console.WriteLine($"O tringulo é caracterizado como: Triangulo {definicaoTriangulo}");
            }


        }


        #endregion
    }
}
