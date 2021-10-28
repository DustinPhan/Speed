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
    private int n;
    private int p = 0;
    public Sprite[] faces;
    public GameObject cardPrefab;

    void Start()
    {
        //Instiantiates the normal cards in each list item
        foreach (string C in CardManager.Card.color)
        {
            foreach (string V in CardManager.Card.value)
            {
                CardManager.Card.cards.Add(new CardClass(V, C, faces[p]));
                p++;
            }
        }

        CardManager.Card.Shuffle(CardManager.Card.cards);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            n = 0;

            Debug.Log(CardManager.Card.cards[n].cardValue + CardManager.Card.cards[n].cardColorCode);
            n = n + 1;
        }
    }
}
