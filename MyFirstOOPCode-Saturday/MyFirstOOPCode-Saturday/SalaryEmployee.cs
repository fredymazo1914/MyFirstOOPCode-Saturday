using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstOOPCode_Saturday
{
    public class SalaryEmployee : Employee //Con :Employee se genera una herencia a la clase SalaryEmployee
    {
        #region Properties
        public decimal Salary { get; set; }

        #endregion

        
        #region Methods
        
        //Sobrescritura de un método abstracto
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            //base significa la clase base o padre y podemos heredar todo lo que tiene
            return $"{base.ToString()}" +
                $"Value to pay..........{GetValueToPay()}";
        }


        #endregion



    }
}
