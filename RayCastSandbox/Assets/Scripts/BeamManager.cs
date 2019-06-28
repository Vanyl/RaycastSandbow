using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
//                          ^ nom de la classe qu'on veut


public class BeamManager : MonoBehaviour
{
    private LineRenderer line;

    [Tooltip("Time before destruction.")]
    public float time = 3f;

    [Header("Position")] //Dans script en public est noté dans unity (plus strcturé)
    public Vector3 start;
    public Vector3 end;
    
    void Start()
    {
        line = GetComponent<LineRenderer>();
        Destroy(gameObject, time); //fonction qui détruit objet si on met pas de temps c'est immédiat, si on met "après un certain temps destruction"

        line.positionCount = 2;
        line.SetPosition(0, start);
        line.SetPosition(1, end);

    }

   
    void Update()
    {
        
    }
}
