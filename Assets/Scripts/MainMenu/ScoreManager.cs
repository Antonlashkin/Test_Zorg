using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static string saveKey = "SaveData";

    void Start()
    {
        var data = SaveManager.Load<SaveData.SavedScore>(saveKey);
        transform.GetComponent<TMP_Text>().text = data.scoreText; ;
    }
}
