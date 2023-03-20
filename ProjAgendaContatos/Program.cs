using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using ProjAgendaContatos;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Contact> phoneBook = new List<Contact>();



        int op;
        phoneBook = new List<Contact>();
        Console.Title = "Agenda de Contatos";

        int Menu()
        {
            int xpto;
            Console.WriteLine("\n\nMENU DE OPÇÕES\n1- INSERIR CONTATO"
                + "\n2- EDITAR CONTATO\n3- REMOVER CONTATO\n4- MOSTRA AGENDA\n5- SAIR\n\nESCOLHA UMA OPÇÃO: \n");

            while (!int.TryParse(Console.ReadLine(), out xpto)) 
            {
                Console.WriteLine("Insira apenas números inteiros");
                Thread.Sleep(1000);
                Console.Clear();
                Menu();
            }

            while ((xpto < 1) || (xpto > 5))
            {
                Console.Clear();
               // Menu();
                Console.WriteLine(" Informe um valor do menu ( entre 1 e 5)");
                Menu();
                //Thread.Sleep(1000);
                while (!int.TryParse(Console.ReadLine(), out xpto)) 
                {                   
                    Console.Clear();
                    Menu();
                }
            }
            return xpto;
        }

        do
        {
            op = Menu();
            switch (op)
            {
                case 1:
                    phoneBook.Add(CreateContact());
                    break;

                case 2:
                    EditContact();                    
                    break;

                case 3:
                    phoneBook.Remove(DeleteContact());                    
                    break;
                case 4:
                    PrintPhoneBook(phoneBook);

                    break;

                case 5:
                    System.Environment.Exit(0);                 
                    break;

                default:
                    Console.WriteLine("Valor inválido!");
                    break;


            }

        } while (true);




        Contact DeleteContact()
        {
            Console.WriteLine("Informe o nome: ");
            var n = Console.ReadLine();
            foreach (var item in phoneBook)
            {
                if (item.Name.Equals(n))
                {
                    return item;
                }
                else
                {
                    Console.WriteLine("Contato não encontrado");                    
                }
            }
            return null;
        }






        void PrintPhoneBook(List<Contact> l)
        {

            foreach (Contact item in l)
            {
                Console.WriteLine(item);
            }
        }


        Contact CreateContact()
        {
            Console.WriteLine("Informe o nome: ");
            String n = Console.ReadLine();
            Console.WriteLine("Informe o telefone: ");
            String t = Console.ReadLine();

            Contact contact = new(n, t);
            return contact;
        }

        void EditContact()
        {
            Console.Clear();            
            Console.Write("Digite o nome do contato que deseja editar: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            foreach (Contact contact in phoneBook)
            {
                if (contact.Name.ToUpper().Equals(name.ToUpper()))
                {
                    Console.WriteLine();

                    int option;
                    do
                    {
                       

                        option = EditingMenu(); 
                        switch (option)
                        {

                            case 1:
                                contact.EditName();
                                break;

                            case 2:
                                contact.EditPhone();
                                break;

                            case 3:
                                contact.EditEmail();
                                break;
                            case 4:
                                contact.Adress.EditStreet();
                                break;

                            case 5:
                                contact.Adress.EditCity();
                                break;

                            case 6:
                                contact.Adress.EditState();
                                break;

                            case 7:
                                contact.Adress.EditCountry();
                                break;

                            case 8:
                                contact.Adress.EditPostalCode();

                                break;

                            case 9:
                                System.Environment.Exit(0);
                                break;

                            default:
                                while (!int.TryParse(Console.ReadLine(), out option)) // testar
                                {
                                    Console.WriteLine("Insira apenas números inteiros");                                    
                                }
                                break;

                        }

                    } while (option != 9);
                }
            }
        }

        int EditingMenu()
        {
            int answer;
            Console.WriteLine("\n\nOPÇÕES PARA EDITAR CONTATO:\n1- EDITAR NOME"
                + "\n2- EDITAR TELEFONE\n3- EDITAR EMAIL\n4- EDITAR ENDEREÇO\n5- EDITAR CIDADE\n6- EDITAR ESTADO\n7- EDITAR PAIS \n8- EDITAR CEP\n9- SAIR\n\nESCOLHA UMA OPÇÃO: \n");
             
            while (!int.TryParse(Console.ReadLine(), out answer)) 
            {
                Console.WriteLine("Insira apenas números inteiros");
                Thread.Sleep(1000);
                Console.Clear();
                EditingMenu();
            }
            while( (answer < 1) || (answer >9) )
            {
                Console.Clear();                
                Console.WriteLine(" Informe um valor do menu ( entre 1 e 5)");
                Menu();
                
                while (!int.TryParse(Console.ReadLine(), out answer))
                {
                    Console.WriteLine("Digite um numero conform as opções do Menu ( entre 1 e 9)");
                    Thread.Sleep(2000);
                    Console.Clear();
                    EditingMenu();
                }
            }
            
            return answer;
        }
        



    }


}
