using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public enum ENUM_PlayerMoveState
{
    idle,
    walking,
    running,
    jumping,
    dashing,
    jumpDash
}

public class PlayerMovement : MonoBehaviour
{
    public PlayerData data;
    public PlayerAnimations anim;
    [Header("Basic Data")]
    [SerializeField] float gravityValue = -9.81f;
    public ENUM_PlayerMoveState moveState;
    [SerializeField] GameObject groundCheckTransform;
    [SerializeField] bool groundedPlayer;
    [SerializeField] float groundCheckDistance;
    [SerializeField]Vector3 velocity;
    Vector3 dir;
    bool blockedMovementByAction;
    bool blockedMovementByUI;
    [Header("Movement")]
    [SerializeField] float moveSpeed;
    [SerializeField] float runSpeedMultiplier;
    [SerializeField] float runningStaminaCost;
    [SerializeField] bool isRunning;
    [Header("Jumping")]
    [SerializeField] float jumpHeight = 1.0f;
    [SerializeField] float jumpStaminaCost;
    [SerializeField] Vector2 input;

    [Header("Reference")]
    public CharacterController controller;

    public LayerMask groundLayer;




    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if(blockedMovementByAction == true)
        {
            return;
        }
        if (blockedMovementByUI == true)
        {
            return;
        }

        GroundCheck();
        ActAccordingToState();
    }
    void ActAccordingToState()
    {
        //Debug.Log("Acting According to State");
        switch (moveState)
        {
            case ENUM_PlayerMoveState.idle:
                Idle();
                break;
            case ENUM_PlayerMoveState.walking:
                Walking();
                break;
            case ENUM_PlayerMoveState.jumping:
                Jumping();
                break;
            default:
                break;
        }

    }
    bool TryToChangeState(ENUM_PlayerMoveState newState)
    {
        if (moveState == newState)
        {
            return false;
        }
        
        if (moveState != ENUM_PlayerMoveState.jumping)
        {
            //Debug.Log("New state = " + newState);
            moveState = newState;

            return true;
        }

        return false;


    }
    void FinishCurrentState(ENUM_PlayerMoveState newState)
    {
        moveState = newState;
    }

    public void ActionMoving(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            input = context.ReadValue<Vector2>();
            TryToChangeState(ENUM_PlayerMoveState.walking);
            anim.anim.SetBool("Walking", true);
        }
        if (context.phase == InputActionPhase.Canceled)
        {
            input = Vector2.zero;
            TryToChangeState(ENUM_PlayerMoveState.idle);
            anim.anim.SetBool("Walking", false);
        }
    }
    public void ActionRunning(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Performed)
        {
            isRunning = true;
            anim.anim.SetBool("Running", true);
        }
        if(context.phase == InputActionPhase.Canceled)
        {
            anim.anim.SetBool("Running", false);
            isRunning = false;
        }
    }
    public void ActionJump(InputAction.CallbackContext context)
    {
        if(context.phase != InputActionPhase.Performed)
        {
            return;
        }

        //Debug.Log("Action Jump Approved");
        if (groundedPlayer == false)
            return;
        if (moveState == ENUM_PlayerMoveState.jumping)
            return;


        //Debug.Log("Current Velocity = " + velocity.y);
        bool check = TryToChangeState(ENUM_PlayerMoveState.jumping);
        if (check == false)
            return;
        velocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        //Debug.Log("New Velocity = " + velocity.y);
        Jumping();
        //Debug.Log("After Jumping Called");
    }
    
    void Idle()
    {
        MoveAccordingToGravity();
        return;
    }
    void Walking()
    {
        dir.x = input.x;
        dir.z = input.y;
        dir *= moveSpeed * Time.deltaTime;
        dir = transform.TransformDirection(dir);

        if(isRunning == true)
        {
            dir *= runSpeedMultiplier;
        }

        controller.Move(dir);
        MoveAccordingToGravity();
    }
    void Jumping()
    {
        dir.x = input.x;
        dir.z = input.y;
        dir *= moveSpeed * Time.deltaTime;
        dir = transform.TransformDirection(dir);

        controller.Move(dir);
        MoveAccordingToGravity();

        //if(groundedPlayer == true)
        if(velocity.y <= 0 && groundedPlayer)
        {
            //Debug.Log("Jumping finished,");
            if (input == Vector2.zero)
            {
                FinishCurrentState(ENUM_PlayerMoveState.idle);
                //TryToChangeState(ENUM_PlayerMoveState.idle);
            }
            else
            {
                FinishCurrentState(ENUM_PlayerMoveState.walking);
                //TryToChangeState(ENUM_PlayerMoveState.walking);
            }
        }
    }

    void GroundCheck()
    {
        RaycastHit hitinfo;
        Physics.Raycast(groundCheckTransform.transform.position, Vector3.down, out hitinfo, groundCheckDistance, groundLayer);
        //Debug.Log(hitinfo.collider.gameObject);
        Debug.DrawRay(groundCheckTransform.transform.position, Vector3.down, Color.red);
        groundedPlayer = Physics.Raycast(groundCheckTransform.transform.position, Vector3.down, groundCheckDistance, groundLayer);
        if(groundedPlayer == true && velocity.y <= 0)
        {
            velocity.y = 0;
        }
    }
    void MoveAccordingToGravity()
    {
        velocity.y += gravityValue * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    public void BlockMovementByUI()
    {
        blockedMovementByUI = true;
    }
    public void BlockMovementByAction()
    {
        blockedMovementByAction = true;
    }
    public void AllowMovementByUI()
    {
        blockedMovementByUI = false;
    }
    public void AllowMovementByAction()
    {
        blockedMovementByAction = false;
    }

    public void SetMovementSpeed(float newSpeed)
    {
        moveSpeed = newSpeed;
    }
    public Vector3 GetMoveDir()
    {
        //Debug.Log("Move Dir = " + dir);
        return dir;
    }
    public void ModifyMovementSpeedByPercent(float val)
    {

    }
    public void ModifyMovementSpeedByFlat(float val)
    {

    }
}
