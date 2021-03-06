﻿using UnityEngine;


public enum PointerType
{
    FButton = 0,
    TaskArrow = 1,
}


public class Pointer : MonoBehaviour
{
    // Up - true, down - false
    private bool _iconDirection = true;
    
    [SerializeField]
    private SpriteRenderer _spriteRenderer;
    [SerializeField]
    protected Sprite taskArrow;
    [SerializeField]
    protected Sprite fButton;

    [SerializeField] protected float iconAmplitude;
    [SerializeField] protected float iconMovementSpeed;
    [SerializeField] protected Vector3 delta;
    

    private void Start()
    {
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        
        transform.localPosition = delta; 
        SetState(true);
    }
    
    private void Update()
    {
        if (_iconDirection) 
            _spriteRenderer.transform.localPosition += Vector3.up * (Time.deltaTime * iconMovementSpeed);
        else
            _spriteRenderer.transform.localPosition += Vector3.down * (Time.deltaTime * iconMovementSpeed);

        var yPosition = _spriteRenderer.transform.localPosition.y - delta.y;
        if (yPosition > iconAmplitude / 2 || yPosition < -iconAmplitude / 2)
            _iconDirection = !_iconDirection;
    }

    public void SetState(bool state)
    {
        _spriteRenderer.enabled = state;
    }

    public void SetPointer(PointerType type)
    {
        switch (type)
        {
            case PointerType.FButton:
                _spriteRenderer.sprite = fButton;
                break;
            
            case PointerType.TaskArrow:
                _spriteRenderer.sprite = taskArrow;
                break;
        }
    }
    
}