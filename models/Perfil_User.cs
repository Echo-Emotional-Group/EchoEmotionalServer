using System.ComponentModel.DataAnnotations;

namespace Models {
    public class Perfil_User {
        [Key]
        public string? Id_account_facebook { get; set; }

        public string? Full_Name { get; set; }
        public  DateTime Data_Post { get; set; }
        public  DateTime Data_Nasc { get; set; }
        public DateTime Data_Registro { get; set; }

        public ICollection<Emotion> Emotions {get; set;}

        public ICollection<Emotion_Reaction> Emotion_Reactions {get; set;}

    }
     
}