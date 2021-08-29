using System;

namespace upn_T1_q_7
{
    class Program
    {
        static void Main(string[] args)
        {
            String diaNac, mesNac;
            Int16 diamesNac;
            Console.WriteLine("Bienvenido a la solución de la pregunta 7:");
            Console.Write("Ingrese día de nacimiento (1,2,3,...,31): ");
            diaNac = Console.ReadLine();
            Console.Write("Ingrese día mes de nacimiento (1,2,3,...,12): ");
            mesNac = Console.ReadLine();
            diamesNac = Convert.ToInt16(diaNac + mesNac);
            Console.WriteLine("Bienvenido a la solución de la pregunta 7:");

        }
    }
}
