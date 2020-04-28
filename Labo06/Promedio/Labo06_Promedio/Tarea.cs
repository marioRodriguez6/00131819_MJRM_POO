using System;
using System.Data;
using Microsoft.VisualBasic;

namespace Labo06_Promedio
{
    public class Tarea : Evaluacion {
        
        private DateTime fechaEntrega;

        public Tarea(int percentage, string name, DateTime fechaEntrega) : base(percentage, name)
        {
            this.fechaEntrega = fechaEntrega;
        }
    }
}