using System;

namespace Labo06_Promedio
{
    public class Evaluacion
    {

        protected int Percentage;
        protected String Name;

        public Evaluacion(int percentage, string name) {
            Percentage = percentage;
            Name = name;
        }
        
        public int Percentage1 => Percentage;

        public string Name1 => Name;
    }
}