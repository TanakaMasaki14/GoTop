using UnityEngine;

public class BreakableBoard : MonoBehaviour
{
    public float maxDurability = 100f; // ”Â‚ÌÅ‘å‘Ï‹v“x
    private float currentDurability; // Œ»İ‚Ì‘Ï‹v“x

    void Start()
    {
        currentDurability = maxDurability;
    }

    // ƒ_ƒ[ƒW‚ğ—^‚¦‚éŠÖ”
    public void ApplyDamage(float damage)
    {
        currentDurability -= damage;

        if (currentDurability <= 0)
        {
            Break();
        }
    }

    // ”Â‚ª”j‰ó‚³‚ê‚½‚Æ‚«‚Ìˆ—
    private void Break()
    {
        // ”j‰ó‚³‚ê‚½Œã‚Ìˆ—‚ğ‚±‚±‚É‹Lq‚·‚é
        Destroy(gameObject);
    }
}
