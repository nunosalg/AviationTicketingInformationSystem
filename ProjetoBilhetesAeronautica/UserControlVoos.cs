using Biblioteca;

namespace ProjetoBilhetesAeronautica
{
    public partial class UserControlVoos : UserControl
    {
        List<Voo> voos = new List<Voo>();
        List<Aparelho> aparelhos = new List<Aparelho>();
        List<Bilhete> bilhetes = new List<Bilhete>();

        Voo vooSelecionado;
        Aparelho aparelhoSelecionado;

        public UserControlVoos(List<Voo> listaVoos, List<Aparelho> listaAparelhos, List<Bilhete> listaBilhetes)
        {
            InitializeComponent();
            // Define a data minima para o dia seguinte à data atual
            DateTimePickerCriarData.MinDate = DateTime.Now.AddDays(1);

            // Lista de voos
            voos = listaVoos;
            if (voos.Count > 0) // Se a lista de voos conter algum voo
            {
                InitListVoos();
                vooSelecionado = ListBoxVoos.SelectedItem as Voo;
                // Apresenta a informação do voo na label
                LblInfoVoo.Text = vooSelecionado.ToString();

                NumUpDownEditar();
            }

            // Lista de aparelhos
            aparelhos = listaAparelhos;
            if(aparelhos.Count > 0) // Se a lista de aparelhos conter algum
            {
                InitListAparelhosDisponiveis();
                aparelhoSelecionado = ListBoxAparelhosDisponiveis.SelectedItem as Aparelho;
            }

            // Lista de bilhetes
            bilhetes = listaBilhetes;
        }

