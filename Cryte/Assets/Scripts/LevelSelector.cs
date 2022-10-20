using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    private int PlanetValue;
    private float angle;
    private GameObject PlanetsPivot;
    void Start()
    {
        PlanetsPivot = GameObject.Find("PlanetsPivot");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && PlanetValue == 1)
		{
            PlanetValue++;
            PlanetsPivot.transform.rotation = new Quaternion(0, PlanetsPivot.transform.rotation.y - angle, 0, 0);
        }
            
            
            

        if (Input.GetKeyDown(KeyCode.RightArrow) && PlanetValue == 0)
		{
            PlanetValue--;
            PlanetsPivot.transform.rotation = new Quaternion(0, PlanetsPivot.transform.rotation.y + angle, 0, 0) ;
		}
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			switch (PlanetValue)
			{
                case 0:
                    SceneManager.LoadScene("FirstPlanet");
                    break;

			}
		}
    }
}
