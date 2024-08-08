namespace ProjetoBilhetesAeronautica
{
    public partial class FormPrincipal : Form
    {
        FormCreditos _formCreditos;
        FormColaborador _formColaborador;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void BtnCreditos_Click(object sender, EventArgs e)
        {
            // Desabilitar este form e abrir o form dos creditos passando este como parâmetro para conseguir voltar a habilitar após fechar o dos créditos
            this.Enabled = false;
            _formCreditos = new FormCreditos(this, 0);
            _formCreditos.Show();
        }

        private void BtnLoginColaborador_Click(object sender, EventArgs e)
        {
            string utilizador = TextBoxUtilizador.Text;
            string password = TextBoxPassword.Text;
            if (!string.IsNullOrWhiteSpace(utilizador) && !string.IsNullOrWhiteSpace(password))
            {
                // Apenas aceita passwords com 8 caracteres mínimo
                if (password.Length >= 8) 
                {
                    this.Hide();
                    _formColaborador = new FormColaborador(this, utilizador);
                    _formColaborador.Show();
                }
                else
                {
                    MessageBox.Show("A password tem de conter no mínimo 8 caracteres!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Introduza o nome de utilizador e password!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
