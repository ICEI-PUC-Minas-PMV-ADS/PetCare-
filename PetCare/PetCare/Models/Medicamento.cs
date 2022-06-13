namespace PetCare.Models
{

    public class Medicamento : Registro
    {
        public int idRegistro { get; set; }
        public string nome { get; set; }
        public string aplicacao { get; set; }
        public string reaplicacao { get; set; }
        public string dosagem { get; set; }

    }
}
