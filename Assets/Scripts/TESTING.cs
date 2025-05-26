using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTING : MonoBehaviour
{
    public bool runAOO;
    [Header("AOO")]
    public Transform mainSphere;
    public Transform secondSphere;
    public Transform destinationSphere;
    public Vector3 currentDestination;
    public Vector3 rotationSpeed;
    public float movementSpeed;
    public float currentDistance;


    void Update()
    {
        AOO();
    }
    void AOO()
    {
        if(runAOO == true)
        {
            mainSphere.localEulerAngles += rotationSpeed * Time.deltaTime;
            currentDistance = Vector3.Distance(secondSphere.position, currentDestination);
            destinationSphere.position = currentDestination;
            if(currentDistance <= 5)
            {
                currentDestination.x = Random.Range(-25, 25);
                currentDestination.z = Random.Range(-25, 25);
            }
            secondSphere.position = Vector3.MoveTowards(secondSphere.position, currentDestination, movementSpeed);
        }
    }
}
