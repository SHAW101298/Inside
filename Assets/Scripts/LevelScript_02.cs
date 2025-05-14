using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScript_02 : MonoBehaviour
{
    [SerializeField] GameObject missingPiece;
    [SerializeField] GameObject emptySpot;
    [SerializeField] GameObject emptySpotReadyForPiece;
    [SerializeField] GameObject filledSpot;

    [SerializeField] List<GameObject> altarCrows;

    public bool foundMissingPiece;
    public bool placedMissingPiece;

    public void FoundMissingPiece()
    {
        missingPiece.SetActive(false);
        foundMissingPiece = true;
        emptySpotReadyForPiece.SetActive(true);
        emptySpot.SetActive(false);
    }

    public void PlacedMissingPiece()
    {
        placedMissingPiece = true;
        emptySpotReadyForPiece.SetActive(false);
        filledSpot.SetActive(true);
    }

}
