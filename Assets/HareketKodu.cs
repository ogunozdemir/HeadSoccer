using UnityEngine;
using System.Collections;

public class HareketKodu : MonoBehaviour
{
	public int hiz;
	public string Wplayer;
	public bool ziplama;
	// Use this for initialization
	void Start()
	{
		
	}
	
	// Update is called once per frame
	void Update()
	{
		
		if (Input.GetKey(KeyCode.D) && Wplayer == "1")
		{
			transform.Translate(hiz * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey(KeyCode.A) && Wplayer == "1")
		{
			transform.Translate(-hiz * Time.deltaTime * 1, 0, 0);
		}
		if (Input.GetKeyDown(KeyCode.W) && Wplayer == "1" && !ziplama)
		{
			GetComponent<Rigidbody2D>().AddForce(Vector3.up * 700000);
			ziplama=true;
			StartCoroutine(Ziplama());
		}

		if (Input.GetKey(KeyCode.RightArrow) && Wplayer == "2")
		{
			transform.Translate(hiz * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey(KeyCode.LeftArrow) && Wplayer == "2")
		{
			transform.Translate(-hiz * Time.deltaTime * 1, 0, 0);
		}
		if (Input.GetKeyDown(KeyCode.UpArrow) && Wplayer == "2" && !ziplama)
		{
			GetComponent<Rigidbody2D>().AddForce(Vector3.up * 700000);
			ziplama=true;
			StartCoroutine(Ziplama());
		}
		
	}

	IEnumerator Ziplama()
	{
		yield return new WaitForSeconds (0.9f);
		ziplama = false;
	}
}