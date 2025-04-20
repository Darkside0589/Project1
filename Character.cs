using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

	public string characterName;
	public int health;
	public int attackPower;
	public int defense;
	public bool IsAlive () {
		return health > 0;
	}

	// Use this for initialization
	public void Takedamage (int damage){
		health -= damage;
		if (health < 0)
			health = 0;
	}
}
