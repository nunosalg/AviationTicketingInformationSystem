using Biblioteca;
using System.Windows.Forms;

namespace ProjetoBilhetesAeronautica
{
    public partial class UserControlComprarBilhete : UserControl
    {
        Panel panel; // Painel do formcolaborador 
        List<Bilhete> bilhetes = new List<Bilhete>(); // Lista global de bilhetes
        Passageiro passageiro; // Passageiro criado para proceder
        Voo voo; // Voo selecionado
        string lugar; // Lugar selecionado
        int idBilhete; // Id a constar no bilhete criado
        Bilhete bilheteSelecionado; // Bilhete selecionado 

        public UserControlComprarBilhete(Voo vooSelecionado, string lugarSelecionado, List<Bilhete> listaBilhetes, Panel panelColaborador)
        {
            InitializeComponent();
            panel = panelColaborador;
            voo = vooSelecionado;
            lugar = lugarSelecionado;
            bilhetes = listaBilhetes;
            bilheteSelecionado = ListBoxListaBilhetes.SelectedItem as Bilhete;

            if (bilhetes.Count > 0) // Caso existam bilhetes
            {
                idBilhete = bilhetes.Last().Id + 1; // Id do novo bilhete será = id + 1 da lista de bilhetes
            }
            else
            {
                idBilhete = 1; // Caso nao existam será 1
            }
            // Apresentar a informaçao do voo e lugar selecionados
            ApresentarInfo();
            // Apresenta a lista de bilhetes emitidos para o voo selecionado
            InitListaBilhetes();
        }

