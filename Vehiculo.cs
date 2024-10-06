using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ReservadeVehiculos
{
	internal class Vehiculo
	{
		private string modelo {  get; set; }	
		private double precio { get; set; }	

		public Vehiculo() {
		
		}

	}

	internal class Descuento
	{
		private string descuento { get; set; }

		public Descuento() {

		}

		public static void AplicarDescuento(int vehiculo, double precio)
		{
			switch (vehiculo)
			{
				case 1:  break;
				case 2: break;
				case 3: break;
				case 4: break;
				case 5: break;
				case 6: break;
				case 7: break;
			}

		}

	}
}

// Camioneta
// Sedan 
// Jeep
// station wagon
// Cuadraciclos
// Motos 
// biclicletas
