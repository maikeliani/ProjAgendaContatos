using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAgendaContatos
{
    internal class Contact
    {
        public string Name { get; set; }
        public Address Adress { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }

        public Contact(string nome, string telefone)
        {
            this.Name = nome;
            this.Adress = new Address();
            this.Phone = telefone;
            
        }



        public void EditPhone()
        {
            Console.WriteLine("Digite o novo numero de telefone");
            string aux = Console.ReadLine();
            this.Phone = aux;
        }
        public void EditEmail()
        {
            Console.WriteLine("Digite o novo e-mail");
            string aux = Console.ReadLine();
            this.Email = aux;
        }

        public void EditName()
        {
            Console.WriteLine("Digite o novo nome");
            string aux = Console.ReadLine();
            this.Name = aux;
        }

       

        



        public override string ToString()
        {
            return $"\n\nNome: {Name}\nTelefone: {Phone}\n{Adress.ToString()}";
        }



    }
}
