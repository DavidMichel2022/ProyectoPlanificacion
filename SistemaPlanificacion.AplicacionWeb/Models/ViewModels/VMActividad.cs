using SistemaPlanificacion.Entity;

namespace SistemaPlanificacion.AplicacionWeb.Models.ViewModels
{
    public class VMActividad
    {
        public int IdActividad { get; set; }
        public string? Nombre { get; set; }
        public int? EsActivo { get; set; }
    }
}
