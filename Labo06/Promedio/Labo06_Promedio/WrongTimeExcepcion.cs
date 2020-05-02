using System;

namespace Labo06_Promedio
{
    public class WrongTimeExcepcion : Exception
    {
        public WrongTimeExcepcion(String msg)
            : base(msg)
        {

        }
    }
}