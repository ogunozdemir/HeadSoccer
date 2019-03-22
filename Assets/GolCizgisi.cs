using UnityEngine;
using System.Collections;

public class GolCizgisi : MonoBehaviour {
	public Transform player1Spawner;
	public Transform player2Spawner;
	public Transform topSpawner;
	public string kale;
	public GameObject player1pr;
	public GameObject player2pr;
	public GameObject Toppr;
	public GameObject Sayac;
	private Sayac Skor;

	public AudioClip golSesi;
	public AudioSource golSesiSource;

	void Start()
	{
		Skor = Sayac.GetComponent<Sayac> ();
		golSesiSource = GetComponent<AudioSource>();

	}
	// Use this for initialization
	void OnTriggerEnter2D (Collider2D top) {
		if (top.tag == "Top" && kale == "1") {
			Destroy (GameObject.FindGameObjectWithTag ("Player1"));
			Destroy (GameObject.FindGameObjectWithTag ("Player2"));
			Destroy (GameObject.FindGameObjectWithTag ("Top"));
			Skor.skor2++;
			Spawner ();
			golSesiSource.PlayOneShot(golSesi, 0.8f);

		} else if (top.tag == "Top" && kale == "2") {
			Destroy (GameObject.FindGameObjectWithTag ("Player1"));
			Destroy (GameObject.FindGameObjectWithTag ("Player2"));
			Destroy (GameObject.FindGameObjectWithTag ("Top"));
			Skor.skor1++;
			Spawner ();
			golSesiSource.PlayOneShot(golSesi, 0.8f);
		}
	}

	void Spawner () {
		Instantiate (player1pr, player1Spawner.position, player1Spawner.rotation);
		Instantiate (player2pr, player2Spawner.position, player2Spawner.rotation);
		Instantiate (Toppr, topSpawner.position, topSpawner.rotation);
	}	
}
