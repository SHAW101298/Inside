using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionPositionTip : MonoBehaviour
{
    [SerializeField] Transform playerEyeLevel;
    [SerializeField] Transform spriteObject;

    [SerializeField] float maxSizeDistance;
    [SerializeField] float startShowingDistance;
    float calculatedSize;
    float distance;


    // Start is called before the first frame update
    void Start()
    {
        GetReferenceToPlayer();
        GetReferenceToImage();
    }

    // Update is called once per frame
    void Update()
    {
        CalculateDistance();
    }
    void CalculateDistance()
    {

        // If not close enough, scale is 0
        // Once reach min distance, start scaling upwards
        // Once reach max distance, stop scaling
        distance = Vector3.Distance(transform.position, playerEyeLevel.position);

        if (distance > startShowingDistance)
        {
            spriteObject.transform.localScale = Vector3.zero;
            return;
        }
        distance -= startShowingDistance;
        calculatedSize = -distance / maxSizeDistance;

        if (calculatedSize >= 1)
            calculatedSize = 1;
        
        spriteObject.transform.localScale = new Vector3(calculatedSize, calculatedSize, calculatedSize);

    }
    void GetReferenceToPlayer()
    {
        if(playerEyeLevel == null)
        {
            playerEyeLevel = PlayerData.instance.cam.transform;
        }
    }
    void GetReferenceToImage()
    {
        if(spriteObject == null)
        {
            spriteObject = GetComponentInChildren<RotToPlayer>().gameObject.transform;
        }
    }
}
