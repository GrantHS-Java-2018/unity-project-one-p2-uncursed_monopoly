﻿using System;
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
        m_YourSecondButton.onClick.AddListener(Buy);
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
        
        
    }

    


    // Update is called once per frame
    void Update()
    {
        
    }
}
