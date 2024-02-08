using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private static GameObject staticPlayerObject;

    private void Start()
    {
        staticPlayerObject = player;
    }

    public static GameObject GetPlayer()
    {
        return staticPlayerObject;
    }
}
