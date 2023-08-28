using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public string objectName; // �������ƣ�����ʶ�����ʾ
    public bool isInteractable; // �Ƿ�ɽ���

    private void Start()
    {
        // ��ʼ���߼�����������Ĭ��״̬
        isInteractable = true;
    }

    public void Interact()
    {
        if (isInteractable)
        {
            // ִ�н����߼�
            Debug.Log("Interacting with " + objectName);

            // ʾ�����ı������ɫ
            GetComponent<SpriteRenderer>().color = Color.green;

            // �����Ҫ�������ڴ˴���Ӹ��ཻ���߼������紥���¼��򶯻�
        }
        else
        {
            Debug.Log(objectName + " is not interactable.");
        }
    }

    public void SetInteractable(bool value)
    {
        // ���ö����Ƿ�ɽ���
        isInteractable = value;
    }
}
