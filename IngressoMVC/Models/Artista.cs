using IngressoMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    abstract public class Artista : IEntidade
    {
        protected Artista(string nome, string fotoPerfilURL, string bio)
        {
            DataCadastro = DateTime.Now;
            DataAlteracao = DataCadastro;
            Nome = nome;
            FotoPerfilURL = fotoPerfilURL;
            Bio = bio;
        }

        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Nome { get; private set; }
        public string FotoPerfilURL { get; private set; }
        public string Bio { get;  private set; }
    }
}
