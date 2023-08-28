using UnityEngine;

[CreateAssetMenu]
public class VectorValue : ScriptableObject
{
    public Vector2 initialValue; // ��ʼֵ
    public Vector2 runtimeValue; // ����ʱ��ֵ

    private void OnEnable()
    {
        runtimeValue = initialValue; // �ڽű�����ʱ����������ʱ��ֵΪ��ʼֵ
    }
}
