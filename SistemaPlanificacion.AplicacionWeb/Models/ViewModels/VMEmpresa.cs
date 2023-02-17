using SistemaPlanificacion.Entity;

namespace SistemaPlanificacion.AplicacionWeb.Models.ViewModels
{
    public class VMEmpresa
    {
        public int IdEmpresa { get; set; }

        public string? Nombre { get; set; }
        public int? EsActivo { get; set; }
    }
}
