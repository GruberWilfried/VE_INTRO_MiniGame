using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    public string[] namen;
    public string test = "a test";

    // Start is called before the first frame update
    void Start()
    {
        // Initialisierung des Arrays im Code
        //namen = new string[12];

        test = "etwas anderes";
        namen[0] = "Maximilian Mustermann";
        namen[1] = "Junior " + namen[0];
        namen[namen.Length - 1] = "Maxima Mustermann";
    }


}
