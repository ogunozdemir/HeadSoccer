using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Sayac : MonoBehaviour {
	public int skor1;
	public int skor2;
	public Text Skor1;
	public Text Skor2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Skor1.text = skor1.ToString();
		Skor2.text = skor2.ToString();
	}
}
