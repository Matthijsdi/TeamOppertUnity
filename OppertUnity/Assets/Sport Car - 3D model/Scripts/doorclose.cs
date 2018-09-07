using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorclose : MonoBehaviour {

	private Animator _animator;

	// Use this for initialization
	void Start()
	{
		_animator = GetComponent<Animator>();
	}

	private void OnTriggerStay(Collider other)
	{
		transform.Translate(Vector3.down * Time.deltaTime, Space.World);
	}

	// Update is called once per frame
	void Update()
	{

	}
}
