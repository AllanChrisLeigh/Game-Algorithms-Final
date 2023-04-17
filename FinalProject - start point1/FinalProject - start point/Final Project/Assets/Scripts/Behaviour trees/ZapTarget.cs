using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using UnityEngine;

public class ZapTarget : Task
{
    public Boid boid;
    public GameObject hitObject;

    public override NodeResult Execute()
    {
        Vector3 startPoint = boid.transform.position;
        Vector3 endPoint = hitObject.transform.position;

        boid.zapLine(startPoint, endPoint);
    }
}
