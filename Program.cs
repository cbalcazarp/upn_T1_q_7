using System;

namespace upn_T1_q_7
{
    class Program
    {
        static void Main(string[] args)
        {
            String diaNac, mesNac, nroMes;
            Int32 primerNum, segundoNum, resultado;
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

            primerNum = Convert.ToInt32(diaNac + nroMes);
            Console.WriteLine("Primer número es: " + Convert.ToString(primerNum));

            Console.Write("Ingrese su edad: ");
            segundoNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundo número es: " + Convert.ToString(segundoNum));

            resultado = (((primerNum * 2) + 5) * 50) + segundoNum + 365 - 615;
            Console.WriteLine("Resultado de lo siguiente \"multiplique el primer número por 2, adiciónele 5, multiplique por 50, súmele el segundo número, súmele 365 y réstele 615.\": " + Convert.ToString(resultado));
                     

        }
    }
}
