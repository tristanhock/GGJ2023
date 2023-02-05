using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timerDuration = 60.0f;  // The duration of the timer in seconds
    public Text timerText;  // A reference to the Text component that displays the timer

    private float startTime;  // The start time of the timer

    private void Start()
    {
        // Get the current time as the start time of the timer
        startTime = Time.time;
    }

    private void Update()
    {
        // Calculate the elapsed time since the start of the timer
        float elapsedTime = Time.time - startTime;

        // Calculate the remaining time
        float remainingTime = timerDuration - elapsedTime;

        // Display the remaining time in the timer text
        timerText.text = remainingTime.ToString("0.0");

        // Check if the timer has finished
        if (remainingTime <= 0)
        {
            // The timer has finished, do something here (e.g. end the game)
        }
    }
}
