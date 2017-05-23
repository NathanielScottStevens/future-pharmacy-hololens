using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler 
{
    Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();    
    } 

    public void OnPointerEnter(PointerEventData eventData)
    {
        animator.SetBool("isMinimized", false);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        animator.SetBool("isMinimized", true);
    }
}