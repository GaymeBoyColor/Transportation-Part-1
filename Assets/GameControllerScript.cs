using UnityEngine;
using System.Collections;

public class GameControllerScript : MonoBehaviour {
	public GameObject cubePrefab;
	public GameObject[] allCubes;
	int numCubes = 16;

	// Use this for initialization
	void Start () {
		allCubes = new GameObject[numCubes];
		for (int i = 0; i < numCubes; i++) {
			allCubes [i] = (GameObject)Instantiate (cubePrefab, new Vector3 (i * 2 - 14, 0, 10), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}