using System;

namespace Labo06_Promedio
{
    public class MoreThanTenException : Exception
    {
        public MoreThanTenException (String msg)
                :base(msg)
            {
            
            }
    }    
}
