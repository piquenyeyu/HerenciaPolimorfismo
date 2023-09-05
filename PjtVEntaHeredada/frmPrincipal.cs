namespace PjtVEntaHeredada
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btncontado_Click(object sender, EventArgs e)
        {
            frmContado frmContado = new frmContado();
            frmContado.ShowDialog();
        }

        private void btncredito_Click(object sender, EventArgs e)
        {
            frmcredito frmCredito = new frmcredito();
            frmCredito.ShowDialog();
        }
    }
}