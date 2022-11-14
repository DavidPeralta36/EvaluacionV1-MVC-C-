using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Negocio
{
    public class Class1
    {
        ProyectoEntities db = new ProyectoEntities();

        public List<Roles> ListarRoles()
        {
            var roles = from p in db.Roles select p;

            return roles.ToList();
        }
        public List<Trabajadores> ListarTrabajadores()
        {
            var trabajadores = from p in db.Trabajadores select p;

            return trabajadores.ToList();
        }
        public List<Reportes> ListarReportes()
        {
            var reportes = from p in db.Reportes select p;

            return reportes.ToList();
        }

        public void Agregar(Reportes itm)
        {
            var personas = new Reportes();

            db.Reportes.Add(itm);
            db.SaveChanges();
        }

        public Reportes Buscar(int IdReportes)
        {
            var reporte = from p in db.Reportes where p.IdReporte == IdReportes select p;

            return reporte.FirstOrDefault();
        }
 

        public void Modificar(Reportes itm)
        {
            var reporte = (from p in db.Reportes where p.IdReporte == itm.IdReporte select p).FirstOrDefault();

            reporte.IdReporte = itm.IdReporte;
            reporte.AccionRealizar = itm.AccionRealizar;
            reporte.AccionRealizar = itm.AccionRealizar;
            reporte.Atencion = itm.Atencion;

            db.SaveChanges();
        }

        public void Eliminar(int IdReporte)
        {
            var reporte = (from p in db.Reportes where p.IdReporte == IdReporte select p).FirstOrDefault();


            db.Reportes.Remove(reporte);


            db.SaveChanges();

        }

    }
}
