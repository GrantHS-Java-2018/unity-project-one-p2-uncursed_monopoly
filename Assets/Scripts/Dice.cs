using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.NetworkSystem;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Dice : MonoBehaviour
{   
    [SerializeField]private Sprite[] dieFace;
    //[SerializeField] private Button button;
    public int value;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public int turn = 1;
    public GameObject Button;   
    public GameObject bail;
    public GameObject ccGOOFJ;//community chest get out of jail free
    public GameObject chanceGOOFJ;//chance get out of jail free
    public GameObject endTurnButton;
    public List<GameObject> playerList;
    // Start is called before the first frame update
    public GameObject buyButton;
    public GameObject doNotBuyButton;
    public GameObject PayButton;
 
    void Start()
    {
        playerList = new List<GameObject>{Player1, Player2, Player3};//creates the list
    }
    public IEnumerator Roll()//rolling method
    {
        for (int i = 0; i < 10; i++)//randomizes the dice faces and stops imitating a role
        {
            int num = Random.Range(0,6) + 1;
            
            GetComponent<SpriteRenderer>().sprite = dieFace[num - 1];
            
            value = num;
            
            yield return new WaitForSeconds(.10f);
            
        }
     
        MovePlayer(turn);//starts to move the player
    }

    private void MovePlayer(int player)
    {
        Debug.Log("turn 3 roll");        
        Debug.Log("turn 3 roll end");
        
        if (playerList[player - 1].GetComponent<Player>().Doubles()) //if there are doubles, than allows you to roll again
        {
            Button.SetActive(true);
            
            Debug.Log("doubles are present");

            if (playerList[player - 1].GetComponent<Player>().inJail == true)//if in jail than you get out of jail
            {
                playerList[player - 1].GetComponent<Player>().inJail = false;
                
                //turn = 1;
                
                Button.SetActive(false);
            }

            playerList[player - 1].GetComponent<Player>().stopRolling = 1;
            
        }
        else//moves the player normally and allows you to end the turn
        {
            Debug.Log("no Doubles");
            
            //turn = 1;
            
            playerList[player - 1].GetComponent<Player>().doublesCounter = 0;
            
            Button.SetActive(false);
            
            endTurnButton.SetActive(true);
            
        }
        playerList[player - 1].GetComponent<Player>().followWaypoints();

    }
    
    public void endTurn()//if the end turn button is pressed, than the next player goes and the buttons reset
    {
        Debug.Log("endturnActivated");                       
        
        Button.SetActive(true);
        
        if (turn == 1)
        {
            Player1.GetComponent<Player>().stopRolling = 1;
            
            turn++;
            
            if (turn == 2 && Player2.GetComponent<Player>().inJail == true)
                {
                    ccGOOFJ.SetActive(true);
                    
                    chanceGOOFJ.SetActive(true);
                    
                    bail.SetActive(true);
                }            
        }
        
        else if (turn == 2)
           
        {
            Player2.GetComponent<Player>().stopRolling = 1;
            
            turn++;
            
              if (turn == 3 && Player3.GetComponent<Player>().inJail == true)
                {
                    ccGOOFJ.SetActive(true);
                    
                    chanceGOOFJ.SetActive(true);
                    
                    bail.SetActive(true);
                }
        }
        else if (turn == 3)
        {
            Debug.Log("turn 1 switched");
            
            Player3.GetComponent<Player>().stopRolling = 1;
            
            turn = 1;
            
            if (turn == 1 && Player1.GetComponent<Player>().inJail == true)
            {
                ccGOOFJ.SetActive(true);
                
                chanceGOOFJ.SetActive(true);
                
                bail.SetActive(true);
            }
        }
    
        Debug.Log("endturnEnded");
        
        endTurnButton.SetActive(false);
        buyButton.SetActive(false);
        doNotBuyButton.SetActive(false);
        PayButton.SetActive(false);
   
        
    }

}
