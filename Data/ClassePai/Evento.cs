using System;
using System.Collections.Generic;

namespace Data.ClassePai{
    public abstract class Evento{
        protected string Titulo { get; set; }
        protected string Local { get; set; }
        protected int Lotacao { get; set; }
        protected DateTime Data { get; set; }
        protected string Duracao { get; set; }
        protected int Classificacao { get; set; }
        /// <summary>
        /// Construtor vazio para instanciação
        /// </summary>

        public Evento(){}
        /// <summary>
        /// Construtor com os parametros necessários para funcionamento dos métodos.
        /// </summary>
        /// <param name="titulo">Passe titulo como String</param>
        /// <param name="local">Passe local como string</param>
        /// <param name="lotacao"></param>
        /// <param name="data">Passe lotacao como int</param>
        /// <param name="duracao">Passe data como DateTime</param>
        /// <param name="classificacao">Passe classificacao como int</param>
        public Evento(string titulo,string local, int lotacao, DateTime data, string duracao, int classificacao, Ingresso ingresso){
            Titulo = titulo;
            Local = local;
            Lotacao = lotacao;
            Data = data;
            Duracao = duracao;
            Classificacao = classificacao;
        }
        /// <summary>
        /// O método Cadastrar grava os dados do objeto em um arquivo .csv
        /// </summary>
        /// <returns></returns>
        public virtual bool Cadastrar(){
            
            return false;
        }
        /// <summary>
        /// O método Pesquisar, realiza uma busca em show.csv usando o dado passado como parâmetro de pesquisa
        /// </summary>
        /// <param name="TituloEvento">Passe DataEvento como DateTime</param>
        /// <returns>Retorna todas as linhas do arquivo que contenham o parâmetro passado</returns>
        public virtual string Pesquisar(DateTime DataEvento){
        return "";
        }
        /// <summary>
        /// O método Pesquisar, realiza uma busca em show.csv usando o dado passado como parâmetro de pesquisa
        /// </summary>
        /// <param name="TituloEvento">Passe TituloEvento como string</param>
        /// <returns>Retorna todas as linhas do arquivo que contenham o parâmetro passado</returns>
        public virtual string Pesquisar(string TituloEvento){
            
            List<Evento> Evento;
        
        return "";
        }
    }
}