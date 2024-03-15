using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models {
    [Table("reaction")]
    public class Reacao {
        public Guid Id { get; set; }

        [Column("type")]
        public string? Tipo { get; set; }

        public ICollection<Registro> Registros {get; set;}

    }
     
}