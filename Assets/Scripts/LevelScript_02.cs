using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScript_02 : MonoBehaviour
{
    [SerializeField] GameObject missingPiece;
    [SerializeField] GameObject emptySpot;
    [SerializeField] GameObject emptySpotReadyForPiece;
    [SerializeField] GameObject filledSpot;

    [SerializeField] GameObject roadCrowsBefore;
    [SerializeField] GameObject roadCrowsAfter;
    [Header("After placing Missing Piece")]
    [SerializeField] List<GameObject> objectsBeforePlacingPiece;
    [SerializeField] List<GameObject> objectsAfterPlacingPiece;

    [Header("Checkers")]
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

        foreach(GameObject obj in objectsBeforePlacingPiece)
        {
            obj.SetActive(false);
        }
        foreach(GameObject obj in objectsAfterPlacingPiece)
        {
            obj.SetActive(true);
        }
    }

    public void EnterTheRoad()
    {
        Debug.Log("Enter The road");
        RenderSettings.fogEndDistance = fogAmountOnRoad;
    }

}
