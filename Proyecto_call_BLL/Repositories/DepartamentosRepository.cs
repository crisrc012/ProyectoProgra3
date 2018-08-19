using Proyecto_call_DAL.Interfaces;
using Uam.Programacion.Proyecto.Models;

namespace Proyecto_call_BLL.Repositories
{
    public sealed class DepartamentosRepository : BaseRepository<Departamentos, int>
    {
        public DepartamentosRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}