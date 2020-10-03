﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Event : MonoBehaviour
{
    private BoxCollider2D eventTrigger;

    [SerializeField]
    protected float eventRange = 2f;

    // Start is called before the first frame update
    public virtual void Start()
    {
        eventTrigger = GetComponent<BoxCollider2D>();
        eventTrigger.size = new Vector2(eventRange, eventRange);
        eventTrigger.isTrigger = true;
    }

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            EventTrigger();
        }
    }

    protected void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            EventExit();
        }
    }

    public virtual void EventTrigger()
    {
        Debug.Log("Enter");
    }

    public virtual void EventExit()
    {

    }
}