        private void BtnPassageiro_Click(object sender, EventArgs e)
        {
            string nome = TextBoxNome.Text;
            string apelido = TextBoxApelido.Text;
            DateTime dataNascimento = DateTimePickerDataNascimento.Value.Date;
            // Caso seja indicado nome, apelido e numero de identificação do passageiro
            if (!string.IsNullOrWhiteSpace(nome) && !string.IsNullOrWhiteSpace(apelido) && !string.IsNullOrWhiteSpace(TextBoxNumeroID.Text)) 
            {
                if (int.TryParse(TextBoxNumeroID.Text, out int numeroID)) // Procede a tentativa de converter o número indiciado a um inteiro
                {
                    if (!NumeroIdPassageiroExistente(numeroID)) // Verifica se o número indicado não existe já em algum bilhete do voo
                    {
                        if (ValidarDataNascimento()) // Valida a data de nascimento indicada
                        {
                            // Cria o passageiro
                            Passageiro novoPassageiro = new Passageiro()
                            {
                                Nome = nome,
                                Apelido = apelido,
                                NumeroId = Convert.ToInt32(numeroID),
                                DataNascimento = dataNascimento
                            };

                            passageiro = novoPassageiro;
                            // Apresentar a informaçao do voo e lugar selecionados, mais info do passageiro e preço do bilhete 
                            ApresentarInfo();
                            // Atualiza a lista de bilhetes
                            InitListaBilhetes();
                            // Limpa os campos da info do passageiro
                            LimparCampos();
                        }
                        else
                        {
                            MessageBox.Show("O passageiro tem de ter no mínimo 1 ano!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Já existe um passageiro com o mesmo número de identificação no voo selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("O número de identificação não é válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tem de inserir o nome, apelido e número de identificação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnComprarBilhete_Click(object sender, EventArgs e)
        {
            if (voo != null && lugar != null && passageiro != null) // Caso exista um voo e lugar selecionados e passageiro criado
            {
                // Cria o bilhete
                Bilhete novoBilhete = new Bilhete()
                {
                    Id = idBilhete++,
                    Voo = voo,
                    Lugar = lugar,
                    Passageiro = passageiro,
                };

                bilhetes.Add(novoBilhete); // Adiciona o bilhete à lista de bilhetes global

                voo.ListaBilhetes.Add(novoBilhete); // Adiciona o bilhete à lista de bilhetes do voo

                LblInfoCompra.Text = string.Empty;

                MessageBox.Show("Bilhete comprado com sucesso!", "Compra efetuada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Abre o user control onde é apresentado o bilhete emitido 
                UserControlBilheteEmitido userControlBilheteEmitido = new UserControlBilheteEmitido(novoBilhete);
                panel.Controls.Clear();
                panel.Controls.Add(userControlBilheteEmitido);
                userControlBilheteEmitido.Dock = DockStyle.Fill;
            }
            else
            {
                MessageBox.Show("Tem de selecionar voo e lugar, e adicionar o passageiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRemoverBilhete_Click(object sender, EventArgs e)
        {
            bilheteSelecionado = ListBoxListaBilhetes.SelectedItem as Bilhete; 
            if (bilheteSelecionado != null) // Caso exista um bilhete selecionado
            {
                MessageBox.Show($"Bilhete com o ID {bilheteSelecionado.Id} foi removido!", "Bilhete removido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                voo.LugaresDisponiveis.Add(bilheteSelecionado.Lugar); // Adiciona o lugar do bilhete de volta à lista de lugares disponiveis
                voo.ListaBilhetes.Remove(bilheteSelecionado); // Remove o bilhete da lista de bilhetes do voo

                bilhetes.Remove(bilheteSelecionado); // Remove o bilhete da lista de bilhetes global

                InitListaBilhetes(); // Atualiza a lista de bilhetes
            }
            else
            {
                MessageBox.Show("Tem de selecionar um lugar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Apresenta a informação do voo e lugar selecionados
        /// </summary>
        private void ApresentarInfo()
        {
            string info = $"Informação do voo:\n{voo.NumeroVoo}\nOrigem: {voo.Origem}\nDestino: {voo.Destino}\nData e hora de partida: {voo.DataHoraPartida}\n" +
                $"Lugar selecionado: {lugar}";

            if (passageiro == null) // Caso ainda não tenha sido preenchida a info do passageiro
            {
                LblInfoCompra.Text = info;
            }
            else // Caso já tenha sido preenchida a info do passageiro
            {
                LblInfoCompra.Text = $"{info}\n{passageiro}\nPreço bilhete: {PrecoBilhete():C2}"; // Apresenta tambem info do passageiro mais preço do bilhete
            }
        }

        /// <summary>
        /// Limpa as textbox com as informações do passageiro e dá reset ao datetimepicker da data de nascimento
        /// </summary>
        private void LimparCampos()
        {
            TextBoxNome.Text = string.Empty;
            TextBoxApelido.Text = string.Empty;
            TextBoxNumeroID.Text = string.Empty;
            DateTimePickerDataNascimento.MaxDate = DateTime.Now.Date;
            DateTimePickerDataNascimento.Value = DateTime.Now.Date;
        }

        /// <summary>
        /// Calcula um preço para o bilhete consoante a duração e ocupação do voo
        /// </summary>
        /// <returns></returns>
        private double PrecoBilhete()
        {
            double valorPorMinuto = 0.5; // Custo por minuto
            double distancia = voo.HorasVoo.TotalMinutes; // Duração do voo em minutos
            double valorOcupacao = voo.ListaBilhetes.Count * 0.1; // Aumenta o preço consoante a ocupação do voo

            double precoBilhete = valorPorMinuto * distancia + valorOcupacao;

            return precoBilhete;
        }

        /// <summary>
        /// Valida a data de nascimento indicada
        /// </summary>
        /// <returns></returns>
        private bool ValidarDataNascimento()
        {
            DateTime dataNascimento = DateTimePickerDataNascimento.Value.Date;
            // Não permite datas de nascimento inferiores a 1 ano
            if (DateTime.Now.Year - dataNascimento.Year > 1 || (DateTime.Now.Year - dataNascimento.Year == 1 && DateTime.Now.Month > dataNascimento.Month))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Verifica se existe algum bilhete emitido com o mesmo número de identificação de passageiro indicado
        /// </summary>
        /// <param name="numeroID"></param>
        /// <returns></returns>
        private bool NumeroIdPassageiroExistente(int numeroID)
        {
            if (voo.ListaBilhetes.Count > 0) // Caso existam bilhetes emitidos
            {
                // Verifica se o numero de identificação indicado é igual a algum dos bilhetes já emitidos para este voo
                Bilhete bilheteExistente = voo.ListaBilhetes.FirstOrDefault(b => b.Passageiro.NumeroId == numeroID);

                return bilheteExistente != null; // Caso exista, retorna "true"
            }

            return false;
        }

        /// <summary>
        /// Apresenta a lista de bilhetes do voo nas listbox
        /// </summary>
        private void InitListaBilhetes()
        {
            ListBoxListaBilhetes.DataSource = null;
            ListBoxListaBilhetes.DataSource = voo.ListaBilhetes;
            ListBoxListaBilhetes.DisplayMember = "InfoBilhete";
        }
    }
}
