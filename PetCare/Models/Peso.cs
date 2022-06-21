namespace PetCare.Models
{
    public class Peso : Registro
    {
        public int idRegistro { get; set; }
        public double peso { get; set; }
        public string observacao { get; set; }
        public string dataPesagem { get; set; }
    }
}
