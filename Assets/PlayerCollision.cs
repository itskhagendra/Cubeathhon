
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
	public Playermovement movement;

	// Use this for initialization
void OnCollisionEnter(Collision collisioninfo)
{
	if(collisioninfo.collider.tag=="obstacle")
	{
		movement.enabled=false;
	}
}
}
