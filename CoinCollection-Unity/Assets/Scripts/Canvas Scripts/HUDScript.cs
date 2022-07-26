/**** 
 * Created by: Akram Taghavi-Burris
 * Date Created: Feb 23, 2022
 * 
 * Last Edited by: NA
 * Last Edited: Feb 23, 2022
 * 
 * Description: Updates HUD canvas referecing game manager
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class HUDScript : MonoBehaviour
{
    /*** VARIABLES ***/

    GameManager gm; //reference to game manager

    [Header("Stats Placement")]
    public TMP_Text levelCountTextbox; //textbox for level count
    public TMP_Text livesTextbox; //textbox for the lives
    public TMP_Text healthTextbox; //textbox for highscore
    public TMP_Text scoreTextbox; //textbox for the score
    public TMP_Text highScoreTextbox; //textbox for highscore
    public TMP_Text collectableCountTextbox; //textbox for amount of collectables
    public TMP_Text TimerTextbox; //textbox for Timer display
    public TMP_Text fastestTimeTextbox; //textbox for the Fastest Time


    //GM Data
    private int level;
    private int totalLevels;
    private int lives;
    private int score;
    private int highscore;
    private string timer;
    private string collection;

   private void Start()
    {
        gm = GameManager.GM; //refernce to game manager

        //reference to levle info
        level = gm.gameLevelsCount;
        totalLevels = gm.gameLevels.Length;

        SetHUD(); //set up the hud

    }//end Start

 // Update is called once per frame
    void Update()
    {
        GetGameStats();
        SetHUD();
    }//end Update()

    void GetGameStats()
    {
        lives = gm.Lives;
        score = gm.Score;
        highscore = gm.HighScore;
        timer = gm.Timer;
        collection = gm.Collection;
    }

    void SetHUD()
    {
        //if texbox exsists update value
        if (levelCountTextbox) { levelCountTextbox.text = "Level " + level + "/" + totalLevels; }
        if (livesTextbox) { livesTextbox.text = "Lives " + lives; }
        if (scoreTextbox) { scoreTextbox.text = "Scores " + score; }
        if (highScoreTextbox) { highScoreTextbox.text = "High Score " + highscore; }
        if (TimerTextbox) { TimerTextbox.text = "Time: " + timer; }
        if (collectableCountTextbox) { collectableCountTextbox.text = "Collected: " + collection; }


    }//end SetHUD()

}
