using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                         ___________    ");
            Console.WriteLine("               /|\\     |        b.h|   ");      /* ||Legenda|| */
            Console.WriteLine("              / | \\    | ÁREA = ---|   ");     
            Console.WriteLine("             /  |  \\   |        7.5|   ");  
            Console.WriteLine("            /   |   \\  |___________|   ");   /* Área: área do triângulo */
            Console.WriteLine("           /    |    \\                 ");  /* b: base */
            Console.WriteLine("          /     |     \\  ÁREA = 3.75   "); /* h:altura */
            Console.WriteLine("         / h= 5 |      \\               ");
            Console.WriteLine("        /       |       \\              ");
            Console.WriteLine("       /        |        \\             ");
            Console.WriteLine("      /         |         \\            ");
            Console.WriteLine("     /          |          \\           ");
            Console.WriteLine("    /___________|___________\\          ");
            Console.WriteLine("       |b= 3 |                          ");

            
            Double X = 3;
            Double Y = 5;
            Double multiplicaçãodasmedidas1 = X * Y;
            Console.WriteLine($"{X} * {Y} = {multiplicaçãodasmedidas1} | Calculo da Área |");

            Double doubleX = 15;
            Double doubleY = 2;
            Double multiplicaçãodasmedidas2 = doubleX / doubleY;
            Console.WriteLine($"{X} / {Y} = {multiplicaçãodasmedidas2} | Medida dada |");

            Double doubleX2 = 7.5;
            Double doubleY2 = 2;
            Double divisãodaArea = doubleX2 / doubleY2;
            Console.WriteLine($"{doubleX2} / {doubleY2} = {divisãodaArea} | Área do Triangulo");

                                   /* 7.5 */
                               /*---------- = 3.75*/    
                                 /* 2 */
        }
    }
}
