using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI_InteractionSystem : MonoBehaviour
{
    [Header("Interactions")]
    [SerializeField] InteractionHolder currentInteraction;
    [SerializeField] GameObject interactionsWindow;
    [SerializeField] float showTimer;
    [Space(20)]
    [SerializeField] GameObject[] prefabs;
    float timer;
    bool isActive;

    private void Update()
    {
        InfoWindowTimer();
    }
    void InfoWindowTimer()
    {
        if (isActive == false)
            return;


        timer += Time.deltaTime;
        if (timer >= showTimer)
        {
            HideWindow();
        }
    }
    public void HideWindow()
    {
        interactionsWindow.SetActive(false);
        isActive = false;
        currentInteraction = null;
        timer = 0;
    }

    public void ShowPossibleInteractions(InteractionHolder holder)
    {
        //Debug.LogWarning("IMPLEMENT ME");

        if(currentInteraction == holder)
        {
            if (holder.CheckIfDirty() == true)
            {
                //Debug.Log("ITS DIRTY");
                RecreateButtons(holder);
            }
            timer = 0;
        }
        else
        {
            //Debug.Log("ELSE");
            currentInteraction = holder;
            RecreateButtons(holder);
            //Debug.Log("Current interaction = " + currentInteraction);
        }
        
    }

    void RecreateButtons(InteractionHolder holder)
    {
        //Debug.Log("Recreating Buttons");
        foreach(Transform child in interactionsWindow.transform)
        {
            Destroy(child.gameObject);
        }

        int count = holder.GetPossibleInteractions().Count;
        GameObject tempCreatedObject;
        string tempTextInformation;
        int prefabToSpawn;
        for (int i = 0; i < count; i++)
        {
            prefabToSpawn = holder.GetPossibleInteractions()[i].GetDefaultInteractionKey();
            tempCreatedObject = Instantiate(prefabs[prefabToSpawn]);
            tempCreatedObject.transform.SetParent(interactionsWindow.transform);
            tempTextInformation = holder.GetPossibleInteractions()[i].GetInfoHolder().GetInformation();
            tempCreatedObject.GetComponentInChildren<UI_Data>().SetTextField(tempTextInformation);
        }

        currentInteraction.MarkAsClean();

        interactionsWindow.SetActive(true);
        isActive = true;
    }


}
