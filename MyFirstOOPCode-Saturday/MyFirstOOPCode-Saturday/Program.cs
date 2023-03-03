using System;

namespace MyFirstOOPCode_Saturday
{
    public class Program
    {
        private static object commissionEmployee;

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
                Employee salaryEmployee = new SalaryEmployee()
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
                Console.WriteLine(salaryEmployee.ToString());

                Console.WriteLine("");
                                
                Console.WriteLine("Type your ID: ");
                int id = Convert.ToInt32(Console.ReadLine());//Conversión de dato con Convert.ToInt32

                Console.WriteLine("Type your first name: ");
                string firstName = Console.ReadLine();

                Console.WriteLine("Type your last name: ");
                string lastName = Console.ReadLine();

                Console.WriteLine("Are you active?: ");
                bool isActive = Convert.ToBoolean (Console.ReadLine());

                //Creación del objeto
                Employee commissionEmployeeObject = new CommissionEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = dateObjectBirthDate,
                    HiringDate = dateObjectHiringDate,
                    IsActive = isActive
                };

                Console.WriteLine(commissionEmployee.ToString());

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
