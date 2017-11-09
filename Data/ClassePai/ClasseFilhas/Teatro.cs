using System;
using System.IO;
using System.Text;

namespace Data.ClassePai.ClasseFilhas
{
    public class Teatro : Evento
    {
        public string Diretor { get; set; }
        public string[] Elenco { get; set; }

        public Teatro() { }
        public Teatro(string titulo, string local, int lotacao, string duracao, int classificacao, DateTime data, string diretor, string[] elenco)
        {
            base.Titulo = titulo;
            base.Local = local;
            base.Lotacao = lotacao;
            base.Duracao = duracao;
            base.Classificacao = classificacao;
            base.Data = data;
            Diretor = diretor;
            Elenco = elenco;
        }
        public override bool Cadastrar()
        {
            bool rt = false;

            StreamWriter ar = null;

            try
            {
                ar = new StreamWriter("teatro.csv", true);
                ar.Write(
                            Titulo + ";" +
                            Diretor);

                foreach (string i in Elenco)
                    ar.Write(i + "-");

                ar.WriteLine(
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
                throw new Exception("Erro ao tentar cadastrar\n" + e.Message);
            }
            finally
            {
                ar.Close();
            }
            return rt;
        }
        public override string Pesquisar(string TituloEvento)
        {
            string rt = "Nada encontrado";
            string t;

            StreamReader src = null;
            try
            {
                src = new StreamReader("teatro.csv", Encoding.Default);
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
        public override string Pesquisar(DateTime DataEvento)
        {
            string rt = "Nada encontrado";
            string t;

            StreamReader src = null;
            try
            {
                src = new StreamReader("teatro.csv", Encoding.Default);
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
        public string PesquisarAtor(string ator){
            string rt = "Nada encontrado";
            string t;

            StreamReader src = null;
            try{
                src = new StreamReader("teatro.csv",Encoding.Default);
                while( (t = src.ReadLine()) != null){
                    string[] txt1 = t.Split(';');
                    string[] txt2 = txt1[2].Split('-');
                    foreach(string i in txt2){
                        if(i == ator){
                            rt+= t+"\n";
                            break;
                        }
                    }

                }
            }
            catch(Exception e){
                rt = "Erro ao tentar pesquisar\n"+e.Message;
            }
            finally{
                src.Close();
            }
            return rt;
        }
    }
}