using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // ����SceneManager�����ռ�

public class SceneTransition : MonoBehaviour
{
    public string sceneToLoad; // Ҫ���صĳ�������
    public Vector2 playerPosition; // ������³����еĳ�ʼλ��
    public VectorValue playerStorage; // ���ڴ洢���λ�õ�VectorValue����

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            playerStorage.initialValue = playerPosition; // ����������³����е�λ��
            SceneManager.LoadScene(sceneToLoad); // �����³���
        }
    }
}
