using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelProgression : MonoBehaviour
{
    [SerializeField]
    string strTag;
    static int counter = 1; 

    private void OnCollisionEnter(Collision collision)
    {
        counter++;

        if (counter == 2 && collision.collider.tag == strTag)
        {
            SceneManager.LoadScene("Level 2");
        } else if (counter == 3 && collision.collider.tag == strTag)
        {
            SceneManager.LoadScene("Level 3");
        } else if (counter == 4 && collision.collider.tag == strTag)
        {
            SceneManager.LoadScene("Level 4");
        } else if (counter > 4 && collision.collider.tag == strTag)
        {
            SceneManager.LoadScene("End");
        }

    }
}
