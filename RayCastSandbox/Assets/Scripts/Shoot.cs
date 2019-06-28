using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 start = transform.position;
            Vector3 end = transform.position + transform.forward * 1000;

            RaycastHit hit;

            if(Physics.Raycast(transform.position, transform.forward, out hit)) // si je touche
            {
                end = hit.point; //alors point de fin = hit.point
            }




            //charger ressource
            GameObject resource = Resources.Load("beam") as GameObject;
            BeamManager beam = resource.GetComponent<BeamManager>();
            beam.start = start;
            beam.end = end;

            Instantiate(resource);


        }
        
    }
}
