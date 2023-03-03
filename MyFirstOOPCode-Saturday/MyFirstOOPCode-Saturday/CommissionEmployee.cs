using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MyFirstOOPCode_Saturday
{
    public class CommissionEmployee : Employee
    {
        #region Properties

        public double CommissionPercentage { get; set; }

        public decimal Sales { get; set; }

        #endregion

        #region Methods
        public override decimal GetValueToPay()//Implementación clase abstracta
        {
            return Sales * (decimal)CommissionPercentage; 
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Commission Percentage.....{CommissionPercentage:P2}\n\t" +
                $"Sales.....................{Sales:C2}$\"" +
                $"Value to Pay..............{GetValueToPay():C2}";
        }

        #endregion
    }
}
