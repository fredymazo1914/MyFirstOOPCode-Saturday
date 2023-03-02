﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstOOPCode_Saturday
{
    public abstract class Employee
    {
        #region Properties

        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }
        #endregion

        #region Methods

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            //Salto de línea \n\t
            return $"********EMPLOYEE********\n\t " +
                $"ID:...............{Id} \n\t " +
                $"First Name:.......{FirstName} \n\t " +
                $"LastName:.........{LastName} \n\t " +
                $"Birth Date:.......{BirthDate} \n\t " +
                $"Hiring Date:......{HiringDate} \n\t " +
                $"Is Active?........{IsActive}";
            
        }
        #endregion
    }
}
