using System.Data;
using Programacion.Proyecto.DataAccess;

namespace Programacion.Proyecto.Biz
{
    public class ActivosService
    {
        public DataTable GetActivos()
        {
            using (var context = SqlDbContext.Create())
            {
                return context.ExecuteDataTable("SP_LISTAR_ACTIVOS");
            }
        }
    }
}
