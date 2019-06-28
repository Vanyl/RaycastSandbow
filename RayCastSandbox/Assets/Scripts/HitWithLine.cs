using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitWithLine : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 lineBegin = transform.position;
        Vector3 lineEnd = transform.position + transform.forward * 10;
        RaycastHit hit;
        Color color = Color.red;

        LineRenderer line = GetComponent<LineRenderer>();
        line.positionCount = 2; //je vais dire que 'jai besoin d'add 2 positions

        Vector3[] positions = new Vector3[] { lineBegin, lineEnd };
        line.SetPositions(positions);

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            lineEnd = hit.point;
            color = Color.blue;
        }

        line.endColor = color;

        
        
    }
}
