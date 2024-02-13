using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private Transform stopwatch;
    [SerializeField] private GameObject newScore;
    private int lastScore;
    private string lastScoreText;
    void Start()
    {
        lastScoreText = stopwatch.GetComponent<Stopwatch>().GetStopwatchText(ref lastScore).text;
        transform.GetComponent<TMP_Text>().text = "Your score: " + lastScoreText;

        var savedData = SaveManager.Load<SaveData.SavedScore>(ScoreManager.saveKey);

        if (lastScore > savedData.score)
        {
            var data = new SaveData.SavedScore()
            {
                scoreText = lastScoreText,
                score = lastScore,

            };
            SaveManager.Save(ScoreManager.saveKey, data);

            newScore.SetActive(true);
        }
    }
}
