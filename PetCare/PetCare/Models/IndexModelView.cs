namespace PetCare.Models
{
    public class IndexModelView
    {
        public int idPet { get; set; }
        public Registro Registro { get; set; }
        public Medicamento Medicamento { get; set; }
        public Peso Peso { get; set; }
        public Vacina Vacina { get; set; }
        public List<IndexModelView> ListaRegistrosPesos { get; set; }
        public List<IndexModelView> ListaRegistrosMedicamentos { get; set; }
        public List<IndexModelView> ListaRegistrosVacinas { get; set; }
    }
}
