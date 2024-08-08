using Biblioteca;

namespace ProjetoBilhetesAeronautica
{
    public partial class UserControlAparelhos : UserControl
    {
        int idAviao;

        List<Aparelho> aparelhos = new List<Aparelho>();
        List<Voo> voos = new List<Voo>();

        Aparelho aparelhoSelecionado;
        
        public UserControlAparelhos(List<Aparelho> listaAparelhos, List<Voo> listaVoos)
        {
            InitializeComponent();
            aparelhos = listaAparelhos;
            voos = listaVoos;

            if (aparelhos.Count > 0)
            {
                InitListAparelhos();

                aparelhoSelecionado = ListBoxAparelhos.SelectedItem as Aparelho;
                InitListLugares();

                DadosEditarVoo();
                // Caso existam aparelhos, o id do próximo aparelho vai ser o seguinte ao ultimo criado
                idAviao = aparelhos.Last().Id + 1;
            }
            else
            {
                idAviao = 100; // Caso não existam aparelhos na lista, o id inicia no 100
            }
        }

        private void BtnCriarAparelho_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBoxCriarDescricao.Text) && !string.IsNullOrWhiteSpace(TextBoxCriarCompanhiaAerea.Text) && NumUpDownCriarCapacidade.Value > 0)
            {
                try
                {   // Cria um novo aparelho
                    Aparelho novoAparelho = new Aparelho()
                    {
                        Id = idAviao++, // Adicionar o id do avião e incrementar logo a seguir
                        Descricao = TextBoxCriarDescricao.Text,
                        CompanhiaAerea = TextBoxCriarCompanhiaAerea.Text,
                        Capacidade = Convert.ToInt32(NumUpDownCriarCapacidade.Value),
                        Activo = true,
                        Lugares = new List<string>(),
                    };
                    // Adicionar o aparelho criado à lista de aparelhos
                    aparelhos.Add(novoAparelho);
                    // Atualizar a lista de aparelhos na listbox
                    InitListAparelhos();
                    // Seleciona na listbox o novo aparelho criado 
                    ListBoxAparelhos.SelectedItem = novoAparelho;
                    // Define o novo aparelho como aparelho selecionado 
                    aparelhoSelecionado = novoAparelho;
                    // Limpar as textboxs e definir o valor do numericupdown da capacidade para 0
                    TextBoxCriarDescricao.Text = string.Empty;
                    TextBoxCriarCompanhiaAerea.Text = string.Empty;
                    NumUpDownCriarCapacidade.Value = 0;

                    DadosEditarVoo();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tem de indicar a descrição, companhia aérea e capacidade do aparelho!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            aparelhoSelecionado = ListBoxAparelhos.SelectedItem as Aparelho;
            if (aparelhoSelecionado != null) // Verifica se existe algum aparelho selecionado
            {
                if (VerficarVoosAparelho(aparelhoSelecionado) == false) // Verifica se o aparelho não tem voos associados
                {
                    MessageBox.Show($"O aparelho {aparelhoSelecionado.IdDescricao} foi removido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    aparelhos.Remove(aparelhoSelecionado); // Remove o aparelho
                    InitListAparelhos(); // Atualiza a lista de aparelhos na listbox
                    ListBoxLugares.DataSource = null; // Limpa a listbox de lugares
                    LblInfoAparelho.Text = string.Empty; // Limpa a label com a info do aparelho
                }
                else
                {
                    MessageBox.Show("Não pode remover o aparelho pois possui voos associados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tem de selecionar um aparelho!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            aparelhoSelecionado = ListBoxAparelhos.SelectedItem as Aparelho;
            if (aparelhoSelecionado != null) // Verifica se existe algum aparelho selecionado
            {   // Alterar a descrição
                if (!string.IsNullOrWhiteSpace(TextBoxEditarDescricao.Text))
                {
                    aparelhoSelecionado.Descricao = TextBoxEditarDescricao.Text;
                    TextBoxEditarDescricao.Text = string.Empty;
                }
                // Alterar a companhia aérea
                if (!string.IsNullOrWhiteSpace(TextBoxEditarCompanhiaAerea.Text))
                {
                    aparelhoSelecionado.CompanhiaAerea = TextBoxEditarCompanhiaAerea.Text;
                    TextBoxEditarCompanhiaAerea.Text = string.Empty;
                }
                // Alterar a capacidade e atualizar a lista de lugares
                if (Convert.ToInt32(NumUpDownEditarCapacidade.Value) != aparelhoSelecionado.Capacidade)
                {
                    if (VerficarVoosAparelho(aparelhoSelecionado) == false)
                    {
                        if (NumUpDownEditarCapacidade.Value != 0)
                        {
                            aparelhoSelecionado.Capacidade = Convert.ToInt32(NumUpDownEditarCapacidade.Value);
                            NumUpDownEditarCapacidade.Value = 0;
                            //Atualiza a lista de lugares do aparelho, tendo em conta a nova capacidade
                            aparelhoSelecionado.Lugares = new List<string>();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não pode alterar a capacidade do aparelho pois possui voos associados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
                // Alterar o estado para ativo ou inativo
                if (RadioButtonAtivo.Checked)
                {
                    aparelhoSelecionado.Activo = true;
                    RadioButtonAtivo.Checked = false;
                }
                else if (RadioButtonInativo.Checked)
                {
                    aparelhoSelecionado.Activo = false;
                    RadioButtonInativo.Checked = false;
                }

                InitListAparelhos();

                InitListLugares();

                DadosEditarVoo();
            }
            else
            {
                MessageBox.Show("Tem de selecionar um aparelho!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListBoxAparelhos_SelectedIndexChanged(object sender, EventArgs e)
        {
            aparelhoSelecionado = ListBoxAparelhos.SelectedItem as Aparelho;
            if (aparelhoSelecionado != null)
            {
                InitListLugares();
                LblInfoAparelho.Text = aparelhoSelecionado.ToString();
                DadosEditarVoo();
            }
        }

        private void DadosEditarVoo()
        {
            TextBoxEditarDescricao.Text = aparelhoSelecionado.Descricao;
            TextBoxEditarCompanhiaAerea.Text = aparelhoSelecionado.CompanhiaAerea;
            NumUpDownEditarCapacidade.Value = aparelhoSelecionado.Capacidade;
            if (aparelhoSelecionado.Activo)
            {
                RadioButtonAtivo.Checked = true;
            }
            else
            {
                RadioButtonInativo.Checked = true; ;
            }
        }

        /// <summary>
        /// Apresenta a lista de aparelhos na listbox aparelhos
        /// </summary>
        private void InitListAparelhos()
        {
            ListBoxAparelhos.DataSource = null;
            ListBoxAparelhos.DataSource = aparelhos;
            ListBoxAparelhos.DisplayMember = "IdDescricao";
        }

        /// <summary>
        /// Apresenta a lista de lugares do aparelho na listbox lugares
        /// </summary>
        private void InitListLugares()
        {
            aparelhoSelecionado = ListBoxAparelhos.SelectedItem as Aparelho;
            if (aparelhoSelecionado != null && aparelhoSelecionado.Lugares != null)
            {
                ListBoxLugares.DataSource = null;
                ListBoxLugares.DataSource = aparelhoSelecionado.Lugares;
            }
        }

        /// <summary>
        /// Verifica se o aparelho tem algum voo associado
        /// </summary>
        /// <param name="aparelho"></param>
        /// <returns></returns>
        private bool VerficarVoosAparelho(Aparelho aparelho)
        {
            List<Voo> voosAparelho = new List<Voo>();
            // Verificar os voos da lista de voos que tenham o aparelho selecionado associado
            voosAparelho = voos.Where(v => v.Aparelho == aparelho).ToList();

            if (voosAparelho.Count > 0) // Se tiver voos associados retorna "true"
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
