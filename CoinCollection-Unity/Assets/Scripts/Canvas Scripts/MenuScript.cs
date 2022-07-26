/**** 
 * Created by: Akram Taghavi-Burris
 * Date Created: July 03, 2022
 * 
 * Last Edited by: NA
 * Last Edited: July 03, 2022
 * 
 * Description: Manages the UI elements for the menu scenes
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //libraries for UI components
using TMPro; //libraries for TextMeshPro components

public class MenuScript : MonoBehaviour
{
    GameManager gm; //refernce to game manager

    [Header("Text Boxes")]
    public TMP_Text titleTextbox; //textbox for the title
    public TMP_Text creditsTextbox; //textbox for the credits
    public TMP_Text copyrightTextbox; //textbox for the copyright
    public TMP_Text mesageTextbox; //textbox for end message



    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GM; //refernce to game manager

        //If text boxes exist set the value
        if (titleTextbox) { titleTextbox.text = gm.gameTitle; }
        if (creditsTextbox) { creditsTextbox.text = gm.gameCredits; }
        if (copyrightTextbox) { copyrightTextbox.text = gm.copyrightDate; }
        if (mesageTextbox) { mesageTextbox.text = gm.endMsg; }


    }//end Start()


    public void OnGameStart()
    {
        Debug.Log("Start Game");
        gm.SetTargetState(GameState.gamePlaying);

    }//end OnGameStart()

    public void OnGameExit()
    {
        Debug.Log("Exited Game");
        Application.Quit();

    }//end OnGameExit()



}
