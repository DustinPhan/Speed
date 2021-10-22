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

    private void start()
    {

    }


    private int n = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (CardClass c in CardManager.Card.cards)
            {
                Debug.Log(CardManager.Card.cards[n].cardValue);
                n ++;
            }
        }
    }
}
