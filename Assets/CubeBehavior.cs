using UnityEngine;
using System.Collections;

public class CubeBehavior : MonoBehaviour {

	void OnMouseDown () {

		GameObject[] allCubes = GameObject.FindGameObjectsWithTag("Clickable Cube");
		foreach (GameObject oneCube in allCubes) {
			oneCube.GetComponent<Renderer>().material.color = Color.white;
		}
		GetComponent<Renderer>().material.color = Color.red;
	}

}