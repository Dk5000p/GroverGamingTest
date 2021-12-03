using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wager : MonoBehaviour
{
    public static float wagerAmount=0.00f;
    public SpriteRenderer startButton;
    public Text  wagerAmountDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wagerAmountDisplay.text ="Wager:$"+wagerAmount.ToString();
    }
    private void OnMouseDown()
    {
        startButton.color = Color.white;
        if (wagerAmount== 0f)
        {
           wagerAmount = 0.25f;

      }else if (wagerAmount== 0.25f)
        {
           wagerAmount = 0.50f;
        }else if (wagerAmount == 0.50f)
        {
            wagerAmount = 1.00f;

        }else if (wagerAmount == 1.00f)
        {
            wagerAmount = 5.00f;
        }
    }
}
