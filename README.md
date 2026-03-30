<div align="center">

# Chayanon Yimyam
### Game Developer — Multiplayer & Gameplay Systems · Unity · C#

[![Itch.io](https://img.shields.io/badge/Itch.io-FA5C5C?style=flat&logo=itchdotio&logoColor=white)](https://pbzpooh123.itch.io)
[![GitHub](https://img.shields.io/badge/GitHub-181717?style=flat&logo=github&logoColor=white)](https://github.com/pbzpooh123)

</div>

---

## Dev Focus

| Area | Details |
|---|---|
| **Multiplayer / Network** | Server-authoritative architecture, real-time sync, turn order management, FishNet 4, Unity Netcode for GameObjects |
| **Gameplay Systems** | Turn-based mechanics, dice movement, tile logic, respawn systems, checkpoint systems |
| **Game Economy** | Stock ownership, partial stakes, negotiation mechanics, event-driven money flow |
| **QA / Testing** | Multiplayer session testing, edge case coverage, client-side integrity validation |

---

## Tech Stack

| Category | Tools |
|---|---|
| Engine | Unity 2022 |
| Language | C# |
| Networking | FishNet 4, Unity Netcode for GameObjects |
| Platform | PC (Windows), Android |
| Other | GameMaker Studio 2 |

---

## Projects

---

### Iron Curtain *(2025 — Thesis)*

Cold War-themed multiplayer economic board game. Players compete through stock ownership, negotiation, and corporate strategy.

[![Play](https://img.shields.io/badge/Play-Itch.io-FA5C5C?style=flat)](https://pbzpooh123.itch.io/iron)
[![Watch](https://img.shields.io/badge/Teaser-YouTube-FF0000?style=flat)](https://youtu.be/kqVdGULhmao)
[![Repo](https://img.shields.io/badge/Repo-GitHub-181717?style=flat)](https://github.com/pbzpooh123/Ironcur)

**Platform:** PC · **Players:** 2–4 Online · **Role:** Lead Game Developer

#### Network Systems
| System | Description |
|---|---|
| Multiplayer Networking | Real-time connectivity via FishNet 4 — player sync, turn order, authoritative server logic |
| Server-Authoritative Logic | All money flow, penalties, and rewards processed server-side — no client-side manipulation paths |

#### Gameplay Systems
| System | Description |
|---|---|
| Turn-Based Movement | Dice-based movement with server-side tile logic (events, taxes, bonuses, investments) |
| Stock Ownership | Custom stock market with partial ownership, majority stakes, and live share tracking |
| Negotiation System | Proposal mechanic for player-to-player stock deals on investment tiles |
| Results UI | End-game analytics with investor-type titles, awards, and animated score breakdowns |

#### QA / Testing
- Ran multiplayer session tests across 2–4 client configurations
- Verified turn synchronization consistency under simulated latency
- Stress-tested stock market logic for edge cases (majority ownership flip, zero-balance events)
- Confirmed no client-side manipulation paths in server-authoritative flow

---

### Infinite Deflect *(2025)*

Fast-paced 4-player online PvP. Deflect a ball away from yourself or get eliminated.

[![Play](https://img.shields.io/badge/Play-Itch.io-FA5C5C?style=flat)](https://pbzpooh123.itch.io/infinite-deflect)
[![Repo](https://img.shields.io/badge/Repo-GitHub-181717?style=flat)](https://github.com/pbzpooh123/Infinite-Deflect.git)

**Platform:** PC · **Players:** 2–4 Online · **Role:** Game Developer

#### Network Systems
| System | Description |
|---|---|
| Multiplayer Connection | Real-time connections via Unity Netcode for GameObjects — joining, sync, state management |

#### Gameplay Systems
| System | Description |
|---|---|
| Ball Targeting System | Ball randomly re-targets on each deflect, keeping rounds unpredictable |
| Respawn System | Smooth between-round respawning without disconnecting eliminated players |

#### QA / Testing
- Verified deflect randomness distribution across extended test sessions
- Tested respawn logic for all elimination edge cases
- Confirmed stable state transitions during round resets

---

### Fire Keeper *(2025)*

2D platformer side-scroller — first Android release.

[![Play](https://img.shields.io/badge/Play-Itch.io-FA5C5C?style=flat)](https://pbzpooh123.itch.io/grassland-adventures)
[![Repo](https://img.shields.io/badge/Repo-GitHub-181717?style=flat)](https://github.com/pbzpooh123/Mobile-Project.git)

**Platform:** Android · **Role:** Game Developer

- Checkpoint respawn system inspired by Celeste
- First mobile release — touch controls, aspect ratio handling

---

### Toytopia Defense *(2023 — First Game)*

Simple 2D tower defense built with GameMaker Studio 2.

[![Play](https://img.shields.io/badge/Play-Itch.io-FA5C5C?style=flat)](https://everlasting8.itch.io/toytopia-defense)

- Enemy pathing system
- Tower upgrade mechanics
- Round management with skip button

---

<div align="center">

*Open to Game Developer and QA Tester roles — multiplayer and gameplay systems.*

</div>
