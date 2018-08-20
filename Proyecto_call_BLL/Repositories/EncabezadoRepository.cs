using Proyecto_call_DAL.Interfaces;
using Uam.Programacion.Proyecto.Models;

namespace Proyecto_call_BLL.Repositories
{
    public sealed class EncabezadoRepository : BaseRepository<Encabezado, int>
    {
        public EncabezadoRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}