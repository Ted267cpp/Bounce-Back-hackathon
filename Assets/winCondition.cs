using UnityEngine;

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
        if(transformWiner.position.x>=5.7 && transformWiner.position.y>=1.2)//5.7 1.2
        {
            firstWinCondition = true;
            dieButPink.IsTouched = true;
        }
        if (transform.position.x <= -4.3 && transform.position.y <= -1.9 && firstWinCondition == true)//4.3 1.9
        {
            secondWinCondition = true;
        }
    }
}
