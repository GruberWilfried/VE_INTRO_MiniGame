using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZugriffObjekte : MonoBehaviour
{
    // Vorgehensweise Nummer 1
    public GameObject myGame;

    // Vorgehensweise Nummer 2
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        // Vorgehensweise Nummer 1
        myGame.GetComponent<Rigidbody>().mass = 2.4f;

        // Vorgehensweise Nummer 2
        rb.mass = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
