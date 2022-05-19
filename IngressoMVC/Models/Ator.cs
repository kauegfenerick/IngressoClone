using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class Ator : Artista
    {
        public Ator(string nome, string fotoPerfilURL, string bio) : base(nome, fotoPerfilURL, bio)
        {
        }
        #region Relacionamentos
        public List<AtorFilme> AtoresFilmes{ get; set; }

        #endregion
    }
}
