using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace SistemaBiblioteca.Models
{
    [Table("ESTOQUE")]
    public class Estoque
    {
        [DisplayName("Codigo")]
        [Column("ID")]
        public int Id { get; set; }

        [DisplayName("Quantidade")]
        [Column("QUANTIDADE")]
        public int Quantidade { get; set; }

        [DisplayName("LIVROS")]
        [Column("FK_ESTOQUE_LIVRO_ID")]
        public Livros Livro { get; set; }

    }
}
