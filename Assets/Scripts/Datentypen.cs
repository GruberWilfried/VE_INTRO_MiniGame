using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Datentypen : MonoBehaviour
{
    // Value Types      (Struct)
    public int ganzeZahlen;
    public float gleitKommaZahlen;
    public string symbole;  // Eigentlich Reference Type kann aber wie Value Type verwendet werden
    public bool zweiEntscheidungen;

    public Vector3 posValues;
    public Color colValues;
    // ....
    // ....

    // Refernce Types   (Class)
    public GameObject go;
    public Transform tr;
    public Collider col;
    public CapsuleCollider cCol;
    public Rigidbody rb;
    public MeshRenderer mr;
    // .....
    // .....

    public Datentypen dt;


    private void Start()
    {
        // Value Type
        // Bei der Zuweisung wird der Wert kopiert
        // bzw. ein neuer Wert erstellt
        int x = 5;
        int y = x;
        int z = x;
        x = 8;
        // y = hat weiterhin den Wert 5
        // z = hat weiterhin den Wert 5

        // Reference Type
        // Bei der Zuweisung wird der Wert nur referenziert
        // und NICHT kopiert
        GameObject a = go;
        GameObject b = go;
        GameObject c = go;
        a.name = "Horst";
        //b.name = ????;       // "Horst";
        //c.name = ????;       // "Horst";
    }

    private void Update()
    {
        
    }
}
