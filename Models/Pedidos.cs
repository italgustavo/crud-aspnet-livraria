using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaBiblioteca.Models
{
    [Table("PEDIDOS")]
    public class Pedidos
    {
        [DisplayName("Codigo")]
        [Column("ID")]
        public int Id { get; set; }

        [DisplayName("Pessoa")]
        [Column("PESSOA_ID")]
        public int IdPessoa { get; set; }

        [DisplayName("Endereço")]
        [Column("LIVRO_ID")]
        public int IdLivro { get; set; }

        [DisplayName("Endereço")]
        [Column("DATA_EMPRESTIMO")]
        public DateTime DataEmprestimo { get; set; }

        [DisplayName("Endereço")]
        [Column("OBSERVACAO")]
        public string Observacao { get; set; }
    }
}
