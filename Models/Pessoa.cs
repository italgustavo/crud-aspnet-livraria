using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SistemaBiblioteca.Models
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [DisplayName("Codigo")]
        [Column("ID")]
        public int Id { get; set; }

        [DisplayName("Cpf")]
        [Column("CPF")]
        public string Cpf { get; set; }

        [DisplayName("Nome")]
        [Column("NOME")]
        public string Nome { get; set; }

        [DisplayName("Data de nascimento")]
        [Column("DATANASCIMENTO")] 
        public DateTime DataNascimento { get; set; }

        [DisplayName("Telefone")]
        [Column("TELEFONE")]
        public string Telefone { get; set; }

        [DisplayName("Endereço")]
        [Column("ID_ENDERECO")]
        public Endereco Endereco { get; set; }

    }
}
