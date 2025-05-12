using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_MenuButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] float scaleModifier;
    [SerializeField] RectTransform rect;
    public void OnPointerEnter(PointerEventData eventData)
    {
        rect.localScale = Vector3.one * scaleModifier;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        rect.localScale = Vector3.one;
    }
}
