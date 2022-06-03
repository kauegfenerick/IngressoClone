using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models.ViewModels.Request
{
    public class PostCinemaDTO
    {
        [Display(Name ="Nome")]
        [Required(ErrorMessage ="O cinema deve ter um nome")]
        public string Nome { get; set; }
        [Display(Name = "Descrição")]
        public string Descricacao { get; set; }
        [Required(ErrorMessage ="O cinema deve possuir uma logo")]
        [Display(Name = "URL da Logo")]
        public string LogoURL { get; set; }
    }
}
