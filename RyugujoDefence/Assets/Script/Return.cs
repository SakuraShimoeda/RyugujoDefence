using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

public class Return : MonoBehaviour
{

  
    public int timeCount;

    void Start()
    {

        
        Invoke("GoTitle", timeCount);
    }
    
    void GoTitle()
    {
        SceneManager.LoadScene("Title");
    }
}
