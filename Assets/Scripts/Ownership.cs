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

    public int[] playerOwnership;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckOwnership(int player)
    {
        if (dice1.GetComponent<Dice>().playerList[player - 1].GetComponent<Player>().waypointIndex == playerOwnership[Property.GetComponent<Properties>().properyTracker])
        {
            
        }

        if (playerOwnership[Property.GetComponent<Properties>().properyTracker] == 0)
        {
            buyButton.SetActive(true);
            doNotBuyButton.SetActive(true);
        }
        else if (playerOwnership[Property.GetComponent<Properties>().properyTracker] == dice1.GetComponent<Dice>().turn)
        {
            
        }
        else
        {
            
        }
        
    }

}
