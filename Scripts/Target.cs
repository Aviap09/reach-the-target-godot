using Godot;
using System;

public partial class Target : Area2D
{
	Label message;
	Sprite2D sprite;
	public override void _Ready()
	{
		message = GetNode<Label>("../Label");
		sprite = GetNode<Sprite2D>("Sprite2D");
	}
	private void  OnBodyEntered(Node2D body)
	{
		if(body.Name == "Player")
		{
			GD.Print("TARGET REACHED!");
			message.Text = "TARGET REACHED!";
			sprite.Texture = GD.Load<Texture2D>("res://Texture/Target2.png");
		}
	}
}
