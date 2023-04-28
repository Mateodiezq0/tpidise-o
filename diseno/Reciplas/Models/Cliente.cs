using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations; 


namespace Reciplas.Models{
    public class Cliente{ 
    public string Nombre {get; set;}
    public string Direccion {get; set;}
    public int Dni {get; set;} 
 
    }
     
    public class ClienteDBContext : DbContext{
        public DbSet<Cliente> Clientes { get; set; }
    }
    //public static void AddOrUpdate<TEntity> (this System.Data.Entity.IDbSet<TEntity> set, params TEntity[] entities) where TEntity : class;
}

