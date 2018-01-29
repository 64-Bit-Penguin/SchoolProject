using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Contact_Level_Selection : MonoBehaviour {

	private GameObject Placeholder;
	//private Object CurrentScene;
	private LevelSelection LS;
	private int LevelID;
	private string SceneName;


	// Use this for initialization
	void Start () {
		//Placeholder = GameObject.FindWithTag("Script_Placeholder");
		//LS = Placeholder.GetComponent<LevelSelection> ();

		//DontDestroyOnLoad (GameObject.FindGameObjectWithTag("ButtonManager"));


	}
	
	// Update is called once per frame
	public void Change_Scene () {
		//LS.Level_ID = LevelID;
		SceneManager.LoadScene(SceneName);
	}

	public void Get_SceneName(string Scene_Name)
	{
		SceneName = Scene_Name;
	}

	public void Get_Level_ID(int Level_ID)
	{
		LevelID = Level_ID;
		try {
			PlayerPrefs.SetInt ("LevelID", LevelID);
		} catch  {}
	}

	/*public void Get_Current_Scene(Object Current_Scene)
	{
		CurrentScene = Current_Scene;
	}*/
}
