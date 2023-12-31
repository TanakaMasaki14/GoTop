using UnityEngine;

public class BreakableBoard : MonoBehaviour
{
    public float maxDurability = 100f; // 板の最大耐久度
    private float currentDurability; // 現在の耐久度

    void Start()
    {
        currentDurability = maxDurability;
    }

    // ダメージを与える関数
    public void ApplyDamage(float damage)
    {
        currentDurability -= damage;

        if (currentDurability <= 0)
        {
            Break();
        }
    }

    // 板が破壊されたときの処理
    private void Break()
    {
        // 破壊された後の処理をここに記述する
        Destroy(gameObject);
    }
}
