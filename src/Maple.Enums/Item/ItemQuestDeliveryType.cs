using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Delivery sub-type of a quest-delivery item
/// (<c>CItemInfo::QUESTDELIVERYITEM.nType</c>).
/// Controls which stage of a delivery quest the item participates in.
/// </summary>
/// <remarks>
/// Loaded by <c>CItemInfo::RegisterQuestDeliveryItem</c> from
/// <c>Item.wz/{id}.img/info/</c> into the <c>QUESTDELIVERYITEM</c> struct
/// and indexed in <c>CItemInfo::m_mQuestDeliveryItem</c> by item ID.
/// <para>
/// At runtime <c>CUIQuestDelivery</c> branches on this value to determine
/// which quest-manager check (<c>CQuestMan::IsDeliveryAcceptQuest</c> vs
/// <c>CQuestMan::IsDeliveryCompleteQuest</c>) to apply before encoding
/// the quest packet.
/// </para>
/// </remarks>
public enum ItemQuestDeliveryType : byte
{
    /// <summary>
    /// Item is used to trigger acceptance of a delivery quest
    /// that the character has not yet started.
    /// Checked via <c>CQuestMan::IsDeliveryAcceptQuest</c>.
    /// </summary>
    [Label("Accept", 1)]
    Accept = 0,

    /// <summary>
    /// Item is used to complete a delivery quest that is already
    /// in progress (quest state == 1).
    /// Checked via <c>CQuestMan::IsDeliveryCompleteQuest</c>.
    /// Requires the item's <c>lDisallowComplete</c> allow-list to pass.
    /// </summary>
    [Label("Complete", 1)]
    Complete = 1,
}
