using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassiveMovement : MonoBehaviour
{
    [SerializeField] List<GameObject> objectsToMove;
    [SerializeField] Vector3 amountToMove;
    [SerializeField] float moveTime;
    [Header("DEBUG")]
    [SerializeField] bool debugStartMovement;
    float timer;
    bool startMovement;
    bool movementInAction;
    Vector3 moveValue;

    // Update is called once per frame
    void Update()
    {
        StartMovementByDebug();
        Movement();
    }

    void Movement()
    {
        if (movementInAction == false)
            return;

        timer += Time.deltaTime;
        moveValue = amountToMove * Time.deltaTime;

        foreach(GameObject GO in objectsToMove)
        {
            GO.transform.Translate(moveValue);
        }

        if(timer >= moveTime)
        {
            timer = 0;
            movementInAction = false;
        }
    }

    public void StartMovement()
    {
        if(movementInAction == true)
        {
            startMovement = false;
            return;
        }

        movementInAction = true;
        startMovement = false;
    }
    void StartMovementByDebug()
    {
        if(debugStartMovement == true)
        {
            debugStartMovement = false;
            StartMovement();
        }
    }
}
