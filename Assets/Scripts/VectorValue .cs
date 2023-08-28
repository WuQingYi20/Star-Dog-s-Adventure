using UnityEngine;

[CreateAssetMenu]
public class VectorValue : ScriptableObject
{
    public Vector2 initialValue; // 初始值
    public Vector2 runtimeValue; // 运行时的值

    private void OnEnable()
    {
        runtimeValue = initialValue; // 在脚本启用时，设置运行时的值为初始值
    }
}
