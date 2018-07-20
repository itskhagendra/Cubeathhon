
using UnityEngine;
using UnityEngine.UI;

public class scrore : MonoBehaviour {

	public Transform player;
	public Text score;

	// Use this for initialization


	// Update is called once per frame
	void Update () {

	score.text=player.position.z.ToString("0");

	}
}
