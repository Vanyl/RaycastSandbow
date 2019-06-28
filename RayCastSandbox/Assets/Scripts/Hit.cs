using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    Vector3 fwd;
    public float scope;

    // Start is called before the first frame update
    void Start()
    {
         fwd = transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        Color color = Color.blue;

        if (Physics.Raycast(transform.position, fwd, scope))
        {
            print("HIT");
            color = Color.green;
        }

        Debug.DrawRay(transform.position, fwd * scope, color);


    }
}
