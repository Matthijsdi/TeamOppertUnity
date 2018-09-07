using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorscript : MonoBehaviour {

	private Animator _animator;

	// Use this for initialization
	void Start () {
		_animator = GetComponent<Animator>();
	}

	private void OnTriggerStay(Collider other)
	{
		transform.Translate(Vector3.up * Time.deltaTime, Space.World);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
