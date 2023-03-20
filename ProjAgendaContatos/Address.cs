using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjAgendaContatos
{
    internal class Address
    {
        public string Street;
        public string City;
        public string PostalCode;
        public string Country;
        public string State;
            
        public Address()
        {
            
        }


        public void EditStreet()
        {
            Console.WriteLine("Digite o novo endereço");
            string aux = Console.ReadLine();
            this.Street = aux;
        }
        public void EditCity()
        {
            Console.WriteLine("Digite a cidade");
            string aux = Console.ReadLine();
            this.City = aux;
        }


        public void EditCountry()
        {
            Console.WriteLine("Digite o novo país");
            string aux = Console.ReadLine();
            this.Country = aux;
        }

        public void EditPostalCode()
        {
            Console.WriteLine("Digite o novo CEP");
            string aux = Console.ReadLine();
            this.PostalCode = aux;
        }

        public void EditState()
        {
            Console.WriteLine("Digite o Estado");
            string aux = Console.ReadLine();
            this.State = aux;
        }

        public override string ToString()
        {
            return "Rua: " + Street+ "\nEstado: " + State + "\nCidade: "
                + City + "\nPaís: " + Country + "\nCEP: " + PostalCode;
        }


    }
}
