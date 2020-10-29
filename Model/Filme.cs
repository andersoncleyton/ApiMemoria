using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMemoria.Model
{
    /// <summary>
    /// Classe de filme
    /// </summary>
    public class Filme
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{get;set;}

        [Required(ErrorMessage="Titulo obrigatorio.")]
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano {get; set;}

        [Required(ErrorMessage="Categoria obrigatoria.")]
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

    }
}