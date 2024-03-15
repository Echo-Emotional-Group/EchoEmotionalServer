using System.ComponentModel.DataAnnotations;

namespace Models {
    public class Emotion_Reaction {
        public Guid Emotion_Id { get; set; }
        
        public Guid Reaction_Id {get; set; }
        
        public string? Id_account_facebook {get; set;}

        public Emotion Emotion {get; set;}

        public Reaction Reaction {get; set;}

        public Perfil_User Perfil_User {get; set;}

        

    }
     
}