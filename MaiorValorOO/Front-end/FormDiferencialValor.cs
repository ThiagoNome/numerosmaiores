using MaiorValorOO.Back_end;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MaiorValorOO.Front_end
{
    public partial class FormDiferencialValor : Form
    {
        public FormDiferencialValor()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int v1;
            int v2;
            int v3;

            v1 = ((int)numericUpDown1.Value);
            v2 = ((int)numericUpDown2.Value);
            v3 = ((int)numericUpDown3.Value);

            ValorMaior bolo = new ValorMaior();
            lbl_resultado.Text = bolo.CalcularMaiorValor(v1,v2,v3);
        }
    }
}
