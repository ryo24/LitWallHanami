using UnityEngine;
using System.Collections;

public class CameraScripts : MonoBehaviour {
	public float speed;
	public float heightspeed;
	public float movespeed;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.RightArrow)){
			 transform.Rotate(0,speed * Time.deltaTime,0);
		}

		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Rotate(0, -1 *  speed * Time.deltaTime,0);

		}

		if(Input.GetKey(KeyCode.UpArrow)){
			transform.position += new Vector3(0,heightspeed * Time.deltaTime,0);
		}
		
		if(Input.GetKey(KeyCode.DownArrow)){
			transform.position += new Vector3(0, -1 * heightspeed * Time.deltaTime,0);

		}

		if(Input.GetKey(KeyCode.A)){
			transform.position += new Vector3( -1 * movespeed * Time.deltaTime,0,0);
		}
		if(Input.GetKey(KeyCode.D)){
			transform.position += new Vector3(movespeed * Time.deltaTime,0,0);
		}

		if(Input.GetKey(KeyCode.W)){
			transform.position += new Vector3( 0,0, movespeed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.S)){
			transform.position += new Vector3(0,0,-1 *movespeed * Time.deltaTime);
		}





		if(Input.GetKey(KeyCode.B)){
			Application.LoadLevel("daytime");
		}

		if(Input.GetKey(KeyCode.N)){
			Application.LoadLevel("daynight");
		}
	
	}
}
