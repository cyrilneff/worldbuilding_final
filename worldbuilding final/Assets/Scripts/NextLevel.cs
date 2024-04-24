using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public int nextLevel = 1;
    // Start is called before the first frame update
    void Start()
    {
        nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
    }
    void OnTriggerEnter(Collider collision)
    {
// Application.LoadLevel(loadLevel);
        SceneManager.LoadScene(nextLevel);

    }

   
}
