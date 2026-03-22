using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class ObjectMassiveTransformRandomizer : MonoBehaviour
{
    [SerializeField] List<GameObject> objectsToAffect;
    [SerializeField] Vector3 positionRandomize;
    [SerializeField] Vector3 rotationRandomize;
    [SerializeField] Vector3 scaleRandomize;

    [Space(20)]
    [SerializeField] bool RandomizeTrigger;

    // Update is called once per frame
    void Update()
    {
        Randomizer();
    }
    void Randomizer()
    {
        if (RandomizeTrigger == false)
            return;
            
        RandomizeTrigger = false;


        int maxCount = objectsToAffect.Count;
        Debug.Log("Max count = " + maxCount);
        for(int i = 0; i < maxCount; i++)
        {
            objectsToAffect[i].transform.position += GetRandomPosition();
            objectsToAffect[i].transform.eulerAngles += GetRandomRotation();
            objectsToAffect[i].transform.localScale += GetRandomScale();
        }
    }
    Vector3 GetRandomPosition()
    {
        float randValX = Random.Range(-positionRandomize.x, positionRandomize.x);
        float randValY = Random.Range(-positionRandomize.y, positionRandomize.y);
        float randValZ = Random.Range(-positionRandomize.z, positionRandomize.z);
        return new Vector3(randValX, randValY, randValZ);
    }
    Vector3 GetRandomRotation()
    {
        float randValX = Random.Range(-rotationRandomize.x, rotationRandomize.x);
        float randValY = Random.Range(-rotationRandomize.y, rotationRandomize.y);
        float randValZ = Random.Range(-rotationRandomize.z, rotationRandomize.z);
        return new Vector3(randValX, randValY, randValZ);
    }
    Vector3 GetRandomScale()
    {
        float randValX = Random.Range(-scaleRandomize.x, scaleRandomize.x);
        float randValY = Random.Range(-scaleRandomize.y, scaleRandomize.y);
        float randValZ = Random.Range(-scaleRandomize.z, scaleRandomize.z);
        return new Vector3(randValX, randValY, randValZ);
    }
}
