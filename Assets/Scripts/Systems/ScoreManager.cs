using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    [Header("We Aint Got Shit")]
    public float playerScore;
    public Text playerScoreText;

	// Use this for initialization
	void Start () {
        playerScore = 0;

    }
	
	// Update is called once per frame
	void Update () {
        MakeScoreHappen();

    }

    //Super secret Score Function
    void MakeScoreHappen() {
        playerScore += Time.time;
        playerScoreText.text = playerScore.ToString();
    }
}
