using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CleanArchitecture.NetCore.Infrastructure.DataSources.DB.EntityFramework.Model
{
    [Table("USUARIOS")]
    public class UsuarioEntity
    {
        [Key]
        public string Alias { get; set; }
        public string Clave { get; set; }
    }
}
