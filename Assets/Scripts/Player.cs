using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject dice1, dice2;

    public GameObject Button;
    // Start is called before the first frame update
    public GameObject[] waypointArray;
    private Waypoint currentWaypoint;
    private int currentLocation = 0;
    private int waypointIndex = 0;
    public int stopRolling = 1; 
    int doublesCounter = 0;
    public GameObject jailWaypoint;
    void Start()
    {
        transform.position = new Vector3(waypointArray[waypointIndex].transform.position.x, waypointArray[waypointIndex].transform.position.y, 0);

    }
    
    // Update is called once per frame
    public void followWaypoints()
    {
        if (stopRolling == 1)
        {
            Doubles();
            for (int i = 0; i < dice2.GetComponent<Dice>().value + dice1.GetComponent<Dice>().value; i++)
            {
                transform.position = new Vector3(waypointArray[waypointIndex + 1].transform.position.x,
                    waypointArray[waypointIndex + 1].transform.position.y, 0);
                waypointIndex++;
            }

            stopRolling = 2;
        }
        else
        {
            stopRolling = 1;
        }

       
         void Doubles()
         {
             Boolean doubles;
             if (dice2.GetComponent<Dice>().value == dice1.GetComponent<Dice>().value)
             {
                 doubles = true;
                 if (doublesCounter < 3)
                         {
                             doublesCounter++;
                             if (doublesCounter == 3)
                             {
                                 transform.position = new Vector3(jailWaypoint.transform.position.x,
                                     waypointArray[waypointIndex + 1].transform.position.y, 0);
                                 Button.SetActive(false); 
                             }
                             else
                             {
                                 //GetComponent<Renderer>().enabled = true;
                                 Button.SetActive(true);
                             }
                         }
                         else
                         {
                             //GetComponent<Renderer>().enabled = false;
                             Button.SetActive(false); 
                             doublesCounter = 0;
                         }
             }
             else
             {
                 doubles = false;
                 Button.SetActive(false); 
             }
             
        
        }

        
    }

    void Update()
    {
        
    }
}
