using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public string objectName; // 对象名称，用于识别或显示
    public bool isInteractable; // 是否可交互

    private void Start()
    {
        // 初始化逻辑，例如设置默认状态
        isInteractable = true;
    }

    public void Interact()
    {
        if (isInteractable)
        {
            // 执行交互逻辑
            Debug.Log("Interacting with " + objectName);

            // 示例：改变对象颜色
            GetComponent<SpriteRenderer>().color = Color.green;

            // 如果需要，可以在此处添加更多交互逻辑，例如触发事件或动画
        }
        else
        {
            Debug.Log(objectName + " is not interactable.");
        }
    }

    public void SetInteractable(bool value)
    {
        // 设置对象是否可交互
        isInteractable = value;
    }
}
