using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI moneyText; // ������ʾ��Ǯ��Text���
    public TextMeshProUGUI inventoryText; // ������ʾ���ߵ�Text���
    public TextMeshProUGUI npcRelationsText; // ������ʾNPC��ϵ��Text���

    public PlayerResourceManager playerResourceManager; // �����Դ������������

    // ����UI
    public void UpdateUI()
    {
        // ���½�Ǯ��ʾ
        moneyText.text = "Money: " + playerResourceManager.money;

        // ���µ�����ʾ
        inventoryText.text = "Inventory: " + string.Join(", ", playerResourceManager.inventory);

        // ����NPC��ϵ��ʾ
        npcRelationsText.text = "NPC Relations: ";
        foreach (var relation in playerResourceManager.npcRelations)
        {
            npcRelationsText.text += $"{relation.Key}: {relation.Value}, ";
        }
    }
}
