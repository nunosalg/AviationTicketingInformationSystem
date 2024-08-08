namespace Biblioteca
{
    public class Bilhete
    {
        private string _lugar;

        #region Propriedades

        public int Id { get; set; }

        public Voo Voo { get; set; }

        public string Lugar 
        {
            get
            {
                return _lugar;
            }    
            set
            {
                _lugar = value;
                RemoverLugarDisponivel(_lugar);
            }
        }

        public Passageiro Passageiro { get; set; }

        public string InfoBilhete
        {
            get { return $"{Id}-{Passageiro.NomeCompleto}-{Passageiro.NumeroId}"; }
        }      
        
        #endregion

        /// <summary>
        /// Remove o lugar, escolhido no bilhete, da lista de lugares disponiveis do voo
        /// </summary>
        /// <param name="lugarEscolhido"></param>
        private void RemoverLugarDisponivel(string lugarEscolhido)
        {
            Voo.LugaresDisponiveis.Remove(lugarEscolhido);
        }

        public override string ToString()
        {
            return $"ID bilhete: #{Id}\n{Voo.NumeroVoo}\nOrigem: {Voo.Origem}\nDestino: {Voo.Destino}\nData e hora: {Voo.DataHoraPartida}\n" +
                $"Lugar: {Lugar}\nPassageiro: {Passageiro.NomeCompleto} {Passageiro.NumeroId}";
        }
    }
}
