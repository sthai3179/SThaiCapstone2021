using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopMove : MonoBehaviour
{
    public ParticleSystem scoreshot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Trigger function to destroy basketball
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Basketball") {
            Destroy(other.gameObject);
            Instantiate(scoreshot);
            Destroy(scoreshot);
        }
    }
}
