using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InteractionHolder : MonoBehaviour
{
    // Holds the possible interactions and manages which one is chosen by the player
    // UI will need to be flexible about how many options to show. So we need flexible data pass

    [SerializeField] List<Interaction> possibleInteractions;
    [SerializeField] List<Interaction> disabledInteractions;

    bool isDirty;

    private void Start()
    {
        foreach(Interaction interaction in possibleInteractions)
        {
            interaction.EnableUITipObject();
        }
        foreach (Interaction interaction in disabledInteractions)
        {
            interaction.DisableUITipObject();
        }
    }

    public void RemoveInteraction(Interaction interaction)
    {
        possibleInteractions.Remove(interaction);
        disabledInteractions.Remove(interaction);

        MarkAsDirty();
    }
    public void AddInteraction(Interaction interaction)
    {
        possibleInteractions.Add(interaction);
        MarkAsDirty();
    }
    public void AddInteraction(Interaction interaction, bool state)
    {
        if(state == true)
        {
            possibleInteractions.Add(interaction);
            MarkAsDirty();
        }
        else
        {
            disabledInteractions.Add(interaction);
        }
    }
    public List<Interaction> GetPossibleInteractions()
    {
        return possibleInteractions;
    }
    public List<Interaction> GetDisabledInteractions()
    {
        return disabledInteractions;
    }
    public int GetPossibleInteractionsCount()
    {
        return possibleInteractions.Count;
    }
    public int GetDisabledInteractionsCount()
    {
        return disabledInteractions.Count;
    }
    public void Interact(int x)
    {
        //DEBUG_DropInfoAboutInteractions();
        //DEBUG_DetailedInfoAboutInteractions();
        for(int i = 0; i < possibleInteractions.Count; i++)
        {
            int y = possibleInteractions[i].GetDefaultInteractionKey();
            if (x == y)
            {
                //Debug.Log("Found matching interaction");
                MarkAsDirty();
                possibleInteractions[i].Action_ActivateTrigger();
            }
        }
    }
    public void DisableInteraction(Interaction inter)
    {
        if (disabledInteractions.Contains(inter))
        {
            MarkAsDirty();
            return;
        }

        possibleInteractions.Remove(inter);
        disabledInteractions.Add(inter);

        MarkAsDirty();
    }
    public void DisableAllInteractions()
    {
        foreach(Interaction interaction in possibleInteractions)
        {
            interaction.Action_DisableInteraction();
        }
    }
    public void EnableAllInteractions()
    {
        foreach (Interaction interaction in disabledInteractions)
        {
            interaction.Action_EnableInteraction();
        }
    }
    public void EnableInteraction(Interaction inter)
    {
        //Debug.Log("Amount of interactions is =   " + possibleInteractions.Count + "  /  " + disabledInteractions.Count);
        //Debug.Log("Enabling Interaction = " + inter.gameObject);
        if(possibleInteractions.Contains(inter))
        {
            MarkAsDirty();
            return;
        }

        disabledInteractions.Remove(inter);
        possibleInteractions.Add(inter);

        MarkAsDirty();
    }
    public bool CheckIfDirty()
    {
        return isDirty;
    }
    public void MarkAsClean()
    {
        isDirty = false;
    }
    public void MarkAsDirty()
    {
        isDirty = true;
    }
    public void DEBUG_DropInfoAboutInteractions()
    {
        string state;
        if(CheckIfDirty() == true)
        {
            state = "TRUE";
        }
        else
        {
            state = "FALSE";
        }
        Debug.Log(gameObject.name + " || Amount =  " + possibleInteractions.Count + " / " + disabledInteractions.Count + "  || STATE = " + state) ;
    }
    public void DEBUG_DetailedInfoAboutInteractions()
    {
        Debug.Log("Possible Interactions is =" + possibleInteractions.Count);
        for(int i = 0; i < possibleInteractions.Count; i++)
        {
            Debug.Log(i + " | " + possibleInteractions[i].DEBUG_DropInfo());
            
        }
        Debug.Log("Disabled Interactions is =" + disabledInteractions.Count);
        for(int i = 0; i < disabledInteractions.Count; i++)
        {
            Debug.Log(i + " | " + disabledInteractions[i].DEBUG_DropInfo());
        }
    }
    public void ACTION_DestroyHolderObject()
    {
        foreach(Interaction interaction in possibleInteractions)
        {
            interaction.DestroyUITipObject();
        }
        foreach(Interaction interaction in disabledInteractions)
        {
            interaction.DestroyUITipObject();
        }
        Destroy(gameObject);
    }
    public void ACTION_DisableHolderObject()
    {
        foreach (Interaction interaction in possibleInteractions)
        {
            interaction.DisableUITipObject();
        }
        foreach (Interaction interaction in disabledInteractions)
        {
            interaction.DisableUITipObject();
        }
        gameObject.SetActive(false);
    }
}
