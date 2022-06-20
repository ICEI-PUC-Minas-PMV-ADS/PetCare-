namespace PetCare.Models
{
    public class Registro
    {
        public int id { get; set; }
        public int idPet { get; set; }

        public string tipoRegistro { get; set; }
        public string descricao { get; set; }
    }
}
