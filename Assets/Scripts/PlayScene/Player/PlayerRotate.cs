using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    [SerializeField] private GameObject enemys;
    private GameObject closest;

    private void Update()
    {
        if (enemys.transform.childCount != 0)
        {
            Transform closestsEnemy = FindClosesEnemy();
            var direction = closestsEnemy.position - transform.position;
            float angleHor = Mathf.Atan2( - direction.x, direction.y) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angleHor);
        }
    }

    Transform FindClosesEnemy()
    {
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        for (int i = 0; i < enemys.transform.childCount; i++)
        {
            Vector3 difference = enemys.transform.GetChild(i).position - position;
            float curDistance = difference.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = enemys.transform.GetChild(i).gameObject;
                distance = curDistance;
            }
        }
        return closest.transform;           
    }
}
