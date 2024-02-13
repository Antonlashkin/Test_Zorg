using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] GameObject player;
    private float maxHealth;
    private Image image;
    private float health;
    private static GameObject _healthObject;

    void Start()
    {
        _healthObject = gameObject;
        image = GetComponent<Image>();
        health = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(player);
            GameManager.GameOver();
        }
        image.fillAmount = health / maxHealth;
    }

    public static GameObject TakeHealthObject()
    {
        return _healthObject;
    }

    public void SetHealth(float _health)
    {
        maxHealth = _health;
    }

}
