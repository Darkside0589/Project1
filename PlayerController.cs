using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float moveDistance = 1f;
	private Vector3 targetPosition; 
	private bool isMoving = false; 

	void Start()
	{
		targetPosition = transform.position;
	}

	void Update()
	{
		
		if (!isMoving)
		{
			if (Input.GetKeyDown(KeyCode.W)) 
			{
				Move(Vector3.up);
			}
			else if (Input.GetKeyDown(KeyCode.S)) 
			{
				Move(Vector3.down);
			}
			else if (Input.GetKeyDown(KeyCode.A)) 
			{
				Move(Vector3.left);
			}
			else if (Input.GetKeyDown(KeyCode.D)) 
			{
				Move(Vector3.right);
			}
		}
	}

	private void Move(Vector3 direction)
	{
		targetPosition += direction * moveDistance; 
		isMoving = true; 
		StartCoroutine(MoveToPosition(targetPosition)); 
	}

	private IEnumerator MoveToPosition(Vector3 target)
	{
		while (Vector3.Distance(transform.position, target) > 0.1f)
		{
			transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * 5f); 
			yield return null; 
		}

		transform.position = target; 
		isMoving = false; 
	}
}
