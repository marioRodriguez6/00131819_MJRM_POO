using System;

namespace Labo06_Promedio
{
    public class WrongInputException : Exception
    {
        public WrongInputException (String msg)
            :base(msg)
        {
            
        }
    }
}