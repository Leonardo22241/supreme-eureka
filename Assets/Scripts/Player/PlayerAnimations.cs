﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum InteractionType
{
    Work = 0,
    Drink = 1,
    Chat = 2,
    Copy = 3
}

public class PlayerAnimations : MonoBehaviour
{
    Animator animator;
    
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void TriggerInteraction(InteractionType interactionType)
    {
        animator.SetTrigger("Interact");
        switch (interactionType)
        {
            //Working
            case InteractionType.Work:
                {
                    animator.SetBool("Work",true);
                    break;
                }
            //Drinking
            case InteractionType.Drink:
                {
                    animator.SetBool("Drink", true);
                    break;
                }
            //Speaking
            case InteractionType.Chat:
                {
                    //coming soon...
                    break;
                }
            //Copying
            case InteractionType.Copy:
                {
                    //
                    break;
                }
        }
    }
    
    public void StopDrinking()
    {
        animator.SetBool("Drink", false);
    }

    public void StopWorking()
    {
        animator.SetBool("Work", false);
    }
    
}