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
                var dateObject = new Date(2025, 2, 5);
                /*Tarea para ingresar los datos por consola
                 * Console.WriteLine("Ingresar el año");
                 * Console.ReadLine(year);*/
                
                //Comando para leer
                Console.WriteLine(dateObject.ToString());

                Console.WriteLine("");
                
                //Creación del objeto de tipo SalaruEmployee
                SalaryEmployee salaryEmployeeObject = new SalaryEmployee();

                salaryEmployeeObject.FirstName = "MARÍA";
                salaryEmployeeObject.Salary = 1600000;
                
                //Definición de valores para poder mostrar
                Console.WriteLine(salaryEmployeeObject.ToString());

                Console.WriteLine("");

            }
            //El cath controla la excepción y recibe la clase ex
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
