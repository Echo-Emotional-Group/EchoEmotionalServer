namespace Models {
    public class Emotion {
        public Guid Id { get; set; }
        public string? Emotion_Desc { get; set; }

        public string? Id_Post { get; set; }

        public Perfil_User Perfil_User {get; set;}
        
        public ICollection<Emotion_Reaction> Emotion_Reactions {get; set;}

    }
     
}