/**** 
 * Created by: Stu Dent
 * Date Created: Feb 3, 2022
 * 
 * Last Edited by: 
 * Last Edited: 
 * 
 * Description: Collectable object behaviors for counting the total amount of collectables and checking for collision with the player.
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    /***VARIABLES***/
    static public int collectableCount; //counts the number of colletables in the scene

    // Start is called before the first frame update
    void Start()
    {
        collectableCount++; //add to collectable
        Debug.Log("Number of Colletables " + collectableCount);
    }//end Start()

    // Update is called once per frame
    void Update()
    {
        
    }//end Update()

    //Called when a GameObject collides with another GameObject
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collectable Triggered");

        if(other.tag == "Player")
        {
            Destroy(gameObject); //destroy this gameObject (collectable object)
        }

    }//end OnTriggerEnter()


}
