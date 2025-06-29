using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

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
    public PlayerInput input;
    public PlayerInteractRay interactRay;

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
    public void BlockInteractions()
    {
        interactRay.BlockInteractions();
    }
    public void AllowInteractions()
    {
        interactRay.AllowInteractions();
    }
    public void ChangeMapToUI()
    {
        input.SwitchCurrentActionMap("UI");
    }
    public void ChangeMapToPlayer()
    {
        input.SwitchCurrentActionMap("Player");
    }
    public void TeleportToPosition(Vector3 pos)
    {
        movement.controller.enabled = false;
        gameObject.transform.position = pos;
        movement.controller.enabled = true;
    }
}
