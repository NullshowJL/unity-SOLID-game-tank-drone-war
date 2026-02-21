# Tank Drone War

A 2D tank‑defense shooter built in Unity, designed as a practical project to apply **SOLID design principles**. The player controls three different types of tank and fights off waves of incoming drones.

![Unity](https://img.shields.io/badge/Unity-2022.3-blue)
![C#](https://img.shields.io/badge/C%23-9.0-green)
![Render Pipeline](https://img.shields.io/badge/Render-Built--in-orange)

## Overview

**Tank Drone War** is a learning project focused on applying **SOLID principles** in a real Unity game. The player can switch between three different types of tank—Light, Medium, and Heavy—using the L / M / H keys. Each tank has its own movement style, weapon type, and combat role. Enemy drones spawn continuously, and the difficulty increases over time.

## Gameplay

- **L Key** – Switch to Light Tank (fast movement, light weapon)
- **M Key** – Switch to Medium Tank (balanced stats, medium weapon)
- **H Key** – Switch to Heavy Tank (slow but high damage)
- **↑ / ↓** – Move up and down
- **Mouse** – Aim turret
- **Shooting** – Space Key

## 项目架构

```
Scripts/                # Core scripts
    ├── Drone/          # Drone logic
    ├── GameUtil/       # Game event system
    ├── Mgr/            # Managers (Game, Audio, UI)
    ├── Projectile/     # Projectile logic
    └── Tank/           # Tank logic
        ├── Engine/     # Tank engine / switching system
        ├── Fire/       # Firing system
        ├── Health/     # Health system
        └── Move/       # Movement system
```

## Key Design Features

- **Full SOLID application**: SRP, OCP, ISP, etc.

  **Event‑driven architecture** using `GameEvents` for loose coupling

  **Strategy pattern** for interchangeable movement and weapon behaviors

  **Template Method pattern** in `TankEngineBase`, `TankMoveBase`, and `DroneMoveBase`

  **Dynamic difficulty curve** based on game time and spawn probability

## Tech Stack

- **Engine**: Unity 2022.3 (Built‑in Render Pipeline)
- **Language**: C# 9.0
- **Target Framework**: .NET Framework 4.7.1

## How to Run

1. Clone the repository:`git clone https://github.com/NullshowJL/unity-SOLID-game-tank-drone-war.git`
2. Open the project in Unity Hub (Unity 2022.3+ recommended)
3. Load the scene: `Assets/Scenes/TankDroneWar.unity`
4. Press Play ▶️

