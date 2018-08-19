using Proyecto_call_DAL.Interfaces;
using Uam.Programacion.Proyecto.Models;

namespace Proyecto_call_BLL.Repositories
{
    public sealed class OperadoresRepository : BaseRepository<Operadores, string>
    {
        public OperadoresRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}