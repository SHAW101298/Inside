using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialAnimationState : MonoBehaviour
{
    [SerializeField] string boolParameter;
    [SerializeField] bool boolDesiredState;
    [Space(15)]
    [SerializeField] bool destroyAfterApplying;
    [SerializeField] bool applyImmidately;

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        if(applyImmidately == true)
        {
            ApplyState();
        }
    }

    public void ApplyState()
    {
        anim.SetBool(boolParameter, boolDesiredState);

        if (destroyAfterApplying == true)
        {
            Destroy(this);
        }
    }
}
