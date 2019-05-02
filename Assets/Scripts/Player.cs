using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using Unity.Collections;
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
    public int waypointIndex;
    public int stopRolling = 1;
    public int wallet = 1500;
    private int doublesCounter = 0;
    //public String ownership;
    public bool[] ownership;
    public GameObject[] propertArray;
    public GameObject properties;


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
        //Doubles();
        if (stopRolling == 1)
        {
            Debug.Log("movement");
            for (int i = 0; i < dice2.GetComponent<Dice>().value + dice1.GetComponent<Dice>().value; i++)
            {
                if (waypointIndex == 39)
                {
                    transform.position = new Vector3(waypointArray[0].transform.position.x,
                        waypointArray[0].transform.position.y, 0);
                    waypointIndex = 0;
                }
                else
                {
                    transform.position = new Vector3(waypointArray[waypointIndex + 1].transform.position.x,
                        waypointArray[waypointIndex + 1].transform.position.y, 0);
                    waypointIndex++;
                }

                if (waypointIndex == 0)
                {
                    wallet = wallet + 200;
                }

            }

  
            stopRolling = 2;
            WaypointLocation();
            /*
           if (GetComponent<Dice>().turn == 1 || GetComponent<Dice>().turn == 2)
            {
                GetComponent<Dice>().turn++;
            }
            */
            Button.SetActive(true);
            /*
            if (GetComponent<Dice>().turn == 1)
            {
                GetComponent<Dice>().turn = 2;
                Debug.Log("turn 1");
            }
            
            else if (GetComponent<Dice>().turn == 2)
            {
                GetComponent<Dice>().turn = 3;
                Debug.Log("turn 2");
            }
            
            else if (GetComponent<Dice>().turn == 3)
            {
                GetComponent<Dice>().turn = 1;
                Debug.Log("turn 3");
            }
            */

        }
        else
        {
            stopRolling = 1;
        }
    }

    void Update()
    {

    }


    public bool Doubles()
    {
        Debug.Log("Doubles");

        bool doubles;
        if (dice2.GetComponent<Dice>().value == dice1.GetComponent<Dice>().value)
        {
            if (doublesCounter < 3)
            {
                doublesCounter++;
                if (doublesCounter == 3)
                {
                    transform.position = new Vector3(jailWaypoint.transform.position.x,
                        waypointArray[waypointIndex + 1].transform.position.y, 0);
                    //Button.SetActive(false); 
                    return false;
                }
                else
                {
                    //GetComponent<Renderer>().enabled = true                                 
                    Button.SetActive(true);
                    return true;
                }
            }
            else
            {
                //GetComponent<Renderer>().enabled = false;
                //Button.SetActive(false); 
                doublesCounter = 0;
                return false;
            }
        }
        else
        {
            return false;
            //Button.SetActive(false); 
        }
    }

    void WaypointLocation()
    {
        Debug.Log("check location " + waypointIndex);
        switch (waypointIndex)
        {
            case 7: case 22: case 36://chance

                break;
            case 2: case 17: case 33://cc

                break;
            case 4: case 38://tax

                break;
            case 5: case 15: case 25: case 35://railroad

                break;
            case 12: case 28://company

                break;
            case 0: case 10: case 20://visiting,go,free parking

                break;
            case 30://jail

                break;
            default://properties
                   properties.GetComponent<Properties>().findCard(); 
                break;
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

