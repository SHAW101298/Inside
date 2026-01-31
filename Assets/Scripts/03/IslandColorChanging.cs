using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandColorChanging : MonoBehaviour
{
    [SerializeField] Material[] mats;
    [SerializeField] float blendVal;
    [SerializeField] Transform DesiredPos;
    [SerializeField] float acceptableDistance;
    float distance;

    [SerializeField] SimpleTrigger slotInTrigger;
    [SerializeField] float maxAwayDistance;
    float dist;

    bool updateColors;

    [SerializeField] float preview;
    private void Update()
    {
        UpdateColors();
    }
    void UpdateColors()
    {
        if (updateColors == false)
            return;

        dist = Vector3.Distance(transform.position, DesiredPos.position);
        if (dist > maxAwayDistance)
        {
            dist = maxAwayDistance;
        }

        blendVal = (maxAwayDistance - dist) / maxAwayDistance;
        preview = blendVal;
        foreach (Material mat in mats)
        {
            mat.SetFloat("_BlendAmount", blendVal);
        }
    }
    public void StartUpdatingColors()
    {
        updateColors = true;
    }
    public void StopUpdatingColors()
    {
        //Debug.Log("Stop Updating Colors");
        updateColors = false;
    }
}
