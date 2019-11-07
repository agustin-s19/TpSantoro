using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            login();
            Filtrar();
        }

        static void login()
        {
            string contraseña;
            string usuario;
            Console.WriteLine("Usuario: ");
            usuario = Console.ReadLine();
            Console.WriteLine("CONTRASEÑA: ");
            contraseña = Console.ReadLine();
            Console.Clear();

            while (usuario == "" && contraseña == "")
            {
                Console.WriteLine("Los datos que ingresaste son inválidos.\nPor favor ingrese bien sus datos \n");

                login();
                break;
            }

            if (usuario != "" && contraseña != "")

                Console.WriteLine("Bienvenido " + usuario + "\nIngresando a la tienda");
        }

        static void Filtrar()
        {
            string filtro;
            Console.WriteLine("Elija un filtro para ver la lista de juegos disponibles:\n1) Precio\n2) Requerimientos del sistema\n3) Popularidad\n4) Fecha lanzamiento\n5) Género");
            filtro = Console.ReadLine();
            switch (filtro)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("\nPRECIO:\nFortnite: Gratis\nCounter Strike GO: $10\nLOL: $20\nGTA V: $50\nPUBG: $70");
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("\nREQUERIMIENTOS DEL SISTEMA:\nCounter Strike GO: BAJOS\nLOL: BAJOS\nFortnite: INTERMEDIOS\nGTA V: ALTOS\nPUBG: ALTOS");
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("\nPOPULARIDAD:\nLOL: 5/5\nFortnite: 4/5\nCounter Strike GO: 3/5\nGTA V: 3/5\nPUBG: 2/5");
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("\nAÑO DE LANZAMIENTO:\nPUBG: 2018\nFortnite: 2017\nCounter Strike GO: 2012\nGTA V: 2012\nLOL: 2009");
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("\nGÉNERO:\nFortnite: SHOTTER\nCounter Strike GO: SHOTTER\nPUBG: SHOTTER\nLOL: MOBA\nGTA V: SANDBOX");
                    break;+
            }
            
            
            
            
            
            
            
            
                default:
                    Console.WriteLine("\nPor favor, ingrese un numero entre 1 y 5 para elegir su filtro");
                    Filtrar();
                    break;
                    
            static void comprar () 
        {
                
            string comprar;
            Console.WriteLine("eliga que juego desea comprar:\n1) Fortnite\n2) CS GO\n3) LOL\n4) GTAV\n5) PUUBG");
            comprar = Console.ReadLine();
            switch (comprar)
            
            case "1":
                Console.Clear();
                    Console.WriteLine("Fortnite ha sido comprado");
                break;
            case "2":
                    Console.Clear();
                    Console.WriteLine("CS GO ha sido comprado");
                    break;
            case "3":
                    Console.Clear();
                    Console.WriteLine("LOL ha sido compraro");
                    break;
            case "4":
                    Console.Clear();
                    Console.WriteLine("GTAV ha sido comprado");
                    break;
             case "5":
                    Console.Clear();
                    Console.WriteLine("PUBG ha sido comprado");
                    break;
            case "6":
                    Console.Clear();
                    Console.WriteLine("volver al menu");
                    break;
            }
                
                default:
                    Console.WriteLine("por favor ingrese un numero del 1 al 5 para comprar su juego");
                    comprar();
                    break;







            }
            }
        }
    }
