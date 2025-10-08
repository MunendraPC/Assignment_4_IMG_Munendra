using Godot;
using System;

public partial class Player : CharacterBody2D
{
	[Export] public float Speed = 220f;
	[Export] public float SprintMultiplier = 1.6f;
	[Export] public float SprintDuration = 1.5f;
	[Export] public float SprintCooldown = 2.0f;

	private float _sprintTimer = 0f;
	private float _cooldownTimer = 0f;

	public override void _PhysicsProcess(double delta)
	{
		var input = Vector2.Zero;
		input.X = Input.GetActionStrength("ui_right") - Input.GetActionStrength("ui_left");
		input.Y = Input.GetActionStrength("ui_down") - Input.GetActionStrength("ui_up");
		if (input.LengthSquared() > 1f) input = input.Normalized();

		float speed = Speed;
		// Use Shift key for sprint to avoid needing an extra action mapping
		if (Input.IsKeyPressed(Key.Shift) && _cooldownTimer <= 0f)
		{
			if (_sprintTimer < SprintDuration)
			{
				_sprintTimer += (float)delta;
				speed *= SprintMultiplier;
			}
			else
			{
				_cooldownTimer = SprintCooldown;
			}
		}
		else
		{
			_sprintTimer = Math.Max(0f, _sprintTimer - (float)delta * 0.7f);
		}
		if (_cooldownTimer > 0f) _cooldownTimer -= (float)delta;

		Velocity = input * speed;
		MoveAndSlide();
	}
}
