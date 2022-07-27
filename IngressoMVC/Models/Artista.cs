using IngressoMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public int Id { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime DataAlteracao { get; private set; }
        public string Nome { get; private set; }
        [Display(Name ="URL da foto de perfil")]
        public string FotoPerfilURL { get; private set; }
        [Display(Name = "Biografia")]
        public string Bio { get;  private set; }

        public void AtualizarDados(string nome, string fotoPerfilUrl, string bio)
        {
            Nome = nome;
            Bio = bio;
            FotoPerfilURL = fotoPerfilUrl;
            DataAlteracao = DateTime.Now;
        }
    }
}
