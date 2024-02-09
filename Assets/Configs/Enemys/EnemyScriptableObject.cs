using UnityEngine;

[CreateAssetMenu(fileName = "EnemyConfig", menuName = "Configs/Enemy Config ")]
public class EnemyScriptableObject : ScriptableObject
{
    public Sprite sprite;
    public float speed;
    public float damage;
    public float health;
}
