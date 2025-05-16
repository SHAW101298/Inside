using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BenchSitting : MonoBehaviour
{
    [SerializeField] bool isSitting;
    [SerializeField] bool allowDialogPrompts;
    [SerializeField] GameObject sitPosition;

    [SerializeField] float sitTimer;
    [SerializeField] float dialogTimer;
    [SerializeField] float requiredSitTime;
    [SerializeField] float delayBetweenDialogPrompts;
    [SerializeField] DialogPrompt dialog;
    public UnityEvent Event_PromptDialog;


    public void Sit()
    {
        isSitting = true;
        allowDialogPrompts = false;
        sitTimer = 0;
        dialogTimer = 0;
        PlayerData player = PlayerData.instance;
        player.gameObject.transform.position = sitPosition.transform.position;
        player.gameObject.transform.localRotation = sitPosition.transform.localRotation;
        player.BlockMovementAndRotationByAction();
    }
    public void StandUp()
    {
        isSitting = false;
        allowDialogPrompts = false;
        sitTimer = 0;
        dialogTimer = 0;
        PlayerData player = PlayerData.instance;
        player.AllowMovementAndRotationByAction();
        player.gameObject.transform.localEulerAngles = Vector3.up * -90;
    }

    private void Update()
    {
        if(isSitting == true)
        {
            sitTimer += Time.deltaTime;

            if(sitTimer >= requiredSitTime)
            {
                allowDialogPrompts = true;
            }
        }

        if(allowDialogPrompts == true)
        {
            dialogTimer += Time.deltaTime;
            if(dialogTimer >= delayBetweenDialogPrompts)
            {
                dialogTimer = 0;
                dialog.PromptRandomDialogField();
                Event_PromptDialog.Invoke();
            }
        }
    }
    
}
