using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models {

    [Table("emotion")]
    public class Emotion {
        [Key]
        [Column("post_id")]
        public string PostId { get; set; }
        [Column("description")]
        public string? Description { get; set; }
        [Column("last_edition")]
        public DateTime LastEdition { get; set; }
        public ICollection<Reaction> Reactions { get; set; }
    };
     
};