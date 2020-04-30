using System;

namespace Labo06_Promedio
{
    public class NegativeInputException : Exception
    {
        public NegativeInputException(String msg)
                :base(msg)
        {
            
        }
    }
}