using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_MenuButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] float scaleModifier;
    [SerializeField] RectTransform rect;
    [SerializeField] AudioSource source;
    public void OnPointerEnter(PointerEventData eventData)
    {
        rect.localScale = Vector3.one * scaleModifier;
        float randPitch = Random.Range(-0.15f, 0.15f);
        float randSpan = Random.Range(-0.4f, 0.4f);
        source.pitch = 1 + randPitch;
        source.panStereo = randSpan;
        source.Play();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        rect.localScale = Vector3.one;
    }
}
