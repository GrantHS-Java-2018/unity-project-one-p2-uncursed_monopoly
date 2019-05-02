using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RollButton : MonoBehaviour
{
    //public static Boolean rollButton = false;
    public Boolean rollButtonPress = false;
    public Boolean pressRoll = false;
    private int button;
    public Button m_YourFirstButton;
    public GameObject dice1, dice2;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    int doublesCounter = 0;
    public Button m_YourSecondButton;
    GameObject Button;
    public int totalDice;
    // Start is called before the first frame update
    void Start()
    {
        m_YourFirstButton.onClick.AddListener(TaskOnClick);
        m_YourSecondButton.onClick.AddListener(CheckOwnership);
       // button.onClick.AddListener(Dice, Dice2);
    }
    void TaskOnClick()
    {
        totalDice = 0;
        rollButtonPress = true;
        //Output this to console when Button1 or Button3 is clicked
        StartCoroutine(dice1.GetComponent<Dice>().Roll());
        StartCoroutine(dice2.GetComponent<Dice>().Roll());
        totalDice = dice1.GetComponent<Dice>().value + dice2.GetComponent<Dice>().value;
        //Debug.Log("You have clicked the button!");

    }

    void Buy()
    {
        if (dice1.GetComponent<Dice>().turn == 1)
        {
            
        }
        else if (dice1.GetComponent<Dice>().turn == 2)
        {
            
        }
        else if (dice1.GetComponent<Dice>().turn == 3)
        {
     
        }
        
    }

    void CheckOwnership()
    {
        if (dice1.GetComponent<Dice>().turn == 1)
        {
            if (Player2.GetComponent<Player>().ownership[Player1.GetComponent<Player>().waypointIndex] == true)
            {
                
            }
            else if (Player3.GetComponent<Player>().ownership[Player1.GetComponent<Player>().waypointIndex] == true)
            {
                
            }
            else if (Player1.GetComponent<Player>().ownership[Player1.GetComponent<Player>().waypointIndex] == true)
            {
               
            }
            else if (Player1.GetComponent<Player>().ownership[Player1.GetComponent<Player>().waypointIndex] == false && Player2.GetComponent<Player>().ownership[Player1.GetComponent<Player>().waypointIndex] == false && Player3.GetComponent<Player>().ownership[Player1.GetComponent<Player>().waypointIndex] == false)
            {
                Buy();
            }
        }
        else if (dice1.GetComponent<Dice>().turn == 2)
        {
            
        }
        else if (dice1.GetComponent<Dice>().turn == 3)
        {
     
        }
    }

    void Payrent()
    {
        
    }
    

    


    // Update is called once per frame
    void Update()
    {
        
    }
}
