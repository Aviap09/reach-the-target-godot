using Godot;

public partial class Player : CharacterBody2D
{
	[Export]
	public float Speed = 250.0f;

    public override void _PhysicsProcess(double delta)
    {
		Rect2 viewport = GetViewportRect();

		Position = new Vector2(
			Mathf.Clamp(Position.X, 0, viewport.Size.X),
			Mathf.Clamp(Position.Y, 0, viewport.Size.Y)
		);

		Vector2 direction = Input.GetVector(
			"move_left",
			"move_right",
			"move_up",
			"move_down"
		);

		Velocity = direction * Speed;
		MoveAndSlide();
    }

	
}
