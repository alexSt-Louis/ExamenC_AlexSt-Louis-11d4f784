using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
 public void ChangementScenes(string ExamenC_02){
    SceneManager.LoadScene(ExamenC_02);
}   
}
