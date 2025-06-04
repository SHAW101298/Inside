using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockPathCreation : MonoBehaviour
{
    [SerializeField] List<Transform> desiredTransform;
    [SerializeField] List<Transform> startTransform;
    [SerializeField] List<Transform> rockTransforms;
    

    [SerializeField] float creationTime;
    float timer;
    int rockNumber;
    [SerializeField] bool createPath;
    // Start is called before the first frame update
    void Start()
    {
        rockNumber = rockTransforms.Count;

        RandmoizeDesiredTransformList();
    }

    // Update is called once per frame
    void Update()
    {
        if(createPath == true)
        {
            timer += Time.deltaTime;
            float percent = timer / creationTime;

            for(int i = 0; i < rockNumber; i++)
            {
                rockTransforms[i].position = Vector3.Slerp(startTransform[i].position, desiredTransform[i].position, percent);
                rockTransforms[i].rotation = Quaternion.Slerp(startTransform[i].rotation, desiredTransform[i].rotation, percent);
                rockTransforms[i].localScale = Vector3.Slerp(startTransform[i].localScale, desiredTransform[i].localScale, percent);
                //rockTransforms[i].eulerAngles = Vector3.Slerp(rockTransforms[i].eulerAngles, desiredTransform[i].eulerAngles, percent);
            }


            if(timer >= creationTime)
            {
                percent = 1;
                createPath = false;
                timer = 0;
            }
        }
    }
    public void RandmoizeDesiredTransformList()
    {
        List<Transform> copiedList = new List<Transform>();
        foreach (Transform tr in desiredTransform)
        {
            copiedList.Add(tr);
        }

        desiredTransform.Clear();
        int rand;
        for(int i = 0; i < rockNumber; i++)
        {
            rand = Random.Range(0, copiedList.Count);
            desiredTransform.Add(copiedList[rand]);
            copiedList.RemoveAt(rand);
        }
    }
    public void StartCreatingPath()
    {
        createPath = true;
        timer = 0;
    }
}
