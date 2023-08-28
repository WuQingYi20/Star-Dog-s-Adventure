using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // ����UI�����ռ����ڲ�������

public class MoneyStorage : MonoBehaviour
{
    public int currentMoney; // ��ǰ�洢�Ľ�Ǯ
    public GameObject moneyUI; // ��Ǯ���������
    public Text moneyText; // ��ʾ��Ǯ������UI�ı�

    private void Start()
    {
        // ��ʼ���߼�������ӱ����ļ����ؽ�Ǯ״̬
        currentMoney = 0;
        UpdateMoneyUI();
    }

    public void InteractWithMoneyStorage()
    {
        // �򿪴�Ǯ����
        moneyUI.SetActive(true);

        // ���½�������ʾ�Ľ�Ǯ����
        UpdateMoneyUI();
    }

    public void DepositMoney(int amount)
    {
        // ��Ǯ�߼�
        currentMoney += amount;
        UpdateMoneyUI();
    }

    public void WithdrawMoney(int amount)
    {
        // ȡǮ�߼�
        if (currentMoney >= amount)
        {
            currentMoney -= amount;
            UpdateMoneyUI();
        }
        else
        {
            Debug.Log("Not enough money.");
        }
    }

    private void UpdateMoneyUI()
    {
        // ���´�Ǯ��������ʾ�Ľ�Ǯ����
        moneyText.text = "Current Money: " + currentMoney;
    }
}
