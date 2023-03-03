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
                var dateObjectBirthDate = new Date(1920, 2, 8);
                var dateObjectHiringDate = new Date(2023, 1, 1);
                /*Tarea para ingresar los datos por consola
                 * Console.WriteLine("Ingresar el año");
                 * Console.ReadLine(year);*/

                //Comando para leer
                //Console.WriteLine(dateObject.ToString());

                Console.WriteLine("");
                
                //Creación del objeto de tipo SalaryEmployee
                Employee salaryEmployeeObject = new SalaryEmployee()
                {
                    Id = 1036453304,
                    FirstName = "María",
                    LastName = "Sandoval",
                    BirthDate= dateObjectBirthDate,
                    HiringDate= dateObjectHiringDate,
                    IsActive = true,
                    Salary = 1600000.56M//La M muestra decimales
                };
               
                
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
