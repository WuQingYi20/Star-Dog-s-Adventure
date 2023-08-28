using System.Collections;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;

public class NPCBehavior : MonoBehaviour
{
    public MoodManager moodManager; // 心情管理器的引用

    void Start()
    {
        // 初始化或其他逻辑
    }

    void Update()
    {
        // 基础行为逻辑，例如移动或对话

        if (moodManager.IsHappy())
        {
            // 如果妈妈心情好，执行特定行为
        }
        else
        {
            // 如果妈妈心情不好，执行其他行为
        }
    }

    public void InteractWithPlayer()
    {
        // 玩家与妈妈角色交互时的逻辑
        if (moodManager.IsHappy())
        {
            // 如果妈妈心情好，给玩家一些钱或奖励
        }
        else
        {
            // 如果妈妈心情不好，可能不给钱或奖励
        }
    }
}
