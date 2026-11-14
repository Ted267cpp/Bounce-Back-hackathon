using UnityEngine;

public class DieButPink : MonoBehaviour
{
    public bool IsTouched = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(IsTouched)
        {
            Destroy(gameObject);
        }   
    }
}
