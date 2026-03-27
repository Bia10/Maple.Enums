# Maple.Enums

![.NET](https://img.shields.io/badge/net10.0-5C2D91?logo=.NET&labelColor=gray)
![C#](https://img.shields.io/badge/C%23-14.0-239120?labelColor=gray)
[![Build Status](https://github.com/Bia10/Maple.Enums/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/Bia10/Maple.Enums/actions/workflows/dotnet.yml)
[![codecov](https://codecov.io/gh/Bia10/Maple.Enums/branch/main/graph/badge.svg)](https://codecov.io/gh/Bia10/Maple.Enums)
[![Nuget](https://img.shields.io/nuget/v/Maple.Enums?color=purple)](https://www.nuget.org/packages/Maple.Enums/)
[![License](https://img.shields.io/github/license/Bia10/Maple.Enums)](https://github.com/Bia10/Maple.Enums/blob/main/LICENSE)

A comprehensive collection of **290 strongly-typed MapleStory V95 enumerations**. Cross-platform, trimmable and AOT/NativeAOT compatible.

[Example](#example) | [Example Catalogue](#example-catalogue) | [Public API Reference](docs/PublicApi.md)

## Features

- **290 enums** covering jobs, stats, items, combat, fields, mobs, quests, network opcodes, and more
- **AOT-compatible** — `.NET 10`, `IsAotCompatible=true`, zero runtime reflection
- **Source-generated** via [FastEnum.Generators](https://github.com/xin9le/FastEnum) — no `Enum.GetValues` overhead
- **Triple-indexed labels** on every member:
  - Index 0 — original V95 PDB identifier (typos preserved verbatim)
  - Index 1 — human-readable display name for compound words (`WhiteKnight` → `"White Knight"`)
  - Index 2+ — WZ content string codes where applicable (`EquipSlot.Cap` → `"Cp"`)
- **Full XML documentation** on every enum and member — IntelliSense-friendly

## Install

```
dotnet add package Maple.Enums
```

## Example

```csharp
// Human-readable display label
Console.WriteLine(Job.WhiteKnight.GetDisplayLabel()); // "White Knight"
Console.WriteLine(WeaponType.OhSword.GetDisplayLabel()); // "1H Sword"
Console.WriteLine(Element.Fire.GetDisplayLabel()); // "Fire"
```

For more examples see [Example Catalogue](#example-catalogue).

## Namespace & Structure

All enums live in the single flat namespace `Maple.Enums`. Files are organised into domain subfolders for discoverability but introduce no sub-namespaces.

| Folder | Domain |
|--------|--------|
| `Auth/` | Login, PIN, security |
| `Admin/` | Admin commands, locale, region codes |
| `Character/` | Stats, jobs, movement, temporary stats |
| `Combat/` | Skills, elements, weapons, summons |
| `Economy/` | Drop ownership, meso logs, rates |
| `Event/` | Mini-games, carnival, seasonal events |
| `Field/` | Maps, portals, field limits, reactors |
| `Item/` | Inventory, equipment, cash items, crafting |
| `Life/` | Mobs, NPCs, boss IDs, mob skills |
| `NexonPlatform/` | Nexon Messenger SDK types |
| `Network/` | Packet opcodes, transfer results |
| `Pet/` | Pet abilities, actions, food results |
| `Quest/` | Quest states, job flags, areas |
| `Shop/` | NPC shop, cash shop, personal shop |
| `Social/` | Party, guild, friends, marriage, chat |
| `UI/` | Animation layers, cursor, effects, fonts |

## Documentation

- **[REFERENCE.md](src/Maple.Enums/REFERENCE.md)** — full provenance catalog: origin classification (CLIENT_CONFIRMED / CLIENT_PARTIAL / WZ_DATA / CUSTOM) for all 287 enums
- **[typos.md](src/Maple.Enums/typos.md)** — 37 preserved V95 client PDB typos documented alongside their corrected C# spellings

## Benchmarks

Benchmarks.

### Detailed Benchmarks

#### Comparison Benchmarks

##### TestBench Benchmark Results


## Example Catalogue

The following examples are available in [ReadMeTest.cs](src/Maple.Enums.XyzTest/ReadMeTest.cs).

### Example - Empty

```csharp
// Human-readable display label
Console.WriteLine(Job.WhiteKnight.GetDisplayLabel()); // "White Knight"
Console.WriteLine(WeaponType.OhSword.GetDisplayLabel()); // "1H Sword"
Console.WriteLine(Element.Fire.GetDisplayLabel()); // "Fire"
```

## Public API Reference

See [docs/PublicApi.md](docs/PublicApi.md) for the full generated public API reference (287 enums, ~16,000 lines).

## License

MIT
