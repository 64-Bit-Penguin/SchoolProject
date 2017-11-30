using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonClick : MonoBehaviour
{
	public static float musicPos;

	public void NewGameBtn(string NewGameLevel)
    {
		
        SceneManager.LoadScene(NewGameLevel);
    }

    public void ExitBtn()
    {
        Application.Quit();
    }

    public void Option()
    {
        
    }

	public void SetMusicPosition(AudioSource Audio)
	{
		try {
			musicPos = Audio.time;
			print (musicPos);
		} catch (System.Exception ex) {
			throw new System.Exception (ex.Message);
		}
	}

}
