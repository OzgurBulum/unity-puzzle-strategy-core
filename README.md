# Unity Puzzle Strategy Core

A 2D push-based puzzle (Sokoban-like) built with Unity as part of a structured game development learning roadmap.

![Unity](https://img.shields.io/badge/Unity-6-black?logo=unity)
![Platform](https://img.shields.io/badge/Platform-PC-blue)
![License](https://img.shields.io/badge/License-MIT-green)

## Features

- **Grid-based Movement** - WASD ile hücre hücre hareket
- **Wall Collision** - Duvarlara çarpılınca durma
- **Push Mechanic** - Kutuları itme, arkası boşsa hareket
- **Win Condition** - Kutu hedefe ulaşınca Level Complete
- **Reset** - R tuşu ile level başa döner
- **Undo** - Z tuşu ile son hamleyi geri al (Stack tabanlı)
- **Level Select** - Ana menüden 5 level arasında seçim
- **Level Flow** - Next Level / Restart / Level Select panel

## Controls

| Tuş | Aksiyon |
|-----|---------|
| W | Yukarı |
| A | Sol |
| S | Aşağı |
| D | Sağ |
| R | Reset |
| Z | Undo |

## Technical Details

- **Engine:** Unity 6
- **Language:** C#
- **Input:** Legacy Input System (Input.GetKeyDown)
- **Physics:** Physics2D.OverlapPoint (grid collision check)
- **Undo:** Stack<MoveState> (LIFO)
- **Scene Management:** SceneManager.LoadScene

## Development Timeline

| Versiyon | Tarih | Milestone |
|----------|-------|-----------|
| v0.1.0 | Haziran 2026 - Hafta 1 | Grid movement, wall collision, push mechanic |
| v0.2.0 | Haziran 2026 - Hafta 2 | 5 levels, win condition, reset, undo, level select |

---

Made with Unity