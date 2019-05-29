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
    public GameObject[] waypointArray;
    private Waypoint currentWaypoint;
    public GameObject jailWaypoint;
    private int currentLocation = 0;
    public int waypointIndex;
    public int stopRolling = 1;
    public int wallet = 1500;
    public int doublesCounter = 0;
    //public String ownership;
    public bool [] ownership;
    public GameObject[] propertArray;
    public GameObject properties;

    public GameObject chanceGOOFJButton;
    public GameObject ccGOOFJButton;
    public GameObject bail;
    public GameObject walletText;

    // placeholders / future //

    //public String[] chance = new String[]{"Ilinois", "Boardwalk", "Go", "GOOJF", "Back 3", "Marxism", "$50 1", "$50 2", "property tax", "gain $150", "St. Charles", "pay $15", "Go2Jail"};
   // public String[] chest = new String[]{"get 25", "lose 50", "get 10", "GOOJF", "get 20", "get 100", "capitlism", "get 200", "property tax", "Go", "loose 100", "pay $150", "Go2Jail", "get 45", "get 100"};

    
    public String tileType;
    public int rentvalue;
    public bool inJail = false;
    public int jailCounter = 0;
    public bool chanceGOOFJ = false;
    public bool ccGOOFJ = false;
   
    
  



    void payrent()
    {
        wallet = wallet - rentvalue;

    }

    void Start()
    {
        chanceGOOFJButton.SetActive(false);
        ccGOOFJButton.SetActive(false);
        bail.SetActive(false);
        
        uiText();
       

        transform.position = new Vector3(waypointArray[waypointIndex].transform.position.x,
            waypointArray[waypointIndex].transform.position.y, 0);

    }
    //ownerCheck(); // placeholder//

    public void uiText()
    {
        
        walletText.GetComponent<TextMeshProUGUI>().text = "player money" + stopRolling.ToString();
    }
    
   


    // Update is called once per frame
    public void followWaypoints()
    {
        //Doubles();
        if (stopRolling == 1)
        {
            if (inJail == true)
            {
                Debug.Log("inJail");
                WaypointJail();
                /*
                chanceGOOFJButton.SetActive(false);
                ccGOOFJButton.SetActive(false);
                bail.SetActive(false);
                */
            }
            else
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
            }
      

  
            stopRolling = 2;
            WaypointLocation();
            /*
           if (GetComponent<Dice>().turn == 1 || GetComponent<Dice>().turn == 2)
            {
                GetComponent<Dice>().turn++;
            }
            */
            //Button.SetActive(true);
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
                        jailWaypoint.transform.position.y, 0);
                    inJail = true;
                    Button.SetActive(false);
                    //Button.SetActive(false); 
                    doublesCounter = 0;
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
            doublesCounter = 0;
            Button.SetActive(false);
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
                transform.position = new Vector3(jailWaypoint.transform.position.x,
                    jailWaypoint.transform.position.y, 0);
                inJail = true;
                break;
            default://properties
                   properties.GetComponent<Properties>().findCard(); 
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
        //followWaypoints();
    }

    public void communityChance()
    {
        
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

