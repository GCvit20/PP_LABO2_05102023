
namespace Trabajo_integrador_laboratorio_2
{
    public partial class FrmCalculadora : Form
    {

        public FrmCalculadora()
        {
            InitializeComponent();

            rdbDecimal.TabIndex = 0;
            rdbBinario.TabIndex = 1;
            txtPrimerOperador.TabIndex = 2;
            txtSegundoOperador.TabIndex = 3;
            cmbOperacion.TabIndex = 4;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblSegundoOperador_Click(object sender, EventArgs e)
        {

        }

        private void LblOperacion_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] options = new string[] { "+", "-", "/", "*" };


            foreach (string option in options)
            {
                this.cmbOperacion.Items.Add(option);
            }

            this.cmbOperacion.SelectedIndex = 0;

            //Agregamos el evento al formulario 
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

        }

        private void LblPrimerOperador_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {

            setResultado();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtPrimerOperador.Clear();
            this.txtSegundoOperador.Clear();
            this.cmbOperacion.SelectedIndex = 0;
            this.rdbDecimal.Checked = true;
            lblResultadoNumero.Text = string.Empty;

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void grpSistema_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult resultado = MessageBox.Show("Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true; // Cancelar el cierre
            }
        }


        private void setResultado()
        {

        }

        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultadoNumero_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}