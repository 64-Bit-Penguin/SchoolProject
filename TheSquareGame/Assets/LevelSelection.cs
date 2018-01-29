using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour {

	private int Level_ID;
    public GameObject Lava1;
    public GameObject Lava2;
    public GameObject Lava3;
    public GameObject Snow4;
    public GameObject Snow5;
    public GameObject Snow6;

    void Start () {


        try
        {
            Level_ID = PlayerPrefs.GetInt("LevelID");
        }
        catch { }
        
        if(Level_ID == 1)
        {
            Lava1.SetActive(true);

            Lava2.SetActive(false);

            Lava3.SetActive(false);

            Snow4.SetActive(false);

            Snow5.SetActive(false);

            Snow6.SetActive(false);
        }
        else if (Level_ID == 2)
        {
            Lava1.SetActive(false);

            Lava2.SetActive(true);

            Lava3.SetActive(false);

            Snow4.SetActive(false);

            Snow5.SetActive(false);

            Snow6.SetActive(false);
        }
        else if (Level_ID == 3)
        {
            Lava1.SetActive(false);

            Lava2.SetActive(false);

            Lava3.SetActive(true);

            Snow4.SetActive(false);

            Snow5.SetActive(false);

            Snow6.SetActive(false);
        }
        else if (Level_ID == 4)
        {
            Lava1.SetActive(false);

            Lava2.SetActive(false);

            Lava3.SetActive(false);

            Snow4.SetActive(true);

            Snow5.SetActive(false);

            Snow6.SetActive(false);
        }
        else if (Level_ID == 5)
        {
            Lava1.SetActive(false);

            Lava2.SetActive(false);

            Lava3.SetActive(false);

            Snow4.SetActive(false);

            Snow5.SetActive(true);

            Snow6.SetActive(false);
        }
        else if (Level_ID == 6)
        {
            Lava1.SetActive(false);

            Lava2.SetActive(false);

            Lava3.SetActive(false);

            Snow4.SetActive(false);

            Snow5.SetActive(false);

            Snow6.SetActive(true);
        }


    }
}
