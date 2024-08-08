namespace Biblioteca
{
    public class Aparelho
    {
        private int _capacidade;

        private List<string> _lugares;

        #region Propriedades

        public int Id { get; set; }

        public string Descricao { get; set; }

        public string CompanhiaAerea { get; set; }

        public int Capacidade 
        { 
            get
            {
                return _capacidade;
            } 
            set
            {
                if (value > 300)
                {
                    throw new ArgumentException("A capacidade não pode ser superior a 300 lugares!");
                }
                else
                {
                    _capacidade = value;
                }
            }
        }

        public List<string> Lugares 
        {  
            get
            {
                return _lugares;
            } 
            set
            {
                _lugares = value;
                NomearLugares();
            }
        }

        public bool Activo { get; set; }

        public string IdDescricao 
        { 
            get
            {
                return $"[{Id}] - {Descricao}";
            }
        }

        #endregion

        /// <summary>
        /// Nomeia os lugares, do aparelho, tendo em conta a capacidade
        /// </summary>
        private void NomearLugares()
        {
            string[] letrasLugares = ["A", "B", "C", "D", "E", "F"];
            int x = 0; // Indice do array
            int fila = 1;
            string lugar;

            _lugares.Clear();

            for (int i = _capacidade; i > 0; i--)
            {
                if (fila < 10)
                {
                    lugar = $"0{fila}{letrasLugares[x]}";
                }
                else
                {
                    lugar = $"{fila}{letrasLugares[x]}";
                }
                
                _lugares.Add(lugar);

                x++;
                // Voltar ao indice inicial do array e mudar o numero da fila
                if (x == 6)
                {
                    x = 0;
                    fila++;
                }
            }
        }

        /// <summary>
        /// Retorna o estado do aparelho (ativo ou inativo)
        /// </summary>
        /// <returns></returns>
        private string EstadoAparelho()
        {
            if (Activo)
            {
                return "Ativo";
            }
            else
            {
                return "Inativo";
            }
        }

        public override string ToString()
        {
            return $"ID: [{Id}]\nDescrição: {Descricao}\nCompanhia aérea: {CompanhiaAerea}\nCapacidade: {Capacidade} lugares\n" +
                $"Estado: {EstadoAparelho()}\n";
        }
    }
}
