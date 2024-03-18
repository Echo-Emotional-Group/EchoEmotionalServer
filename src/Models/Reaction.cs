using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models {

    [Table("reaction")]
    public class Reaction {
        [Column("id")]
        public int Id { get; set; }
        [ForeignKey("Emotion")]
        [Column("post_id")]
        public string PostId { get; set; }
        [Column("reaction_id")]
        public int ReactionId { get; set; }
        public Emotion Emotion { get; set; }
    };

};