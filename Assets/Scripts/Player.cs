using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
// using NUnit.Framework.Internal;
using TMPro.EditorUtilities;
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
    public int wallet = 1500;
    public String ownership;
    
    
    
    
    
    
    // placeholders / future //

    public String tileType;
    public int rentvalue;

    void actions(){
    }

     void ownerCheck()
    {
    }



     void CCorChance()
    {
    }

    // end of placeholdes // 

     void payrent()
    {
        wallet = wallet - rentvalue;
        
    }
    
    void Start()
    {
        
        transform.position = new Vector3(waypointArray[waypointIndex].transform.position.x, waypointArray[waypointIndex].transform.position.y, 0);
        
        ownerCheck(); // placeholder//

        if (ownership == "available"){
            
        }
        if (ownership == "yours"){
            actions(); // placeholder//
            }

        if (ownership == "theirs"){
            payrent(); // placehholder//
            actions();
        }

        if (ownership == "unownable")
        {
            if (tileType == "CC" & tileType == "Chance")  {
                CCorChance();
            }
            actions();
        }
    }
    
    
    
    // Update is called once per frame
    public void followWaypoints()
    {
        if (stopRolling == 1)
        {
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
    }
    void Update()
    {
        
    }

    
    
    

}
