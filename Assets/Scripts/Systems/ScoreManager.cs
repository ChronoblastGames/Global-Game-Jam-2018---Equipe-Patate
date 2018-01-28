using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public TransmissionManager transmission;

    [Header("We Aint Got Shit")]
    public Text playerScoreText;
    public Text distanceFromHomeText;
    public Text timerText;

    public float timer;
    public float seconds;
    public float minutes;
    public float hours;
    public float playerScore;
    
	// Use this for initialization

	void Start () {
        playerScore = 0;
        timer = 0;
        //transmission = GameObject.FindGameObjectWithTag("TransmissionManager").GetComponent<TransmissionManager>();

    }
	
	// Update is called once per frame
	void Update () {
        MakeScoreHappen();

    }

    //Super secret Score Function
    void MakeScoreHappen() {

        timer += Time.deltaTime;
        int minutes = Mathf.FloorToInt(timer / 60F);
        int seconds = Mathf.FloorToInt(timer - minutes * 60);
        string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);
        timerText.text = niceTime;

        //distanceFromHomeText.text = transmission.currentTransmissionTime.ToString();

        //playerScore = Time.deltaTime * transmission.currentTransmissionTime;
        //playerScoreText.text = playerScore.ToString();

    }
}
