using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 引入SceneManager命名空间

public class SceneTransition : MonoBehaviour
{
    public string sceneToLoad; // 要加载的场景名称
    public Vector2 playerPosition; // 玩家在新场景中的初始位置
    public VectorValue playerStorage; // 用于存储玩家位置的VectorValue对象

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            playerStorage.initialValue = playerPosition; // 设置玩家在新场景中的位置
            SceneManager.LoadScene(sceneToLoad); // 加载新场景
        }
    }
}
