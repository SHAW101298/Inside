using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameVisibility : MonoBehaviour
{
    [Header("References")]
    public Light lightSource;
    public Transform cameraPosition;
    public Transform forwardPosition;
    public float dangerLevel;
    Vector3 followPosition;
    public LayerMask terrainLayer;
    [Header("Neutral")]
    public Color neutralColor;
    public float neutralRange;
    public float neutralIntensity;
    [Header("Danger")]
    public Color dangerColor;
    public float dangerRange;
    public float dangerIntensity;
    [Header("Current")]
    public Color currentColor;
    public float currentRange;
    public float currentIntensity;

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

        SetVisibilityAccordingToDanger();
    }

    void CalculateFollowPosition()
    {
        RaycastHit hitInfo;
        dir = forwardPosition.position - cameraPosition.position;
        if(Physics.Raycast(cameraPosition.position, dir, out hitInfo, 2, terrainLayer) == true)
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
        currentColor = Color.Lerp(neutralColor, dangerColor, dangerLevel);
        currentIntensity = Mathf.Lerp(neutralIntensity, dangerIntensity, dangerLevel);
        currentRange = Mathf.Lerp(neutralRange, dangerRange, dangerLevel);
        lightSource.range = currentRange;
        lightSource.intensity = currentIntensity;
        lightSource.color = currentColor;
    }

    public void EnteredDanger1()
    {
        dangerLevel = 1;
    }
    public void EnteredDanger2()
    {
        dangerLevel = 2;
    }
}
