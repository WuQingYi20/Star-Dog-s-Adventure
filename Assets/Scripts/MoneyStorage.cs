using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // 引入UI命名空间用于操作界面

public class MoneyStorage : MonoBehaviour
{
    public int currentMoney; // 当前存储的金钱
    public GameObject moneyUI; // 存钱界面的引用
    public Text moneyText; // 显示金钱数量的UI文本

    private void Start()
    {
        // 初始化逻辑，例如从保存文件加载金钱状态
        currentMoney = 0;
        UpdateMoneyUI();
    }

    public void InteractWithMoneyStorage()
    {
        // 打开存钱界面
        moneyUI.SetActive(true);

        // 更新界面上显示的金钱数量
        UpdateMoneyUI();
    }

    public void DepositMoney(int amount)
    {
        // 存钱逻辑
        currentMoney += amount;
        UpdateMoneyUI();
    }

    public void WithdrawMoney(int amount)
    {
        // 取钱逻辑
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
        // 更新存钱界面上显示的金钱数量
        moneyText.text = "Current Money: " + currentMoney;
    }
}
