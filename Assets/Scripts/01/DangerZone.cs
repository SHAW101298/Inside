using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerZone : MonoBehaviour
{
    [SerializeField] FlameVisibility flame;

    [SerializeField] Transform startPosition;
    [SerializeField] Transform endPosition;
    bool isActive;
    [SerializeField] List<AudioSource> whisperSources;
    [SerializeField] List<AudioSourceController> audioControllers;
    [SerializeField] float maxTimeDifference;
    [SerializeField] float minTimeDifference;
    [Space(15)]
    [SerializeField] bool moveEndPosition;
    [SerializeField] bool moveStartPosition;
    [SerializeField] Transform endPosition1;
    [SerializeField] Transform startPosition1;
    Vector3 endVel;
    Vector3 startVel;
    float moveTimer;
    float timeDifference;
    float timer;
    bool startTimer;
    int lastIndex;
    public float currentDangerLevel;
    float distanceBetweenPoints;
    bool reachedMaxDangerArea;
    PlayerData playerData;

    private void Start()
    {
        playerData = PlayerData.instance;
        distanceBetweenPoints = Vector3.Distance(startPosition.position, endPosition.position);
    }
    private void Update()
    {
        if(isActive == true)
        {
            foreach(AudioSource source in whisperSources)
            {
                source.volume = flame.dangerLevel;
            }
            foreach (AudioSourceController source in audioControllers)
            {
                source.ChangeDesiredVolume(flame.dangerLevel);
            }
            EndPointMovement();
            StartPointMovement();
        }
        SetRandomStartTimers();
        CalculateDanger();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            ActivateDangerZone();
        }
    }
    public void RecalculateDistanceBetweenPoints()
    {
        distanceBetweenPoints = Vector3.Distance(startPosition.position, endPosition.position);
    }
    public void ActivateDangerZone()
    {
        //flame.SetAsCurrentDanger(startPosition.position, endPosition.position);
        flame.SetAsCurrentDanger(this);
        isActive = true;
        startTimer = true;
        timer = 0;
        timeDifference = Random.Range(minTimeDifference, maxTimeDifference);
        lastIndex = 0;
    }
    public void DisableDangerZone()
    {
        isActive = false;
        startTimer = false;
        timer = 0;
        lastIndex = 0;
        flame.dangerLevel = 0;
        
        foreach (AudioSource source in whisperSources)
        {
            source.volume = flame.dangerLevel;
        }
        foreach (AudioSourceController source in audioControllers)
        {
            source.ChangeDesiredVolume(flame.dangerLevel);
        }
    }
    void CalculateDanger()
    {
        if(reachedMaxDangerArea == true)
        {
            return;
        }

        float dist = Vector3.Distance(playerData.transform.position, endPosition.position);
        currentDangerLevel = ((dist - distanceBetweenPoints) * -1) / distanceBetweenPoints;
        if (currentDangerLevel < 0)
            currentDangerLevel = 0;
    }

    public void EnterMaxDangerArea()
    {
        reachedMaxDangerArea = true;
        currentDangerLevel = 1;
    }
    public void LeftMaxDangerArea()
    {
        reachedMaxDangerArea = false;
    }


    void SetRandomStartTimers()
    {
        if (startTimer == true)
        {
            timer += Time.deltaTime;
            if(timer >= timeDifference)
            {
                timer -= timeDifference;
                timeDifference = Random.Range(minTimeDifference, maxTimeDifference);
                audioControllers[lastIndex].gameObject.SetActive(true);
                lastIndex++;
                Debug.Log("Time Difference = " + timeDifference);
                if(lastIndex >= whisperSources.Count)
                {
                    startTimer = false;
                    timer = 0;
                }
            }
        }
    }
    void EndPointMovement()
    {
        if(moveEndPosition == true)
        {
            endPosition.transform.position = Vector3.SmoothDamp(endPosition.position, endPosition1.position, ref endVel, 2f);
            if(Vector3.Distance(endPosition.position, endPosition1.position) <= 0.2f)
            {
                moveEndPosition = false;
            }
        }
        
    }
    void StartPointMovement()
    {
        if (moveStartPosition == true)
        {
            startPosition.transform.position = Vector3.SmoothDamp(startPosition.position, startPosition1.position, ref startVel, 2f);
            if (Vector3.Distance(startPosition.position, startPosition1.position) <= 0.2f)
            {
                moveStartPosition = false;
            }
        }
    }
}
