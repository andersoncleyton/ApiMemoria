using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMemoria.Model
{

    /// <summary>
    /// Classe de categoria
    /// </summary>
    public class Categoria
    {
        [Key]
        public int Id{get;set;}

        [Required(ErrorMessage="Nome obrigatorio.")]
        public string Nome{get; set;}
    }
}