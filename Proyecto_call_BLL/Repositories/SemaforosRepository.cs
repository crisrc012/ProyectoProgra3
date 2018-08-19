using Proyecto_call_DAL.Interfaces;
using Uam.Programacion.Proyecto.Models;

namespace Proyecto_call_BLL.Repositories
{
    public sealed class SemaforosRepository : BaseRepository<EstadosSemaforo, string>
    {
        public SemaforosRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}