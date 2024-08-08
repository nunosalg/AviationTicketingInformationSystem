namespace Biblioteca
{
    public class Voo
    {
        private static int id = 100;

        #region Atributos

        private string _origem;

        private string _destino;

        private TimeSpan _horasVoo;

        private Aparelho _aparelho;

        private List<string> _lugaresDisponiveis;

        private DateTime _dataHoraPartida;

        #endregion

        #region Propriedades

        public DateTime DataHoraPartida 
        {
            get
            {
                return _dataHoraPartida;
            }
            set
            {
                _dataHoraPartida = value;
                CalcularHoraChegada();
            }

        }

        public TimeSpan HorasVoo 
        { 
            get
            {
                return _horasVoo;
            }
            set
            {
                if (value.TotalMinutes > 0)
                {
                    _horasVoo = value;
                    CalcularHoraChegada();
                }
                else
                {
                    throw new Exception("Tem de definir a duração do voo!");
                }
            }
        }

        public DateTime HoraChegada { get; private set; }
        
        public string Origem 
        { 
            get
            {
                return _origem;
            }
            set
            {
                _origem = value;
            }
        }

        public string Destino 
        {
            get
            {
                return _destino;
            }
            set
            {
                _destino = value;
                AtualizarNumeroVoo();
            }
        }

        public string NumeroVoo { get; private set; }

        public Aparelho Aparelho 
        { 
            get 
            { 
                return _aparelho; 
            }
            set
            {
                if (value != null)
                {
                    _aparelho = value;
                }
                else
                {
                    throw new InvalidOperationException("Tem de indicar um aparelho para o voo!");
                }
            } 
        }

        public List<string> LugaresDisponiveis 
        { 
            get
            {
                return _lugaresDisponiveis;
            }
            set
            {
                _lugaresDisponiveis = new List<string>(value);
            } 
        }
             
        public List<Bilhete> ListaBilhetes { get; set; }
        #endregion

        /// <summary>
        /// Nomeia o voo consoante a origem e o destino
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private string NomearVoo()
        {
            if (VerificarOrigem() && VerificarDestino())
            {
                string letrasOrigem = _origem[0].ToString() + _origem[1].ToString();
                string letrasDestino = _destino[0].ToString() + _destino[1].ToString();
                // Atribuir as duas primeiras letras da origem e destino ao número de voo, seguidas do id
                return $"{letrasOrigem.ToUpper()}{letrasDestino.ToUpper()}{id}";
            }
            else
            {
                throw new Exception("Introduza dados válidos para origem e destino!");
            }
        }

        /// <summary>
        /// Atualiza o número do voo e o id
        /// </summary>
        private void AtualizarNumeroVoo()
        {
            NumeroVoo = NomearVoo();
            id++;
        }

        /// <summary>
        /// Verifica se os dados da origem são válidos
        /// </summary>
        /// <returns></returns>
        private bool VerificarOrigem()
        {
            if (!string.IsNullOrEmpty(_origem) && _origem.Length >= 2) 
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        /// <summary>
        /// Verifica se os dados do destino são válidos
        /// </summary>
        /// <returns></returns>
        private bool VerificarDestino()
        {
            if (!string.IsNullOrEmpty(_destino) && _destino.Length >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Calcula a hora de chegada consoante a hora de partida e duração do voo
        /// </summary>
        private void CalcularHoraChegada()
        {
            HoraChegada = DataHoraPartida.Add(HorasVoo);
        }

        /// <summary>
        /// Apresenta a disposição dos lugares no aparelho
        /// </summary>
        /// <returns></returns>
        public string ListarLugares()
        {
            string disposicaoLugares = "                Cockpit" + Environment.NewLine;
            int contador = 1;
            foreach (string lugar in Aparelho.Lugares)
            {
                disposicaoLugares += $"{lugar} ";

                if (contador % 3 == 0)
                {
                    disposicaoLugares += "  ";
                }
                // Após 6 lugares, mudar de linha para apresentar a fila seguinte
                if (contador % 6 == 0)
                {
                    disposicaoLugares += Environment.NewLine;
                }
                
                if (lugar == Aparelho.Lugares.Last())
                {
                    disposicaoLugares += "                  Cauda";
                }
                contador++;
            }
            return disposicaoLugares;
        }

        public override string ToString()
        {
            return $"Número voo: {NumeroVoo}\nData e hora de partida: {DataHoraPartida:dd/MM/yyyy HH:mm}\nHoras de voo: {HorasVoo}\nHora de chegada: {HoraChegada:dd/MM/yyyy HH:mm}\nOrigem: {Origem}\nDestino: {Destino}\n" +
                $"Avião: [{Aparelho.Id}] {Aparelho.Descricao}\n{Aparelho.CompanhiaAerea}\nLugares disponiveis:\n{LugaresDisponiveis.Count}\n" +
                $"Bilhetes emitidos:\n{ListaBilhetes.Count}";
        }
    }
}
