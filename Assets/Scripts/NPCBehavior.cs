using System.Collections;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;

public class NPCBehavior : MonoBehaviour
{
    public MoodManager moodManager; // ���������������

    void Start()
    {
        // ��ʼ���������߼�
    }

    void Update()
    {
        // ������Ϊ�߼��������ƶ���Ի�

        if (moodManager.IsHappy())
        {
            // �����������ã�ִ���ض���Ϊ
        }
        else
        {
            // ����������鲻�ã�ִ��������Ϊ
        }
    }

    public void InteractWithPlayer()
    {
        // ����������ɫ����ʱ���߼�
        if (moodManager.IsHappy())
        {
            // �����������ã������һЩǮ����
        }
        else
        {
            // ����������鲻�ã����ܲ���Ǯ����
        }
    }
}
