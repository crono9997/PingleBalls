using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 v3 = Input.mousePosition;
		v3 = Camera.main.ScreenToWorldPoint(v3);

		v3.z = 0;
		v3.y = transform.position.y;
		v3.x = Mathf.Clamp(v3.x, -6.9f, 6.9f);
		transform.position = v3;
	}
}
