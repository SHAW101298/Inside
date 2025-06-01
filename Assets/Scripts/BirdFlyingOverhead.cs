using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BirdFlyingOverhead : MonoBehaviour
{
    [Header("References")]
    [SerializeField] FlyingBirdsController controller;
    [SerializeField] Animator anim;
    [SerializeField] Transform startPosition;
    [SerializeField] List<Transform> possibleDestinations;

    [Header("Data")]
    [SerializeField] float speed;
    [SerializeField] Vector3 direction;
    [SerializeField] Vector3 destination;

    public UnityEvent EVENT_ReachedDestination;
    float dist;

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime * direction;
        dist = Vector3.Distance(transform.position, destination);

        if(dist <= 2f)
        {
            EVENT_ReachedDestination.Invoke();
            controller.MarkMeAsInactive(this);
        }
        
    }
    public void GetNewDestination()
    {
        int rand = Random.Range(0, possibleDestinations.Count);
        destination = possibleDestinations[rand].position;
        transform.position = startPosition.position;
        direction = (destination - transform.position).normalized;
        transform.LookAt(destination);
        anim.SetBool("Flying", true);
    }
    public void TriggerDestruction()
    {
        Destroy(gameObject);
    }

}
