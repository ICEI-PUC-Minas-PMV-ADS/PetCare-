namespace PetCare.Models
{
    public class Pet
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string especie { get; set; }
        public string raca { get; set; }
        public string nascimento { get; set; }
        public string imagem { get; set; }
        public int idDono { get; set; }
    }
}
