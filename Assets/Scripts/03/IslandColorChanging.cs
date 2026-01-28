using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandColorChanging : MonoBehaviour
{
    [SerializeField] Material mat;
    [SerializeField] float blendVal;
    [SerializeField] Transform DesiredPos;
    [SerializeField] float acceptableDistance;
    float distance;

    [SerializeField] SimpleTrigger slotInTrigger;
    float maxAwayDistance;
    float dist;
    private void Update()
    {
        dist = Vector3.Distance(transform.position, DesiredPos.position);
        if(dist > maxAwayDistance)
        {
            dist = maxAwayDistance;
        }

        blendVal = dist / maxAwayDistance;
    }
}
