using System.Collections;
using TMPro;
using UnityEngine;

public class Stopwatch : MonoBehaviour
{
    private TMP_Text stopwatchText;
    private int stopwatchSeconds = 0;
    private int stopwatchMinutes = 0;
    private int stopwatchHours = 0;


    void Start()
    {
        stopwatchText = GetComponent<TMP_Text>();
        StartCoroutine(StopwatchWork());
    }

    private IEnumerator StopwatchWork()
    {
        yield return new WaitForSeconds(1);
        stopwatchSeconds++;
        if (stopwatchSeconds >= 60)
        {
            stopwatchMinutes++;
            stopwatchSeconds = 0;
            if (stopwatchMinutes >= 60)
            {
                stopwatchHours++;
                stopwatchMinutes = 0;
            }
        }
        string seconds = "";
        string minutes = "";

        if (stopwatchSeconds < 10)
        {
            seconds = "0" + stopwatchSeconds;
        }
        else
        {
            seconds = stopwatchSeconds.ToString();
        }

        if (stopwatchMinutes < 10)
        {
            minutes = "0" + stopwatchMinutes;
        }
        else
        {
            minutes = stopwatchMinutes.ToString();
        }
        stopwatchText.text = stopwatchHours.ToString() + ":" + minutes + ":" + seconds;
        StartCoroutine(StopwatchWork());
    }

    public TMP_Text GetStopwatchText(ref int scoreNumber)
    {
        scoreNumber = 3600 * stopwatchHours + 60 * stopwatchMinutes + stopwatchSeconds;
        return stopwatchText;
    }
}
