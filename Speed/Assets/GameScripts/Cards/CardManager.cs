using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    private static CardManager _card;

    public static CardManager Card
    {
        get
        {
            //Creates the Game Manager (when it is in the game space)
            if (_card == null)
            {
                GameObject go = new GameObject("CardManager");
                go.AddComponent<CardManager>();
            }

            return _card;
        }
    }

    //Varialbes List
    public int cardQuantity { get; set;}
    public string[] color { get; set; }
    public string[] value { get; set; }
    public Sprite[] cardFace { get; set; }
    public List<CardClass> cards { get; set; }
        //We could have a slider that increases the amount of powerups, though whether we should depends on whether we can implement it

    //Function List

    //Randomizes the list (This code was copied and pasted directly from a stackflow page)
    public void Shuffle<T>(List<T> list)
    {
        System.Random random = new System.Random();
        int n = list.Count;
        while (n > 1)
        {
            int k = random.Next(n);
            n--;
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    //_dialogue is set to this program (freshly made in the Dialogue{}) upon awakening
    void Awake()
    {
        _card = this;
    }

    //Sets the values of the variable list (The Default, which can be changed based on new level conditions)
    void Start()
    {
        //Sets the initial quantities in the variable list
        cardQuantity = 52;
        color = new string[] { "R", "G", "Y", "B" };
        value = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        //Instiantiates the normal cards in each list item
        cards = new List<CardClass>();
        foreach(string C in color)
        {
            foreach(string V in value)
            {
                cards.Add(new CardClass(V, C));
            }
        }

        Shuffle(cards);

    }
}
