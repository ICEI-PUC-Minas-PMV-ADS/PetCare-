namespace PetCare.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string confirma_senha { get; set; }
        public string nascimento { get; set; }
        public string imagem { get; set; }
    }
}
