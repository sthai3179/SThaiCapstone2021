using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootTarget : MonoBehaviour
{
    //Movement Speed
    public float movementspeed = 1.5f;
    //Distance Movement/Range
    public float leftright = 20f;
    //Chance of changing to opposite direction
    public float dirswitch = 0.06f;
    // Start is called before the first frame update
    public int count;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Basic Movement
        Vector3 pos = transform.position;
        pos.z += movementspeed * Time.deltaTime;
        transform.position = pos;
        //Change the direction
        if (pos.z < -leftright)
        {
            movementspeed = Mathf.Abs(movementspeed); //Move right
        }
        else if (pos.z > leftright)
        {
            movementspeed = -Mathf.Abs(movementspeed);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        //Increasing movement variant
        //if (other.gameObject.tag == "Bullet")
        //{
        //    ScoreNumber.scorevalue += 200;
        //    movementspeed += 1.0f;
        //    dirswitch -= 0.02f;


        //    //Destroy(this.gameObject);
        //    Destroy(other.gameObject);
        //}

        if (other.gameObject.tag == "Bullet")
        {
            ScoreNumber.scorevalue += 200;

                Destroy(this.gameObject);
                Destroy(other.gameObject);
            }

    }

    private void FixedUpdate()
    {
        if (Random.value < dirswitch)
        {
            movementspeed *= -1; //Change Direction
        }
    }
}
