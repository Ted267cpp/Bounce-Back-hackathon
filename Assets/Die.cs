using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using UnityEngine.Timeline;
public class Die : MonoBehaviour
{
    // x<-9.1 x>9.6
    public Transform transform;
    public AudioSource audioSource;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<-9.1f || transform.position.x>9.6f || transform.position.y<-5.6)
        {
            reseter();
        }
    }
    void OnTriggerEnter2D(Collider2D collision) 
    {
        reseter();
    }
    void reseter() 
    {
        audioSource.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
