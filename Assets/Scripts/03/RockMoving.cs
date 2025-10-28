using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class RockMoving : MonoBehaviour
{
    #region
    public static RockMoving Instance;
    private void Awake()
    {
        Instance = this;
    }
    #endregion
    public LayerMask interactionLayer;
    public MovableRock heldRock;

    public LayerMask moveLayerMask;

    public PlayerData player;


    // Update is called once per frame
    void Update()
    {

    }
    public void GrabRock(MovableRock rock)
    {
        heldRock = rock;
    }
    void ReleaseRock()
    {
        if(heldRock == null)
        {
            return;
        }
        else
        {
            heldRock.Release();
            heldRock = null;
        }
    }
    public void ReleaseRock(InputAction.CallbackContext context)
    {
        //Debug.Log("Current phase = " + context.phase);
        //Debug.Log("   ");
        if (context.phase != InputActionPhase.Canceled)
        {
            return;
        }

        ReleaseRock();
    }
}
