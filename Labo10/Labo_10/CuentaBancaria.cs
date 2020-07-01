namespace Labo_10
{
    public class CuentaBancaria
    {

        public readonly string _name;
        public readonly double _ActualBalance;


        public CuentaBancaria(string name = " ", double ActualBalance = 0)
        {
            _name = name;
            _ActualBalance = ActualBalance; 

        }
    }
}