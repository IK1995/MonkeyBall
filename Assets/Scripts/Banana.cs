using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : MonoBehaviour {

    public int p = 0;
    public int ch = 1;
	// Update is called once per frame
	void Update () {
        Transform Bananatrans = this.transform;

        Vector3 pos = Bananatrans.position;

        if (ch == 1)
        {
            p++;
            pos.y += 0.005f;
            if (p == 60) ch = -1;
        }
        else
        {
            p--;
            pos.y -= 0.005f;
            if (p == -60) ch = 1;
        }

        Bananatrans.position = pos;

        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}
}
