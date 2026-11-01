using Godot;
using System;

public partial class Target : Area2D
{
	Label message;
	public override void _Ready()
	{
		message = GetNode<Label>("../Label");
	}
	private void  OnBodyEntered(Node2D body)
	{
		if(body.Name == "Player")
		{
			GD.Print("TARGET REACHED!");
			message.Text = "TARGET REACHED!";
		}
	}
}
