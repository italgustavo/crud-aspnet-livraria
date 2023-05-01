using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaBiblioteca.Models
{
    [Table("LIVRO")]
    public class Livros
    {
        [DisplayName("Codigo")]
        [Column("ID")]
        public int Id { get; set; }

        [DisplayName("Nome")]
        [Column("NOME")]
        public string Name { get; set; }

        [DisplayName("Nome do autor")]
        [Column("NOME_AUTOR")]
        public string NomeAutor { get; set; }

        [DisplayName("Nome Editora")]
        [Column("EDITORA")]
        public string Editora { get; set; }

        [DisplayName("Data compra")]
        [Column("DATA_COMPRA")]
        public DateTime DataCompra { get; set; }

        [DisplayName("Estoque")]
        [Column("ID_ESTOQUE")]
        public int IdEstoque { get; set; }

        public Estoque Estoque { get; set; }
    }
}
