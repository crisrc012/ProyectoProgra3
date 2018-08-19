using Proyecto_call_DAL.Interfaces;
using Uam.Programacion.Proyecto.Models;

namespace Proyecto_call_BLL.Repositories
{
    public sealed class EstadosRepository : BaseRepository<Estados, string>
    {
        public EstadosRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}