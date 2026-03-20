using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MassivePrefabSpawner : MonoBehaviour
{
    [SerializeField] List<Object> prefabToSpawn;
    [SerializeField] float radius;
    [SerializeField] int amount;
    [SerializeField] LayerMask raycastLayer;
    [Space(15)]
    [SerializeField] Vector3 rotationRandomization;
    [SerializeField] Vector3 scaleRandomization;

    [Header("Button")]
    [SerializeField] bool runScript;


    void Update()
    {
        SpawningScript();
    }
    void SpawningScript()
    {
        if (runScript == false)
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
        GameObject parent = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        int treesCount = 0;
        for (int i = 0; i < amount; i++)
        {
            Vector2 randomCircle = Random.insideUnitCircle * radius;
            //Debug.Log("random circle = " + randomCircle);
            randSpot = new Vector3(randomCircle.x, 0, randomCircle.y) + transform.position;
            Vector3 calculatedOrigin = randSpot + new Vector3(0, 50, 0);
            //Debug.Log("calculated origin = " + calculatedOrigin);
            dir = (randSpot - calculatedOrigin).normalized;



            if (Physics.Raycast(calculatedOrigin, dir, out hit, 500f, raycastLayer) == true)
            {
                //Debug.Log("hit point is = " + hit.point);
                if (prefabToSpawn.Count == 0)
                    return;
              
                int random = GetRandomPrefabNumber();                    
                Object spawnedPrefab = PrefabUtility.InstantiatePrefab(prefabToSpawn[random]);                   
                temp = (GameObject)spawnedPrefab;

                temp.transform.position = hit.point;
                temp.transform.SetParent(parent.transform);
                // transform randomization
                randRot.x = Random.Range(-rotationRandomization.x, rotationRandomization.x);
                randRot.y = Random.Range(-rotationRandomization.y, rotationRandomization.y);
                randRot.z = Random.Range(-rotationRandomization.z, rotationRandomization.z);
                randScale.x = Random.Range(1 - scaleRandomization.x, 1 + scaleRandomization.x);
                randScale.y = Random.Range(1 - scaleRandomization.y, 1 + scaleRandomization.y);
                randScale.z = Random.Range(1 - scaleRandomization.z, 1 + scaleRandomization.z);
                temp.transform.localEulerAngles = randRot;
                temp.transform.localScale = randScale;
                treesCount++;
            }
        }
        Debug.Log("Created " + treesCount + " trees.");
    }

    int GetRandomPrefabNumber()
    {
        int random = Random.Range(0, prefabToSpawn.Count);
        return random;
    }
}
