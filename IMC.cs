using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC.IMC
{
    internal class IMC
    {
        static void Main(string[] args)
        {



           
            int Peso;
            Double Altura;
            Double IMC;
            Double PreIMC;
            dynamic Nombre;


        
            Console.WriteLine("Calculador de IMC (Indice de Masa Corporal) \n"); 
            Console.WriteLine("Oprima cualquier letra para continuar"); 
            Console.ReadKey();
            
                            


            Console.WriteLine("¿Como te llamas?"); 
            Nombre = Convert.ToString(Console.ReadLine()); 
            


            Console.WriteLine("Hola " + Nombre + ", Escribe su peso en kg:"); 
            Peso = Convert.ToInt32(Console.ReadLine()); 
           

            Console.WriteLine("Ahora escriba su altura en metros:"); 
            Altura = Convert.ToDouble(Console.ReadLine()); 
            

            
            PreIMC = Convert.ToDouble(Altura * Altura); 
            IMC = Convert.ToDouble(Peso / PreIMC); 
                                                  


            

            if (IMC > 40 && IMC < 50) 
            {
                Console.WriteLine("Mala noticia " + Nombre + "!, Padeces de obesidad morbida, Tu riesgo en salud es extremadamente alto\n");
                Console.WriteLine("Gracias por utilizar la calculadora de IMC (Indice de Masa Corporal)");
                Console.WriteLine("CC\n");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }

            else if (IMC > 35 && IMC < 40) 
            {
                Console.WriteLine("Mala noticia " + Nombre + "!, Padeces de obesidad grado 2, Tu riesgo en salud es muy alto\n");
                Console.WriteLine("Gracias por utilizar la calculadora de IMC (Indice de Masa Corporal)");
                Console.WriteLine("CC\n");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }

            else if (IMC > 30 && IMC < 35) 
            {
                Console.WriteLine("Mala noticia " + Nombre + ", Padeces de obesidad nivel 1, Tu riesgo en salud es alto\n");
                Console.WriteLine("Gracias por utilizar la calculadora de IMC (Indice de Masa Corporal)");
                Console.WriteLine(" CC\n");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }

            else if (IMC > 25 && IMC < 30)
            {
                Console.WriteLine("Intemedia noticia " + Nombre + ", Padeces de sobrepeso, Tu riesgo en salud es moderado\n");
                Console.WriteLine("Gracias por utilizar la calculadora de IMC (Indice de Masa Corporal)");
                Console.WriteLine("CC\n");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }

            else if (IMC > 20 && IMC < 25)
            {
                Console.WriteLine("Buena noticia " + Nombre + "!, Padeces de peso saludable, No corres algun riesco en tu salud\n");
                Console.WriteLine("Gracias por utilizar la calculadora de IMC (Indice de Masa Corporal)");
                Console.WriteLine("CC\n");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }

            else if (IMC > 5 && IMC < 20)
            {
                Console.WriteLine("Mala Noticia noticia " + Nombre + "!, Tu peso no es saludable, Estas muy delgado corres peligro\n");
                Console.WriteLine("Gracias por utilizar la calculadora de IMC");
                Console.WriteLine("CC\n");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Algo paso mal, Por favor asegurate seguir las instrucciones o agrega valores logicos\n");
                Console.WriteLine("CC");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }
          

        }
    }
}

