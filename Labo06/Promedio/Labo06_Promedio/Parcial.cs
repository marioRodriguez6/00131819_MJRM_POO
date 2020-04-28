namespace Labo06_Promedio
{
    public class Parcial : Evaluacion
    {

        private int cantPreguntas;

        public Parcial(int percentage, string name, int cantPreguntas) : base(percentage, name)
        {
            this.cantPreguntas = cantPreguntas;
        }
    }
}