using UnityEngine;
using UnityEngine.SceneManagement;
public class winCondition : MonoBehaviour
{
    public Transform transformWiner;
    private bool firstWinCondition = false;
    public bool secondWinCondition = false;
    DieButPink dieButPink;
    private void Start()
    {
        transformWiner = GameObject.Find("Player").transform;
        dieButPink = GameObject.Find("Pink ball").GetComponent<DieButPink>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (transformWiner.position.x <= -7 && transformWiner.position.y <= -1.9 && dieButPink.IsTouched == true)//4.3 1.9
        {
            SceneManager.LoadScene("Level 2");
        }
    }
}
