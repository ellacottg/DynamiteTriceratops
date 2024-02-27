using System;
using Godot;

namespace SpectreDispatcher {

	// Test class
	public class Test {
		public Test() {
			Hero player = new Hero(50,5); // create player hero character object
			Console.WriteLine("Player items count = " + player.Items.Length);
			GD.Print("Player items count = " + player.Items.Length); // output in godot items[] length
		}
	}

}
