using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties : MonoBehaviour
{
    public GameObject Card;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    [SerializeField]private Sprite[] properyCards;
    
    // Start is called before the first frame update
    void Start()
    {
        Card.SetActive (false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void findCard()
    {
        if (Player1.GetComponent<Player>().waypointIndex == 1)
        {
            GetComponent<SpriteRenderer>().sprite = properyCards[0];
            Card.SetActive (true);
        }

        switch (Player1.GetComponent<Player>().waypointIndex)
        {
            case 1:
                GetComponent<SpriteRenderer>().sprite = properyCards[0];
                break;
            
        }
    }
    
    
    
}
