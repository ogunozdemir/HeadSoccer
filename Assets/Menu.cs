using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void mennu (int baslat) {
		if(baslat==1)
		{
			Application.LoadLevel(1);
		}
		if(baslat==3)
		{
			Application.Quit();
		}
	}
}
