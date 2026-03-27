# Changelog

All notable changes to this project are documented in [GitHub Releases](https://github.com/Bia10/Maple.Enums/releases).

This project uses [MinVer](https://github.com/adamralph/minver) for semantic versioning based on git tags.

## [0.1.0] - 2026-03-27

### Added

- `MapBoatType` — ship/boat kind for continental-move maps (`CShip.m_nShipKind`, WZ `ship/shipKind`): `Regular`, `Premium`.
- `ItemQuestDeliveryType` — delivery item quest-stage discriminant (`CItemInfo::QUESTDELIVERYITEM.nType`): `Accept`, `Complete`.
- `MobEscortType` — mob escort participation role (`CMobTemplate.nEscortType`, WZ `info/escort`): `None`, `EscortTarget`.
- `NpcSpecialActionType` — NPC server-directed special action state (`CNpc.m_bSpecialAction`): `None`, `Active`.
