using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandBehavior : MonoBehaviour
{
    readonly System.Random random = new System.Random();

    private GameObject cardPrefab;

    private int[] hand;
    private int handPos;



    private int CountTotal()
    {
        int total = 0;
        foreach(int card in hand)
        {
            total += card;
        }
        return total;
    }

    private int NewCard()
    {
        return random.Next(1, 14);
    }

    private void Draw(int count = 1)
    {
        for (; count != 0; count--)
        {
            hand[handPos] = NewCard();
            handPos += 1;
        } 
    }

    private void NewHand()
    {
        hand = new int[22];
        handPos = 0;
    }

    private void Logic()
    {
        NewHand();

        Draw(2);

        int total = CountTotal();

        if (total > 21) { /* bust */ }
        if (total == 21) { /* win */ }

    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
