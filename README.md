# 🤠 Cowboy Quick Draw

**Cowboy Shootout Simulator**  
**Language:** C# | **Focus:** OOP, SOLID Principles, Design Patterns

## 📌 Objective
Design and implement a console-based simulation of a cowboy duel. Two cowboys engage in a shootout using various weapons, ammo types, and firing modes. The system follows SOLID principles and utilizes relevant design patterns to ensure scalability and maintainability.

---

## ⚙️ Core Features

### 1. Cowboys
- Each cowboy has:
  - A name
  - Health (100 HP)
  - A weapon (can switch when ammo is depleted)
  - A base shooting accuracy (randomized or adjustable)
- Can:
  - Shoot
  - Take damage
  - Switch weapons

### 2. Weapons
- Abstract `Weapon` class
- Concrete weapon types:
  - Gun
  - Shotgun
  - Rifle
- Attributes:
  - Supported fire modes: `Safe`, `Semi`, `Auto`
  - Ammo capacity
  - Bullet type (e.g., `.22LR`, `9mm`, `.12GA`)
  - Weapon Type

### 3. Fire Modes (State Pattern)
- Implemented as states:
  - `SafeMode`
  - `SemiAutoMode`
  - `FullAutoMode`
- Each mode controls how the weapon behaves when fired

### 4. Bullets & Calibers
- Bullet type defines damage:
  - `.22` – 10 HP
  - `9mm` – 15 HP
  - `.38 Special` – 25 HP
  - `.12GA` – 30 HP

### 5. Weapon Switching (Chain of Responsibility)
- When ammo runs out:
  - Automatically checks for a backup weapon
  - Switches to the next available weapon

### 6. Combat Flow
- Loop-based duel sequence:
  - Each round:
    - Cowboys try to shoot (accuracy considered)
    - Apply damage if hit
    - Check and switch weapons if needed
- Duel ends when one cowboy’s health reaches 0

---

## 📁 Status
**Work in Progress...**

