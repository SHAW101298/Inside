using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHookUp : MonoBehaviour
{
    #region
    public static CameraHookUp Instance;
    public void CreateInstance()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            //Debug.Log("CAMERA HOOKUP");
            Instance = this;
        }
    }
#endregion
    public GameObject cam;
    public GameObject player;

    [SerializeField] PlayerRotation input;
    public Vector3 positionOnPlayer;
    [SerializeField] float sensitivity = 3;
    float x, y;
    [SerializeField] Transform forward;

   

    private void Update()
    {
        x = input.input.x;
        y = input.input.y;
        //UpdatePosition();
    }
    private void LateUpdate()
    {
        if (input.blockedRotation == true)
            return;
        RotateCam();
    }
    void RotateCam()
    {
        //x *= Time.deltaTime * sensitivity;
        x *= sensitivity/10;
        y *= sensitivity/10;
        //input.body.transform.eulerAngles.y;
        //y *= Time.deltaTime * sensitivity;

        Vector3 rotation = Vector3.zero;
        rotation.x = cam.transform.eulerAngles.x;
        rotation.y = input.body.transform.eulerAngles.y;
        rotation.x -= y;
        //Vector3 rotateValue = new Vector3(y, -x, 0);
        cam.transform.eulerAngles = rotation;
        //handsObject.transform.localEulerAngles = new Vector3(rotation.x,0,0);
    }
    public Vector3 GetForwardDir()
    {
        Vector3 dir = (forward.position - gameObject.transform.position).normalized;
        return dir;
    }
}
