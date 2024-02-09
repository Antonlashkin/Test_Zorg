using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthManager : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    private Image image;
    private float health;
    void Start()
    {
        image = GetComponent<Image>();
        health = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        image.fillAmount = health / maxHealth;
        if (health <= 0)
        {
            Destroy(transform.parent.parent.parent.gameObject);
        }
    }
}

