using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {

	public GameObject[] tilePrefabs;
	public int width = 10;
	public int height = 10;
	public float tileSize= 1.0f;
	// Use this for initialization
	void Start () {
		GenerateMap ();
	}
	
	// Update is called once per frame
	void GenerateMap () {
		for (int x = 0; x < width; x++) {
			for (int y = 0; y < height; x++) {
				GameObject tile = Instantiate (tilePrefabs [Random.Range (0, tilePrefabs.Length)], new Vector3 (x * tileSize, y * tileSize, 0), Quaternion.identity);
				tile.transform.parent = transform;
			}
		}

		
	}
}
