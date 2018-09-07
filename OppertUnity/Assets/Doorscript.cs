using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorscript : MonoBehaviour {

	// Use this for initialization

	private void OnTriggerStay(Collider other)
	{
		transform.Translate(Vector3.up * Time.deltaTime, Space.World);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
