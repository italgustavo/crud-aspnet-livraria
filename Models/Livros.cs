using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaBiblioteca.Models
{
    [Table("LIVROS")]
    public class Livros
    {
        [DisplayName("Codigo")]
        [Column("ID")]
        public int Id { get; set; }

        [DisplayName("Nome")]
        [Column("NOME")]
        public string Name { get; set; }

        [DisplayName("Nome do autor")]
        [Column("NOMEAUTOR")]
        public string NomeAutor { get; set; }

        [DisplayName("Nome Editora")]
        [Column("EDITORA")]
        public string Editora { get; set; }

        [DisplayName("Data compra")]
        [Column("DATACOMRPA")]
        public DateTime DataCompra { get; set; }

        [DisplayName("Data de lançamento")]
        [Column("DATALANCAMENTO")]
        public DateTime DataLancamento { get; set; }

    }
}
