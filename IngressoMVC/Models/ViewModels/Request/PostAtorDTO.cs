using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models.ViewModels.Request
{
    public class PostAtorDTO
    {
        [Required(ErrorMessage = "Nome do ator é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Nome do ator deve ter entre 3 e 50 letras")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Foto do ator é obrigatória")]
        [Display(Name = "URL da foto de perfil")]
        public string FotoPerfilURL { get; set; }
        [Display(Name = "Biografia")]
        public string Bio { get; set; }
    }
}
