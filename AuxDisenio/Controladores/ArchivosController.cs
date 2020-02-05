using AuxDisenio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxDisenio.Controladores
{
    class ArchivosController
    {

        dbSibaritaEntities _db = new dbSibaritaEntities();

        public List<Archivo> Listar(string pBuscar)
        {
            return _db.Archivo.Where(x => x.nombre.Contains(pBuscar)).ToList();
        }
        public bool Insertar(Data.Archivo reg)
        {
            _db.Archivo.Add(reg);
            _db.SaveChanges();
            return true;
        }
        public bool Modificar(Data.Archivo reg)
        {
            _db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }
        public bool Eliminar(int pParametro)
        {
            var reg = _db.Archivo.Where(x => x.id == pParametro).FirstOrDefault();
            _db.Archivo.Remove(reg);
            return _db.SaveChanges() > 0;
        }
        internal List<Archivo> BuscarPorPK(int pCodProv)
        {
            return _db.Archivo.Where(x => x.id == pCodProv).ToList();
        }
    }
}
