using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerResourceManager : MonoBehaviour
{
    public int money; // 玩家的金钱
    public List<string> inventory; // 玩家的道具清单
    public Dictionary<string, int> npcRelations; // 玩家与NPC的关系

    // 初始化
    private void Start()
    {
        money = 0; // 初始金钱为0
        inventory = new List<string>(); // 初始化空的道具清单
        npcRelations = new Dictionary<string, int>(); // 初始化空的NPC关系字典
    }

    // 增加金钱
    public void AddMoney(int amount)
    {
        money += amount;
    }

    // 使用金钱
    public bool UseMoney(int amount)
    {
        if (money >= amount)
        {
            money -= amount;
            return true;
        }
        return false;
    }

    // 添加道具
    public void AddItem(string item)
    {
        inventory.Add(item);
    }

    // 使用道具
    public bool UseItem(string item)
    {
        if (inventory.Contains(item))
        {
            inventory.Remove(item);
            return true;
        }
        return false;
    }

    // 增加或更新NPC关系
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

    // 获取与特定NPC的关系值
    public int GetNpcRelation(string npcName)
    {
        if (npcRelations.ContainsKey(npcName))
        {
            return npcRelations[npcName];
        }
        return 0; // 如果没有与该NPC的关系记录，返回0
    }
}
