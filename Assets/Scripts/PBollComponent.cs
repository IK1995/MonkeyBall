using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PBollComponent : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text GOALText;

    private Rigidbody rb;
    private int count;
    private int ch = 0;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        count = 0;
        GOALText.text = "";
        SetCountText();
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
	}
    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bananas"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText ();
        }
        if (other.gameObject.CompareTag("GOAL"))
        {
            ch = 1;
            SetCountText();
            //int sceneIndex = SceneManager.GetActiveScene().buildIndex;

            yield return new WaitForSeconds(2);

            SceneManager.LoadScene("Coas2");
        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            ch = 2;
            SetCountText();
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;

            yield return new WaitForSeconds(2);

            SceneManager.LoadScene(sceneIndex);
        }

    }
    void SetCountText()
    {
        countText.text = "Banana: " + count.ToString();
        if (ch == 1)
        {
            GOALText.text = "GOAL!!";
        }else if (ch == 2)
        {
            GOALText.text = "Game Over!";
        }
    }
}
