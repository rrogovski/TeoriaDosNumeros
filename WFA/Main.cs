using System.Windows.Forms;

namespace WFA
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonExeTeorema2_Click(object sender, System.EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            var _p = (int)numericUpDown_inteiro.Value;

            Teorema4 teorema4 = new Teorema4();
            textBoxVerificaPrimo.Text = teorema4.VerificaPrimo(_p) ? "Primo" : "Composto";
            teorema4.Lista(_p);

            labelPrimosAteP.Text = "Primos até " + _p.ToString();
            richTextBoxPrimos.Text = teorema4.ListaPrimos;

            labelDivisoresAteP.Text = "Divisores até " + _p.ToString();
            richTextBoxDivisores.Text = teorema4.ListaDivisores;

            Cursor.Current = Cursors.Default;
        }
    }
}
