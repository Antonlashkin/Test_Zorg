using UnityEngine;

public class EnemyAtack : MonoBehaviour
{
    [SerializeField] private float damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Health enemyHealth = Health.TakeHealthObject().GetComponent<Health>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damage);
            }
        }
    }
}
