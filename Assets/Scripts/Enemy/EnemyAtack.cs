using System.Collections;
using UnityEngine;

public class EnemyAtack : MonoBehaviour
{
    [SerializeField] private float reloadTime;
    private bool playerIsAtacked = false;
    private float damage;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Health playerHealth = Health.TakeHealthObject().GetComponent<Health>();
            if (playerHealth != null && !playerIsAtacked)
            {
                playerHealth.TakeDamage(damage);
                playerIsAtacked = true;
                StartCoroutine(Reloading());
            }
        }
    }

    private IEnumerator Reloading()
    {
        yield return new WaitForSeconds(reloadTime);
        playerIsAtacked = false;
    }

    public void SetDamage(float _damage)
    {
        damage = _damage;
    }
}
