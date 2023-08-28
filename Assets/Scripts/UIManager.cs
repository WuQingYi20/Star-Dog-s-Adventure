using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI moneyText; // 用于显示金钱的Text组件
    public TextMeshProUGUI inventoryText; // 用于显示道具的Text组件
    public TextMeshProUGUI npcRelationsText; // 用于显示NPC关系的Text组件

    public PlayerResourceManager playerResourceManager; // 玩家资源管理器的引用

    // 更新UI
    public void UpdateUI()
    {
        // 更新金钱显示
        moneyText.text = "Money: " + playerResourceManager.money;

        // 更新道具显示
        inventoryText.text = "Inventory: " + string.Join(", ", playerResourceManager.inventory);

        // 更新NPC关系显示
        npcRelationsText.text = "NPC Relations: ";
        foreach (var relation in playerResourceManager.npcRelations)
        {
            npcRelationsText.text += $"{relation.Key}: {relation.Value}, ";
        }
    }
}
