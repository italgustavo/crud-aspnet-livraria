using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaBiblioteca.Models
{
    [Table("ENDERECO")]
    public class Endereco
    {
        [DisplayName("Codigo")]
        [Column("ID")]
        public int Id { get; set; }

        [DisplayName("Cep")]
        [Column("CEP")]
        public string Cep { get; set; }

        [DisplayName("Cidade")]
        [Column("CIDADE")]
        public string Cidade { get; set; }

        [DisplayName("Estado")]
        [Column("ESTADO")]
        public string Estado { get; set; }

        [DisplayName("Codigo")]
        [Column("LOGRADOURO")]
        public string Logradouro { get; set; }

    }
}
