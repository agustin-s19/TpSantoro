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



                Console.WriteLine("Bienvenido" + usuario + "\nIngresando a la tienda");
               

        }
    }
}
