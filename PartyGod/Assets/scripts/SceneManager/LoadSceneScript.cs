using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadSceneScript : MonoBehaviour {
    public int sceneToLoad;
    public PersistentObject Script;
	public void LoadScene()
    {
        if (sceneToLoad <= Script.availibleScene) {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
