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

    private AudioSource audio;
    public AudioClip deathSound;

    // Funktionen die von Unity selbständig aufgerufen werden durch Vererbung von MonoBehaviour

    // Wenn Player Objekt das erste Mal in der Szene vorkommt
    private void Start()
    {
        audio = GameObject.FindAnyObjectByType<AudioSource>();
    }

    // Wird einmal pro Frame aufgerufen
    // ( bei 30 FPS -> 30 x in der Sekunde)
    // "Herzschlag unseres Spiels"
    private void Update()
    {
        //  if  -> Keyword zum deklarieren eines If Statements
        // ()   -> Condition
        // {}   -> Scope (Geltungsbereich) -> Wird ausgeführt wenn in der Condition true heraus kommt
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

    // Ähnlich wie die Start Funktion
    private void Awake()
    {
        
    }

    // Im gleichen Frame aber etwas später als Update
    private void LateUpdate()
    {
        
    }

    private void OnApplicationQuit()
    {
        
    }

    // Wenn ein GameObject mit unserem eigenen kollidiert
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            audio.PlayOneShot(deathSound);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }

    private void OnCollisionExit(Collision collision)
    {
        
    }

}
