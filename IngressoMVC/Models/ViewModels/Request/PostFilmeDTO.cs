using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IngressoMVC.Models.ViewModels.RequestDTO
{
    public class PostFilmeDTO
    {
        [Display(Name = "T�tulo")]
        [Required(ErrorMessage = "O t�tulo � obrigat�rio!")]
        public string Titulo { get; set; }

        [Display(Name = "Descri��o")]
        [Required(ErrorMessage = "A descri��o � obrigat�ria!")]
        public string Descricao { get; set; }

        [Display(Name = "Pre�o")]
        [Required(ErrorMessage = "O Pre�o � obrigat�rio!")]
        public decimal Preco { get; set; }

        [Display(Name = "Imagem")]
        [Required(ErrorMessage = "A imagem � obrigat�ra!")]
        public string ImagemURL { get; set; }

        [Display(Name = "Estr�ia")]
        [Required(ErrorMessage = "Estr�ia � obrigat�ria!")]
        public DateTime DataLancamento { get; set; }

        [Display(Name = "Encerramento")]
        [Required(ErrorMessage = "Encerramento � obrigat�rio!")]
        public DateTime DataEncerramento { get; set; }

        #region relacionamentos
        [Display(Name = "Informe o Cinema")]
        [Required(ErrorMessage = "Cinema � Obrigat�rio")]
        public int CinemaId { get; set; }

        [Display(Name = "Informe o Produtor")]
        [Required(ErrorMessage = "Produtor � Obrigat�rio")]
        public int ProdutorId { get; set; }

        [Display(Name = "Informe o(s) Ator(es)")]
        [Required(ErrorMessage = "Ator(es) � Obrigat�rio")]
        public List<int> AtoresId { get; set; }

        [Display(Name = "Informe a(s) Categoria(s)")]
        [Required(ErrorMessage = "Categoria(s) � Obrigat�rio")]
        public List<int> CategoriasId { get; set; }
        #endregion
    }
}