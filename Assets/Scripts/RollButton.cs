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
    public Button getOutChance;
    public Button getOutCC;
    //public Button buyHousing;
    public Button mortgageing;
    public Button endTurn;
    public Button doNotBuyProperty;
    public Button payRent;
    public GameObject dice1, dice2;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    int doublesCounter = 0;
    public GameObject propertyClass;
    public GameObject Ownership;
    private bool BrownCollection = false;
    private bool LightBlueCollection = false;
    private bool PinkCollection = false;
    private bool OrangeCollection = false;
    private bool RedCollection = false;
    private bool YellowCollection = false;
    private bool GreenCollection = false;
    private bool DarkBlueCollection = false;
    
    GameObject Button;
    public int totalDice;
    // Start is called before the first frame update
    void Start()//checks when a button is pressed, and starts the code
    {
        
        rollButton.onClick.AddListener(TaskOnClick);
        buyProperties.onClick.AddListener(Buy);
        //postBail.onClick.AddListener(bail);
        //getOut.onClick.AddListener(GOOJF);
        //buyHousing.onClick.AddListener(housing);
        //mortgageing.onClick.AddListener(mortgage);
        endTurn.onClick.AddListener(endTurnStarter);
        getOutChance.onClick.AddListener(GOOJF);
        getOutCC.onClick.AddListener(GOOJF);
        postBail.onClick.AddListener(bail);
        doNotBuyProperty.onClick.AddListener(nothing);
        payRent.onClick.AddListener(Payrent);
        // button.onClick.AddListener(Dice, Dice2);
    }

    void nothing()
    {
        Ownership.GetComponent<Ownership>().stopItGetSomeHelp();
    }

    void endTurnStarter()
    {
        dice1.GetComponent<Dice>().endTurn();
        
        dice2.GetComponent<Dice>().turn = dice1.GetComponent<Dice>().turn;

    }
    
    void TaskOnClick()
    {
        
        totalDice = 0;
        
        rollButtonPress = true;
              
        StartCoroutine(dice1.GetComponent<Dice>().Roll());
        
        StartCoroutine(dice2.GetComponent<Dice>().Roll());
        
        totalDice = dice1.GetComponent<Dice>().value + dice2.GetComponent<Dice>().value;       

    }
    

    void Buy()//subtracts the property value from the player
    {
        int player = dice1.GetComponent<Dice>().turn;
        if (dice1.GetComponent<Dice>().turn == 1)
        {
            switch (Player1.GetComponent<Player>().waypointIndex)
            {
                
                case 1:
                    dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet = dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet - 60;
                    break;
                case 3:
                    dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet = dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet - 60;
                    break;
                case 6:
                    dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet = dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet - 100;
                    break;
                case 8:
                    dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet = dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet - 100;
                    break;
                case 9:
                    dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet = dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet - 120;
                    break;
                case 11:
                    dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet = dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet - 140;
                    break;
                case 13:
                    dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet = dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet - 140;
                    break;
                case 14:
                    dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet = dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet - 160;
                    break;
                case 16:
                    dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet = dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet - 160;
                    break;
                case 18:
                    dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet = dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet - 180;
                    break;
                case 19:
                    dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet = dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet - 200;
                    break;
                case 21:
                    dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet = dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet - 220;
                    break;
                case 23:
                    dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet = dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet - 220;
                    break;
                case 24:
                    dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet = dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet - 240;
                    break;
                case 26:
                    dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet = dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet - 260;
                    break;
                case 27:
                    dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet = dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet - 260;
                    break;
                case 29:
                    dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet = dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet - 280;
                    break;
                case 31:
                    dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet = dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet - 300;
                    break;
                case 32:
                    dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet = dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet - 300;
                    break;
                case 34:
                    dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet = dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet - 320;
                    break;
                case 37:
                    dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet = dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet - 350;
                    break;
                case 39:
                    dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet = dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().wallet - 400;
                    break;
            }
            
            switch (Player1.GetComponent<Player>().waypointIndex)
            {
                
                case 1: case 3:
                    Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 60;
                    break;
                case 6: case 8:
                    Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 100;
                    break;
                case 9:
                    Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 120;
                    break;
                case 11: case 13:
                    Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 140;
                    break;
                case 14:
                    Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 160;
                    break;
                case 18: case 16:
                    Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 180;
                    break;
                case 19:
                    Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 200;
                    break;
                case 23: case 21:
                    Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 220;
                    break;
                case 24:
                    Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 240;
                    break;
                case 27: case 26:
                    Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 260;
                    break;
                case 29:
                    Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 280;
                    break;
                case 32: case 31:
                    Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 300;
                    break;
                case 34:
                    Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 320;
                    break;
                case 37:
                    Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 350;
                    break;
                case 39:
                    Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 400;
                    break;
            }
        }
        else if (dice1.GetComponent<Dice>().turn == 2)
        {
            switch (Player2.GetComponent<Player>().waypointIndex)
            {
                case 1: case 3:
                    Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 60;
                    break;
                case 6: case 8:
                    Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 100;
                    break;
                case 9:
                    Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 120;
                    break;
                case 11: case 13:
                    Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 140;
                    break;
                case 14:
                    Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 160;
                    break;
                case 18: case 16:
                    Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 180;
                    break;
                case 19:
                    Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 200;
                    break;
                case 23: case 21:
                    Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 220;
                    break;
                case 24:
                    Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 240;
                    break;
                case 27: case 26:
                    Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 260;
                    break;
                case 29:
                    Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 280;
                    break;
                case 32: case 31:
                    Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 300;
                    break;
                case 34:
                    Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 320;
                    break;
                case 37:
                    Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 350;
                    break;
                case 39:
                    Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 400;
                    break;
            }
            
        }
        else if (dice1.GetComponent<Dice>().turn == 3)
        {
            switch (Player3.GetComponent<Player>().waypointIndex)
            {
                case 1: case 3:
                    Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 60;
                    break;
                case 6: case 8:
                    Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 100;
                    break;
                case 9:
                    Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 120;
                    break;
                case 11: case 13:
                    Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 140;
                    break;
                case 14:
                    Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 160;
                    break;
                case 18: case 16:
                    Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 180;
                    break;
                case 19:
                    Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 200;
                    break;
                case 23: case 21:
                    Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 220;
                    break;
                case 24:
                    Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 240;
                    break;
                case 27: case 26:
                    Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 260;
                    break;
                case 29:
                    Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 280;
                    break;
                case 32: case 31:
                    Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 300;
                    break;
                case 34:
                    Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 320;
                    break;
                case 37:
                    Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 350;
                    break;
                case 39:
                    Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 400;
                    break;
            }
        }

        Ownership.GetComponent<Ownership>().playerOwnership[propertyClass.GetComponent<Properties>().properyTracker] =
            dice1.GetComponent<Dice>().turn;
        Ownership.GetComponent<Ownership>().stopItGetSomeHelp();
        
        
    }

    void Payrent()//gives one player money, and subtracts it from another
    {
        if (dice1.GetComponent<Dice>().turn == 1)
        {

            if (Ownership.GetComponent<Ownership>()
                    .playerOwnership[propertyClass.GetComponent<Properties>().properyTracker] == 2)
            {
                switch (Player1.GetComponent<Player>().waypointIndex)
                    {
                    case 1:
                        if (BrownCollection == true)
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 4;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 4;
                        }
                        else
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 2;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 2;

                        }
                        break;
                    case 3:
                        if (BrownCollection == true)
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 8;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 8;
                        }
                        else
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 4;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 4;
                        }
                        break;
                    case 6:
                        if (LightBlueCollection == true)
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 12;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 12;
                        }
                        else
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 6;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 6;
                        }
                        break;
                    case 8:
                        if (LightBlueCollection == true)
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 12;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 12;
                        }
                        else
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 6;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 6;
                        }
                        break;
                    case 9:
                        if (LightBlueCollection == true)
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 16;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 16;
                        }
                        else
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 8;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 8;
                        }
                        break;
                    case 11:
                        if (PinkCollection == true)
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 20;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 20;
                        }
                        else
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 10;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 10;
                        }
                        break;
                    case 13:
                        if (PinkCollection == true)
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 20;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 20;
                        }
                        else
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 10;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 10;
                        }
                        break;
                    case 14:
                        if (PinkCollection == true)
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 24;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 24;
                        }
                        else
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 12;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 12;
                        }
                        break;
                    case 16:
                        if (OrangeCollection == true)
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 28;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 28;
                        }
                        else
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 14;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 14;
                        }
                        break;
                    case 18:
                        if (OrangeCollection == true)
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 28;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 28;
                        }
                        else
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 14;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 14;
                        }
                        break;
                    case 19:
                        if (OrangeCollection == true)
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 32;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 32;
                        }
                        else
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 16;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 16;
                        }
                        break;
                    case 21:
                        if (RedCollection == true)
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 36;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 36;
                        }
                        else
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 18;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 18;
                        }
                        break;
                    case 23:
                        if (RedCollection == true)
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 36;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 36;
                        }
                        else
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 18;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 18;
                        }
                        break;
                    case 24:
                        if (RedCollection == true)
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 40;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 40;
                        }
                        else
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 20;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 20;
                        }
                        break;
                    case 26:
                        if (YellowCollection == true)
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 44;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 44;
                        }
                        else
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 22;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 22;
                        }
                        break;
                    case 27:
                        if (YellowCollection == true)
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 44;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 44;
                        }
                        else
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 22;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 22;
                        }
                        break;
                    case 29:
                        if (YellowCollection == true)
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 44;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 44;
                        }
                        else
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 24;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 24;
                        }
                        break;
                    case 31:
                        if (GreenCollection == true)
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 52;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 52;
                        }
                        else
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 26;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 26;
                        }
                        break;
                    case 32:
                        if (GreenCollection == true)
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 52;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 52;
                        }
                        else
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 26;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 26;
                        }
                        break;
                    case 34:
                        if (GreenCollection == true)
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 56;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 56;
                        }
                        else
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 28;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 28;
                        }
                        break;
                    case 37:
                        if (DarkBlueCollection == true)
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 70;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 70;
                        }
                        else
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 35;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 35;
                        }
                        break;
                    case 39:
                        if (DarkBlueCollection == true)
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 100;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 100;
                        }
                        else
                        {
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 50;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 50;
                        }
                        break;
                    }
            }
            else
            {
                switch (Player1.GetComponent<Player>().waypointIndex)
                       {
                       case 1:
                           if (BrownCollection == true)
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 4;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 4;
                           }
                           else
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 2;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 2;
                
                           }
                           break;
                       case 3:
                           if (BrownCollection == true)
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 8;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 8;
                           }
                           else
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 4;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 4;
                           }
                           break;
                       case 6:
                           if (LightBlueCollection == true)
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 12;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 12;
                           }
                           else
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 6;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 6;
                           }
                           break;
                       case 8:
                           if (LightBlueCollection == true)
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 12;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 12;
                           }
                           else
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 6;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 6;
                           }
                           break;
                       case 9:
                           if (LightBlueCollection == true)
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 16;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 16;
                           }
                           else
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 8;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 8;
                           }
                           break;
                       case 11:
                           if (PinkCollection == true)
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 20;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 20;
                           }
                           else
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 10;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 10;
                           }
                           break;
                       case 13:
                           if (PinkCollection == true)
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 20;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 20;
                           }
                           else
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 10;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 10;
                           }
                           break;
                       case 14:
                           if (PinkCollection == true)
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 24;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 24;
                           }
                           else
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 12;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 12;
                           }
                           break;
                       case 16:
                           if (OrangeCollection == true)
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 28;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 28;
                           }
                           else
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 14;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 14;
                           }
                           break;
                       case 18:
                           if (OrangeCollection == true)
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 28;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 28;
                           }
                           else
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 14;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 14;
                           }
                           break;
                       case 19:
                           if (OrangeCollection == true)
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 32;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 32;
                           }
                           else
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 16;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 16;
                           }
                           break;
                       case 21:
                           if (RedCollection == true)
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 36;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 36;
                           }
                           else
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 18;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 18;
                           }
                           break;
                       case 23:
                           if (RedCollection == true)
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 36;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 36;
                           }
                           else
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 18;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 18;
                           }
                           break;
                       case 24:
                           if (RedCollection == true)
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 40;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 40;
                           }
                           else
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 20;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 20;
                           }
                           break;
                       case 26:
                           if (YellowCollection == true)
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 44;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 44;
                           }
                           else
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 22;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 22;
                           }
                           break;
                       case 27:
                           if (YellowCollection == true)
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 44;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 44;
                           }
                           else
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 22;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 22;
                           }
                           break;
                       case 29:
                           if (YellowCollection == true)
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 44;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 44;
                           }
                           else
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 24;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 24;
                           }
                           break;
                       case 31:
                           if (GreenCollection == true)
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 52;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 52;
                           }
                           else
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 26;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 26;
                           }
                           break;
                       case 32:
                           if (GreenCollection == true)
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 52;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 52;
                           }
                           else
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 26;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 26;
                           }
                           break;
                       case 34:
                           if (GreenCollection == true)
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 56;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 56;
                           }
                           else
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 28;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 28;
                           }
                           break;
                       case 37:
                           if (DarkBlueCollection == true)
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 70;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 70;
                           }
                           else
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 35;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 35;
                           }
                           break;
                       case 39:
                           if (DarkBlueCollection == true)
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 100;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 100;
                           }
                           else
                           {
                               Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 50;
                               Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 50;
                           }
                           break;
    
    
                    }
            }
        }
        else if (dice1.GetComponent<Dice>().turn == 2)
        {
            if (Ownership.GetComponent<Ownership>()
                    .playerOwnership[propertyClass.GetComponent<Properties>().properyTracker] == 1)
            {

                switch (Player2.GetComponent<Player>().waypointIndex)
                {
                    case 1:
                        if (BrownCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 4;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 4;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 2;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 2;

                        }

                        break;
                    case 3:
                        if (BrownCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 8;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 8;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 4;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 4;
                        }

                        break;
                    case 6:
                        if (LightBlueCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 12;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 12;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 6;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 6;
                        }

                        break;
                    case 8:
                        if (LightBlueCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 12;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 12;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 6;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 6;
                        }

                        break;
                    case 9:
                        if (LightBlueCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 16;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 16;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 8;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 8;
                        }

                        break;
                    case 11:
                        if (PinkCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 20;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 20;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 10;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 10;
                        }

                        break;
                    case 13:
                        if (PinkCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 20;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 20;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 10;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 10;
                        }

                        break;
                    case 14:
                        if (PinkCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 24;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 24;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 12;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 12;
                        }

                        break;
                    case 16:
                        if (OrangeCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 28;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 28;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 14;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 14;
                        }

                        break;
                    case 18:
                        if (OrangeCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 28;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 28;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 14;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 14;
                        }

                        break;
                    case 19:
                        if (OrangeCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 32;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 32;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 16;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 16;
                        }

                        break;
                    case 21:
                        if (RedCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 36;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 36;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 18;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 18;
                        }

                        break;
                    case 23:
                        if (RedCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 36;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 36;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 18;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 18;
                        }

                        break;
                    case 24:
                        if (RedCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 40;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 40;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 20;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 20;
                        }

                        break;
                    case 26:
                        if (YellowCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 44;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 44;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 22;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 22;
                        }

                        break;
                    case 27:
                        if (YellowCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 44;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 44;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 22;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 22;
                        }

                        break;
                    case 29:
                        if (YellowCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 44;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 44;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 24;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 24;
                        }

                        break;
                    case 31:
                        if (GreenCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 52;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 52;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 26;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 26;
                        }

                        break;
                    case 32:
                        if (GreenCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 52;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 52;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 26;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 26;
                        }

                        break;
                    case 34:
                        if (GreenCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 56;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 56;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 28;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 28;
                        }

                        break;
                    case 37:
                        if (DarkBlueCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 70;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 70;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 35;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 35;
                        }

                        break;
                    case 39:
                        if (DarkBlueCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 100;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 100;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 50;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 50;
                        }

                        break;
                }
            }
            else
            {
                switch (Player2.GetComponent<Player>().waypointIndex)
                {
                    case 1:
                        if (BrownCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 4;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 4;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 2;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 2;

                        }

                        break;
                    case 3:
                        if (BrownCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 8;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 8;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 4;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 4;
                        }

                        break;
                    case 6:
                        if (LightBlueCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 12;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 12;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 6;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 6;
                        }

                        break;
                    case 8:
                        if (LightBlueCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 12;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 12;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 6;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 6;
                        }

                        break;
                    case 9:
                        if (LightBlueCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 16;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 16;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 8;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 8;
                        }

                        break;
                    case 11:
                        if (PinkCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 20;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 20;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 10;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 10;
                        }

                        break;
                    case 13:
                        if (PinkCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 20;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 20;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 10;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 10;
                        }

                        break;
                    case 14:
                        if (PinkCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 24;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 24;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 12;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 12;
                        }

                        break;
                    case 16:
                        if (OrangeCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 28;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 28;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 14;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 14;
                        }

                        break;
                    case 18:
                        if (OrangeCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 28;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 28;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 14;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 14;
                        }

                        break;
                    case 19:
                        if (OrangeCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 32;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 32;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 16;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 16;
                        }

                        break;
                    case 21:
                        if (RedCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 36;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 36;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 18;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 18;
                        }

                        break;
                    case 23:
                        if (RedCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 36;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 36;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 18;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 18;
                        }

                        break;
                    case 24:
                        if (RedCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 40;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 40;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 20;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 20;
                        }

                        break;
                    case 26:
                        if (YellowCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 44;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 44;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 22;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 22;
                        }

                        break;
                    case 27:
                        if (YellowCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 44;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 44;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 22;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 22;
                        }

                        break;
                    case 29:
                        if (YellowCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 44;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 44;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 24;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 24;
                        }

                        break;
                    case 31:
                        if (GreenCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 52;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 52;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 26;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 26;
                        }

                        break;
                    case 32:
                        if (GreenCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 52;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 52;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 26;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 26;
                        }

                        break;
                    case 34:
                        if (GreenCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 56;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 56;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 28;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 28;
                        }

                        break;
                    case 37:
                        if (DarkBlueCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 70;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 70;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 35;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 35;
                        }

                        break;
                    case 39:
                        if (DarkBlueCollection == true)
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 100;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 100;
                        }
                        else
                        {
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 50;
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet + 50;
                        }

                        break;



                }
            }
           
            







        }else if (dice1.GetComponent<Dice>().turn == 3)
        {
            if (Ownership.GetComponent<Ownership>()
                    .playerOwnership[propertyClass.GetComponent<Properties>().properyTracker] == 1)
            {

                switch (Player3.GetComponent<Player>().waypointIndex)
                {
                    case 1:
                        if (BrownCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 4;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 4;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 2;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 2;

                        }

                        break;
                    case 3:
                        if (BrownCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 8;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 8;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 4;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 4;
                        }

                        break;
                    case 6:
                        if (LightBlueCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 12;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 12;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 6;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 6;
                        }

                        break;
                    case 8:
                        if (LightBlueCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 12;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 12;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 6;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 6;
                        }

                        break;
                    case 9:
                        if (LightBlueCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 16;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 16;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 8;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 8;
                        }

                        break;
                    case 11:
                        if (PinkCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 20;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 20;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 10;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 10;
                        }

                        break;
                    case 13:
                        if (PinkCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 20;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 20;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 10;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 10;
                        }

                        break;
                    case 14:
                        if (PinkCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 24;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 24;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 12;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 12;
                        }

                        break;
                    case 16:
                        if (OrangeCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 28;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 28;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 14;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 14;
                        }

                        break;
                    case 18:
                        if (OrangeCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 28;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 28;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 14;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 14;
                        }

                        break;
                    case 19:
                        if (OrangeCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 32;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 32;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 16;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 16;
                        }

                        break;
                    case 21:
                        if (RedCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 36;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 36;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 18;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 18;
                        }

                        break;
                    case 23:
                        if (RedCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 36;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 36;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 18;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 18;
                        }

                        break;
                    case 24:
                        if (RedCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 40;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 40;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 20;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 20;
                        }

                        break;
                    case 26:
                        if (YellowCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 44;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 44;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 22;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 22;
                        }

                        break;
                    case 27:
                        if (YellowCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 44;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 44;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 22;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 22;
                        }

                        break;
                    case 29:
                        if (YellowCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 44;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 44;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 24;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 24;
                        }

                        break;
                    case 31:
                        if (GreenCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 52;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 52;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 26;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 26;
                        }

                        break;
                    case 32:
                        if (GreenCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 52;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 52;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 26;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 26;
                        }

                        break;
                    case 34:
                        if (GreenCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 56;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 56;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 28;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 28;
                        }

                        break;
                    case 37:
                        if (DarkBlueCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 70;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 70;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 35;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 35;
                        }

                        break;
                    case 39:
                        if (DarkBlueCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 100;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 100;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 50;
                            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet + 50;
                        }

                        break;
                }
            }
            else
            {
                switch (Player3.GetComponent<Player>().waypointIndex)
                {
                    case 1:
                        if (BrownCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 4;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 4;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 2;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 2;

                        }

                        break;
                    case 3:
                        if (BrownCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 8;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 8;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 4;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 4;
                        }

                        break;
                    case 6:
                        if (LightBlueCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 12;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 12;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 6;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 6;
                        }

                        break;
                    case 8:
                        if (LightBlueCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 12;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 12;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 6;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 6;
                        }

                        break;
                    case 9:
                        if (LightBlueCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 16;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 16;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 8;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 8;
                        }

                        break;
                    case 11:
                        if (PinkCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 20;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 20;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 10;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 10;
                        }

                        break;
                    case 13:
                        if (PinkCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 20;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 20;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 10;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 10;
                        }

                        break;
                    case 14:
                        if (PinkCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 24;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 24;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 12;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 12;
                        }

                        break;
                    case 16:
                        if (OrangeCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 28;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 28;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 14;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 14;
                        }

                        break;
                    case 18:
                        if (OrangeCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 28;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 28;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 14;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 14;
                        }

                        break;
                    case 19:
                        if (OrangeCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 32;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 32;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 16;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 16;
                        }

                        break;
                    case 21:
                        if (RedCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 36;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 36;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 18;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 18;
                        }

                        break;
                    case 23:
                        if (RedCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 36;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 36;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 18;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 18;
                        }

                        break;
                    case 24:
                        if (RedCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 40;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 40;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 20;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 20;
                        }

                        break;
                    case 26:
                        if (YellowCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 44;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 44;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 22;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 22;
                        }

                        break;
                    case 27:
                        if (YellowCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 44;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 44;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 22;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 22;
                        }

                        break;
                    case 29:
                        if (YellowCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 44;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 44;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 24;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 24;
                        }

                        break;
                    case 31:
                        if (GreenCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 52;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 52;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 26;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 26;
                        }

                        break;
                    case 32:
                        if (GreenCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 52;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 52;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 26;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 26;
                        }

                        break;
                    case 34:
                        if (GreenCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 56;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 56;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 28;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 28;
                        }

                        break;
                    case 37:
                        if (DarkBlueCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 70;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 70;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 35;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 35;
                        }

                        break;
                    case 39:
                        if (DarkBlueCollection == true)
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 100;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 100;
                        }
                        else
                        {
                            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 50;
                            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet + 50;
                        }

                        break;
                }
            }
        }




        Ownership.GetComponent<Ownership>().stopItGetSomeHelp();
    }

    void bail()//subtracts 50 to get out of jail
    {
        
        if (dice1.GetComponent<Dice>().turn == 1)
        {
            Player1.GetComponent<Player>().wallet = Player1.GetComponent<Player>().wallet - 50;
            Player1.GetComponent<Player>().MovementFromJail();
        }
        else if (dice1.GetComponent<Dice>().turn == 2)
        {
            Player2.GetComponent<Player>().wallet = Player2.GetComponent<Player>().wallet - 50;
            Player2.GetComponent<Player>().MovementFromJail();

        }
        else if (dice1.GetComponent<Dice>().turn == 3)
        {
            Player3.GetComponent<Player>().wallet = Player3.GetComponent<Player>().wallet - 50;
            Player3.GetComponent<Player>().MovementFromJail();


        }
        
    }
    

    void GOOJF() // uses chance/community chest card to get out of jail
    {
        if (dice1.GetComponent<Dice>().turn == 1)
        {
            if (Player1.GetComponent<Player>().ccGOOFJ == true)
            {
                Player1.GetComponent<Player>().inJail = false;
                Player1.GetComponent<Player>().ccGOOFJ = false;
            }
            else if (Player1.GetComponent<Player>().chanceGOOFJ == true)
            {
                Player1.GetComponent<Player>().inJail = false;
                Player1.GetComponent<Player>().chanceGOOFJ = false;
            }
            Player1.GetComponent<Player>().MovementFromJail();

        }
        else if (dice1.GetComponent<Dice>().turn == 2)
        {
            if (Player2.GetComponent<Player>().ccGOOFJ == true)
            {
                Player2.GetComponent<Player>().inJail = false;
                Player2.GetComponent<Player>().ccGOOFJ = false;
            }
            else if (Player2.GetComponent<Player>().chanceGOOFJ == true)
            {
                Player2.GetComponent<Player>().inJail = false;
                Player2.GetComponent<Player>().chanceGOOFJ = false;
            }
            Player2.GetComponent<Player>().MovementFromJail();

            
        }
        else if (dice1.GetComponent<Dice>().turn == 3)
        {
            if (Player3.GetComponent<Player>().ccGOOFJ == true)
            {
                Player3.GetComponent<Player>().inJail = false;
                Player3.GetComponent<Player>().ccGOOFJ = false;
            }
            else if (Player3.GetComponent<Player>().chanceGOOFJ == true)
            {
                Player3.GetComponent<Player>().inJail = false;
                Player3.GetComponent<Player>().chanceGOOFJ = false;
            }
            Player3.GetComponent<Player>().MovementFromJail();

     
        }
        
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
