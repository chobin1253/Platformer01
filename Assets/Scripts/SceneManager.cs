using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MySceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("Level1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
