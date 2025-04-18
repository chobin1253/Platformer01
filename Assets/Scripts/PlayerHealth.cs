using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    private bool isInvincible = false;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        if (isInvincible)
        {
            Debug.Log("무적 상태! 데미지 무시.");
            return;
        }

        currentHealth -= damage;
        Debug.Log("현재 체력: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void ActivateInvincibility(float duration)
    {
        StartCoroutine(InvincibilityRoutine(duration));
    }

    private System.Collections.IEnumerator InvincibilityRoutine(float duration)
    {
        isInvincible = true;
        Debug.Log("무적 시작!");
        yield return new WaitForSeconds(duration);
        isInvincible = false;
        Debug.Log("무적 해제!");
    }

    private void Die()
    {
        Debug.Log("플레이어 사망!");
        // 리스폰하거나 게임오버 처리 등등
    }
    public bool IsInvincible()
    {
        return isInvincible;
    }

}
