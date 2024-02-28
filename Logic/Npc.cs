

namespace SpectreDispatcher {
	
	public class Npc : Character {
		// private int energy;
		// private int strength;
		// private Item[] items; // If the Npc character has inventory to track

		private int type; // enemy type is 1 of 3 possibilities (rock/paper/scissors)

		public int Type {
			get {return type;}
			set {type = value;}
		}

	}

}
