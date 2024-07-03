using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using SistemaDeGerenciamentoDeClientesMvc.Data; // Adicione esta linha

namespace SistemaDeGerenciamentoDeClientesMvc.Models
{
    public class Cliente
    {
        [Key]
        public int ID_Cliente { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }

        // Construtor para inicializar as propriedades
        public Cliente()
        {
            Nome = string.Empty;
            Endereco = string.Empty;
            Telefone = string.Empty;
            RG = string.Empty;
            CPF = string.Empty;
            Email = string.Empty;
        }

        public void AddCliente(ApplicationDbContext context)
        {
            context.Clientes.Add(this);
            context.SaveChanges();
        }

        public static List<Cliente> GetClientes(ApplicationDbContext context)
        {
            return context.Clientes.ToList();
        }

        public void UpdateCliente(ApplicationDbContext context)
        {
            context.Clientes.Update(this);
            context.SaveChanges();
        }

        public static void DeleteCliente(int id, ApplicationDbContext context)
        {
            var cliente = context.Clientes.Find(id);
            if (cliente != null)
            {
                context.Clientes.Remove(cliente);
                context.SaveChanges();
            }
        }
    }
}
