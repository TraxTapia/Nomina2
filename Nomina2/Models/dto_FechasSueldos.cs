using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nomina2.Models
{
    public class dto_FechasSueldos
    {

        public string NumEmp { get; set; }
        public string TipoContrato { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaAntiguedad { get; set; }
        public DateTime FechaVencimientoContrato { get; set; }
        public DateTime FechaPlanta { get; set; }
        public DateTime FechaAntiguedadPuesto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaReservada { get; set; }
        public string Compañia { get; set; }
        public string Localidad { get; set; }
        public string Direccion { get; set; }
        public string Subdireccion { get; set; }
        public string Departamento { get; set; }
        public string Puesto { get; set; }
        public string NivelTabular { get; set; }
        public string CategoriaSueldo { get; set; }
        public string Turno { get; set; }
        public string DuracionPlaza { get; set; }
        public string CveRegistroPatronal { get; set; }
        public string CentroBeneficio { get; set; }
        public string TipoNomina { get; set; }
        public string ZonaSalarioMinimo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SueldoMensual { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SueldoDiario { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SueldoDiarioIntegrado { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IntegradoSinTope { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ParteFija { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FactorIntegracion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VariableBimestreAnterior { get; set; }

        public int DiasBimestreAnterior { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IntegradoInfonavit { get; set; }
    }
}
