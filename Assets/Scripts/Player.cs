using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using Unity.Collections;
//using NUnit.Framework.Internal;
// using TMPro.EditorUtilities;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public GameObject dice1, dice2;

    public GameObject Button;

    // Start is called before the first frame update
    public GameObject[] waypointArray;// waypoint array
    private Waypoint currentWaypoint;    //waypoint
    public GameObject jailWaypoint;// the jail waypoint
    private int currentLocation = 0; // current location 
    public int waypointIndex;//waypoint index
    public int stopRolling = 1;  //tells when to stop rolling
    public int wallet = 1500;// amount of money
    public int doublesCounter = 0;// counts number of doubles
    //public String ownership;
    public bool [] ownership;// ownership
    public GameObject[] propertArray;// array of properties
    public GameObject properties;// properties

    public GameObject chanceGOOFJButton;// Chance Get out of jail object
    public GameObject ccGOOFJButton;//Chest get out of jail 
    public GameObject bail;// bail 
    public GameObject walletText;

    public GameObject walletNum;
    // placeholders / future //
    
    public String tileType;
    public int rentvalue;  //rent value
    public bool inJail = false;  //in jail boolean
    public int jailCounter = 0;  // jail counter
    public bool chanceGOOFJ = false; // chance goojf bool
    public bool ccGOOFJ = false;  //community chest goojf bool
    public GameObject OwnershipClass;  //ownership class
    

    void Start() // sets up conditions
    {
       // these hold the jail related stuff
        chanceGOOFJButton.SetActive(false); 
        ccGOOFJButton.SetActive(false);
        bail.SetActive(false);
        
       
        //  puts waypoints in position and keeps them from falling through z-axis.
        transform.position = new Vector3(waypointArray[waypointIndex].transform.position.x,
            waypointArray[waypointIndex].transform.position.y, 0);

    }

    public void uiText()
    {
        
    }
    
    
   


    // Update is called once per frame
    public void followWaypoints() // player movement
    {
        //Doubles();
        if (stopRolling == 1)
        {
            if (inJail == true)
            {
                Debug.Log("inJail");
                WaypointJail();
            }
            else
            {
              Debug.Log("movement");
              int IWantToDie = dice2.GetComponent<Dice>().value + dice1.GetComponent<Dice>().value; 
              //calculates dice value
              if (Doubles())//code for fixing doubles running doubles
              {
                  IWantToDie = IWantToDie / 2; 
                  // manually fixes an unknown issue. doubles would cause player to move twice what it was supposed to.
              }
                    for (int i = 0; i < IWantToDie; i++)
                    {
                        if (waypointIndex == 39) // when player hits the last waypoint this sends it back to waypoint zero.
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
                            Button.GetComponent<RollButton>().PlayerMoneyupdater();
                        }
        
                    }
            }
      

  
            //stopRolling = 2;
            WaypointLocation();
        }
        else
        {
            stopRolling = 1;
            
        }
    }

    public bool Doubles()
    {
        Debug.Log("Doubles");

        bool doubles;
        if (dice2.GetComponent<Dice>().value == dice1.GetComponent<Dice>().value)
        {
            if (doublesCounter < 12)
            {
                doublesCounter++;
                if (doublesCounter == 12)
                {
                    transform.position = new Vector3(jailWaypoint.transform.position.x,
                        jailWaypoint.transform.position.y, 0);
                    inJail = true;
                    Button.SetActive(false);
                    //Button.SetActive(false); 
                    doublesCounter = 0;
                    return false;
                }
                else
                {
                    Button.SetActive(true);
                    return true;
                }
            }
            else
            {
                doublesCounter = 0;
                return false;
            }
        }
        else
        {
            doublesCounter = 0;
            Button.SetActive(false);
            return false;
        }
    }
   
  
    void WaypointLocation()
    {
        Debug.Log("check location " + waypointIndex);
        properties.GetComponent<Properties>().Card.SetActive(false);
        OwnershipClass.GetComponent<Ownership>().stopItGetSomeHelp();
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
                transform.position = new Vector3(jailWaypoint.transform.position.x,
                    jailWaypoint.transform.position.y, 0);
                inJail = true;
                break;
            default://properties
                   properties.GetComponent<Properties>().findCard(); 
                   OwnershipClass.GetComponent<Ownership>().CheckOwnership();
                break;
        }
        
        
        
    }

    void WaypointJail()
    {
        if (jailCounter == 3)
        {
            if (dice1.GetComponent<Dice>().turn == 1)
            {
                GetComponent<Player>().wallet = GetComponent<Player>().wallet - 50;
            }
            else if (dice1.GetComponent<Dice>().turn == 2)
            {
                GetComponent<Player>().wallet = GetComponent<Player>().wallet - 50;

            }
            else if (dice1.GetComponent<Dice>().turn == 3)
            {
                GetComponent<Player>().wallet = GetComponent<Player>().wallet - 50;

            }

            jailCounter = 0;
            inJail = false;
            followWaypoints();
        }
        else
        {
            if (chanceGOOFJ == true && ccGOOFJ == true)
            {
                chanceGOOFJButton.SetActive(true);
            }
            else if (chanceGOOFJ == true)
            {
                chanceGOOFJButton.SetActive(true);

            }
            else if (ccGOOFJ == true)
            {
                ccGOOFJButton.SetActive(true);
            }
            else
            {
                ccGOOFJButton.SetActive(false);
                chanceGOOFJButton.SetActive(false);
            }
            bail.SetActive(true);
            jailCounter++;
        }
        
    }

    public void MovementFromJail()
    {
        inJail = false;
        ccGOOFJButton.SetActive(false);
        chanceGOOFJButton.SetActive(false);
        bail.SetActive(false);
        waypointIndex = 10;
        transform.position = new Vector3(waypointArray[waypointIndex].transform.position.x,
            waypointArray[waypointIndex].transform.position.y, 0);
    }
        
}