        private void BtnCriar_Click(object sender, EventArgs e)
        {
            vooSelecionado = null;
            if (!string.IsNullOrWhiteSpace(TextBoxCriarOrigem.Text) && !string.IsNullOrWhiteSpace(TextBoxCriarDestino.Text)) // Certificar que é definida origem e destino
            {
                try
                {
                    string origemVoo = TextBoxCriarOrigem.Text.Trim();
                    string destinoVoo = TextBoxCriarDestino.Text.Trim();

                    if (NumUpDownCriarDuraHoras.Value > 0 || NumUpDownCriarDuraMinutos.Value > 0) // Certificar que é definida duração 
                    {
                        aparelhoSelecionado = ListBoxAparelhosDisponiveis.SelectedItem as Aparelho;
                        // Certificar que existe algum aparelho selecionado
                        if (aparelhoSelecionado != null)
                        {
                            // Dados da data e hora de voo
                            int anoVoo = Convert.ToInt32(DateTimePickerCriarData.Value.Year);
                            int mesVoo = Convert.ToInt32(DateTimePickerCriarData.Value.Month);
                            int diaVoo = Convert.ToInt32(DateTimePickerCriarData.Value.Day);
                            int horaVoo = Convert.ToInt32(NumUpDownCriarHora.Value);
                            int minVoo = Convert.ToInt32(NumUpDownCriarMinutos.Value);
                            DateTime dataHoraEscolhida = new DateTime(anoVoo, mesVoo, diaVoo, horaVoo, minVoo, 0);

                            // Dados da duração do voo
                            int horasVoo = Convert.ToInt32(NumUpDownCriarDuraHoras.Value);
                            int minutosVoo = Convert.ToInt32(NumUpDownCriarDuraMinutos.Value);
                            TimeSpan duracaoVoo = new TimeSpan(horasVoo, minutosVoo, 0);

                            if (!AparelhoTemVooMesmaData(dataHoraEscolhida, origemVoo, destinoVoo, duracaoVoo))
                            {
                                Voo novoVoo = new Voo()
                                {
                                    DataHoraPartida = dataHoraEscolhida,
                                    HorasVoo = duracaoVoo,
                                    Origem = origemVoo,
                                    Destino = destinoVoo,
                                    Aparelho = aparelhoSelecionado,
                                    LugaresDisponiveis = new List<string>(aparelhoSelecionado.Lugares),
                                    ListaBilhetes = new List<Bilhete>(),
                                };
                                // Adiciona o voo à lista de voos
                                voos.Add(novoVoo);
                                // Inicializa a lista de voos e seleciona o último voo criado
                                InitListVoos();
                                ListBoxVoos.SelectedItem = novoVoo;
                                vooSelecionado = novoVoo;
                                // Apresenta a informação do voo na label
                                LblInfoVoo.Text = vooSelecionado.ToString();

                                NumUpDownEditar();

                                LimparCamposCriarVoo();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tem de selecionar um aparelho!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tem de definir a duração do voo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tem de definir a origem e destino do voo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            vooSelecionado = ListBoxVoos.SelectedItem as Voo;
            aparelhoSelecionado = ListBoxAparelhosDisponiveis.SelectedItem as Aparelho;
            // Verifica se existe um voo selecionado
            if (vooSelecionado != null) 
            {
                // Verifica se esse voo não possui bilhetes emitidos
                if (vooSelecionado.ListaBilhetes.Count == 0)
                {
                    string origemEscolhida = TextBoxEditarOrigem.Text.Trim();
                    string destinoEscolhido = TextBoxEditarDestino.Text.Trim();
                    // Dados editar data e hora do voo
                    int anoVoo = Convert.ToInt32(DateTimePickerEditarData.Value.Year);
                    int mesVoo = Convert.ToInt32(DateTimePickerEditarData.Value.Month);
                    int diaVoo = Convert.ToInt32(DateTimePickerEditarData.Value.Day);
                    int horaVoo = Convert.ToInt32(NumUpDownEditarHora.Value);
                    int minVoo = Convert.ToInt32(NumUpDownEditarMinuto.Value);
                    DateTime dataEscolhida = new DateTime(anoVoo, mesVoo, diaVoo, horaVoo, minVoo, 0);
                    // Dados editar duração do voo
                    int duracaoHoras = Convert.ToInt32(NumUpDownEditarHorasVoo.Value);
                    int duracaoMinutos = Convert.ToInt32(NumUpDownEditarMinutosVoo.Value);
                    TimeSpan duracaoVoo = new TimeSpan(duracaoHoras, duracaoMinutos, 0);

                    if (!AparelhoTemVooMesmaData(dataEscolhida, origemEscolhida, destinoEscolhido, duracaoVoo))
                    {
                        if (!string.IsNullOrWhiteSpace(origemEscolhida)) // Edita a origem do voo caso a textboxeditarorigem contenha algo
                        {
                            vooSelecionado.Origem = origemEscolhida;
                        }


                        if (!string.IsNullOrWhiteSpace(destinoEscolhido)) // Edita o destino do voo caso a textboxeditardestino contenha algo
                        {
                            vooSelecionado.Destino = destinoEscolhido;
                        }

                        EditarDadosDataHoraDuracaoVoo();

                        aparelhoSelecionado = ListBoxAparelhosDisponiveis.SelectedItem as Aparelho;
                        if (aparelhoSelecionado != null) // Caso exista algum aparelho selecionado
                        {
                            vooSelecionado.Aparelho = aparelhoSelecionado;
                        }
                        else
                        {
                            MessageBox.Show("Tem de definir a origem e destino do voo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        InitListVoos();
                        ListBoxVoos.SelectedItem = vooSelecionado;
                        // Apresenta a info do voo selecionado na label
                        LblInfoVoo.Text = vooSelecionado.ToString();
                        // Limpa as textboxs
                        TextBoxEditarOrigem.Text = string.Empty;
                        TextBoxEditarDestino.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("O voo selecionado já possui bilhetes emitidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tem de selecionar um voo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            vooSelecionado = ListBoxVoos.SelectedItem as Voo;
            if (ListBoxVoos.SelectedItem != null)
            {
                if (vooSelecionado.ListaBilhetes.Count > 0) // Verifica se o voo selecionado possui bilhetes emitidos
                {
                    MessageBox.Show($"O voo {vooSelecionado.NumeroVoo} foi removido e foram devolvidos {vooSelecionado.ListaBilhetes.Count} bilhetes!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RemoverBilheteListaBilhetes(); // Remove os bilhetes da lista de bilhetes global
                    RemoverVoo(); // Remove o voo
                }
                else
                {
                    MessageBox.Show($"O voo {vooSelecionado.NumeroVoo} foi removido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RemoverVoo();
                }
            }
            else
            {
                MessageBox.Show("Tem de selecionar um voo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListBoxVoos_SelectedIndexChanged(object sender, EventArgs e)
        {
            vooSelecionado = ListBoxVoos.SelectedItem as Voo;
            if(vooSelecionado != null)
            {
                ListBoxAparelhosDisponiveis.SelectedItem = vooSelecionado.Aparelho;
                aparelhoSelecionado = ListBoxAparelhosDisponiveis.SelectedItem as Aparelho;
                NumUpDownEditar();
                LblInfoVoo.Text = vooSelecionado.ToString();
            }
        }

        /// <summary>
        /// Verifica quais os aparelhos que estão disponiveis (ativos) e apresenta-os na lista de aparelhos
        /// </summary>
        private void InitListAparelhosDisponiveis()
        {
            List<Aparelho> aparelhosDisponiveis = new List<Aparelho>();
            // Adicionar à lista de aparelhos disponiveis apenas os aparelhos que tenham o estado ativo
            aparelhosDisponiveis = aparelhos.Where(a => a.Activo == true).ToList();
            
            ListBoxAparelhosDisponiveis.DataSource = null;
            ListBoxAparelhosDisponiveis.DataSource = aparelhosDisponiveis;
            ListBoxAparelhosDisponiveis.DisplayMember = "IdDescricao";
        }

        /// <summary>
        /// Inicializa a lista de voos criados
        /// </summary>
        private void InitListVoos()
        {
            ListBoxVoos.DataSource = null;
            ListBoxVoos.DataSource = voos;
            ListBoxVoos.DisplayMember = "NumeroVoo";
        }

        /// <summary>
        /// Limpa os campos após a criação de um voo
        /// </summary>
        private void LimparCamposCriarVoo()
        {
            TextBoxCriarOrigem.Text = string.Empty;
            TextBoxCriarDestino.Text = string.Empty;
            DateTimePickerCriarData.Value = DateTime.Now.AddDays(1);
            NumUpDownCriarHora.Value = 0;
            NumUpDownCriarMinutos.Value = 0;
            NumUpDownCriarDuraHoras.Value = 0;
            NumUpDownCriarDuraMinutos.Value = 0;
            ListBoxAparelhosDisponiveis.ClearSelected(); 
        }

        /// <summary>
        /// Atibui o valor das propriedades do voo selecionado aos numerics up and down que editam o voo
        /// </summary>
        private void NumUpDownEditar()
        {
            TextBoxEditarOrigem.Text = vooSelecionado.Origem;
            TextBoxEditarDestino.Text = vooSelecionado.Destino;
            DateTimePickerEditarData.Value = vooSelecionado.DataHoraPartida;
            NumUpDownEditarHora.Value = vooSelecionado.DataHoraPartida.Hour;
            NumUpDownEditarMinuto.Value = vooSelecionado.DataHoraPartida.Minute;
            NumUpDownEditarHorasVoo.Value = vooSelecionado.HorasVoo.Hours;
            NumUpDownEditarMinutosVoo.Value = vooSelecionado.HorasVoo.Minutes;
        }

        /// <summary>
        /// Edita os dados da data e hora de partida e a duração de voo
        /// </summary>
        private void EditarDadosDataHoraDuracaoVoo()
        {
            // Datetimepicker e numeric up and down que editam a data e hora de voo
            int alterarAno = Convert.ToInt32(DateTimePickerEditarData.Value.Year);
            int alterarMes = Convert.ToInt32(DateTimePickerEditarData.Value.Month);
            int alterarDia = Convert.ToInt32(DateTimePickerEditarData.Value.Day);
            int alterarHora = Convert.ToInt32(NumUpDownEditarHora.Value);
            int alterarMinuto = Convert.ToInt32(NumUpDownEditarMinuto.Value);
            vooSelecionado.DataHoraPartida = new DateTime(alterarAno, alterarMes, alterarDia, alterarHora, alterarMinuto, 0);
            // Numeric up and down que editam o tempo de voo
            int alterarHorasVoo = Convert.ToInt32(NumUpDownEditarHorasVoo.Value);
            int alterarMinutosVoo = Convert.ToInt32(NumUpDownEditarMinutosVoo.Value);
            vooSelecionado.HorasVoo = new TimeSpan(alterarHorasVoo, alterarMinutosVoo, 0);
        }

        /// <summary>
        /// Remove o voo selecionado
        /// </summary>
        private void RemoverVoo()
        {
            voos.Remove(vooSelecionado); // Remove o voo
            InitListVoos(); // Atualiza a lista de voos
            LblInfoVoo.Text = string.Empty; // Limpa a label com a info do voo
        }

        /// <summary>
        /// Remove os bilhetes da lista de bilhetes que estejam no voo selecionado
        /// </summary>
        private void RemoverBilheteListaBilhetes()
        {
            List<int> bilhetesParaRemover = new List<int>();

            foreach(Bilhete bilhete in vooSelecionado.ListaBilhetes)
            {
                bilhetesParaRemover.Add(bilhete.Id); // Adiciona à lista de bilhetes a remover, os ids dos bilhetes do voo
            }

            bilhetes.RemoveAll(b => bilhetesParaRemover.Contains(b.Id)); // Remove os bilhetes com o mesmo id na lista de bilhetes global
        }

        /// <summary>
        /// Verifica se existem voos na mesma data que o novo voo escolhido e qual a origem e destino
        /// </summary>
        /// <param name="dataEscolhida"></param>
        /// <param name="origemEscolhida"></param>
        /// <param name="destinoEscolhido"></param>
        /// <returns></returns>
        private bool AparelhoTemVooMesmaData(DateTime dataEscolhida, string origemEscolhida, string destinoEscolhido, TimeSpan duracaoVoo)
        {
            int intervaloPrepararAviao = 60; // 1 hora em minutos
            int totalMinutosVoo = (int)duracaoVoo.TotalMinutes; // Total minutos da duração do voo

            // Lista com voos do aparelho selecionado com rotas diferentes para o dia selecionado 
            var voosRotaDiferenteDia = voos.Where(v => v.Aparelho.Id == aparelhoSelecionado.Id && dataEscolhida.Date == v.DataHoraPartida.Date && 
                                                        ((origemEscolhida != v.Origem && origemEscolhida != v.Destino) ||
                                                        (destinoEscolhido != v.Origem && destinoEscolhido != v.Destino))).ToList();
            
            voosRotaDiferenteDia.Remove(vooSelecionado);

            // Se existir qualquer voo que não siga a mesma rota
            if (voosRotaDiferenteDia.Count > 0)
            {
                MessageBox.Show("O avião já tem uma rota diferente definida para esse dia.", "Conflito de Rota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true; // Conflito, não pode criar o novo voo
            }

            // Lista com os voos do aparelho selecionado na mesma data
            var voosMesmoDia = voos.Where(v => v.Aparelho == aparelhoSelecionado && v.DataHoraPartida.Date == dataEscolhida.Date).ToList();

            voosMesmoDia.Remove(vooSelecionado);

            foreach (var v in voosMesmoDia)
            {
                DateTime partidaExistente = v.DataHoraPartida;
                DateTime chegadaExistente = v.HoraChegada;
                DateTime novaPartida = dataEscolhida;

                // Caso a data de partida do novo voo seja igual a alguma existente
                if (novaPartida == partidaExistente)
                {
                    MessageBox.Show("O avião já tem um voo definido para essa rota nesse horário.", "Conflito de Rota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true; // Conflito, não pode criar o novo voo
                }

                // Verificar conflito quando o novo voo tem a mesma origem e destino
                if (origemEscolhida == v.Origem && destinoEscolhido == v.Destino)
                {
                    int intervaloDobroPreparacao = (totalMinutosVoo + intervaloPrepararAviao) * 2;

                    // Confirma se o novo voo está dentro do intervalo do voo existente
                    if (novaPartida < partidaExistente)
                    {
                        if (novaPartida > partidaExistente.AddMinutes(-intervaloDobroPreparacao))
                        {
                            MessageBox.Show("O avião já tem um voo definido para essa rota nesse horário.", "Conflito de Rota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return true; // Conflito, não pode criar o novo voo
                        }
                    }

                    if (novaPartida > partidaExistente)
                    {
                        if (novaPartida < partidaExistente.AddMinutes(intervaloDobroPreparacao))
                        {
                            MessageBox.Show("O avião já tem um voo definido para essa rota nesse horário.", "Conflito de Rota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return true; // Conflito, não pode criar o novo voo
                        }
                    }
                }
                // Verificar conflito quando o novo voo tem a origem e destino trocado
                else if (origemEscolhida == v.Destino && destinoEscolhido == v.Origem)
                {
                    // Confirma se o novo voo está dentro do intervalo do voo existente
                    if (novaPartida < partidaExistente)
                    {
                        if (novaPartida > partidaExistente.AddMinutes(-totalMinutosVoo - intervaloPrepararAviao))
                        {
                            MessageBox.Show("O avião já tem um voo definido para uma rota diferente nesse horário.", "Conflito de Rota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return true; // Conflito, não pode criar o novo voo
                        }
                    }

                    if (novaPartida > partidaExistente) 
                    {
                        if (novaPartida < chegadaExistente.AddMinutes(intervaloPrepararAviao))
                        {
                            MessageBox.Show("O avião já tem um voo definido para uma rota diferente nesse horário.", "Conflito de Rota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return true; // Conflito, não pode criar o novo voo
                        }
                    }
                }
            }

            return false; // Não há conflito, pode criar o novo voo
        }
    }
}
