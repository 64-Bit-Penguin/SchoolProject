using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSkipper : MonoBehaviour {

	public GameObject[] Levels;	

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.N)) {

			if (GameObject.FindGameObjectWithTag ("Level1")) {
				Levels [0].SetActive (false);
				Levels [1].SetActive (true);
			}
			else if (GameObject.FindGameObjectWithTag ("Level2")) {
				Levels [1].SetActive (false);
				Levels [2].SetActive (true);
			}
			else if (GameObject.FindGameObjectWithTag ("Level3")) {
				Levels [2].SetActive (false);
				Levels [3].SetActive (true);
			}
			else if (GameObject.FindGameObjectWithTag ("Level4")) {
				//UnityEditor.EditorUtility.DisplayDialog ("Not available", "You can not skip this level LUL", "Be a muschi");
				SceneManager.LoadScene ("mainmenu");
			}
		}
	}
}
