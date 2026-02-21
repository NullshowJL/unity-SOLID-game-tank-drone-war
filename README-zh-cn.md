# Tank Drone War

一款基于 **SOLID 设计原则** 构建的 Unity 2D 坦克防御射击游戏。
玩家控制三辆不同形态的坦克，抵御不断涌来的无人机群。

![Unity](https://img.shields.io/badge/Unity-2022.3-blue)
![C#](https://img.shields.io/badge/C%23-9.0-green)
![Render Pipeline](https://img.shields.io/badge/Render-Built--in-orange)

## 项目简介

Tank Drone War 是一个以 **SOLID 原则实践** 为核心目标的学习项目。
游戏中，玩家可以通过按键（L / M / H）实时切换轻型、中型、重型三种坦克，
每种坦克拥有不同的移动方式和弹药类型。
敌方无人机会持续生成，且难度随时间递增。

## 玩法

- **L 键**：切换为轻型坦克（快速移动，轻型弹药）
- **M 键**：切换为中型坦克（均衡属性，中型弹药）
- **H 键**：切换为重型坦克（慢速但高伤害）
- **↑ / ↓**：上下移动
- **鼠标**：瞄准旋转
- **射击**：空格键

## 项目架构

```
Scripts/                # 脚本核心
    ├── Drone/          # 无人机逻辑
    ├── GameUtil/       # 游戏事件系统
    ├── Mgr/            # 管理器（Game、Audio、UI）
    ├── Projectile/     # 弹药逻辑
    └── Tank/           # 坦克逻辑
        ├── Engine/     # 引擎/选择系统
        ├── Fire/       # 射击系统
        ├── Health/     # 生命系统
        └── Move/       # 移动系统
```

## 设计亮点

- **SOLID 原则全面应用**：接口隔离、开闭原则、单一职责等
- **事件驱动架构**：模块间通过 `GameEvents` 静态事件解耦
- **策略模式**：弹药、移动通过接口实现可替换策略
- **模板方法模式**：`TankEngineBase` / `TankMoveBase` / `DroneMoveBase` 定义骨架
- **动态难度曲线**：无人机生成概率随游戏时间动态调整

## 技术栈

- **引擎**：Unity 2022.3 (Built-in Render Pipeline)
- **语言**：C# 9.0
- **目标框架**：.NET Framework 4.7.1

## 如何运行

1. 克隆仓库：`git clone https://github.com/NullshowJL/unity-SOLID-game-tank-drone-war.git`
2. 使用 Unity Hub 打开项目（推荐 Unity 2022.3+）
3. 打开场景 `Assets/Scenes/TankDroneWar.unity`
4. 点击 Play ▶️

