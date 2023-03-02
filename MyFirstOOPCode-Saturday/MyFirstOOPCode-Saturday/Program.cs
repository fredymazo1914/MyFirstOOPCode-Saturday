using System;

namespace MyFirstOOPCode_Saturday
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Creación del objeto de la clase date
                var dateObject = new Date(2024, 2, 29);
                /*Tarea para ingresar los datos por consola
                 * Console.WriteLine("Ingresar el año");
                 * Console.ReadLine(year);*/
                
                //Comando para leer
                Console.WriteLine(dateObject.ToString());
            }
            //El cath controla la excepción y recibe la clase ex
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
