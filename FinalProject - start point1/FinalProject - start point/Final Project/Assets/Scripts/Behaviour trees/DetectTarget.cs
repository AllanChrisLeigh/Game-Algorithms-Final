using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using UnityEngine;

public class DetectTarget : Task
{
    public float DetectionDistance = 50.0f;
    public Flock flock;
    public GameObject hitObject;

    public override NodeResult Execute()
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(flock.transform.position, flock.transform.forward * DetectionDistance, out hit))
        {
            hitObject = hit.collider.gameObject;
            return NodeResult.SUCCESS;
        }
        return NodeResult.FAILURE;
    }
}
