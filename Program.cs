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
			Console.Write("Ingresar Numero de Vehiculo:   ");
			int tipovehiculo = int.Parse(Console.ReadLine());
			Console.Write("Numero de Dias a usar   ");
			int diasusados = int.Parse(Console.ReadLine());
			Vehiculo vehiculo = new Vehiculo();
			Vehiculo.Descuento descuento = new Vehiculo.Descuento
			{
				vehiculo = tipovehiculo,
				dias = diasusados
			};
			descuento.AplicarDescuento();

			Console.ReadKey();
		}
	}
}
