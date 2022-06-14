/**** 
 * Created by: Stu Dent
 * Date Created: Feb 3, 2022
 * 
 * Last Edited by: 
 * Last Edited: 
 * 
 * Description: A level timer that can be set and controlled
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    /***VARIABLES***/
    #region Timer Singleton
    static private Timer timer; //refence GameManager
    static public Timer LevelTimer { get { return timer; } } //public access to read only timer 

    //Check to make sure only one gm of the GameManager is in the scene
    void CheckTimerIsInScene()
    {

        //Check if instnace is null
        if (timer == null)
        {
            timer = this; //set gm to this gm of the game object
            Debug.Log(timer);
        }
        else //else if gm is not null a Game Manager must already exsist
        {
            Destroy(this.gameObject); //In this case you need to delete this gm
        }
    }//end CheckTimerIsInScene()
    #endregion
    
    [Tooltip("Start time in seconds")]
    public float startTime = 10f; //time for level (if level is timed)

    private float currentTime; //current time of timer

    [HideInInspector]
    public bool timerStoped = false; //check if timer is stoped


    // Awake is called on instantiation before Start
    void Awake()
    {
        //runs the method to check for the GameManager
        CheckTimerIsInScene();
    }//end Awake()


    // Start is called before the first frame update
    void Start()
    {
        timer = Timer.LevelTimer; //find the level timer
        currentTime = startTime; //set the current time to the startTime specified
}

    // Update is called once per frame
    void Update()
    {
        RunTimer();

    }//end Update()

    //Runs the timer countdown
    private void RunTimer()
    {
        if (timerStoped)
        { // check to see if timer has stoped
            LevelEnd();
        }
        else
        { 
            if(currentTime > 0)
            {
                // if still time, update timer countdown
                currentTime -= Time.deltaTime;
            }
            else
            {//if the timer is equal to or less than zero
                currentTime = 0; //set time to zero
                timerStoped = true; //stop the timer
            }

            DisplayTime(currentTime); //call DisplayTime method to format time
            Debug.Log(DisplayTime(currentTime));

        }

    }//end RunTimer();

    //Formats time as string
    string DisplayTime(float timeToDispaly)
    {
        timeToDispaly += 1; //adds 1 to time, to accuratly refelect time in field

        float minutes = Mathf.FloorToInt(timeToDispaly / 60); //calculate timer mintues
        float seconds = Mathf.FloorToInt(timeToDispaly % 60); //calculate timer seconds

        return string.Format("{0:00}:{1:00}", minutes, seconds); //retrun time as string
    }//end DisplayTime


    //Runs events for the end of the level
    private void LevelEnd()
    {
        Debug.Log("level end");

    }//end LevelEnd()


}
