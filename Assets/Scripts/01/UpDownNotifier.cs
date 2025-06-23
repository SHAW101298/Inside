using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UpDownNotifier : MonoBehaviour
{
    // X ROTATION
    [SerializeField] float percent;
    [SerializeField] bool side;
    [SerializeField] Transform up;
    [SerializeField] Transform down;
    [SerializeField] Vector3 rot;



    // Update is called once per frame
    void Update()
    {
        rot = transform.localEulerAngles;
        /*
        if(rot.x >= 0)
        {
            Debug.Log("Down");
            percent = -rot.x / 90;
            down.localScale = new Vector3(1, percent, 1);
            up.localScale = Vector3.zero;
        }
        else
        {
            Debug.Log("Up");
            percent = -rot.x - 90;
            up.localScale = new Vector3(1, percent, 1);
            down.localScale = Vector3.zero;
        }
        */

        if(rot.x >= 270)
        {
            percent = (360 - rot.x  -15) / 90;
            up.localScale = new Vector3(1, percent, 1);
            down.localScale = Vector3.zero;
        }
        else if(rot.x >= 20)
        {
            percent = (rot.x - 20) / 90;
            down.localScale = new Vector3(1, -percent, 1);
            up.localScale = Vector3.zero;
        }
        else
        {
            down.localScale = Vector3.zero;
            up.localScale = Vector3.zero;
        }
    }
    public void TriggerDestruction()
    {
        up.localScale = Vector3.zero;
        down.localScale = Vector3.zero;
        Destroy(this);

    }
}
