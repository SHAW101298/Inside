using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScript_02 : MonoBehaviour
{
    [Header("References")]
    [SerializeField] GameObject missingPiece;
    [SerializeField] GameObject emptySpot;
    [SerializeField] GameObject emptySpotReadyForPiece;
    [SerializeField] GameObject filledSpot;
    [SerializeField] AudioSource musicAudioSource;
    [Header("After placing Missing Piece")]
    [SerializeField] List<GameObject> objectsBeforePlacingPiece;
    [SerializeField] List<GameObject> objectsAfterPlacingPiece;
    [SerializeField] Animator doorAnimator;
    [Header("Character Slow Change")]
    [SerializeField] SkinnedMeshRenderer characterMeshRenderer;
    [SerializeField] Material transparentMaterial;
    [SerializeField] float currentAlpha;
    [Header("Checkers")]
    public bool foundMissingPiece;
    public bool placedMissingPiece;


    public void FoundMissingPiece()
    {
        missingPiece.SetActive(false);
        foundMissingPiece = true;
        emptySpotReadyForPiece.SetActive(true);
        emptySpot.SetActive(false);
        characterMeshRenderer.material = transparentMaterial;
    }

    public void PlacedMissingPiece()
    {
        placedMissingPiece = true;
        emptySpotReadyForPiece.SetActive(false);
        filledSpot.SetActive(true);

        foreach(GameObject obj in objectsBeforePlacingPiece)
        {
            obj.SetActive(false);
        }
        foreach(GameObject obj in objectsAfterPlacingPiece)
        {
            obj.SetActive(true);
        }
        //DialogManager.Instance.ShowText(98);
    }
    public void OpenDoorFirstTime()
    {
        doorAnimator.SetTrigger("Open");
    }

    public void ModifyCharacterTransparency(float amount)
    {
        currentAlpha -= amount;
        Color color = transparentMaterial.color;
        color.a = currentAlpha;
        transparentMaterial.color = color;
    }
}