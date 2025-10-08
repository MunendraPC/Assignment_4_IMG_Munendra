# Assignment_4_IMG_Munendra

FlockingChase (Godot 4 + C#)

A small top-down demo showing flocking behavior using Craig Reynolds’ Boids algorithm, made in Godot 4.4.1 (Mono/C#).

Gameplay

You control a small square (Player) that can move and sprint.

A flock of enemies moves using Boids rules (separation, alignment, cohesion).

Walking into the door spawns a chasing enemy wave.

A background ambient flock adds atmosphere.

Controls

Arrow Keys → Move

Shift → Sprint

Touch the door → Trigger an enemy wave

Technical Summary

Implemented flocking algorithm based on Craig Reynolds’ Boids model (Wikipedia, 1986 ).

Integrated with gameplay logic and C# scripts for movement, collision, and spawning.

Created and connected nodes manually in the Godot editor (e.g., Player, BoidFlock, Door, EnemySpawner).

Exported parameters (speed, weights, etc.) for designer tuning.

Files scenes/Main.tscn scenes/Boid.tscn src/Player.cs src/GameManager.cs src/Boid.cs src/BoidFlock.cs src/EnemySpawner.cs src/Door.cs src/BackgroundFlock.cs

Credits & Citations

Code generation and structure assistance: ChatGPT (OpenAI)

Flocking algorithm reference: “Boids” by Craig Reynolds (1986), via Wikipedia

Node setup and gameplay design: created manually by me

Additional guidance: official Godot C# API docs

