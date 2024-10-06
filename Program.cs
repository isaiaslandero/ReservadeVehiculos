using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservadeVehiculos
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Tipos de Vehiculos Disponibles");
			Console.WriteLine("1 - Camioneta");
			Console.WriteLine("2 - Sedan");
			Console.WriteLine("3 - Jeep");
			Console.WriteLine("4 - station wagon");
			Console.WriteLine("5 - Cuadraciclos");
			Console.WriteLine("6 - Motos");
			Console.WriteLine("7 - Biclicletas");
			Console.WriteLine("Ingresar Numero de Vehiculo");
			int seleccion = int.Parse(Console.ReadLine());
		}
	}
}
