namespace Models {
    public class Usuario {
        public Guid Id { get; set; }

        public required string Nome_Completo { get; set; }
        public required int  Data_Nascimento { get; set; }

        public DateTime Data_Registro { get; set; }

    }
}