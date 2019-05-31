using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {

	private void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.CompareTag("Boll"))
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;

            //yield return new WaitForSeconds(2);

            SceneManager.LoadScene(sceneIndex);
        }
    }
}
