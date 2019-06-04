using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEditorInternal;
using UnityEngine;

public class Properties : MonoBehaviour
{
    public GameObject Card;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject dice1, dice2;
    [SerializeField]public Sprite[] properyCards;
    public GameObject mortgage;

    public int properyTracker;

    void Start()
    {
        mortgage.SetActive(false);
    }
    // Start is called before the first frame update

    public void findCard()
    {
        Debug.Log("findCard");
        Card.SetActive (true);
        if (dice1.GetComponent<Dice>().turn == 1)
        {
           switch (Player1.GetComponent<Player>().waypointIndex)
        {
            case 1:
                GetComponent<SpriteRenderer>().sprite = properyCards[0];
                properyTracker = 0;
                break;
            case 3:
                GetComponent<SpriteRenderer>().sprite = properyCards[1];
                properyTracker = 1;
                break;
            case 6:
                GetComponent<SpriteRenderer>().sprite = properyCards[2];
                properyTracker = 2;
                break;
            case 8:
                GetComponent<SpriteRenderer>().sprite = properyCards[3];
                properyTracker = 3;
                break;
            case 9:
                GetComponent<SpriteRenderer>().sprite = properyCards[4];
                properyTracker = 4;
                break;
            case 11:
                GetComponent<SpriteRenderer>().sprite = properyCards[5];
                properyTracker = 5;
                break;
            case 13:
                GetComponent<SpriteRenderer>().sprite = properyCards[6];
                properyTracker = 6;
                break;
            case 14:
                GetComponent<SpriteRenderer>().sprite = properyCards[7];
                properyTracker = 7;
                break;
            case 16:
                GetComponent<SpriteRenderer>().sprite = properyCards[8];
                properyTracker = 8;
                break;
            case 18:
                GetComponent<SpriteRenderer>().sprite = properyCards[9];
                properyTracker = 9;
                break;
            case 19:
                GetComponent<SpriteRenderer>().sprite = properyCards[10];
                properyTracker = 10;
                break;
            case 21:
                GetComponent<SpriteRenderer>().sprite = properyCards[11];
                properyTracker = 11;
                break;
            case 23:
                GetComponent<SpriteRenderer>().sprite = properyCards[12];
                properyTracker = 12;
                break;
            case 24:
                GetComponent<SpriteRenderer>().sprite = properyCards[13];
                properyTracker = 13;
                break;
            case 26:
                GetComponent<SpriteRenderer>().sprite = properyCards[14];
                properyTracker = 14;
                break;
            case 27:
                GetComponent<SpriteRenderer>().sprite = properyCards[15];
                properyTracker = 15;
                break;
            case 29:
                GetComponent<SpriteRenderer>().sprite = properyCards[16];
                properyTracker = 16;
                break;
            case 31:
                GetComponent<SpriteRenderer>().sprite = properyCards[17];
                properyTracker = 17;
                break;
            case 32:
                GetComponent<SpriteRenderer>().sprite = properyCards[18];
                properyTracker = 18;
                break;
            case 34:
                GetComponent<SpriteRenderer>().sprite = properyCards[19];
                properyTracker = 19;
                break;
            case 37:
                GetComponent<SpriteRenderer>().sprite = properyCards[20];
                properyTracker = 20;
                break;
            case 39:
                GetComponent<SpriteRenderer>().sprite = properyCards[21];
                properyTracker = 21;
                break;
        } 
        }
        
        else if(dice1.GetComponent<Dice>().turn == 2){
            switch (Player2.GetComponent<Player>().waypointIndex)
            {
                case 1:
                    GetComponent<SpriteRenderer>().sprite = properyCards[0];
                    properyTracker = 0;
                    break;
                case 3:
                    GetComponent<SpriteRenderer>().sprite = properyCards[1];
                    properyTracker = 1;
                    break;
                case 6:
                    GetComponent<SpriteRenderer>().sprite = properyCards[2];
                    properyTracker = 2;
                    break;
                case 8:
                    GetComponent<SpriteRenderer>().sprite = properyCards[3];
                    properyTracker = 3;
                    break;
                case 9:
                    GetComponent<SpriteRenderer>().sprite = properyCards[4];
                    properyTracker = 4;
                    break;
                case 11:
                    GetComponent<SpriteRenderer>().sprite = properyCards[5];
                    properyTracker = 5;
                    break;
                case 13:
                    GetComponent<SpriteRenderer>().sprite = properyCards[6];
                    properyTracker = 6;
                    break;
                case 14:
                    GetComponent<SpriteRenderer>().sprite = properyCards[7];
                    properyTracker = 7;
                    break;
                case 16:
                    GetComponent<SpriteRenderer>().sprite = properyCards[8];
                    properyTracker = 8;
                    break;
                case 18:
                    GetComponent<SpriteRenderer>().sprite = properyCards[9];
                    properyTracker = 9;
                    break;
                case 19:
                    GetComponent<SpriteRenderer>().sprite = properyCards[10];
                    properyTracker = 10;
                    break;
                case 21:
                    GetComponent<SpriteRenderer>().sprite = properyCards[11];
                    properyTracker = 11;
                    break;
                case 23:
                    GetComponent<SpriteRenderer>().sprite = properyCards[12];
                    properyTracker = 12;
                    break;
                case 24:
                    GetComponent<SpriteRenderer>().sprite = properyCards[13];
                    properyTracker = 13;
                    break;
                case 26:
                    GetComponent<SpriteRenderer>().sprite = properyCards[14];
                    properyTracker = 14;
                    break;
                case 27:
                    GetComponent<SpriteRenderer>().sprite = properyCards[15];
                    properyTracker = 15;
                    break;
                case 29:
                    GetComponent<SpriteRenderer>().sprite = properyCards[16];
                    properyTracker = 16;
                    break;
                case 31:
                    GetComponent<SpriteRenderer>().sprite = properyCards[17];
                    properyTracker = 17;
                    break;
                case 32:
                    GetComponent<SpriteRenderer>().sprite = properyCards[18];
                    properyTracker = 18;
                    break;
                case 34:
                    GetComponent<SpriteRenderer>().sprite = properyCards[19];
                    properyTracker = 19;
                    break;
                case 37:
                    GetComponent<SpriteRenderer>().sprite = properyCards[20];
                    properyTracker = 20;
                    break;
                case 39:
                    GetComponent<SpriteRenderer>().sprite = properyCards[21];
                    properyTracker = 21;
                    break;
            }
        }
        
        else if (dice1.GetComponent<Dice>().turn == 3)
        {
            switch (Player3.GetComponent<Player>().waypointIndex)
            {
                case 1:
                    GetComponent<SpriteRenderer>().sprite = properyCards[0];
                    properyTracker = 0;
                    break;
                case 3:
                    GetComponent<SpriteRenderer>().sprite = properyCards[1];
                    properyTracker = 1;
                    break;
                case 6:
                    GetComponent<SpriteRenderer>().sprite = properyCards[2];
                    properyTracker = 2;
                    break;
                case 8:
                    GetComponent<SpriteRenderer>().sprite = properyCards[3];
                    properyTracker = 3;
                    break;
                case 9:
                    GetComponent<SpriteRenderer>().sprite = properyCards[4];
                    properyTracker = 4;
                    break;
                case 11:
                    GetComponent<SpriteRenderer>().sprite = properyCards[5];
                    properyTracker = 5;
                    break;
                case 13:
                    GetComponent<SpriteRenderer>().sprite = properyCards[6];
                    properyTracker = 6;
                    break;
                case 14:
                    GetComponent<SpriteRenderer>().sprite = properyCards[7];
                    properyTracker = 7;
                    break;
                case 16:
                    GetComponent<SpriteRenderer>().sprite = properyCards[8];
                    properyTracker = 8;
                    break;
                case 18:
                    GetComponent<SpriteRenderer>().sprite = properyCards[9];
                    properyTracker = 9;
                    break;
                case 19:
                    GetComponent<SpriteRenderer>().sprite = properyCards[10];
                    properyTracker = 10;
                    break;
                case 21:
                    GetComponent<SpriteRenderer>().sprite = properyCards[11];
                    properyTracker = 11;
                    break;
                case 23:
                    GetComponent<SpriteRenderer>().sprite = properyCards[12];
                    properyTracker = 12;
                    break;
                case 24:
                    GetComponent<SpriteRenderer>().sprite = properyCards[13];
                    properyTracker = 13;
                    break;
                case 26:
                    GetComponent<SpriteRenderer>().sprite = properyCards[14];
                    properyTracker = 14;
                    break;
                case 27:
                    GetComponent<SpriteRenderer>().sprite = properyCards[15];
                    properyTracker = 15;
                    break;
                case 29:
                    GetComponent<SpriteRenderer>().sprite = properyCards[16];
                    properyTracker = 16;
                    break;
                case 31:
                    GetComponent<SpriteRenderer>().sprite = properyCards[17];
                    properyTracker = 17;
                    break;
                case 32:
                    GetComponent<SpriteRenderer>().sprite = properyCards[18];
                    properyTracker = 18;
                    break;
                case 34:
                    GetComponent<SpriteRenderer>().sprite = properyCards[19];
                    properyTracker = 19;
                    break;
                case 37:
                    GetComponent<SpriteRenderer>().sprite = properyCards[20];
                    properyTracker = 20;
                    break;
                case 39:
                    GetComponent<SpriteRenderer>().sprite = properyCards[21];
                    properyTracker = 21;
                    break;
            }
        }
        
    } 
}
