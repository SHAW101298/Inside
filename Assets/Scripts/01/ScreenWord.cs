using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class ScreenWord : MonoBehaviour
{
    [SerializeField] TMP_Text textField;
    [SerializeField] float timeToLive;
    [SerializeField] float lifeTimer;
    [SerializeField] bool wordIsExpired;
    [Header("Word Movement")]
    [SerializeField] float erraticMovementAmount;
    [SerializeField] float normalMovemntValue;
    [Header("Transparency Control")]
    [SerializeField] float transparencyTimer;
    [SerializeField] float transparencyCeilingTime;
    [SerializeField] bool reverse;
    // Start is called before the first frame update

    private void Start()
    {
        transparencyCeilingTime = timeToLive / 2;
    }
    private void Update()
    {
        WordLife();
        ErraticMovement();
        WordTransparency();
    }

    public void WordLife()
    {
        lifeTimer += Time.deltaTime;

        if (lifeTimer >= timeToLive)
        {
            wordIsExpired = true;
        }
    }
    public void SetText(string tekst)
    {
        textField.text = tekst;
    }
    public void SetText(string tekst,float dangerLevel)
    {
        string modifiedText = "";
        float rand;
        float upperChance = dangerLevel / 2;
        for (int i = 0; i < tekst.Length; i++)
        {
            rand = Random.Range(0, 1f);
            if (rand <= upperChance)
            {
                modifiedText += System.Char.ToUpper(tekst[i]);
            }
            else
            {
                modifiedText += tekst[i];
            }
        }
        textField.text = modifiedText;
        timeToLive -= dangerLevel * 1.5f;
    }
    public bool CheckIfExpired()
    {
        return wordIsExpired;
    }
    public void ErraticMovement()
    {
        Vector3 mov = new Vector3();
        mov.x = Random.Range(-erraticMovementAmount, erraticMovementAmount);
        mov.y = Random.Range(-erraticMovementAmount, erraticMovementAmount);
        gameObject.transform.localPosition += mov;
    }
    void WordTransparency()
    {
        if(reverse == false)
        {
            transparencyTimer += Time.deltaTime;
            if(transparencyTimer >= transparencyCeilingTime)
            {
                transparencyTimer = transparencyCeilingTime;
                reverse = true;
            }
        }
        else
        {
            transparencyTimer -= Time.deltaTime;
        }
        textField.alpha = transparencyTimer / transparencyCeilingTime;
    }
}
