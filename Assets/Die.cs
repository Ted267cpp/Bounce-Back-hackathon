using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
public class Die : MonoBehaviour
{
    // x<-9.1 x>9.6
    public Transform transform;
    OnTriggerEnter2D enter2D;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<-9.1f || transform.position.x>9.6f || transform.position.y<-5.6)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    void OnTriggerEnter2D(Collider2D collision) 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
