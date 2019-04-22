using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
//using NUnit.Framework.Internal;
// using TMPro.EditorUtilities;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject dice1, dice2;

    public GameObject Button;

    // Start is called before the first frame update
    public GameObject[] waypointArray;
    private Waypoint currentWaypoint;
    public GameObject jailWaypoint;
    private int currentLocation = 0;
    private int waypointIndex;
    public int stopRolling = 1;
    public int wallet = 1500;
    public String ownership;
    public int doublesCounter = 0;





    // placeholders / future //

    public String tileType;
    public int rentvalue;

    void actions()
    {
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

        transform.position = new Vector3(waypointArray[waypointIndex].transform.position.x,
            waypointArray[waypointIndex].transform.position.y, 0);

    }
    //ownerCheck(); // placeholder//





        // Update is called once per frame
         public void followWaypoints()
        {
            Doubles();
            if (stopRolling == 1)
            {
                for (int i = 0; i < dice2.GetComponent<Dice>().value + dice1.GetComponent<Dice>().value; i++)
                {
                    transform.position = new Vector3(waypointArray[waypointIndex + 1].transform.position.x,
                        waypointArray[waypointIndex + 1].transform.position.y, 0);
                    waypointIndex++;
                }

                stopRolling = 2;
                if (GetComponent<Dice>().turn == 1 || GetComponent<Dice>().turn == 2)
                {
                    GetComponent<Dice>().turn++;
                }
                else if (GetComponent<Dice>().turn == 3)
                {
                    GetComponent<Dice>().turn = 1;
                }
                Button.SetActive(true);
            }
            else
            {
                stopRolling = 1;
            }
        }

         void Update()
         {

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


        /*  
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
          */
        
}

