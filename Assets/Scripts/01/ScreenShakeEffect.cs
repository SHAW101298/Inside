using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShakeEffect : MonoBehaviour
{
    [Header("References")]
    [SerializeField] FlameVisibility flame;
    [SerializeField] Transform target;
    [Header("Values")]
    [SerializeField] float maxScreenMovement;
    float desiredScreenMovement;
    [SerializeField] bool isShaking;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isShaking == true)
        {
            desiredScreenMovement = (flame.dangerLevel * 0.8f)* maxScreenMovement;
            Vector3 rand = new Vector3();
            rand.x = Random.Range(-desiredScreenMovement, desiredScreenMovement);
            rand.y = Random.Range(-desiredScreenMovement, desiredScreenMovement);
            rand.z = Random.Range(-desiredScreenMovement, desiredScreenMovement);

            target.transform.localEulerAngles = rand;
        }
    }
}
