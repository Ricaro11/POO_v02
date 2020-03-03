using System;

namespace POO_v02
{
	class Apartamento
	{
		public string Dirección;
		public string Color;
		public float area;
		public int Parqueos;
		public int Habitaciones;
		public int Baños;

		public void Vender()
		{
			Console.WriteLine("Apartamento ubicado en {0}, color {1} tiene {2} m2 de construcción, {3} parqueos, {4} habitaciones y {5} baños", this.Dirección, this.Color, this.area, this.Parqueos, this.Habitaciones, this.Baños);
			Console.WriteLine("Ha sido puesto a la venta");
		}
		public void Alquilar()
		{
			Console.WriteLine("Apartamento ubicado en {0}, color {1} tiene {2} m2 de construcción, {3} parqueos, {4} habitaciones y {5} baños", this.Dirección, this.Color, this.area, this.Parqueos, this.Habitaciones, this.Baños);
			Console.WriteLine("Ha sido Puesto en alquiler");
		}
	}
	public class Prom
	{
		static void Main()
		{
			Console.WriteLine("Introduzca los datos del Apartamento");
			Apartamento Apt = new Apartamento();
			Console.Write("Locacion: ");
			Apt.Dirección = Console.ReadLine();
			Console.Write("Color exterior: ");
			Apt.Color = Console.ReadLine();
			Console.Write("Area de construccion en m2: ");
			Apt.area = Convert.ToInt32(Console.ReadLine());
			Console.Write("Numero de parqueos: ");
			Apt.Parqueos = Convert.ToInt32(Console.ReadLine());
			Console.Write("Numero de habitaciones: ");
			Apt.Habitaciones = Convert.ToInt32(Console.ReadLine());
			Console.Write("Numero de baños: ");
			Apt.Baños = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Este inmueble sera puesto en venta o alquiler? precionar 1 para la VENTA o cualquier otra tecla para el ALQUILER");
			string m = Console.ReadLine();
			if (m == "1")
			{
				Apt.Vender();
			}
			else
			{
				Apt.Alquilar();
			}


		}
	}
}
