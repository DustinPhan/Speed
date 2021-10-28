using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCards : MonoBehaviour
{
    //1st we instantiate the necessary cards in front of the characters with the right properties
    private void cardStart()
    {
        for(int i = 0; i < 6; i++)
        {
            //FIXME: select 5 random cards from the cards List
            //FIXME: Instantiate those 5 cards
            //FIXME: Determine the position and rotation of those cards relative to the camera
        }
    }

    //Variables List
    private int n = 0;
    public Sprite[] cardFace;

    void Update()
    {
        //Prints each card in the list
        while (n < 52)
        {
            foreach (CardClass c in CardManager.Card.cards)
            {
                Debug.Log(CardManager.Card.cards[n].cardValue + CardManager.Card.cards[n].cardColorCode);
                n++;
            }
        }
    }
}
