using UnityEngine; // Bibliothek / Library von Klassen (Objekten)

// Unsere Klasse Player erbt von MonoBehaviour (Methoden/Variablen)
public class Player : MonoBehaviour
{

    public int score;
    public Rigidbody rb;
    public float forwardForce;
    public float sidewayForce;
    public KeyCode forwardKey;
    public KeyCode backwardKey;
    public KeyCode leftKey;
    public KeyCode rightKey;

    // Funktionen die von Unity selbst�ndig aufgerufen werden durch Vererbung von MonoBehaviour

    // Wenn Player Objekt das erste Mal in der Szene vorkommt
    private void Start()
    {
        
    }

    // Wird einmal pro Frame aufgerufen
    // ( bei 30 FPS -> 30 x in der Sekunde)
    // "Herzschlag unseres Spiels"
    private void Update()
    {
        //  if  -> Keyword zum deklarieren eines If Statements
        // ()   -> Condition
        // {}   -> Scope (Geltungsbereich) -> Wird ausgef�hrt wenn in der Condition true heraus kommt
        if (Input.GetKey(forwardKey)) 
        {
            rb.AddForce(0,0,forwardForce);
        }

        if (Input.GetKey(backwardKey))
        {
            rb.AddForce(0, 0, -forwardForce);
        }


        if (Input.GetKey(leftKey))
        {
            rb.AddForce(-sidewayForce, 0, 0);
        }

        if (Input.GetKey(rightKey))
        {
            rb.AddForce(sidewayForce, 0, 0);
        }

        //Vector3 rot = rb.velocity;
        //rot.y = 0f;
        //transform.rotation = Quaternion.LookRotation(rot);
    }

    // �hnlich wie die Start Funktion
    private void Awake()
    {
        
    }

    // Im gleichen Frame aber etwas sp�ter als Update
    private void LateUpdate()
    {
        
    }

    private void OnApplicationQuit()
    {
        
    }

    // Wenn ein GameObject mit unserem eigenen kollidiert
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Collision wurde erkannt");
        //if ("Hammer" == collision.transform.tag)
        //{
        //    Debug.Log("Hammer wurde ber�hrt!");
        //    Destroy(collision.gameObject);
        //}
        //if ("Coin" == collision.transform.tag)
        //{
        //    Debug.Log("Coin wurde ber�hrt!");
        //}
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }

    private void OnCollisionExit(Collision collision)
    {
        
    }

}
