using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models {
    [Table("emotion")]
    public class Emocao {
        public Guid Id { get; set; }
        [Column("emotion_desc")]
        public string? Descricao { get; set; }
        [Column("id_post")]
        public string? IdPost { get; set; }
        
        public ICollection<Registro> Registros {get; set;}

    }
     
}