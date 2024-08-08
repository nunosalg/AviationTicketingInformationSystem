using Biblioteca;

namespace ProjetoBilhetesAeronautica
{
    public partial class FormColaborador : Form
    {
        private const string caminhoAparelhos = @"Data/aparelhos.txt";
        private const string caminhoVoos = @"Data/voos.txt";
        private const string caminhoBilhetes = @"Data/bilhetes.txt";

        FormPrincipal _principal;
        FormCreditos _formCreditos;

        List<Aparelho> listaAparelhos = new List<Aparelho>();
        List<Voo> listaVoos = new List<Voo>();
        List<Bilhete> listaBilhetes = new List<Bilhete>();

        public FormColaborador(FormPrincipal principal, string utilizador)
        {
            InitializeComponent();
            _principal = principal;
            // Apresentar o nome de utilizador que efetuou o login
            LblUtilizador.Text = $"Bem-vindo, {utilizador}";
        }

        private void BtnCreditos_Click(object sender, EventArgs e)
        {   
            // Desabilitar este form e abrir o form dos creditos passando este como parâmetro para conseguir voltar a habilitar após fechar o dos créditos
            this.Enabled = false;
            _formCreditos = new FormCreditos(this, 1);
            _formCreditos.Show();
        }

        private void FormColaborador_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                GerirArquivos.GravarAparelhos(listaAparelhos, caminhoAparelhos); // Gravar a lista de aparelhos
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível guardar os aparelhos...", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                GerirArquivos.GravarVoos(listaVoos, caminhoVoos); // Gravar a lista de voos
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível guardar os voos...", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                GerirArquivos.GravarBilhetes(listaBilhetes, caminhoBilhetes); // Gravar a lista de bilhetes global
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível guardar os bilhetes...", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _principal.Close();
        }

        private void BtnAparelhos_Click(object sender, EventArgs e)
        {
            // User control que vai servir para o crud dos aparelhos
            UserControlAparelhos userControlAparelhos = new UserControlAparelhos(listaAparelhos, listaVoos);
            PanelColaborador.Controls.Clear();
            PanelColaborador.Controls.Add(userControlAparelhos);
            userControlAparelhos.Dock = DockStyle.Fill;
        }

        private void BtnVoos_Click(object sender, EventArgs e)
        {
            // User control que vai servir para o crud dos voos
            UserControlVoos userControlVoos = new UserControlVoos(listaVoos, listaAparelhos, listaBilhetes);
            PanelColaborador.Controls.Clear();
            PanelColaborador.Controls.Add(userControlVoos);
            userControlVoos.Dock = DockStyle.Fill;
        }

        private void BtnBilhetes_Click(object sender, EventArgs e)
        {
            // User control que vai servir para consultar voos, escolher o voo e lugar pretendido antes da compra do bilhete
            UserControlBilhetes userControlBilhetes = new UserControlBilhetes(listaVoos, this.PanelColaborador, listaBilhetes);
            PanelColaborador.Controls.Clear();
            PanelColaborador.Controls.Add(userControlBilhetes);
            userControlBilhetes.Dock = DockStyle.Fill;
        }

        private void FormColaborador_Load(object sender, EventArgs e)
        {
            if (File.Exists(caminhoAparelhos)) // Carregar a lista de aparelhos caso o ficheiro exista
            {
                try
                {
                    listaAparelhos = GerirArquivos.CarregarAparelhos(caminhoAparelhos);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            if (File.Exists(caminhoVoos)) // Carregar a lista de voos caso o ficheiro exista
            {
                try
                {
                    listaVoos = GerirArquivos.CarregarVoos(caminhoVoos, listaAparelhos);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            if (File.Exists(caminhoBilhetes)) // Carregar a lista de bilhetes caso o ficheiro exista
            {
                try
                {
                    listaBilhetes = GerirArquivos.CarregarBilhetes(caminhoBilhetes, listaVoos);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void BtnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
