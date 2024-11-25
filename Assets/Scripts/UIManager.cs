using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public Player[] player;
    public TMP_Text[] pText;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < player.Length; i++)
        {
            pText[i].text = "Player " + (i + 1)  + ": " + player[i].score.ToString();
        }

        
    }
}
