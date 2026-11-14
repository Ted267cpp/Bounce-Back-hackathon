using UnityEngine;

public class DieButPink : MonoBehaviour
{
    public bool IsTouched = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        IsTouched = true;
        Destroy(gameObject);
    }
}
