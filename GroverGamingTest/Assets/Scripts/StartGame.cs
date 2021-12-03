using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public SpriteRenderer m_spriteRenderer;
    public SpriteRenderer upButton;
    public SpriteRenderer downButton;
    public Collider2D start_collider;
    public Collider2D treasure_chest;
    public Collider2D increaseDenomination;
    public Collider2D decreaseDenomination;
    public float lastGameReadout=0.00f;
    public static float currentBalance = 10.00f;
    public Text currentBalanceDisplay;
    public Text lastGameReadoutDisplay;
    public static int multiplier;
    public int chance;
    public int index;
    public static float payout;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentBalanceDisplay.text = "Current Balance:$"+currentBalance.ToString();
        if (Wager.wagerAmount > currentBalance||Wager.wagerAmount==0.00f)
        {
            start_collider.enabled = false;
            m_spriteRenderer.color = Color.grey;
        }
        else
        {
            start_collider.enabled = true;
        }
    }
    private void OnMouseDown()
    {
        m_spriteRenderer.color = Color.grey;
        start_collider.enabled = false;
        increaseDenomination.enabled = false;
        decreaseDenomination.enabled = false;
        upButton.color = Color.grey;
        downButton.color = Color.grey;
        lastGameReadout = 0;
        lastGameReadoutDisplay.text = "Winnings: $" + 0.00f;
        OpenChest.winnings = 0f;
        chance = Random.Range(0, 101);
        currentBalance = currentBalance - Wager.wagerAmount;
        GameObject[] chests = GameObject.FindGameObjectsWithTag("chest");
        foreach (GameObject go in chests)
        {

            go.GetComponent<BoxCollider2D>().enabled=true;
            go.GetComponent<Animator>().Play("Idle");



        }
        if (chance <= 49)
        {
            multiplier = 0;
        }else if (chance > 49 && chance < 80)
        {
            multiplier = Random.Range(1, 11);
        }else if (chance >= 80 && chance < 95)
        {
            int[] numbers = {12,16,24,32,48,64 };
            index = Random.Range(0, 6);
            multiplier = numbers[index];
        }
        else
        {
            int[] numbers = { 100,200,300,400,500};
            index = Random.Range(0, 5);
            multiplier = numbers[index];
        }
        print(Wager.wagerAmount);
        print(multiplier);
        payout = multiplier * Wager.wagerAmount;
        
       
    }
}
