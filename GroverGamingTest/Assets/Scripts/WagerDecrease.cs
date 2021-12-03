using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WagerDecrease : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        if (Wager.wagerAmount == 0.25f)
        {
            Wager.wagerAmount = 0.00f;

        }
        else if (Wager.wagerAmount == 0.50f)
        {
            Wager.wagerAmount = 0.25f;
        }
        else if (Wager.wagerAmount == 1.00f)
        {
            Wager.wagerAmount = 0.50f;

        }
        else if (Wager.wagerAmount == 5.00f)
        {
            Wager.wagerAmount = 1.00f;
        }
    }
}
