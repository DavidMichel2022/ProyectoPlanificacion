using SistemaPlanificacion.Entity;

namespace SistemaPlanificacion.AplicacionWeb.Models.ViewModels
{
    public class VMCentroSalud
    {
        public int IdCentro { get; set; }
        public string? NombreCentro { get; set; }
        public int? EsActivo { get; set; }
    }
}
