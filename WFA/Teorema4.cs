using System;

namespace WFA
{
    public class Teorema4
    {
        public Teorema4()
        {
        }

        public string ListaPrimos { get; private set; }
        public string ListaDivisores { get; private set; }

        public bool VerificaPrimo(int p)
        {
            var primo = (p % 2 != 0 || p <= 2) && p != 1;
            
            var raiz = Math.Sqrt(p);

            for (int i = 3; i <= raiz; i++)
            {
                if (p % i == 0)
                {
                    primo = false;
                    i = (int) (i + raiz);
                }
            }

            return primo;
        }

        public void Lista(int p)
        {
            for (int i = 1; i <= p; i++)
            {
                if (VerificaPrimo(i))
                    ListaPrimos = string.Format("{0}{1}; ",ListaPrimos,i);

                if (p % i == 0)
                    ListaDivisores = string.Format("{0}{1}; ", ListaDivisores, i);
            }
        }
    }
}
