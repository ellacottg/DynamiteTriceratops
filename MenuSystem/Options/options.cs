using Godot;
using System;
using SpectreDispatcher;

public partial class options : Node2D
{
	Test test = new Test(); // This is to test the c# code when Options is clicked at main menu screen
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	private void _on_btn_back_pressed()
	{
		GetTree().ChangeSceneToFile("res://MenuSystem/MenuSystem.tscn");
	}
}
