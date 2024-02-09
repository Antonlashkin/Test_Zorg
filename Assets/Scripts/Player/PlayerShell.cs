using UnityEngine;

public class PlayerShell : MonoBehaviour
{
    [SerializeField] private float speed;
    private float damage;
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            EnemyHealthManager enemyHealth = collision.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<EnemyHealthManager>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damage);
            }
        }
        Destroy(gameObject);
    }

    public void SetDamage(float _damage)
    {
        damage = _damage;
    }
}
