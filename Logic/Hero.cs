using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace SpectreDispatcher {
	
	public class Hero : Character {

		// private int energy;
		// private Item[] items;

		// public Hero(int energy) {
		// 	this.energy = energy;
		// }

		private int gear;

		public Hero(int energy, int str) {
			Energy = energy;
			Strength = str;
			Items = new Item[Common.CountAllResources()];
			gear = 0;
		}

		public int Gear {
			get {return gear;}
			set {gear = value;}
		}


		// method that updates the players hero strength with gear equipped
		

	}

}
