using System.ComponentModel;
using Reciplas.Models; 
protected override void Seed(Reciplas.Models.ClienteDBContext context)
{
    IEnumerable<Cliente> enumerable = context.Clientes.AddOrUpdate( i => i.Cliente,
        new Cliente
        {
            Nombre = "Nahiara",
            Direccion = "Calle Gualaby 42 Sydney",
            Dni = 741
        },

         new Cliente
         {
            Nombre= "Fede",
            Direccion = "alla",
            Dni = 789
         },

         new Cliente
         {
             Nombre= "Valen",
             Direccion = "en el monte",
            Dni = 456
         },

       new Cliente
       {
           Nombre= "Chiara",
           Direccion = "si",
           Dni = 123
       }
   );
   
}