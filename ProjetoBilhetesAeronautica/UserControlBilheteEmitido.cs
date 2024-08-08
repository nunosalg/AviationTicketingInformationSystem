using Biblioteca;

namespace ProjetoBilhetesAeronautica
{
    public partial class UserControlBilheteEmitido : UserControl
    {
        Bilhete bilheteEmitido = new Bilhete();

        public UserControlBilheteEmitido(Bilhete bilhete)
        {
            InitializeComponent();
            bilheteEmitido = bilhete;

            ApresentarDados();
        }

        /// <summary>
        /// Apresenta as informações do bilhete nas labels
        /// </summary>
        private void ApresentarDados()
        {
            LblCompanhiaAerea.Text = bilheteEmitido.Voo.Aparelho.CompanhiaAerea; // Companhia aérea
            LblNumeroVoo.Text = $"Número de voo: {bilheteEmitido.Voo.NumeroVoo}"; // Número de voo
            LblOrigemDestino.Text = $"{bilheteEmitido.Voo.Origem} -> {bilheteEmitido.Voo.Destino}"; // Origem e destino
            LblDataHoraPartida.Text = $"Partida: {bilheteEmitido.Voo.DataHoraPartida:dd/MM/yyyy HH:mm}"; // Data e hora de partida
            LblHoraChegada.Text = $"Chegada: {bilheteEmitido.Voo.HoraChegada:dd/MM/yyyy HH:mm}\n(Não corresponde à hora local)"; // Data e hora de chegada
            LblNomePassageiro.Text = bilheteEmitido.Passageiro.NomeCompleto; // Nome do passageiro
            LblLugar.Text = $"Lugar: {bilheteEmitido.Lugar}"; // Lugar escolhido
            LblId.Text = $"#{bilheteEmitido.Id}"; // Id do bilhete
        }
    }
}
