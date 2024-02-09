using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth;
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
        image.fillAmount = health / maxHealth;
    }

    public static GameObject TakeHealthObject()
    {
        return _healthObject;
    }

}
