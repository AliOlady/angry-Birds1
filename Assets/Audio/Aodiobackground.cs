using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aodiobackground : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("background").GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
