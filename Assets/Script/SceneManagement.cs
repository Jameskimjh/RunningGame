using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagement : MonoBehaviour
{
 
    // Update is called once per frame
    void Update()
    {
        
    }
    public void MainScene()
    {
        SceneManager.LoadScene("Main");
    }
}
