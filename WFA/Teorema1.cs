using System;
using System.Windows.Forms;

namespace WFA
{
    public class Teorema1
    {
        private int _a;
        private int _b;

        public int Resto { get; private set; }
        public int Quociente { get; private set; }

        public Teorema1()
        {
        }

        public Teorema1(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public void CalculaResto(int a, int b)
        {
            Resto = Math.Abs(a % b);

            if (Resto >= 0 && Resto < Math.Abs(b))
                return;

            Resto = b + Resto;
        }


        public void CalculaQuociente(int a, int b)
        {
            Quociente = (a - Resto) / b;
        }

        public void Recalcular(int a, int b)
        {
            Quociente = Quociente - Resto;
            Resto = (a / b - Quociente)*-1;
        }

        public bool Validar(int a, int b)
        {
            return a == Quociente * b + Resto;
        }
    }
}
