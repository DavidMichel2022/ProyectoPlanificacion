using SistemaPlanificacion.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPlanificacion.BLL.Interfaces
{
    public interface ICentroSaludService
    {
        Task<List<CentroSalud>> Lista();
        Task<Empresa> Crear(CentroSalud entidad);
        Task<Empresa> Editar(CentroSalud entidad);
        Task<bool> Eliminar(int idCentroSalud);
    }
}
