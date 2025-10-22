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


    public void RemoveInteraction(Interaction interaction)
    {
        possibleInteractions.Remove(interaction);
        disabledInteractions.Remove(interaction);
    }
    public void AddInteraction(Interaction interaction)
    {
        possibleInteractions.Add(interaction);
    }
    public void AddInteraction(Interaction interaction, bool state)
    {
        if(state == true)
        {
            possibleInteractions.Add(interaction);
            interaction.ChangeActiveState(true);
        }
        else
        {
            disabledInteractions.Add(interaction);
            interaction.ChangeActiveState(false);
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
        if (possibleInteractions[x] == null)
            return;
        possibleInteractions[x].Action_ActivateTrigger();
    }
    public void DisableInteraction(Interaction inter)
    {
        possibleInteractions.Remove(inter);
        disabledInteractions.Add(inter);
    }
}
