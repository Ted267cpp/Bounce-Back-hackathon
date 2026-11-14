using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;  

public class moving : MonoBehaviour {
    public Rigidbody2D rb;
    InputSystem InputActions;
    public void OnRight() 
    {
        rb.AddForce(Vector2.right * 1f, ForceMode2D.Impulse);
    }
    public void OnLeft()
    {
        rb.AddForce(Vector2.left * 1f, ForceMode2D.Impulse);
    }
}
