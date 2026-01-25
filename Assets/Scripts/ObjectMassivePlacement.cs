using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[ExecuteInEditMode]
public class ObjectMassivePlacement : MonoBehaviour
{
    [SerializeField] GameObject objectToSpawn;
    [SerializeField] Transform middleOfCircle;
    [SerializeField] Transform originOfRay;
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
        Vector3 dir;
        Vector3 randRot;
        Vector3 randScale;
        Vector3 randSpot;
        GameObject temp;
        for(int i = 0; i < amountOfObjectsToPlace; i++)
        {
            Vector2 randomCircle = Random.insideUnitCircle * circlePlacementSize;
            Debug.Log("random circle = " + randomCircle);
            randSpot = new Vector3(randomCircle.x, 0, randomCircle.y) + middleOfCircle.position ;
            dir = (randSpot - originOfRay.position).normalized;



            if(Physics.Raycast(originOfRay.position, dir, out hit, 500f, raycastLayer) == true)
            {
                Debug.Log("hit point is = " + hit.point);
                temp = Instantiate(objectToSpawn);
                temp.transform.position = hit.point;
                // transform randomization
                randRot.x = Random.Range(-rotationRandomization.x, rotationRandomization.x);
                randRot.y = Random.Range(-rotationRandomization.y, rotationRandomization.y);
                randRot.z = Random.Range(-rotationRandomization.z, rotationRandomization.z);
                randScale.x = Random.Range(1 - scaleRandomization.x, 1 + scaleRandomization.x);
                randScale.y = Random.Range(1 - scaleRandomization.y, 1 + scaleRandomization.y);
                randScale.z = Random.Range(1 - scaleRandomization.z, 1 + scaleRandomization.z);
                temp.transform.localEulerAngles = randRot;
                temp.transform.localScale = randScale;
            }
        }
    }
}
