using UnityEngine;
using System.Collections;

public class Movecamera : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	float speed = 35f;
	float mouse_multiply = 2f;
	void Update()
	{
	
		if(Input.GetKey(KeyCode.RightArrow)) // right key
		{
			//transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
			transform.Rotate(new Vector3(0,speed * Time.deltaTime,0));
		}
		if(Input.GetKey(KeyCode.LeftArrow)) // left key 
		{

			transform.Rotate(new Vector3(0,-speed * Time.deltaTime,0));
		}
		if(Input.GetKey(KeyCode.DownArrow)) // down key
		{

			transform.Rotate(new Vector3(speed * Time.deltaTime,0,0));
		}
		if(Input.GetKey(KeyCode.UpArrow)) // up key
		{

			transform.Rotate(new Vector3(-speed * Time.deltaTime,0,0));
		}
		if(Input.GetAxis("Mouse X")<0) // left mouse 
		{
			transform.Rotate(new Vector3(0,-speed * Time.deltaTime * mouse_multiply,0));
		}
		if(Input.GetAxis("Mouse X")>0) // right mouse 
		{
			transform.Rotate(new Vector3(0,speed * Time.deltaTime * mouse_multiply,0));
		}
		if(Input.GetAxis("Mouse Y")>0) // up mouse 
		{
			transform.Rotate(new Vector3(-speed * Time.deltaTime * mouse_multiply,0,0));
		}
		if(Input.GetAxis("Mouse Y")<0) // down mouse 
		{
			transform.Rotate(new Vector3(speed * Time.deltaTime * mouse_multiply,0,0));
		}


	}
}
