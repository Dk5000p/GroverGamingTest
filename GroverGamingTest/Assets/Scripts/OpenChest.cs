using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenChest : MonoBehaviour
{
    public BoxCollider2D playButton;
    public BoxCollider2D wagerUp;
    public BoxCollider2D wagerDown;
    public BoxCollider2D chest;
    public SpriteRenderer m_spriteRenderer;
    public SpriteRenderer upButton;
    public SpriteRenderer downButton;
    public static float winnings=0f;
    public Text winningsDisplay;
    public int index;
    public float expectedWinnings;
    public Animator anim;
    public AudioSource open;
    public AudioSource betterLuck;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        winningsDisplay.text = "Winnings: $ " + winnings.ToString();
    }
    private void OnMouseDown()
    {
        chest.enabled = false;
        Counter.chestChoice++;
        //Ends the game if the player has received the payout amount or the multiplier is 0.
        if (StartGame.multiplier == 0 || StartGame.payout == 0)
        {
            anim.Play("Nothing");
            betterLuck.Play();
            playButton.enabled = true;
            m_spriteRenderer.color = Color.white;
            upButton.color = Color.white;
            downButton.color = Color.white;
            wagerUp.enabled = true;
            wagerDown.enabled = true;
            Counter.chestChoice = 0;
            StartGame.currentBalance = StartGame.currentBalance + winnings;
            GameObject[] chests = GameObject.FindGameObjectsWithTag("chest");
            foreach (GameObject go in chests)
            {

                go.GetComponent<BoxCollider2D>().enabled = false;



            }
        }
        else if (Wager.wagerAmount == 0.25f)
        {
            anim.Play("OpenMoney");
            open.Play();
            float[] numbers = { 0.05f, 0.10f, 0.15f, 0.20f, 0.25f };
            index = Random.Range(0, 5);
            print("Winning" + numbers[index]);
            expectedWinnings = winnings + StartGame.multiplier * numbers[index];
            if (expectedWinnings > StartGame.payout)
            {
                winnings = winnings + StartGame.payout;
                StartGame.payout = 0;
            }
            else
            {
                winnings = expectedWinnings;
                StartGame.payout = StartGame.payout - winnings;
            }

        }
        else if (Wager.wagerAmount == 0.5f)
        {
            anim.Play("OpenMoney");
            open.Play();
            float[] numbers = { 0.30f, 0.35f, 0.40f, 0.45f, 0.5f };
            index = Random.Range(0, 5);
            print("Winning" + numbers[index]);
            expectedWinnings = winnings + StartGame.multiplier * numbers[index];
            if (expectedWinnings > StartGame.payout)
            {
                winnings = winnings + StartGame.payout;
                StartGame.payout = 0;
            }
            else
            {
                winnings = expectedWinnings;
                StartGame.payout = StartGame.payout - winnings;
            }
        }
        else if (Wager.wagerAmount == 1.00f)
        {
            anim.Play("OpenMoney");
            open.Play();
            float[] numbers = { 0.05f, 0.10f, 0.15f, 0.20f, 0.25f, 0.30f, 0.35f, 0.40f, 0.45f, 0.5f, 0.55f, 0.60f, 0.65f, 0.70f, 0.75f, 0.80f, 0.85f, 0.90f, 0.95f, 1.00f };
            index = Random.Range(0, 20);
            print("Winning" + numbers[index]);
            expectedWinnings = winnings + StartGame.multiplier * numbers[index];
            print(expectedWinnings);
            print(StartGame.payout);
            if (expectedWinnings > StartGame.payout)
            {
                winnings = winnings + StartGame.payout;
                StartGame.payout = 0;
            }
            else
            {
                winnings = expectedWinnings;
                StartGame.payout = StartGame.payout - winnings;
            }

        }
        else if (Wager.wagerAmount == 5.00f)
        {
            anim.Play("OpenMoney");
            open.Play();
            float[] numbers = { 4.80f, 4.85f, 4.90f, 4.95f, 5.00f };
            index = Random.Range(0, 5);
            print("Winning" + numbers[index]);
            expectedWinnings = winnings + StartGame.multiplier * numbers[index];
            if (expectedWinnings > StartGame.payout)
            {
                winnings = winnings + StartGame.payout;
                StartGame.payout = 0;
            }
            else
            {
                winnings = expectedWinnings;
                StartGame.payout = StartGame.payout - winnings;
            }
        }

        else if (Counter.chestChoice == 8)
        {
            anim.Play("OpenMoney");
            open.Play();
            winnings = winnings + StartGame.payout;
            StartGame.payout = 0;
        }

    }
}
