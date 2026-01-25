using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ObjectMassivePlacement : MonoBehaviour
{
    [SerializeField] GameObject objectToSpawn;
    [SerializeField] Transform middleOfCircle;
    [SerializeField] float circlePlacementSize;
    [SerializeField] int amountOfObjectsToPlace;
    [SerializeField] LayerMask raycastLayer;
    [SerializeField] Vector3 rotationRandomization;
    [SerializeField] Vector3 scaleRandomization;
    [Header("Button")]
    [SerializeField] bool runScript;

    // Update is called once per frame
    void Update()
    {
        SpawningScript();
    }
    void SpawningScript()
    {
        if(runScript == false)
        {
            return;
        }
        runScript = false;
        RaycastHit hit;
        Vector3 raycastPoint = middleOfCircle.transform.position + new Vector3(0, 50, 0);
        Vector3 dir = middleOfCircle.position - raycastPoint;
        Vector3 randRot;
        Vector3 randScale;
        GameObject temp;
        for(int i = 0; i < amountOfObjectsToPlace; i++)
        {
            if(Physics.Raycast(raycastPoint, dir, out hit, 500f, raycastLayer) == true)
            {
                temp = Instantiate(objectToSpawn);
                temp.transform.position = hit.point;
                // transform randomization
                randRot.x = Random.Range(-rotationRandomization.x, rotationRandomization.x);
                randRot.y = Random.Range(-rotationRandomization.y, rotationRandomization.y);
                randRot.z = Random.Range(-rotationRandomization.z, rotationRandomization.z);
                randScale.x = Random.Range(-scaleRandomization.x, scaleRandomization.x);
                randScale.y = Random.Range(-scaleRandomization.y, scaleRandomization.y);
                randScale.z = Random.Range(-scaleRandomization.z, scaleRandomization.z);
                temp.transform.localEulerAngles = randRot;
                temp.transform.localScale = randScale;
            }
        }
    }
}
