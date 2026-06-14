# Unity Puzzle Strategy Core

A 2D push-based puzzle (Sokoban-like) built with Unity as part of a structured game development learning roadmap.

![Unity](https://img.shields.io/badge/Unity-6-black?logo=unity)
![Platform](https://img.shields.io/badge/Platform-PC-blue)
![License](https://img.shields.io/badge/License-MIT-green)

## Features

- **Grid-based Movement** - WASD ile hücre hücre hareket
- **Wall Collision** - Duvarlara çarpılınca durma
- **Push Mechanic** - Kutuları itme, arkası boşsa hareket
- **Target Zone** - Hedef nokta (görsel iskelet)

## Controls

| Tuş | Aksiyon |
|-----|---------|
| W | Yukarı |
| A | Sol |
| S | Aşağı |
| D | Sağ |

## Technical Details

- **Engine:** Unity 6
- **Language:** C#
- **Input:** Legacy Input System (Input.GetKeyDown)
- **Physics:** Physics2D.OverlapPoint (grid collision check)

## Development Timeline

| Versiyon | Tarih | Milestone |
|----------|-------|-----------|
| v0.1.0 | Haziran 2026 - Hafta 1 | Grid movement, wall collision, push mechanic, target |

---

Made with Unity