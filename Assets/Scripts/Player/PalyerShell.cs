using UnityEngine;

public class PalyerShell : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float damage;
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
                Debug.Log(10);
            }
        }
        Destroy(gameObject);
    }
}
