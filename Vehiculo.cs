using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ReservadeVehiculos
{
	public class Vehiculo
	{
		private string modelo { get; set; }
		private double precio { get; set; }

		public class Descuento
		{
			public int vehiculo { get; set; }
			public int dias {  get; set; }
			public Descuento() { }

			public void AplicarDescuento()
			{

				switch (vehiculo)
				{
					case 1:
						if (dias <= 2)
						{
							double precio = 80;
							double resultado = precio * dias;
							Console.WriteLine(resultado.ToString("$ ###,###.00"));
						}
						else
						{
							double precio = 60;
							double resultado = precio * dias;
							Console.WriteLine(resultado.ToString("$ ###,###.00"));
						}
						break;
					case 2:
						if (dias <= 2)
						{
							double precio = 60;
							double resultado = precio * dias;
							Console.WriteLine(resultado.ToString("$ ###,###.00"));
						}
						{
							double precio = 40;
							double resultado = precio * dias;
							Console.WriteLine(resultado.ToString("$ ###,###.00"));
						}
						break;
					case 3:
						if (dias <= 2)
						{
							double precio = 50;
							double resultado = precio * dias;
							Console.WriteLine(resultado.ToString("$ ###,###.00"));
						}
						{
							double precio = 40;
							double resultado = precio * dias;
							Console.WriteLine(resultado.ToString("$ ###,###.00"));
						}
						break;
					case 4:
						if (dias <= 2)
						{
							double precio = 50;
							double resultado = precio * dias;
							Console.WriteLine(resultado.ToString("$ ###,###.00"));
						}
						{
							double precio = 35;
							double resultado = precio * dias;
							Console.WriteLine(resultado.ToString("$ ###,###.00"));
						}
						break;
					case 5:
						if (dias == 1)
						{
							double precio = 30;
							double resultado = precio * dias;
							Console.WriteLine(resultado.ToString("$ ###,###.00"));
						}
						{
							Console.WriteLine("No tiene Promocion");
						}
						break;
					case 6:
						if (dias == 2)
						{
							double precio = 30;
							double resultado = precio * dias;
							Console.WriteLine(resultado.ToString("$ ###,###.00"));
						}
						{
							double precio = 20;
							double resultado = precio * dias;
							Console.WriteLine(resultado.ToString("$ ###,###.00"));
						}
						break;
					case 7:
						if (dias <= 2)
						{
							double precio = 10;
							double resultado = precio * dias;
							Console.WriteLine(resultado.ToString("$ ###,###.00)"));
						}
						{
							Console.WriteLine("No tiene Promocion");
						}
						break;
				}
			}
			//////////////////////////////////////////////////////
		}

	}
}
		

		

//1  Camioneta
//2  Sedan 
//3  Jeep
//4  station wagon
//5  Cuadraciclos
//6  Motos 
//7  biclicletas
