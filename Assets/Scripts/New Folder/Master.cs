using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using TMPro;

public class Master : MonoBehaviour
{
    public VideoPlayer vid;
    public VideoPlayer vid1;
    public Light l;
    public Light l1;
    public GameObject go1;
    public GameObject go2;
    public Camera cam;
    public Toggle t1;
    public Text text1;
    public TextMeshProUGUI text2;
    public BoxCollider box;
    public Slider slid;

    // Start is called before the first frame update
    void Start()
    {
        vid.isLooping = true;
        vid1.playOnAwake = false;
        l.intensity = 3.2f;
        l1.cookieSize = 4;
        go1.name = "Cool!!! Cringe!";
        go2.active = true;
        cam.depth = 2.2f;
        t1.interactable = true;
        text1.text = "Ein Test";
        text1.fontSize = 20;
        box.isTrigger = false;
        slid.value = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
