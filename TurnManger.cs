using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManger : MonoBehaviour {
	public Character player;
	public Character enemy;
	private bool isPlayerTurn = true;

	
	// Update is called once per frame
	void Update () {
		
		if (isPlayerTurn) {
			
		} else {
			EnemyTurn ();
		}
	}

	public void EndTurn(){
		
		isPlayerTurn = !isPlayerTurn;
	}

	private void EnemyTurn(){

		player.Takedamage (enemy.attackPower);
		EndTurn ();
	}
	public void PlayerAttack(){
		if (!isPlayerTurn)
			return;	
		enemy.Takedamage(player.attackPower);
		EndTurn ();
	}
}