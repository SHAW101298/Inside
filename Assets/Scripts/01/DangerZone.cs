using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerZone : MonoBehaviour
{
    [SerializeField] FlameVisibility flame;

    [SerializeField] Transform startPosition;
    [SerializeField] bool isActive;

    private void Update()
    {
        if(isActive == true)
        {

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            flame.EnteredDanger1();
        }
    }
}
