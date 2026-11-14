using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToH2P : MonoBehaviour
{
    public void Learn() 
    {
        SceneManager.LoadSceneAsync("H2P");
    }
}
