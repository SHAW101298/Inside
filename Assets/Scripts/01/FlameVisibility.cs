using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameVisibility : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Light lightSource;
    [SerializeField] Transform cameraPosition;
    [SerializeField] Transform forwardPosition;
    [SerializeField] Transform playerPosition;
    [SerializeField] DangerZone currentDangerZone;
    public float dangerLevel;
    Vector3 followPosition;
    [SerializeField] LayerMask terrainLayer;
    [SerializeField] float raycastDistance;
    [Header("Neutral")]
    [SerializeField] Color neutralColor;
    [SerializeField] float neutralRange;
    [SerializeField] float neutralIntensity;
    [Header("Danger")]
    [SerializeField] Color dangerColor;
    [SerializeField] float dangerRange;
    [SerializeField] float dangerIntensity;
    [Header("Current")]
    [SerializeField] Color currentColor;
    [SerializeField] float currentRange;
    [SerializeField] float currentIntensity;
    [Space(10)]
    [SerializeField] Vector3 startPosition;
    [SerializeField] Vector3 endPosition;
    [SerializeField] float dangerDistance;
    [SerializeField] bool inDanger;

    [Header("Debug")]
    [SerializeField] Vector3 velocity;
    [SerializeField] float smoothTime;
    [SerializeField] Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CalculateFollowPosition();

        gameObject.transform.position = Vector3.SmoothDamp(gameObject.transform.position, followPosition,ref velocity, smoothTime);

        if(inDanger == true)
        {
            //CalculateDangerLevel();
            SetVisibilityAccordingToDanger();
        }
    }

    void CalculateFollowPosition()
    {
        RaycastHit hitInfo;
        dir = forwardPosition.position - cameraPosition.position;
        if(Physics.Raycast(cameraPosition.position, dir, out hitInfo, raycastDistance, terrainLayer) == true)
        {
            followPosition = hitInfo.point - (dir*0.2f);
        }
        else
        {
            followPosition = forwardPosition.position;
        }
    }
    void SetVisibilityAccordingToDanger()
    {
        dangerLevel = currentDangerZone.currentDangerLevel;
        currentColor = Color.Lerp(neutralColor, dangerColor, dangerLevel);
        currentIntensity = Mathf.Lerp(neutralIntensity, dangerIntensity, dangerLevel);
        currentRange = Mathf.Lerp(neutralRange, dangerRange, dangerLevel);
        lightSource.range = currentRange;
        lightSource.intensity = currentIntensity;
        lightSource.color = currentColor;
    }
    
    public void SetAsCurrentDanger(Vector3 start, Vector3 end)
    {
        startPosition = start;
        endPosition = end;
        dangerDistance = Vector3.Distance(startPosition, endPosition);
        inDanger = true;
    }
    public void SetAsCurrentDanger(DangerZone zone)
    {
        currentDangerZone = zone;
        inDanger = true;
    }
    public void ExitDanger()
    {
        inDanger = false;
        lightSource.range = neutralRange;
        lightSource.intensity = neutralIntensity;
        lightSource.color = neutralColor;
        dangerLevel = 0;
    }    
    
    void CalculateDangerLevel()
    {
        float playerDist = Vector3.Distance(startPosition, playerPosition.position);

        //Debug.Log("Playedist = " + playerDist);
        dangerLevel = playerDist / dangerDistance;
    }
}
