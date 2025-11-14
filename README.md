# 🚀 Galaxy Strike  
A fast-paced vertical slice space-shooter game built with **Unity**, featuring smooth WASD movement, mouse-click shooting, enemy waves, particles, UI systems, and polished gameplay mechanics.

---

## 📝 Project Overview
**Galaxy Strike** is a vertical-slice prototype of a sci-fi space shooter where players control a spaceship, dodge enemy waves, and fire lasers to survive.  
The project demonstrates strong Unity fundamentals including scripting, prefabs, particles, timelines, collisions, UI systems, custom tools, and gameplay logic.

---

## 🎮 Gameplay Features

### 🕹 Player Controls
- **WASD movement** for smooth directional control  
- **Mouse left-click** to fire lasers  
- Movement logic uses **Input Action Map** & **Unity's New Input System**

### 🚀 Player Mechanics
- Player ship movement with acceleration  
- Roll ship & roll lerp animations  
- Pitch handling for responsive turning  
- Clamp movement using `Mathf.Clamp()`  
- Target tracking & crosshair system  

### 👾 Enemy Systems
- Multiple enemy ship variants  
- Enemy waves with varying difficulty  
- Enemy hit points, health logic, and collisions  
- Enemy timeline events  
- Explosion particles on destruction  

### 🔫 Combat
- Particle-based laser fire  
- Collision detection using triggers & rigidbodies  
- Particle collision effects  
- Reload system using coroutines  

---

## 🎨 Visual & Environment Tools
- Terrain tools & advanced terrain  
- Textured terrains for backgrounds  
- Skybox setup for deep-space look  
- Trees & environment props  
- Rendering, lighting, and shadow settings  

---

## 🛠 Unity Systems Used
- Master Timeline  
- Animation curves  
- UI Canvas system  
- Score UI  
- Prefab Variants  
- Public methods in C# for modular gameplay  
- Vectored movement math (vector arithmetic)  

---

## 📁 Project Structure (Key Folders)
```plaintext
A
