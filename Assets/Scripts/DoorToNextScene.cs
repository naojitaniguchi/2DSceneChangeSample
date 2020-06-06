using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorToNextScene : MonoBehaviour
{
    public string nextScene;
    public string nextSceneDispName;
    public GameObject uiObject;
    public GameObject uiTextObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.gameObject.tag == "Player")
        {
            GlobalVariable.prevScene = SceneManager.GetActiveScene().name;
            if ( uiObject != null)
            {
                collision.gameObject.GetComponent<Player>().nextScene = nextScene;
                uiTextObject.GetComponent<Text>().text = nextSceneDispName + "に入りますか";
                uiObject.SetActive(true);
            }
            else
            {
                SceneManager.LoadScene(nextScene);
            }
        }
    }
}
