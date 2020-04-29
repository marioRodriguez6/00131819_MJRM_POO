using System;

namespace Labo06_Promedio
{
    public class Laboratorio : Evaluacion
    {

        private String type;

        public Laboratorio(int percentage, string name, string type) : base(percentage, name)
        {
            this.type = type;
        }

        public override string ToString()
        {
            return $"\n laboratorio/ {nameof(Name)}: {Name}, {nameof(Percentage)}: {Percentage}, {nameof(type)}: {type}";
        }


        public override int Percentage2 => Percentage;
    }
}