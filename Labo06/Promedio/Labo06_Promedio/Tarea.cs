using System;
using System.Data;
using Microsoft.VisualBasic;

namespace Labo06_Promedio
{
    public class Tarea : Evaluacion
    {

        private DateTime fechaEntrega;

        public Tarea(int percentage, string name, DateTime fechaEntrega) : base(percentage, name)
        {
            this.fechaEntrega = fechaEntrega;
        }

        public override string ToString()
        {
            return
                $"\n Tarea/ {nameof(Name)}: {Name}, {nameof(Percentage)}: {Percentage}, {nameof(fechaEntrega)}: {fechaEntrega}";
        }

        public string Name2 => Name;

        public int Percentage2 => Percentage;
    }
}