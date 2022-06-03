using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models.ViewModels.Request
{
    public class PostCategoriaDTO
    {
        [Display(Name ="Categoria")]
        [Required(ErrorMessage ="A categoria não pode ser vazia")]
        public string Categoria { get; set; }
    }
}
