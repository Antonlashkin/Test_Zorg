using UnityEngine;

public class EnemyRotate : MonoBehaviour
{
    private GameObject player;

    void Start()
    {
        player = GameManager.GetPlayer();
    }

    void Update()
    {
        if (player != null)
        {
            float angle = Mathf.Atan(-(player.transform.position.x - transform.position.x) / (player.transform.position.y - transform.position.y)) * Mathf.Rad2Deg;

            if (player.transform.position.y - transform.position.y < 0)
            {
                angle += 180;
            }
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
}
