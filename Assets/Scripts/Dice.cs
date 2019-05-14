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

    public GameObject ccGOOFJ;
    public GameObject chanceGOOFJ;
    public GameObject endTurnButton;
    public List<GameObject> playerList;
    // Start is called before the first frame update
    void Awake ()
    {

    }
    void Start()
    {
        playerList = new List<GameObject>{Player1, Player2, Player3};
    }

    // Update is called once per frame
    void Update()
    {
       // if (rollButtonPress == true)
      //  {
            //StartCoroutine(Roll());
       // }
    }


    public IEnumerator Roll()
    {
        for (int i = 0; i < 20; i++)
        {
            int num = Random.Range(0, 6) + 1;
            GetComponent<SpriteRenderer>().sprite = dieFace[num - 1];
            value = num;
            yield return new WaitForSeconds(.15f);
        }
        
        //StartCoroutine(Player1.GetComponent<Player>().followWaypoints());
     
        MovePlayer(turn);
        //Button.SetActive(true);

        
    }

    private void MovePlayer(int player)
    {
        playerList[player - 1].GetComponent<Player>().followWaypoints();
        Debug.Log("turn 3 roll");
        //Player3.GetComponent<Player>().Doubles();
        Debug.Log("turn 3 roll end");
        if (playerList[player - 1].GetComponent<Player>().Doubles())
        {
            Debug.Log("doubles are present");

            if (playerList[player - 1].GetComponent<Player>().inJail == true)
            {
                playerList[player - 1].GetComponent<Player>().inJail = false;
                //turn = 1;
                Button.SetActive(false);
            }
        }
        else
        {
            Debug.Log("no Doubles");
            //turn = 1;
            playerList[player - 1].GetComponent<Player>().doublesCounter = 0;
            Button.SetActive(false);
            endTurnButton.SetActive(true);
            
        }
    }

    private void IncrimentTurn()
    {
        
    }

    public void endTurn()
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
   
        
    }
}
