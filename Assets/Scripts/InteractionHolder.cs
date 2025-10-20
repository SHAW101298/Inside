using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionHolder : MonoBehaviour
{
    // Holds the possible interactions and manages which one is chosen by the player
    // UI will need to be flexible about how many options to show. So we need flexible data pass

    [SerializeField] List<Interaction> possibleInteractions;



}
