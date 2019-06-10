using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ownership : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject dice1, dice2;
    public GameObject Property;
    public GameObject buyButton;
    public GameObject doNotBuyButton;
    public GameObject PayButton;
    public GameObject endTurnButton;
    public int[] playerOwnership;//array that holds information about who owns what property
    // Start is called before the first frame update
    void Start()//hides the buttons and sets up the ownership array
    {
        buyButton.SetActive(false);
        doNotBuyButton.SetActive(false);
        PayButton.SetActive(false);
        playerOwnership = new int [22];
    }

    // Update is called once per frame
    public void CheckOwnership()//checks who owns what
    {
        stopItGetSomeHelp();
        
        if (playerOwnership[Property.GetComponent<Properties>().properyTracker] == 0)//if unowned, than allows you to buy it
        {
            buyButton.SetActive(true);
            doNotBuyButton.SetActive(true);
            endTurnButton.SetActive(false);
        }
        else if (playerOwnership[Property.GetComponent<Properties>().properyTracker] == dice1.GetComponent<Dice>().turn)
        {
            endTurnButton.SetActive(true);
        }
        else
        {
            PayButton.SetActive(true);
            endTurnButton.SetActive(false);
        }
        
        
    }

    public void stopItGetSomeHelp()
    {
        buyButton.SetActive(false);
        doNotBuyButton.SetActive(false);
        PayButton.SetActive(false);
        endTurnButton.SetActive(true);
    }
    

}
