using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

public class moving : MonoBehaviour {
    public Rigidbody2D rb;
    private bool isRightPressed;
    private bool isLeftPressed;
    private Player _controls; // player e un input system
    private void Awake()
    {
        _controls = new Player();
    }
    private void Update()
    {
        isRightPressed = _controls.Ball.Right.ReadValue<float>() > 0;
        isLeftPressed = _controls.Ball.Left.ReadValue<float>() > 0;
    }
    private void FixedUpdate()
    {
        if (isRightPressed)
        {
            rb.AddForce(Vector2.right * 0.1f, ForceMode2D.Impulse);
        }
        if (isLeftPressed)
        {
            rb.AddForce(Vector2.left * 0.1f, ForceMode2D.Impulse);
        }
    }
    private void OnEnable()
    {
        _controls.Enable();
    }
    private void OnDisable()
    {
        _controls.Disable();    
    }
}
