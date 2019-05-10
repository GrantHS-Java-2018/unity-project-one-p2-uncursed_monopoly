using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
    // Start is called before the first frame update
    void Awake ()
    {

    }
    void Start()
    {
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
        if (turn == 1)
        {
            Player1.GetComponent<Player>().followWaypoints();
            Debug.Log("turn 1 roll");
            //Player1.GetComponent<Player>().Doubles();
            Debug.Log("turn 1 roll end");
            if (Player1.GetComponent<Player>().Doubles())
            {
                if (Player1.GetComponent<Player>().inJail == true)
                {
                    Player1.GetComponent<Player>().inJail = false;
                    //turn++;
                    Button.SetActive(false);
                }
            }
            else
            {
                //turn++;
                Player1.GetComponent<Player>().doublesCounter = 0;
                Button.SetActive(false);
            }
            


        }
        else if (turn == 2)
        {
            Player2.GetComponent<Player>().followWaypoints();
            Debug.Log("turn 2 roll");
            //Player2.GetComponent<Player>().Doubles();
            Debug.Log("turn 2 roll end");
            if (Player2.GetComponent<Player>().Doubles())
            {
                if (Player2.GetComponent<Player>().inJail == true)
                {
                    Player2.GetComponent<Player>().inJail = false;
                    //turn++;
                    Button.SetActive(false);
                }
            }
            else
            {
                //turn++;
                Player2.GetComponent<Player>().doublesCounter = 0;
                Button.SetActive(false);
            }
           
        }
        else if (turn == 3)
        {
            Player3.GetComponent<Player>().followWaypoints();
            Debug.Log("turn 3 roll");
            //Player3.GetComponent<Player>().Doubles();
            Debug.Log("turn 3 roll end");
            if (Player3.GetComponent<Player>().Doubles())
            {
                if (Player3.GetComponent<Player>().inJail == true)
                {
                    Player3.GetComponent<Player>().inJail = false;
                    //turn = 1;
                    Button.SetActive(false);
                }
            }
            else
            {
                //turn = 1;
                Player3.GetComponent<Player>().doublesCounter = 0;
                Button.SetActive(false);
            }
           
        }
        //Button.SetActive(true);

        
    }

    public void endTurn()
    {
        Button.SetActive(true);
        if (turn == 1)
        {
            turn++;
            
        }
        else if (turn == 2)
        {
            turn++;
        }
        else if (turn == 3)
        {
            turn = 1;
        }
        
        if (turn == 1 && Player1.GetComponent<Player>().inJail == true)
        {
            ccGOOFJ.SetActive(true);
            chanceGOOFJ.SetActive(true);
            bail.SetActive(true);
        }
        else if (turn == 2 && Player2.GetComponent<Player>().inJail == true)
        {
            ccGOOFJ.SetActive(true);
            chanceGOOFJ.SetActive(true);
            bail.SetActive(true);
        }
        else if (turn == 3 && Player3.GetComponent<Player>().inJail == true)
        {
            ccGOOFJ.SetActive(true);
            chanceGOOFJ.SetActive(true);
            bail.SetActive(true);
        }
        
        
    }
}
