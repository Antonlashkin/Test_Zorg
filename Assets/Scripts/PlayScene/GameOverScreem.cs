using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreem : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        SceneManager.LoadScene(0);
    }
}
