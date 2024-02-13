using UnityEngine;

public class PlayerConfig : MonoBehaviour
{
    [SerializeField] private PlayerScriptableObject playerScriptableObject;
    [SerializeField] private Transform health;

    void Start()
    {
        health.GetComponent<Health>().SetHealth(playerScriptableObject.health);
        transform.GetComponent<PlayerMove>().SetSpeed(playerScriptableObject.speed);
        transform.GetComponent<PlayerShooting>().SetDamage(playerScriptableObject.damage);
        transform.GetComponent<PlayerShooting>().SetTimeBetwenShoots(playerScriptableObject.timeBetwenShots);
    }
}
