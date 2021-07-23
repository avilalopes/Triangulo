using System; 
class minhaClasse {

    static void Main(string[] args) { 

            double a, b, c, perimetro, area;
            Console.WriteLine("Informe 3 valores:");
            string[] valor = Console.ReadLine().Split();
            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);

            if((a + b > c) && (a + c > b) && (b + c > a)) //complete a condicional
            {
                perimetro = a + b + c;
                Console.WriteLine("Perimetro = {0:0.0}", perimetro); //complete a saida
            }
            else
            {
                area = ((a + b)*c)/2;
                Console.WriteLine("Area = {0:0.0}", area); //complete a saida
            }
    }

}