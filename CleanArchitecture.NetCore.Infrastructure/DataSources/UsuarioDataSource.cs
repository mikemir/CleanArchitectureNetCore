using CleanArchitecture.NetCore.Domain;
using CleanArchitecture.NetCore.Infrastructure.DataSources.DB.EntityFramework;
using CleanArchitecture.NetCore.Infrastructure.DataSources.DB.EntityFramework.Model;
using CleanArchitecture.NetCore.InterfaceAdapters.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.NetCore.Infrastructure.DataSources
{
    public class UsuarioDataSource : IUsuarioDataSource
    {
        private readonly UsuarioDbContext _db;

        public UsuarioDataSource(UsuarioDbContext db)
        {
            _db = db;
        }
        public bool CrearUsuario(Usuario usuario)
        {
            var result = false;

            var entity = new UsuarioEntity { Alias = usuario.Alias, Clave = usuario.Clave }; //ToDo: Implementar mapeo

            using (_db)
            {
                _db.Usuarios.Add(entity);
                result = _db.SaveChanges() == 1;
            }

            return result;
        }
    }
}
