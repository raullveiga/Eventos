using System;
using System.IO;
using System.Text;

namespace Data.ClassePai.ClasseFilhas
{
    public class Show : Evento
    {
        public string Artista { get; set; }
        public string GeneroMusical { get; set; }
        /// <summary>
        /// Construtor vazio para instanciação
        /// </summary>
        public Show()
        {

        }
        /// <summary>
        /// Construtor com os parametros necessários para funcionamento dos métodos.
        /// </summary>
        /// <param name="titulo">Passe titulo como String</param>
        /// <param name="local">Passe local como string</param>
        /// <param name="lotacao"></param>
        /// <param name="data">Passe lotacao como int</param>
        /// <param name="duracao">Passe data como DateTime</param>
        /// <param name="classificacao">Passe classificacao como int</param>
        public Show(string titulo, string local, int lotacao, string duracao, int classificacao, DateTime data, string artista, string generoMusical)
        {
            base.Titulo = titulo;
            base.Local = local;
            base.Lotacao = lotacao;
            base.Duracao = duracao;
            base.Classificacao = classificacao;
            base.Data = data;
            Artista = artista;
            GeneroMusical = generoMusical;
        }
        /// <summary>
        /// O método Cadastrar grava os dados do objeto em show.csv
        /// </summary>
        /// <returns></returns>
        public override bool Cadastrar()
        {
            bool rt = false;

            StreamWriter ar = null;

            try
            {
                ar = new StreamWriter("show.csv", true);
                ar.WriteLine(
                            Titulo + ";" +
                            Artista + ";" +
                            GeneroMusical + ":" +
                            Local + ";" +
                            Lotacao + ";" +
                            Duracao + ";" +
                            Classificacao + ";" +
                            Data
                );
                rt = true;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao tentar gravar o arquivo:\n " + e.Message);
            }
            finally
            {
                ar.Close();
            }

            return rt;

        }
        /// <summary>
        /// O método Pesquisar, realiza uma busca em show.csv usando o dado passado como parâmetro de pesquisa
        /// </summary>
        /// <param name="TituloEvento">Passe TituloEvento como string</param>
        /// <returns>Retorna todas as linhas do arquivo que contenham o parâmetro passado</returns>
        public override string Pesquisar(string TituloEvento)
        {
            string rt = "Nada encontrado";
            string t;

            StreamReader src = null;
            try
            {
                src = new StreamReader("show.csv", Encoding.Default);
                while ((t = src.ReadLine()) != null)
                {
                    string[] txt = t.Split(';');
                    if (txt[7] == TituloEvento)
                        rt += t + "\n";
                }
            }
            catch (Exception e)
            {
                rt = "Erro ao tentar pesquisar \n" + e.Message;
            }
            finally
            {
                src.Close();
            }
            return rt;
        }
        /// <summary>
        /// O método Pesquisar, realiza uma busca em show.csv usando o dado passado como parâmetro de pesquisa
        /// </summary>
        /// <param name="TituloEvento">Passe DataEvento como DateTime</param>
        /// <returns>Retorna todas as linhas do arquivo que contenham o parâmetro passado</returns>
        public override string Pesquisar(DateTime DataEvento){
            string rt = "Nada encontrado";
            string t;

            StreamReader src = null;
            try
            {
                src = new StreamReader("show.csv", Encoding.Default);
                while ((t = src.ReadLine()) != null)
                {
                    string[] txt = t.Split(';');
                    if (txt[6] == DataEvento.ToString())
                        rt += t + "\n";
                }
            }
            catch (Exception e)
            {
                rt = "Erro ao tentar pesquisar \n" + e.Message;
            }
            finally
            {
                src.Close();
            }
            return rt;
        }
    }
}