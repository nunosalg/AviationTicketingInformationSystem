namespace Biblioteca
{
    public class Passageiro
    {
        private DateTime _dataNascimento;

        #region Propriedades

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public int NumeroId { get; set; }

        public DateTime DataNascimento
        {
            get
            {
                return _dataNascimento;
            }
            set
            {
                if (ValidarDataNascimento(value))
                {
                    _dataNascimento = value.Date;
                }
                else
                {
                    throw new Exception("Inseriu um ano inválido para a data de nascimento!");
                }
            }
        }

        public string NomeCompleto
        {
            get { return $"{Nome} {Apelido}"; }
        }

        #endregion

        /// <summary>
        /// Verifica se o ano de nascimento não é inferior a 1920
        /// </summary>
        /// <returns></returns>
        private bool ValidarDataNascimento(DateTime dataNascimento)
        {
            if (dataNascimento.Year > 1920)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"Nome: {NomeCompleto}\nNúmero de identificação: {NumeroId}\nData de nascimento: {DataNascimento:dd/MM/yyyy}";
        }
    }
}
