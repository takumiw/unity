﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrFall : MonoBehaviour {

	Vector3 power_dir = Vector3.down;

	// Use this for initialization
	void Start () {
		int fall_speed = (GameController.score / 50) * 100 + 100;
		gameObject.GetComponent<Rigidbody>().AddForce(power_dir * fall_speed);

	}

	// Update is called once per frame
	void Update () {
		if (this.transform.position.y < -5.0f){
			Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter (Collider hit){
		if (hit.CompareTag ("Ojiichan")) {

			// とりあえず、消えるようにする
			FindObjectOfType<GameController>().DecreaseHp();
			Destroy(this.gameObject);

    }
	}
}