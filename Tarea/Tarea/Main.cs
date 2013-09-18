using System;

namespace Tarea
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			GuardaDatos ob=new GuardaDatos();

			Console.WriteLine("Bienvenido");
			Console.WriteLine("Ingrese su nombre: ");
			ob.nombre=Console.ReadLine();
			Console.WriteLine("Ingrese su edad: ");
			ob.edad=Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("Ingrese su correo: ");
			ob.correo=Console.ReadLine();

			Console.Clear();
			Console.WriteLine("Sus datos son los siguientes: ");
			Console.WriteLine("Nombre: "+ ob.nombre);
			Console.WriteLine("Edad: " + ob.edad);
			Console.WriteLine("Correo: " + ob.correo);

		}
	}
}
