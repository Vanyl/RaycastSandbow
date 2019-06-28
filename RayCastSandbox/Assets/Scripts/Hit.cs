using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    Vector3 fwd;
    public float scope;


    void Start()
    {
        fwd = transform.forward;
    }

    void Update()
    {
        Color color = Color.green;
        RaycastHit hit;

        if (Physics.Raycast(transform.position, fwd, out hit, scope))
        {
            if (hit.transform.tag == "monster")
            {
                print("Monster HIT " + hit.distance);
                color = new Color(1f, 0.5f, 0.5f); //couleur si touchée
            }

            //Debug.DrawRay(transform.position, fwd * scope, color); //couleur si autre objet touché
            Debug.DrawLine(transform.position, hit.point , color); //va jusqu'à l'endroit où je touche
        }
    }
}
