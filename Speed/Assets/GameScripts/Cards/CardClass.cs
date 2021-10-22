using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CardClass
{
    //If a card has a powerup, then the card value is irrelevant and in some cased the card color.
    //In that case, 
    public string cardValue;
    public string cardColorCode;
    public bool cardPowerUp;
    public string cardPowerCode;

    //Constructor for normal card
    public CardClass(string value, string colorCode)
    {
        this.cardValue = value;
        this.cardColorCode = colorCode;
    }

    //Constructor for power cards
    public CardClass(string color, bool PowerUp, string PowerCode)
    {
        this.cardColorCode = color;
        this.cardPowerUp = PowerUp;
        this.cardPowerCode = PowerCode;
    }
}

