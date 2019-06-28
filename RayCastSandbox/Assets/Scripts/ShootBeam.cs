using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBeam : MonoBehaviour
{   Transform cameraTransform;
    GameObject currentTeleporter = null;

    
    void Start()
    {
        //cameraTransform = Camera.main.
    }

    
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Vector3 start = cameraTransform.position + cameraTransform.right * 0.1f;
        //    Vector3 end = cameraTransform.position + cameraTransform.right * 0.1f;

        //    RaycastHit hit;

        //    if (Physics.Raycast(cameraTransform.position, cameraTransform.forward, out hit)) // si je touche
        //    {
        //        end = hit.point; 
        //        if(hit.transform.tag == "teleporter")
        //        {
        //            CreateTeleporter(hit.point);
        //        }
        //    }




        //    //charger ressource
        //    GameObject resource = Resources.Load("beam") as GameObject;
        //    BeamManager beam = resource.GetComponent<BeamManager>();
        //    beam.start = start;
        //    beam.end = end;

        //    Instantiate(resource);


        //}        
    }

    private void ShootBeamm()
        {
        Vector3 start = cameraTransform.position + cameraTransform.right * 0.1f;
        Vector3 end = cameraTransform.position + cameraTransform.right * 0.1f;

        RaycastHit hit;

        if (Physics.Raycast(cameraTransform.position, cameraTransform.forward, out hit)) 
        {
            end = hit.point;
            if (hit.transform.tag == "teleporter")
            {
                CreateTeleporter(hit.point);
            }
        }
    }

    private void Teleporter()
    {

    }

}
