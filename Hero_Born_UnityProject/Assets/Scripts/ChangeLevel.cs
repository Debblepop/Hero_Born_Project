using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    int buildindex;
    // Start is called before the first frame update
    void Start()
    {
        buildindex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("build index: " + buildindex);
    }

    // Update is called once per frame
    void Update()
    {
 
        
    }

    void OnTriggerEnter(Collider myCollision)
    {
        SceneManager.LoadScene(buildindex + 1);
    }
}
