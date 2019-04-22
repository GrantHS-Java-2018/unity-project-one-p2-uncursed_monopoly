﻿using System;
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
           
        }
        else if (turn == 2)
        {
            Player2.GetComponent<Player>().followWaypoints();
           
        }
        else if (turn == 3)
        {
            Player3.GetComponent<Player>().followWaypoints();
            
        }
        Button.SetActive(true);

        
    }
}
