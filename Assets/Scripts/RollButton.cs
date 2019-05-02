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
    public Button rollButton;
    public Button buyProperties;
    public Button postBail;
    public Button getOut;
    public Button buyHousing;
    public Button mortgageing;
    public Button endTurn;
    public GameObject dice1, dice2;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    int doublesCounter = 0;
   
    GameObject Button;
    public int totalDice;
    // Start is called before the first frame update
    void Start()
    {
        rollButton.onClick.AddListener(TaskOnClick);
        buyProperties.onClick.AddListener(Buy);
        postBail.onClick.AddListener(bail);
        getOut.onClick.AddListener(GOOJF);
        buyHousing.onClick.AddListener(housing);
        mortgageing.onClick.AddListener(mortgage);
        endTurn.onClick.AddListener(end);
        
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

    void bail()
    {
        
    }

    void GOOJF()
    {
        
    }

    void housing()
    {
        
    }

    void mortgage()
    {
        
    }

    void end()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
