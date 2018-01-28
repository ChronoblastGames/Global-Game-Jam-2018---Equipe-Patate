using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour 
{
    public TransmissionManager transmission;
 
    [Header("Score Variables")]
    public Text playerScoreText;
    public Text distanceFromHomeText;
    public Text timerText;
 
    public float playerScore;
    public float timer;
    public float seconds;
    public float minutes;
    public float hours;

    private void Start()
    {
        transmission = GameObject.FindGameObjectWithTag("TransmissionManager").GetComponent<TransmissionManager>();
    }

    private void Update()
    {
        MakeScoreHappen();
    }

    private void MakeScoreHappen() 
    {
        timer += Time.deltaTime;
 
        int minutes = Mathf.FloorToInt(timer / 60F);
        int seconds = Mathf.FloorToInt(timer - minutes * 60);
 
        string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);
 
        timerText.text = niceTime;
 
        distanceFromHomeText.text = transmission.currentTransmissionTime.ToString();
 
        playerScore = Time.deltaTime * transmission.playerDistanceFromOrigin;
        playerScoreText.text = playerScore.ToString();
    }
 
}
