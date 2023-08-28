using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // 角色移动速度
    public Transform interactPoint; // 交互点，用于检测角色是否接近可交互对象
    public LayerMask interactableLayer; // 可交互对象的图层

    private Rigidbody2D rb; // Rigidbody2D组件引用

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // 获取Rigidbody2D组件
    }

    void Update()
    {
        // 处理角色移动
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector2 move = new Vector2(moveX, moveY);
        rb.velocity = move * moveSpeed;

        // 处理角色交互
        if (Input.GetKeyDown(KeyCode.E)) // 假设E键用于交互
        {
            Interact();
        }
    }

    void Interact()
    {
        // 使用OverlapCircle检测是否有可交互对象在交互点附近
        Collider2D collider = Physics2D.OverlapCircle(interactPoint.position, 0.5f, interactableLayer);

        if (collider != null)
        {
            Debug.Log("Interacting with " + collider.gameObject.name);

            MoneyStorage moneyStorage = collider.GetComponent<MoneyStorage>();
            if (moneyStorage != null)
            {
                moneyStorage.InteractWithMoneyStorage();
            }
        }

    }
}
