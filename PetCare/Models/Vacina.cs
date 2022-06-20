namespace PetCare.Models
{
    public class Vacina : Registro
    {
        public int idRegistro { get; set; }
        public string nome { get; set; }
        public string aplicacao { get; set; }
        public string reaplicacao { get; set; }
    }
}
