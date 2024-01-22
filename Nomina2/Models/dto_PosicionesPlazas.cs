namespace Nomina2.Models
{
    public class dto_PosicionesPlazas
    {
        public int PosicionId { get; set; }
        public int PosicionSup { get; set; }
        public string Cia { get; set; }
        public string Localidad { get; set; }
        public string Direccion { get; set; }
        public string Departamento { get; set; }
        public string Puesto { get; set; }
        public string Plaza { get; set; }
        public string TipoPlaza { get; set; }
        public int PzasAutorizadas { get; set; }
        public int PzasOcupadas { get; set; }
        public int PzasEvAutorizadas { get; set; }
        public int PzasEvOcupadas { get; set; }
        public string Empleado { get; set; }
        public string EmpleadoExterno { get; set; }
    }
}
