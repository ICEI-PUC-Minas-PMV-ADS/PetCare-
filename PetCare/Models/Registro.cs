namespace PetCare.Models
{
    public class Registro
    {
        public int id { get; set; }
        public int idPet { get; set; }
        public int idDono { get; set; }
        public string tipoRegistro { get; set; }
        public string descricao { get; set; }
    }
}
