using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // ��ɫ�ƶ��ٶ�
    public Transform interactPoint; // �����㣬���ڼ���ɫ�Ƿ�ӽ��ɽ�������
    public LayerMask interactableLayer; // �ɽ��������ͼ��

    private Rigidbody2D rb; // Rigidbody2D�������

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // ��ȡRigidbody2D���
    }

    void Update()
    {
        // �����ɫ�ƶ�
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector2 move = new Vector2(moveX, moveY);
        rb.velocity = move * moveSpeed;

        // �����ɫ����
        if (Input.GetKeyDown(KeyCode.E)) // ����E�����ڽ���
        {
            Interact();
        }
    }

    void Interact()
    {
        // ʹ��OverlapCircle����Ƿ��пɽ��������ڽ����㸽��
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
