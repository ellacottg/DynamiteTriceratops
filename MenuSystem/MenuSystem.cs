using Godot;
using System;

public partial class MenuSystem : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	private void _on_btn_singleplayer_pressed()
	{
		GetTree().ChangeSceneToFile("res://Levels/testLevel.tscn");
	}
	private void _on_btn_option_pressed()
	{
		GetTree().ChangeSceneToFile("res://MenuSystem/Options/options.tscn");
	}
	private void _on_button_pressed()
	{
		GetTree().Quit();
	}
	
	private void _on_btn_multiplayer_pressed()
	{
		GetTree().ChangeSceneToFile("res://MultiPlayer/SetupScene.tscn");
	}
}










