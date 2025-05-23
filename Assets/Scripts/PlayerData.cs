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


    public void BlockMovementAndRotationByUI()
    {
        movement.BlockMovementByUI();
        rotation.BlockRotationByUI();
    }
    public void AllowMovemntAndRotationByUI()
    {
        movement.AllowMovementByUI();
        rotation.AllowRotationByUI();
    }
    public void BlockMovementAndRotationByAction()
    {
        movement.BlockMovementByAction();
        rotation.BlockRotationByAction();
    }
    public void AllowMovementAndRotationByAction()
    {
        movement.AllowMovementByAction();
        rotation.AllowRotationByAction();
    }
    public void BlockMovementByAction()
    {
        movement.BlockMovementByAction();
    }
    public void AllowMovementByAction()
    {
        movement.AllowMovementByAction();
    }
    public void BlockMovementByUI()
    {
        movement.BlockMovementByUI();
    }
    public void AllowMovementByUI()
    {
        movement.AllowMovementByUI();
    }
    public void BlockRotationByAction()
    {
        rotation.BlockRotationByAction();
    }
    public void AllowRotationByAction()
    {
        rotation.AllowRotationByAction();
    }
    public void BlockRotationByUI()
    {
        rotation.BlockRotationByUI();
    }
    public void AllowRotationByUI()
    {
        rotation.AllowRotationByUI();
    }

}
