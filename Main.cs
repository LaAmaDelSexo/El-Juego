using Godot;
using System;

public partial class Main : Node
{
    [Export]
    public PackedScene BaseMob { get; set; }
    [Export]
    private CanvasLayer Hud;
    public override void _Ready()
    {
        Engine.MaxFps = 60;
        Engine.PhysicsTicksPerSecond = 60;
    }

    public override void _Process(double delta)
    {

    }
}
