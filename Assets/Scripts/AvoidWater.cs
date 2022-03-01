using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidWater : MonoBehaviour
{
    private Vector3 prevPos = Vector3.zero;



    // Start is called before the first frame update
    void Start()
    {
        prevPos = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast (transform.position, Vector3.down, out hit, 1000))
        {
            if(hit.collider.tag == "Water")
            {
                transform.position = new Vector3(prevPos.x, transform.position.y, prevPos.z);
            }
            else
            {
                prevPos = transform.position;
            }
        }
    }
}
