using Godot;

public partial class Main : Node2D
{
	private void OnQuitPressed()
	{
		GetTree().Quit();
	}

	private void OnPlayPressed()
	{
		GetTree().ChangeSceneToFile("res://world.tscn");
	}

}
