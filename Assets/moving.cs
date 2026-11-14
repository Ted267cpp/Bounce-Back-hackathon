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
    private Player _controls;
    private void Awake()
    {
        _controls = new Player();
    }
    public void OnRight() 
    {
        rb.AddForce(Vector2.right * 1f, ForceMode2D.Impulse);
    }
    public void OnLeft()
    {
        rb.AddForce(Vector2.left * 1f, ForceMode2D.Impulse);
    }
}
