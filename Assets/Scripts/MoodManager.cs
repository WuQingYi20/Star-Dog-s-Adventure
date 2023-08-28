using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoodManager : MonoBehaviour
{
    public enum Mood { Happy, Neutral, Sad }
    public Mood currentMood = Mood.Neutral; // ��ʼ����

    public void UpdateMood()
    {
        // ����������߼������ܻ�����Ϸ�ڵĸ�������

        // ʾ���������������
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
