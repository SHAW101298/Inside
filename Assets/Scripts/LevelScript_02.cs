using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScript_02 : MonoBehaviour
{
    [SerializeField] GameObject missingPiece;
    [SerializeField] GameObject emptySpot;
    [SerializeField] GameObject emptySpotReadyForPiece;
    [SerializeField] GameObject filledSpot;

    [SerializeField] GameObject altarCrowsBefore;
    [SerializeField] GameObject altarCrowsAfter;

    [SerializeField] GameObject roadCrowsBefore;
    [SerializeField] GameObject roadCrowsAfter;

    [SerializeField] float fogAmountOnRoad;

    public bool foundMissingPiece;
    public bool placedMissingPiece;

    public void FoundMissingPiece()
    {
        missingPiece.SetActive(false);
        foundMissingPiece = true;
        emptySpotReadyForPiece.SetActive(true);
        emptySpot.SetActive(false);
        RenderSettings.fogEndDistance = 80;

        roadCrowsBefore.SetActive(false);
        roadCrowsAfter.SetActive(true);
    }

    public void PlacedMissingPiece()
    {
        placedMissingPiece = true;
        emptySpotReadyForPiece.SetActive(false);
        filledSpot.SetActive(true);
        altarCrowsBefore.SetActive(false);
        altarCrowsAfter.SetActive(true);
    }

    public void EnterTheRoad()
    {
        Debug.Log("Enter The road");
        RenderSettings.fogEndDistance = fogAmountOnRoad;
    }

}
