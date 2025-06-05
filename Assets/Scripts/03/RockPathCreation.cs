using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum ENUM_PathState
{
    hidden,
    creating,
    created,
    destroying,
}
public class RockPathCreation : MonoBehaviour
{
    [Header("References")]
    [SerializeField] List<Transform> desiredTransform;
    [SerializeField] List<Transform> startTransform;
    [SerializeField] List<Transform> rockTransforms;
    [Header("Data")]
    [SerializeField] RockPathCreation nextGroup;
    [SerializeField] EnterTrigger enterTrigger;
    [SerializeField] float creationTime;
    [SerializeField] ENUM_PathState pathState;
    [Header("EVENTS")]
    public UnityEvent pathCreated;
    public UnityEvent pathDestroyed;
    float timer;
    int rockNumber;
    bool createPath;
    bool destroyPath;
    // Start is called before the first frame update
    void Start()
    {
        rockNumber = rockTransforms.Count;

        RandmoizeDesiredTransformList();

        if(nextGroup != null)
        {
            enterTrigger.enterEvent.AddListener(nextGroup.StartCreatingPath);
        }
    }

    // Update is called once per frame
    void Update()
    {
        PathCreation();
        PathDestruction();
    }
    void PathCreation()
    {
        if (createPath == true)
        {
            timer += Time.deltaTime;
            float percent = timer / creationTime;

            for (int i = 0; i < rockNumber; i++)
            {
                rockTransforms[i].position = Vector3.Slerp(startTransform[i].position, desiredTransform[i].position, percent);
                rockTransforms[i].rotation = Quaternion.Slerp(startTransform[i].rotation, desiredTransform[i].rotation, percent);
                rockTransforms[i].localScale = Vector3.Slerp(startTransform[i].localScale, desiredTransform[i].localScale, percent);
                //rockTransforms[i].eulerAngles = Vector3.Slerp(rockTransforms[i].eulerAngles, desiredTransform[i].eulerAngles, percent);
            }


            if (timer >= creationTime)
            {
                percent = 1;
                createPath = false;
                timer = 0;
                pathCreated.Invoke();
                pathState = ENUM_PathState.created;
            }
        }
    }
    void PathDestruction()
    {
        if (destroyPath == true)
        {
            timer += Time.deltaTime;
            float percent = timer / creationTime;

            for (int i = 0; i < rockNumber; i++)
            {
                rockTransforms[i].position = Vector3.Slerp(desiredTransform[i].position, startTransform[i].position, percent);
                rockTransforms[i].rotation = Quaternion.Slerp(desiredTransform[i].rotation, startTransform[i].rotation, percent);
                rockTransforms[i].localScale = Vector3.Slerp(desiredTransform[i].localScale, startTransform[i].localScale, percent);
                //rockTransforms[i].eulerAngles = Vector3.Slerp(rockTransforms[i].eulerAngles, desiredTransform[i].eulerAngles, percent);
            }


            if (timer >= creationTime)
            {
                percent = 1;
                destroyPath = false;
                timer = 0;
                pathDestroyed.Invoke();
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
        if (pathState != ENUM_PathState.hidden)
        { 
            return;
        }
        createPath = true;
        pathState = ENUM_PathState.creating;
        timer = 0;
    }
    public void StartDestroyingPath()
    {
        if(createPath == true)
        {
            createPath = false;
        }
        destroyPath = true;
        timer = 0;
        pathState = ENUM_PathState.destroying;
    }
    public void TriggerDestruction()
    {
        Destroy(gameObject);
    }
}
