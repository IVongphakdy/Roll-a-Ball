using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed;
	public Text countText;
	public Text winText;

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	private float nextFire;

	private Vector3 spawn;
	private int ammoCount;

	// Use this for initialization 
	void Start () { 
		moveSpeed = 10f; 
		spawn = transform.position;
		winText.text = "";
		SetCountText ();
		ammoCount = 0;
	} 

	// Update is called once per frame
	void Update () {
		transform.Translate(moveSpeed * Input.GetAxis ("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis ("Vertical") * Time.deltaTime);
	
		if (transform.position.y < -2)
			Die ();

		if (Input.GetButton("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			if (ammoCount > 0) {
				Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
				ammoCount--;
				SetCountText ();
			}
		}
	}

	void OnCollisionEnter(Collision other){
		if (other.transform.tag == "Enemy") {
			Die ();
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Goal")
			winText.text = "You Win!";
		
		if (other.gameObject.CompareTag ("Ammo")){
			ammoCount++;
			other.gameObject.SetActive (false);
			SetCountText ();
		}
	}

	void SetCountText()
	{
		countText.text = "Ammo: " + ammoCount.ToString ();
	}

	void OnGUI(){
		if(GUI.Button (new Rect(10, 10, 45, 45), "Home"))
			Application.LoadLevel(0);
	}

	public void Die()
	{
		//transform.position = spawn;
		Application.LoadLevel(Application.loadedLevel);
	}
}
