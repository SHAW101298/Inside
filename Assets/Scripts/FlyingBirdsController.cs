using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBirdsController : MonoBehaviour
{
    [SerializeField] List<BirdFlyingOverhead> activeBirds;
    [SerializeField] List<BirdFlyingOverhead> inactiveBirds;
    [SerializeField] int desiredAmountOfActiveBirds;
    [SerializeField] int amountOfActiveBirds;

    private void Start()
    {
        int rand;
        for(int i = 0; i < desiredAmountOfActiveBirds; i++)
        {
            ActivateRandomBird();
        }
        foreach(BirdFlyingOverhead bird in activeBirds)
        {
            bird.gameObject.SetActive(true);
            bird.GetNewDestination();
        }
    }

    public void MarkMeAsInactive(BirdFlyingOverhead bird)
    {
        activeBirds.Remove(bird);
        inactiveBirds.Add(bird);
        bird.gameObject.SetActive(false);
        amountOfActiveBirds--;

        if(amountOfActiveBirds < desiredAmountOfActiveBirds)
        {
            ActivateRandomBird();
        }
    }
    public void ActivateRandomBird()
    {
        int rand = Random.Range(0, inactiveBirds.Count);
        //Debug.Log("rand = " + rand);
        BirdFlyingOverhead bird = inactiveBirds[rand];
        //Debug.Log("bird = " + bird.gameObject.name);

        activeBirds.Add(bird);
        inactiveBirds.Remove(bird);

        bird.gameObject.SetActive(true);
        bird.GetNewDestination();
        amountOfActiveBirds++;

    }

}
