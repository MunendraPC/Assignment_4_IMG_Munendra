using Godot;

public partial class Door : Area2D
{
	public override void _Ready()
	{
		BodyEntered += OnBodyEntered;
	}

	private void OnBodyEntered(Node body)
	{
		if (body is Player)
		{
			var spawner = GetNode<EnemySpawner>("../EnemySpawner");
			spawner.TriggerWave();
			var rect = GetNode<ColorRect>("DoorSprite");
			rect.Color = new Color(0.95f, 0.95f, 0.2f, 1f);
			GetTree().CreateTimer(0.15).Timeout += () => rect.Color = new Color(0.2f, 0.9f, 0.4f, 1f);
		}
	}
}
