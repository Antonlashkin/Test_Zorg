using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject gameOverScreen;
    private static GameObject _gameOverScreen;

    private static GameObject staticPlayerObject;

    private void Start()
    {
        _gameOverScreen = gameOverScreen;
        staticPlayerObject = player;
    }

    public static GameObject GetPlayer()
    {
        return staticPlayerObject;
    }

    public static void GameOver()
    {
        _gameOverScreen.SetActive(true);
        Time.timeScale = 1.0f;
    }
}
