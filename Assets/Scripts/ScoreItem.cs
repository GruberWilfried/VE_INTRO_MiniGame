using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreItem : MonoBehaviour
{
    public int score;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Kollision erkannt!");
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().score += score;
            Destroy(gameObject);
        }
    }
}
