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
            Listado();
            Filtrar();
            Comprar();
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

                Console.WriteLine("Bienvenido " + usuario + "\n\nIngresando a la tienda\n\n");
        }

        static void Listado()
        {//Agus, creo que esta es la función que me pediste. Escuchame, si no es esto y hay que hacer otra cosa o agregarle algo más avisame sin drama que tengo la pc y
         //cuelgo un ratito el laburo para arreglarlo.
            Console.WriteLine("Estos son los juegos que tenemos para ofrecerte en esta oportunidad:\n- Fortnite\n- Counter Strike GO\n- GTA V\n- PUBG\n- League of Legends\n");
            
        }
        


        static void Filtrar()
        {
            string filtro;
            Console.WriteLine("Elija un filtro de acuerdo a su preferencia:\n1) Precio\n2) Requerimientos del sistema\n3) Popularidad\n4) Fecha lanzamiento\n5) Género");
            //Yo acá le pondría otra cosa tipo "Elija una búsqueda o filtro (si querés) de su preferencia para poder elegir el juego/título que más le guste"
            //Te modifiqué un par de títulos de juegos en el código para dejarlo todo igualito. También corregí el género Shooter que estaba mal escrito.
            filtro = Console.ReadLine();
            switch (filtro)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("\nPRECIO:\nFortnite: Gratis\nCounter Strike GO: US$10\nLeague of Legends: US$20\nGTA V: US$50\nPUBG: US$70");
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("\nREQUERIMIENTOS DEL SISTEMA:\nCounter Strike GO: BAJOS\nLeague of Legends: BAJOS\nFortnite: INTERMEDIOS\nGTA V: ALTOS\nPUBG: ALTOS");
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("\nPOPULARIDAD:\nLeague of Legends: 5/5\nFortnite: 4/5\nCounter Strike GO: 3/5\nGTA V: 3/5\nPUBG: 2/5");
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("\nAÑO DE LANZAMIENTO:\nPUBG: 2018\nFortnite: 2017\nCounter Strike GO: 2012\nGTA V: 2012\nLeague of Legends: 2009");
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("\nGÉNERO:\nFortnite: SHOOTER\nCounter Strike GO: SHOOTER\nPUBG: SHOOTER\nLOL: MOBA\nGTA V: SANDBOX");
                    break;
                default:
                    Console.WriteLine("\nPor favor, ingrese un numero entre 1 y 5 para elegir su filtro");
                    Filtrar();
                    break;

            }
        }

        static void Comprar()
        {

            string comprar;
            //Te modifiqué los WriteLine de la función esta para darle un toquecito más (?)
            Console.WriteLine("\nElija que juego desea comprar:\n1) Fortnite\n2) Counter Strike GO\n3) League of Legends\n4) GTA V\n5) PUBG\n6) Volver al menú");
            comprar = Console.ReadLine();
            switch (comprar)
            {


                case "1":
                    Console.Clear();
                    Console.WriteLine("Has comprado Fortnite. ¡Felicitaciones!");
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Has comprado Counter Strike GO. ¡Felicitaciones!");
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Has comprado League of Legends. ¡Felicitaciones!");
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("Has comprado GTA V. ¡Felicitaciones!");
                    break;

                case "5":
                    Console.Clear();
                    Console.WriteLine("Has comprado PUBG. ¡Felicitaciones!");
                    break;

                case "6":

                    Console.Clear();
                    Listado();
                    Filtrar();
                    Comprar();
                    break;


                default:
                    Console.WriteLine("por favor ingrese un numero del 1 al 5 para comprar su juego");
                    Comprar();
                    break;


            }



        }
    }

}