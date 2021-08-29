using System;

namespace upn_T1_q_7
{
    class Program
    {
        static void Main(string[] args)
        {
            String diaNac, mesNac, nroMes;
            Int16 diamesNac;
            Console.WriteLine("Bienvenido a la solución de la pregunta 7:");
            Console.Write("Ingrese día de nacimiento (1,2,3,...,31): ");
            diaNac = Console.ReadLine();
            Console.Write("Ingrese día mes de nacimiento (enero, febrero, marzo, ..., diciembre): ");
            mesNac = Console.ReadLine();

            switch (mesNac)
            {
                case "enero":
                    nroMes = "01";
                    break;
                
                case "febrero":
                    nroMes = "02";
                    break;

                case "marzo":
                    nroMes = "03";
                    break;
                
                case "abril":
                    nroMes = "04";
                    break;
                
                case "mayo":
                    nroMes = "05";
                    break;
                
                case "junio":
                    nroMes = "06";
                    break;
                
                case "julio":
                    nroMes = "07";
                    break;
                
                case "agosto":
                    nroMes = "08";
                    break;
                
                case "setiembre":
                    nroMes = "09";
                    break;
                
                case "octubre":
                    nroMes = "10";
                    break;
                
                case "noviembre":
                    nroMes = "11";
                    break;
                
                default:
                    nroMes = "12";
                    break;
                       
            }

            diamesNac = Convert.ToInt16(diaNac + nroMes);
            Console.WriteLine(Convert.ToString(diamesNac));

        }
    }
}
