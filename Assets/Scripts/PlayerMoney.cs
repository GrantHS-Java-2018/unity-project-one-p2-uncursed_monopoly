using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMoney : MonoBehaviour

{
    
    public GameObject playerObj;
    // I need to create obj player to refrence multiple players
    //due to the way we created multiple player scripts in one

    // Start is called before the first frame update
    void Start()
    {
        
        UiText();
        //should call my method to display different player currencies
    }

    

    public void UiText()
    {
        int playerwallet = 0; 
        //establishing a local variable to make assigning text easier
        
        TextMeshProUGUI moneyText = GetComponent<TextMeshProUGUI>();
        //establishing textmesh pro in script
        
     
       playerwallet = playerObj.GetComponent<Player>().wallet;
        //pulling wallet variable from other script
        
       
        moneyText.text = playerObj.name + " wallet  " + playerwallet.ToString();
        //assiging textmesh based on local variable

        
       


    }

}




