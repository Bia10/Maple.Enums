# Changelog

All notable changes to this project are documented in [GitHub Releases](https://github.com/Bia10/Maple.Enums/releases).

This project uses [MinVer](https://github.com/adamralph/minver) for semantic versioning based on git tags.

## [0.3.0] - 2026-03-27

### Added

- `AccountGradeCode` — account grade bitmask (`CWvsContext.m_nGradeCode`, `AccountInfoResult` packet, `Decode1`): `AdminLevel1` (0x01), `AdminLevel2` (0x02), `AdminLevel3` (0x04), `AdminLevel4` (0x08), `AdminLevel5` (0x10), `AdminLevel10` (0x20). Bit checks corroborated by `IsAdminAccount`, `IsTradeBlockedUser`, and `GetAdminLevel` in `game_pseudocode.c`.
- `LifeType` — map life entry type (WZ `Map.wz/{mapId}/life/{id}/type`): `Mob`, `Npc`.

### Changed

- `MapBoatType` — added `None = 0` sentinel for maps without a ship; shifted `Regular` to 1 and `Premium` to 2 to match WZ `ship/shipKind` semantics.

### Notes

- `AccountSubGradeCode` (the packet's `m_nSubGradeCode` field) is `PrivateStatusIDFlag` in the V95 PDB (`enum PrivateStatusIDFlag : __int32`, `PS_*` prefix, line ~1691). It already exists in this library as `PrivateStatusFlag`. Consuming code should reference `PrivateStatusFlag` directly.

## [0.2.0] - 2026-03-27

### Added

- `MapBoatType` — ship/boat kind for continental-move maps (`CShip.m_nShipKind`, WZ `ship/shipKind`): `Regular`, `Premium`.
- `ItemQuestDeliveryType` — delivery item quest-stage discriminant (`CItemInfo::QUESTDELIVERYITEM.nType`): `Accept`, `Complete`.
- `MobEscortType` — mob escort participation role (`CMobTemplate.nEscortType`, WZ `info/escort`): `None`, `EscortTarget`.
- `NpcSpecialActionType` — NPC server-directed special action state (`CNpc.m_bSpecialAction`): `None`, `Active`.
