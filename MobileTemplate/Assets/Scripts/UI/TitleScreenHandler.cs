using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleScreenHandler : MonoBehaviour {

    private SceneLoader sceneLoader;
    private Button button;

    public string FirstLevelName;
	// Use this for initialization
	void Start () {
        sceneLoader = (SceneLoader)GameObject.FindGameObjectWithTag("Loader").GetComponent("SceneLoader");
        button = (Button)gameObject.GetComponent("Button");

        button.onClick.AddListener(() => sceneLoader.LoadScene(FirstLevelName));
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    

    
}
