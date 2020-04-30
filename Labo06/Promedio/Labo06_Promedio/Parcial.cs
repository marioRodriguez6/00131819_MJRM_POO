namespace Labo06_Promedio
{
    public class Parcial : Evaluacion
    {

        private int cantPreguntas;

        public Parcial(int percentage, string name, int cantPreguntas) : base(percentage, name)
        {
            this.cantPreguntas = cantPreguntas;
        }

        public override string ToString()
        {
            return $"\n Parcial/ {nameof(Name)}: {Name}, {nameof(Percentage)}: {Percentage}, {nameof(cantPreguntas)}: {cantPreguntas}";
        }

        public override int CantPreguntas => cantPreguntas;

        public string Name2 => Name;

        public int Percentage2 => Percentage;
    }
}