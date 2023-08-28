using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoodManager : MonoBehaviour
{
    public enum Mood { Happy, Neutral, Sad }
    public Mood currentMood = Mood.Neutral; // 初始心情

    public void UpdateMood()
    {
        // 更新心情的逻辑，可能基于游戏内的各种因素

        // 示例：随机设置心情
        currentMood = (Mood)Random.Range(0, 3);
    }

    public bool IsHappy()
    {
        return currentMood == Mood.Happy;
    }

    public bool IsSad()
    {
        return currentMood == Mood.Sad;
    }
}
