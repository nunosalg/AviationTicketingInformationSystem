using Biblioteca;

namespace ProjetoBilhetesAeronautica
{
    public partial class UserControlBilhetes : UserControl
    {
        Panel panel;

        List<Voo> voos = new List<Voo>();
        List<Bilhete> bilhetes = new List<Bilhete>();
        
        Voo vooSelecionado;
        string lugarSelecionado;
        
        public UserControlBilhetes(List<Voo> listaVoos, Panel panelColaborador, List<Bilhete> listaBilhetes)
        {
            InitializeComponent();
            panel = panelColaborador;
            voos = listaVoos;
            bilhetes = listaBilhetes;

            if (voos.Count > 0) // Caso a lista de voos contenha voos
            {
                InitListVoos(); // Apresenta a lista de voos na listbox
                vooSelecionado = ListBoxVoos.SelectedItem as Voo;

                InitListLugaresDisponiveis(); // Apresenta a lista de lugares disponiveis na listbox
                lugarSelecionado = ListBoxLugares.SelectedItem as string;

                TextBoxDisposicaoLugares.Text = vooSelecionado.ListarLugares(); // Apresenta a disposiçao dos lugares no voo na textbox respectiva
                LblInfoVoo.Text = vooSelecionado.ToString(); // Apresenta a informação do voo selecionado na label
            }

            DateTimePickerConsultarData.Value = DateTime.Now;
            InitComboBoxOrigensEDestinos();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            List<Voo> voosConsultar = new List<Voo>(); 
            DateTime dataConsultar = DateTimePickerConsultarData.Value.Date; // Data selecionada para consultar
            string origemConsultar = ComboBoxOrigens.SelectedItem as string; // Origem escolhida para consultar
            string destinoConsultar = ComboBoxDestinos.SelectedItem as string; // Destino escolhido para consultar

            if (!string.IsNullOrWhiteSpace(origemConsultar) && !string.IsNullOrWhiteSpace(destinoConsultar)) // Caso selecione origem e destino
            {
                if (DateTimePickerConsultarData.Checked == true) // ... + data
                {
                    voosConsultar = voos.Where(v => v.Origem == origemConsultar && v.Destino == destinoConsultar && v.DataHoraPartida.Date == dataConsultar).ToList();
                }
                else if (DateTimePickerConsultarData.Checked == false) // Caso não selecione data
                {
                    voosConsultar = voos.Where(v => v.Origem == origemConsultar && v.Destino == destinoConsultar).ToList();
                }
            }
            else if (!string.IsNullOrWhiteSpace(origemConsultar)) // Caso selecione origem 
            {
                if (DateTimePickerConsultarData.Checked == true) // ... + data
                {
                    voosConsultar = voos.Where(v => v.Origem == origemConsultar && v.DataHoraPartida.Date == dataConsultar).ToList();
                }
                else if (DateTimePickerConsultarData.Checked == false) // Caso não selecione data
                {
                    voosConsultar = voos.Where(v => v.Origem == origemConsultar).ToList();
                }
            }
            else if (!string.IsNullOrWhiteSpace(destinoConsultar)) // Caso selecione destino 
            {
                if (DateTimePickerConsultarData.Checked == true) // ... + data
                {
                    voosConsultar = voos.Where(v => v.Destino == destinoConsultar && v.DataHoraPartida.Date == dataConsultar).ToList();
                }
                else if (DateTimePickerConsultarData.Checked == false) // Caso não selecione data
                {
                    voosConsultar = voos.Where(v => v.Destino == destinoConsultar).ToList();
                }
            }
            else if (DateTimePickerConsultarData.Checked == true) // Caso selecione apenas data
            {
                voosConsultar = voos.Where(v => v.DataHoraPartida.Date == dataConsultar).ToList();
            }
            else
            {
                MessageBox.Show("Tem de indicar origem ou destino ou data de partida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Apresenta na listbox de voos a lista de voos a consultar consoante os critérios indicados
            InitListVoosConsultar(voosConsultar); 
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            vooSelecionado = ListBoxVoos.SelectedItem as Voo; 
            lugarSelecionado = ListBoxLugares.SelectedItem as string;

            if (vooSelecionado != null && lugarSelecionado != null) // Caso exista um voo e lugar selecionado
            {
                // Apresenta o user control para proceder ao preenchimento da informação do passageiro e compra do bilhete
                UserControlComprarBilhete userControlComprarBilhete = new UserControlComprarBilhete(vooSelecionado, lugarSelecionado, bilhetes, panel);
                panel.Controls.Clear();
                panel.Controls.Add(userControlComprarBilhete);
                userControlComprarBilhete.Dock = DockStyle.Fill;
            }
            else
            {
                MessageBox.Show("Tem de selecionar um voo e um lugar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListBoxVoos_SelectedIndexChanged(object sender, EventArgs e)
        {
            vooSelecionado = ListBoxVoos.SelectedItem as Voo;
            if (vooSelecionado != null)
            {
                InitListLugaresDisponiveis();
                // Apresenta a disposição dos lugares do avião na textbox disposicaolugares
                TextBoxDisposicaoLugares.Text = vooSelecionado.ListarLugares();
                LblInfoVoo.Text = vooSelecionado.ToString();
            }
        }

        /// <summary>
        /// Apresenta a lista de voos na listbox voos
        /// </summary>
        private void InitListVoos()
        {
            ListBoxVoos.DataSource = null;
            ListBoxVoos.DataSource = voos;
            ListBoxVoos.DisplayMember = "NumeroVoo";
        }

        /// <summary>
        /// Apresenta a lista de voos consultados consoante o critério indicado (origem, destino, data do voo)
        /// </summary>
        /// <param name="voosConsultar"></param>
        private void InitListVoosConsultar(List<Voo> voosConsultar)
        {
            ListBoxVoos.DataSource = null;
            ListBoxVoos.DataSource = voosConsultar;
            ListBoxVoos.DisplayMember = "NumeroVoo";
        }

        /// <summary>
        /// Apresenta a lista de lugares disponiveis para escolher no voo
        /// </summary>
        private void InitListLugaresDisponiveis()
        {
            vooSelecionado = ListBoxVoos.SelectedItem as Voo;
            if (vooSelecionado != null && vooSelecionado.LugaresDisponiveis != null)
            {
                ListBoxLugares.DataSource = null;
                ListBoxLugares.DataSource = vooSelecionado.LugaresDisponiveis;
            }
        }

        /// <summary>
        /// Apresenta as origens e destinos dos voos já criados nas combo box respectivas
        /// </summary>
        private void InitComboBoxOrigensEDestinos()
        {
            // Obter lista única de origens e destino
            var origensUnicas = voos.Select(v => v.Origem).Distinct().ToList();
            var destinosUnicos = voos.Select(v => v.Destino).Distinct().ToList();

            // Configurar os datasource das combobox com listas únicas
            ComboBoxOrigens.DataSource = origensUnicas;
            ComboBoxDestinos.DataSource = destinosUnicos;
        }
    }
}
