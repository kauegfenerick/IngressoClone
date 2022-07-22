using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models.ViewModels.Request
{
    public class PostCategoriaDTO
    {
        [Required, StringLength(50, MinimumLength = 1, ErrorMessage = "Campo Obrigatório")]
        public string Nome { get; set; }

    }
}
