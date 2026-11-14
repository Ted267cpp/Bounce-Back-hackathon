using UnityEngine;

public class winCondition : MonoBehaviour
{
    public Transform transformWiner;
    private bool firstWinCondition = false;
    private bool secondWinCondtion = false;
    private void Start()
    {
        transformWiner = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(transformWiner.position.x>=5.7 && transformWiner.position.y>=1.2)//5.7 1.2
        {
            firstWinCondition = true;
        }
        if (transform.position.x <= -4.3 && transform.position.y <= -1.9 && firstWinCondition == true)//4.3 1.9
        {
            secondWinCondtion = true;
        }
    }
}
