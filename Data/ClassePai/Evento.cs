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
        protected Ingresso Ingresso { get; set; }

        public Evento(){}
        public Evento(string titulo,string local, int lotacao, DateTime data, string duracao, int classificacao, Ingresso ingresso){
            Titulo = titulo;
            Local = local;
            Lotacao = lotacao;
            Data = data;
            Duracao = duracao;
            Classificacao = classificacao;
            Ingresso = ingresso;
        }

        public virtual bool Cadastrar(){
            
            return false;
        }
        public virtual string Pesquisar(DateTime DataEvento){
        return "";
        }
        public virtual string Pesquisar(string TituloEvento){
            
            List<Evento> Evento;
        
        return "";
        }
    }
}