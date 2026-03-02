using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotToPlayer : MonoBehaviour
{
    [SerializeField] Transform PlayerTransform;


    void Start()
    {
        GetReferenceToPlayer();
    }


    void Update()
    {
        Rotation();
    }

    void Rotation()
    {
        transform.LookAt(PlayerTransform);
    }
    void GetReferenceToPlayer()
    {
        if (PlayerTransform == null)
        {
            PlayerTransform = PlayerData.instance.cam.transform;
        }
    }
}
