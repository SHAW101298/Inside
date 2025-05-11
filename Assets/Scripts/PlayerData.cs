using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static PlayerData instance;
    public void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    public PlayerMovement movement;
    public PlayerRotation rotation;
    public CameraHookUp cam;
    public PlayerUI ui;
    public PlayerAnimations animations;
}
