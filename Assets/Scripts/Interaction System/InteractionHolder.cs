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
    public void Interact(int x)
    {
        for(int i = 0; i < possibleInteractions.Count; i++)
        {
            if (possibleInteractions[i].GetDefaultInteractionKey() == x)
            {
                MarkAsDirty();
                possibleInteractions[x].Action_ActivateTrigger();
            }
        }
    }
    public void DisableInteraction(Interaction inter)
    {
        possibleInteractions.Remove(inter);
        disabledInteractions.Add(inter);

        MarkAsDirty();
    }
    public void EnableInteraction(Interaction inter)
    {
        //Debug.Log("Amount of interactions is =   " + possibleInteractions.Count + "  /  " + disabledInteractions.Count);
        //Debug.Log("Enabling Interaction = " + inter.gameObject);
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
}
