using UnityEngine;

[CreateAssetMenu(fileName = "PlayerConfig", menuName = "Configs/Player Config ")]
public class PlayerScriptableObject : ScriptableObject
{
    public float timeBetwenShots;
    public float damage;
    public float health;
    public float speed;
}
