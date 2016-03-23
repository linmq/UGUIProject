using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public float speed = 90f;

	void Update () 
	{
		transform.Rotate (Vector3.up * Time.deltaTime * speed);
	}

	public void ChangeSpeed(float speedNew)
	{
		this.speed = speedNew;
	}
}
