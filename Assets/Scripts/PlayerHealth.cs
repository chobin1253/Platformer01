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
            Debug.Log("���� ����! ������ ����.");
            return;
        }

        currentHealth -= damage;
        Debug.Log("���� ü��: " + currentHealth);

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
        Debug.Log("���� ����!");
        yield return new WaitForSeconds(duration);
        isInvincible = false;
        Debug.Log("���� ����!");
    }

    private void Die()
    {
        Debug.Log("�÷��̾� ���!");
        // �������ϰų� ���ӿ��� ó�� ���
    }
    public bool IsInvincible()
    {
        return isInvincible;
    }

}
