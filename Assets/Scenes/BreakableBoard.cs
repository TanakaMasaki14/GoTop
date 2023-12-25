using UnityEngine;

public class BreakableBoard : MonoBehaviour
{
    public float maxDurability = 100f; // �̍ő�ϋv�x
    private float currentDurability; // ���݂̑ϋv�x

    void Start()
    {
        currentDurability = maxDurability;
    }

    // �_���[�W��^����֐�
    public void ApplyDamage(float damage)
    {
        currentDurability -= damage;

        if (currentDurability <= 0)
        {
            Break();
        }
    }

    // ���j�󂳂ꂽ�Ƃ��̏���
    private void Break()
    {
        // �j�󂳂ꂽ��̏����������ɋL�q����
        Destroy(gameObject);
    }
}
