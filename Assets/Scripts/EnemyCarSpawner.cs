using UnityEngine;
using System.Collections;

public class EnemyCarSpawner : MonoBehaviour {

	public GameObject[] cars;
	public float spawnRate = 1f;

	private float xSpawnLimit = 2.2f;
	private float timer;

	private void Start () {
		timer = spawnRate;
	}
	
	private void Update () {
		timer -= Time.deltaTime;

		if (timer < 0) {
			Vector3 spawnPos = new Vector3 (Random.Range (-xSpawnLimit, xSpawnLimit), transform.position.y, transform.position.z);
			GameObject newCar = Instantiate(cars[Random.Range(0, cars.Length - 1)], spawnPos, Quaternion.identity) as GameObject;
			timer = spawnRate;
			newCar.transform.SetParent (this.transform);
		}
	}


}
