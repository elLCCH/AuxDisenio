using AuxDisenio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxDisenio.Controladores
{
    class UsuariosController
    {

        dbSibaritaEntities _db = new dbSibaritaEntities();

        public List<Usuarios> Listar(string pBuscar)
        {
            return _db.Usuarios.Where(x => x.Nombre.Contains(pBuscar)).ToList();
        }
        public bool Insertar(Data.Usuarios reg)
        {
            _db.Usuarios.Add(reg);
            _db.SaveChanges();
            return true;
        }
        public bool Modificar(Data.Usuarios reg)
        {
            _db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }
        public bool Eliminar(string pParametro)
        {
            var reg = _db.Usuarios.Where(x => x.Cuenta == pParametro).FirstOrDefault();
            _db.Usuarios.Remove(reg);
            return _db.SaveChanges() > 0;
        }
        internal List<Usuarios> BuscarPorPK(string pCuenta)
        {
            return _db.Usuarios.Where(x => x.Cuenta == pCuenta).ToList();
        }
    }
}
