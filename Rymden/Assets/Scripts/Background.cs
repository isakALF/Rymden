using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

	public GameObject line;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float waveWait;
	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnWaves ());
	}

	IEnumerator SpawnWaves ()
	{   
		while (true) {
			for (int i = 0; i < hazardCount; i++) {
				Vector3 SpawPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (line, SpawPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}
}