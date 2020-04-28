using System;

namespace Labo06_Promedio
{
    public class Laboratorio : Evaluacion
    {

        private String _type;

        public Laboratorio(int percentage, string name, string type) : base(percentage, name)
        {
            this._type = type;
        }
    }
}