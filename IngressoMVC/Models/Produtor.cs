using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class Produtor : Artista
    {
        public Produtor(string nome, string fotoPerfilURL, string bio) : base(nome, fotoPerfilURL, bio)
        {
        }
        #region Relacionamentos
        public List<Filme> Filmes { get; set; }
        #endregion
    }
}
