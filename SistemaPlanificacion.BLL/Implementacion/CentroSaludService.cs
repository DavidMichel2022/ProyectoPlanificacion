using SistemaPlanificacion.BLL.Interfaces;
using SistemaPlanificacion.DAL.Interfaces;
using SistemaPlanificacion.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPlanificacion.BLL.Implementacion
{
    public class CentroSaludService : ICentroSaludService
    {
        private readonly IGenericRepository<CentroSalud> _repositorio;
        public CentroSaludService(IGenericRepository<CentroSalud> repositorio)
        {
            _repositorio = repositorio;
        }
        public Task<Empresa> Crear(CentroSalud entidad)
        {
            throw new NotImplementedException();
        }

        public Task<Empresa> Editar(CentroSalud entidad)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int idCentroSalud)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CentroSalud>> Lista()
        {
            IQueryable<CentroSalud> query = await _repositorio.Consultar();
            return query.ToList();
        }


    }
}
