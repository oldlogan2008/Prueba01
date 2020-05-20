using System;


namespace AplicacionConsol
{
    class Program
    {
        string usuario;
        string contraseña;

        public void login()
        {
            Console.WriteLine(" Logeate");
            Console.WriteLine("Ingrese Usuario");
            usuario = (Console.ReadLine());
            Console.WriteLine("Ingrese Contraseña");
            contraseña = (Console.ReadLine());
            Console.Clear();
        }
        public void proceso()
        {
            if (usuario == "admin" && contraseña == "123")
            {
                Console.WriteLine("Bienvenido " + usuario);
            }
            else
            {
                Console.WriteLine("Acceso Denegado");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program pro = new Program();
            pro.login();
            pro.proceso();
        }
    }
}