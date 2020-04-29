using System;

namespace Labo06_Promedio
{
    public class Evaluacion
    {
        protected string Name;
        protected int Percentage;

        public Evaluacion(int percentage, string name)
        {
            Percentage = percentage;
            Name = name;
        }

        public int Percentage1 => Percentage;

        public string Name1 => Name;

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Percentage)}: {Percentage}";
        }
    }
}