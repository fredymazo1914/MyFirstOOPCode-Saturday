using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstOOPCode_Saturday
{
    public class Date
    {
        #region Fields
        
        private int _year;
        private int _month;
        private int _day;

        #endregion


        #region Methods
        //Creacíon método constructor
        public Date(int year, int month, int day)//parámetros que recibe el constructor
        {
            //asignación de los campos que llegan a las variables
            _year = ValidateYear(year);
            _month = ValidateMonth(month);//Creación de método ValidateDate que recibe parámetro 
            _day = ValidateDay(day, month, year);
        }

        private int ValidateYear(int year)
        {
            if (year >= 1900)
            {
                return year;
            }

            throw new YearException("The year is invalid!");
        }

        private int ValidateMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }
            
            throw new DayException("The month is invalid!");
        }

        private int ValidateDay(int day, int month, int year)
        {
            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }
        
            
            //Un arreglo siempre tiene la posición cero
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day >= 1 && day <= daysPerMonth[month])//Se envía como parámetro el month
            {
                return day;
            }
            throw new DayException("The day is invalid!");
                        
            /*if (month == 2 && day >= 1 && day <= 28)
            {
                return day;
            }

            else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12 && day >= 1 && day <= 31)
            {
                return day;
            }
            else if (day >= 1 && day <= 30)
            {
                return day;
            }*/
        }

        private bool IsLeapYear(int year)
        {
            bool isLeap = (year % 400 == 0 || year % 4 == 0 && year % 100 != 0 );
            
            return isLeap;
        }

        //Creación de método ToString
        public override string ToString()
        { 
            //Interpolación para concatenar $"{}"
            string date = $"{_year}/{_month}/{_day}";
            return date;
        }

        #endregion
    }
}
