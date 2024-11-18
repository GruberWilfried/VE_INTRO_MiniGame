using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatentypenManager : MonoBehaviour
{
    public string neueSymbole;
    public Datentypen dt;

    void Start()
    {
        //GetComponent<Datentypen>().symbole = "Semin";//neueSymbole;
        dt.symbole = "Semin";
    }

}
