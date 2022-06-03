using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models.ViewModels.Request
{
    public class PostProdutorDTO
    {
        [Required(ErrorMessage ="Nome do produtor é obrigatório")]
        [StringLength(50,MinimumLength = 3,ErrorMessage ="Nome do ator deve ter entre 3 e 50 letras")]
        [Display(Name ="Nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Foto do produtor é obrigatória")]   
        [Display(Name = "URL da foto de perfil")]
        public string FotoPerfilURL { get; set; }
        [Required(ErrorMessage = "A biografia do produtor é obrigatória")]
        [Display(Name = "Biografia")]
        public string Bio { get; set; }
    }
}
