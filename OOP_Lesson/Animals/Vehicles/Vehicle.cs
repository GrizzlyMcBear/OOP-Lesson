using System;

namespace Vehicles
{
	public class Vehicle
	{
		// Only in a `Vehicle` class we could reach these fields:
		private string vehicleId = string.Empty;
		private int coolnessFactor = 0;
		private bool usedBySuperhero = false;

		// All classes inheriting from Vehicle would have this field
		protected string plateNumber = string.Empty;
		protected int wheelsAmount = 0;
		protected double maxSpeed = 0.0;

		// Only the Vehicle object would have access to this field
		private int makeYear = 0;
		
		// These are getter (reading) & setter (updating) the value of the matching field
		public int MakeYear {
			get
			{
				return makeYear;
			}
			set
			{
				DateTime currTime = DateTime.Now;
				
				if (1901 <= value && value <= currTime.Year)
				{
					makeYear = value;
				}
				else
				{
					Console.WriteLine("You're not serious, are you?");
				}
			}
		}

		// This is the c'tor (Constructor), we can initialize values of the object during instantiation with it
		public Vehicle(string vehicleId)
		{
			this.vehicleId = vehicleId;
			this.plateNumber = vehicleId;
		}

		// This is a c'tor calling another c'tor, passing arguments to it
		public Vehicle(string vehicleId, int makeYear) : this(vehicleId)
		{
			MakeYear = makeYear;
		}

		/* This is a public method - everyone could call it
		 * 
		 * If we want the inheriting classes to be able to have different behaviours - we need to override it
		 */
		public virtual void DoStunt()
		{
			Console.WriteLine($"(Vehicle ID: {vehicleId}, ID: {plateNumber})Vehicle boring stunt...");
		}
	}
}
