using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models {
    [Table("emotion_reaction")]
    public class Registro 
    {
        [Column("emotion_id")]
        public Guid IdEmocao { get; set; }
        [Column("reaction_id")]
        public Guid idReacao {get; set; }

        public Emocao Emocao {get; set;}
        public Reacao Reacao {get; set;}
    }
}