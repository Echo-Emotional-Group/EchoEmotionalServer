namespace Models {
    public class Reaction {
        public Guid Id { get; set; }

        public string? Tipo { get; set; }
       
        public ICollection<Emotion_Reaction> Emotion_Reactions {get; set;}

    }
     
}