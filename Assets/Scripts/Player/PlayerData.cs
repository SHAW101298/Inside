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
    public PlayerInventory inventory;


    private void Start()
    {
        SetReferences();
    }

    private void SetReferences()
    {
        if (movement == null)
        {
            movement = GetComponent<PlayerMovement>();
        }
        if (rotation == null)
        {
            rotation = GetComponent<PlayerRotation>();
        }
        if (ui == null)
        {
            ui = GetComponent<PlayerUI>();
        }
        if (animations == null)
        {
            animations = GetComponent<PlayerAnimations>();
        }
        if (input == null)
        {
            input = GetComponent<PlayerInput>();
        }
        if (interactRay == null)
        {
            interactRay = GetComponent<PlayerInteractRay>();
        }
        if (inventory == null)
        {
            inventory = GetComponent<PlayerInventory>();
        }
    }

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
        //Debug.Log("TEleporting to position = " + pos);
        movement.controller.enabled = false;
        gameObject.transform.position = pos;
        movement.controller.enabled = true;
    }
    public void TeleportToObject(GameObject objectPosition)
    {
        //Debug.Log("Teleporting to Object = " + objectPosition.name);
        movement.controller.enabled = false;
        gameObject.transform.position = objectPosition.transform.position;
        movement.controller.enabled = true;
    }
}
