using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Das GameObject das dupliziert werden soll
    public GameObject[] toClone;
    // Anzahl der bisherig vergangenen Frames
    public int frames;
    public int frameMax = 500;

    public float min;
    public float max;

    // vererbt von MonoBehaviour
    //public Transform transform;
    //public GameObject gameObject;

    void Update()
    {
        // Nach 500 Frames soll der Timer wieder bei 0 starten
        // Und das GameObject dupliziert werden
        frames += 1;
        // frames++;
        // frames = frames + 1;

        if (frames >= frameMax)
        {
            int random = Random.Range(0,toClone.Length);
            GameObject clone = Instantiate(toClone[random],transform.position, Quaternion.identity);
            clone.name = "What the hell!!!!";
            clone.GetComponent<SphereCollider>().radius = 0.4f;

            clone.GetComponent<ScoreItem>().score = Random.Range(0,10);

            //clone.GetComponent<SphereCollider>().isTrigger = true;

            // Der Min und Max Wert der zufälligen Zahl
            // soll im Inspektor einstellbar sein

            // Generiert für alle 3 Achsen eine zufällige Zahl
            float randomX = Random.Range(min,max);
            float randomY = Random.Range(min, max);
            float randomZ = Random.Range(min, max);

            // Fügt dem entsprechenden Komponent die Kraft
            // hinzu (welche Funktion brauchen wir?)

            clone.GetComponent<Rigidbody>().AddForce(randomX,randomY,randomZ);


            frames = 0;
        }


    }

    void Test()
    {
        float x = 342.54f;
        string a = x.ToString();
    }
}
