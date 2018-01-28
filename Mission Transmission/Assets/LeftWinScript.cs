using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeftWinScript : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
        StartCoroutine(LoadSceneAfterDelay(3));

    }

    IEnumerator LoadSceneAfterDelay(float waitbySecs)
    {

        yield return new WaitForSeconds(waitbySecs);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }	
	
}
