namespace Biblioteca
{
    public class GerirArquivos
    {
        /// <summary>
        /// Grava os aparelhos num ficheiro
        /// </summary>
        /// <param name="aparelhos"></param>
        /// <param name="caminho"></param>
        public static void GravarAparelhos(List<Aparelho> aparelhos, string caminho)
        {
            using (StreamWriter sw = new StreamWriter(caminho, false))
            {
                if (aparelhos.Count > 0) // Gravar apenas se a lista de aparelhos conter algum aparelho
                {
                    foreach (Aparelho aparelho in aparelhos)
                    {
                        string linha = $"{aparelho.Id};{aparelho.Descricao};{aparelho.CompanhiaAerea};{aparelho.Capacidade};{aparelho.Activo}";

                        sw.WriteLine(linha);
                    }
                }
            }
        }

        /// <summary>
        /// Carrega a lista de aparelhos, caso existam, num ficheiro
        /// </summary>
        /// <param name="caminho"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static List<Aparelho> CarregarAparelhos(string caminho)
        {
            List<Aparelho> aparelhos = new List<Aparelho>(); // Instanciar a lista de aparelhos

            if (File.Exists(caminho)) // Caso o ficheiro exista
            {
                using (StreamReader sr = new StreamReader(caminho))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null) // Ler enquanto o ficheiro conter linhas com dados
                    {
                        string[] dadosAparelho = linha.Split(';');

                        Aparelho aparelho = new Aparelho
                        {
                            Id = Convert.ToInt32(dadosAparelho[0]),
                            Descricao = dadosAparelho[1],
                            CompanhiaAerea = dadosAparelho[2],
                            Capacidade = Convert.ToInt32(dadosAparelho[3]),
                            Activo = Convert.ToBoolean(dadosAparelho[4]),
                            Lugares = new List<string>() // Vai buscar a lista de lugares dentro da classe
                        };

                        aparelhos.Add(aparelho); // Adiciona o aparelho à lista de aparelhos
                    }
                }
            }

            return aparelhos;
        }

        /// <summary>
        /// Grava os voos num ficheiro
        /// </summary>
        /// <param name="voos"></param>
        /// <param name="caminho"></param>
        public static void GravarVoos(List<Voo> voos, string caminho)
        {
            using (StreamWriter sw = new StreamWriter(caminho, false))
            {
                if (voos.Count > 0) // Gravar apenas se a lista de voos conter algum voo
                {
                    foreach (Voo voo in voos)
                    {
                        string linha;

                        if (voo.ListaBilhetes.Count > 0) // Caso a lista de bilhetes do voo contenha algum bilhete emitido
                        {
                            // Gravar os bilhetes pelo id para carregar a informação posteriormente ao carregamento da lista global de bilhetes
                            string listaBilhetes = string.Join(",", voo.ListaBilhetes.Select(b => b.Id));

                            linha = $"{voo.DataHoraPartida};{voo.HorasVoo};{voo.Origem};{voo.Destino};{voo.Aparelho.Id};{listaBilhetes}";
                        }
                        else
                        {
                            linha = $"{voo.DataHoraPartida};{voo.HorasVoo};{voo.Origem};{voo.Destino};{voo.Aparelho.Id}";
                        }

                        sw.WriteLine(linha);
                    }
                }
            }
        }

        /// <summary>
        /// Carrega a lista de voos, caso existam, num ficheiro
        /// </summary>
        /// <param name="caminho"></param>
        /// <param name="listaAparelhos"></param>
        /// <returns></returns>
        public static List<Voo> CarregarVoos(string caminho, List<Aparelho> listaAparelhos)
        {
            List<Voo> voos = new List<Voo>(); // Instancia a lista de voos

            if (File.Exists(caminho))
            {
                using (StreamReader sr = new StreamReader(caminho))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] dadosVoo = linha.Split(';');
                        // Verificar a qual aparelho corresponde o aparelho.Id guardado
                        Aparelho aparelhoVoo = listaAparelhos.First(a => a.Id == Convert.ToInt32(dadosVoo[4]));

                        Voo voo = new Voo
                        {
                            DataHoraPartida = DateTime.Parse(dadosVoo[0]),
                            HorasVoo = TimeSpan.Parse(dadosVoo[1]),
                            Origem = dadosVoo[2],
                            Destino = dadosVoo[3],
                            Aparelho = aparelhoVoo,
                            LugaresDisponiveis = new List<string>(aparelhoVoo.Lugares), // Vai buscar a lista de lugares disponiveis dentro da classe
                            ListaBilhetes = new List<Bilhete>()
                        };

                        voos.Add(voo);
                    }
                }
            }

            return voos;
        }

        /// <summary>
        /// Grava os bilhetes num ficheiro
        /// </summary>
        /// <param name="listaBilhetes"></param>
        /// <param name="caminho"></param>
        public static void GravarBilhetes(List<Bilhete> listaBilhetes, string caminho)
        {
            using (StreamWriter sw = new StreamWriter(caminho, false))
            {
                if (listaBilhetes.Count > 0) // Caso a lista de bilhetes global contenha algum bilhete
                {
                    foreach (Bilhete bilhete in listaBilhetes)
                    {
                        string linha = $"{bilhete.Id};{bilhete.Voo.NumeroVoo};{bilhete.Lugar};{bilhete.Passageiro.Nome};{bilhete.Passageiro.Apelido};{bilhete.Passageiro.NumeroId};{bilhete.Passageiro.DataNascimento:dd/MM/yyyy}";

                        sw.WriteLine(linha);
                    }
                }
            }
        }

        /// <summary>
        /// Carrega a lista de bilhetes, caso existam, num ficheiro
        /// </summary>
        /// <param name="caminho"></param>
        /// <param name="listaVoos"></param>
        /// <returns></returns>
        public static List<Bilhete> CarregarBilhetes(string caminho, List<Voo> listaVoos)
        {
            List<Bilhete> bilhetes = new List<Bilhete>(); // Instancia a lista de bilhetes global

            if (File.Exists(caminho))
            {
                using (StreamReader sr = new StreamReader(caminho))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] dadosBilhete = linha.Split(";");

                        Passageiro passageiro = new Passageiro
                        {
                            Nome = dadosBilhete[3],
                            Apelido = dadosBilhete[4],
                            NumeroId = Convert.ToInt32(dadosBilhete[5]),
                            DataNascimento = DateTime.Parse(dadosBilhete[6])
                        };

                        Bilhete bilhete = new Bilhete
                        {
                            Id = Convert.ToInt32(dadosBilhete[0]),
                            Voo = listaVoos.First(v => v.NumeroVoo == dadosBilhete[1]),
                            Lugar = dadosBilhete[2],
                            Passageiro = passageiro
                        };
                        // Adiciona o bilhete à lista global
                        bilhetes.Add(bilhete);
                        // Adiciona o bilhete à lista de bilhetes do voo correspondente
                        bilhete.Voo.ListaBilhetes.Add(bilhete);
                    }
                }
            }

            return bilhetes;
        }
    }
}