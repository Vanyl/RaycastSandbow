using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    Vector3 fwd = transform.forward;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, fwd, Color.blue);

        if (Physics.Raycast(transform.position, fwd))
        {
            print("HIT");
        }

        else
        {
            Debug.DrawRay(transform.position, fwd, Color.red);
        }
    }
}
