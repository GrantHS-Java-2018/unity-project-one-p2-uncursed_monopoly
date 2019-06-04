using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMoney : MonoBehaviour

{
   
    
    public GameObject Player1;
  
    public GameObject Player2;
   
    public GameObject Player3;
    // I need to create seperate gameobjects for players
    //due to the way we created multiple player scripts in one

    // Start is called before the first frame update
    void Start()
    {
        
        UiText();
        //should call my method to display different player currencies
    }

    

    public void UiText()
    {
        
        
        TextMeshProUGUI moneyText = GetComponent<TextMeshProUGUI>();
        //establishing textmesh pro in scripts
        int player1wallet = 0;
       //establishing a local variable to make assigning text easier
       
       player1wallet = Player1.GetComponent<Player>().wallet;
        //pulling wallet variable from other script
        
        moneyText.text = "player 1 wallet = " + player1wallet.ToString();
        //setting the final text the object will display
        
       


    }

}




