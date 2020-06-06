using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 0.3f;
    public string[] prevScenes;
    public GameObject[] sceneStartPosObjects;
    public string nextScene;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(GlobalVariable.prevScene);
        if (prevScenes != null)
        {
            for (int i = 0; i < prevScenes.Length; i++)
            {
                if (prevScenes[i] == GlobalVariable.prevScene)
                {
                    gameObject.transform.position = sceneStartPosObjects[i].transform.position;
                    break;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(speed * Time.deltaTime * -1.0f, 0.0f, 0.0f);
        }
    }

    public void SceneChangeYes()
    {
        if ( nextScene != null)
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
