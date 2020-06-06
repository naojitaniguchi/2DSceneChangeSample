using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChangeNo : MonoBehaviour
{
    public GameObject uiTop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonPushed()
    {
        uiTop.SetActive(false);
    }
}
