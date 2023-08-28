using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerResourceManager : MonoBehaviour
{
    public int money; // ��ҵĽ�Ǯ
    public List<string> inventory; // ��ҵĵ����嵥
    public Dictionary<string, int> npcRelations; // �����NPC�Ĺ�ϵ

    // ��ʼ��
    private void Start()
    {
        money = 0; // ��ʼ��ǮΪ0
        inventory = new List<string>(); // ��ʼ���յĵ����嵥
        npcRelations = new Dictionary<string, int>(); // ��ʼ���յ�NPC��ϵ�ֵ�
    }

    // ���ӽ�Ǯ
    public void AddMoney(int amount)
    {
        money += amount;
    }

    // ʹ�ý�Ǯ
    public bool UseMoney(int amount)
    {
        if (money >= amount)
        {
            money -= amount;
            return true;
        }
        return false;
    }

    // ��ӵ���
    public void AddItem(string item)
    {
        inventory.Add(item);
    }

    // ʹ�õ���
    public bool UseItem(string item)
    {
        if (inventory.Contains(item))
        {
            inventory.Remove(item);
            return true;
        }
        return false;
    }

    // ���ӻ����NPC��ϵ
    public void UpdateNpcRelation(string npcName, int value)
    {
        if (npcRelations.ContainsKey(npcName))
        {
            npcRelations[npcName] += value;
        }
        else
        {
            npcRelations.Add(npcName, value);
        }
    }

    // ��ȡ���ض�NPC�Ĺ�ϵֵ
    public int GetNpcRelation(string npcName)
    {
        if (npcRelations.ContainsKey(npcName))
        {
            return npcRelations[npcName];
        }
        return 0; // ���û�����NPC�Ĺ�ϵ��¼������0
    }
}
