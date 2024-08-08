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
            // Desabilitar este form e abrir o form dos creditos passando este como par�metro para conseguir voltar a habilitar ap�s fechar o dos cr�ditos
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
                // Apenas aceita passwords com 8 caracteres m�nimo
                if (password.Length >= 8) 
                {
                    this.Hide();
                    _formColaborador = new FormColaborador(this, utilizador);
                    _formColaborador.Show();
                }
                else
                {
                    MessageBox.Show("A password tem de conter no m�nimo 8 caracteres!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Introduza o nome de utilizador e password!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
