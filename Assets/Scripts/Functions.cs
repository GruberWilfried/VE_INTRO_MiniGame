using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        int randomNr = Random.Range(32,123);
        Death(5); // 5 Mal
        Death(randomNr); // ? Mal

        Instantiate(prefab);

        MultiplyNumbers(3,5);
        MultiplyNumbers(3.67f, 5.546f);

        Funktion1(5,7);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Death(25); // 25 Mal
    }

    // Funktion deklarieren
    // Acces Modifier (optional) -> public / private
    // void -> Return Type
    // Identifier -> Name der Funktion
    public void Death(int anzahl)
    {
        for (int i = 0; i < anzahl; i++)
        {
            Debug.Log("Badass ist Gestorben!");
        }
    }

    public int MultiplyNumbers(int a, int b)
    {
        return a * b;
    }

    public float MultiplyNumbers(float a, float b)
    {
        return a * b;
    }

    public float Funktion1(float a, float b) {

        return (a + a * b) / b;
    }

    public string Text(string name, string buchstabe) // name = "Herr Gruber"
    {
        string satz = ("Schönen Guten Tag " + name + ". Text" + buchstabe + ". Bis Bald " + name + ".");
        return satz;
    }

    public string Spam(string name, string spam, int anzahl)
    {
        for (int i = 0; i < anzahl; i++)
        {
            name += spam;
        }

        return name;
    }
}
