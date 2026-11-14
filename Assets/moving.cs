using UnityEngine;

public class moving : MonoBehaviour {
    public Rigidbody2D rd;
    public void OnRight() 
    {
        rd.AddForce(Vector2.right * 1f, ForceMode2D.Impulse);
    }
    public void OnLeft()
    {
        rd.AddForce(Vector2.left * 1f, ForceMode2D.Impulse);
    }
}
