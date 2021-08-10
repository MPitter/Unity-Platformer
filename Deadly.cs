using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deadly : MonoBehaviour {

    public int Next;
    Diedar dead;

    

	// Use this for initialization
	void Start () {
        dead = FindObjectOfType<Diedar>();
    }
    void Update() {
        Time.timeScale += (1f / 1f) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
        if (Next >= 5)
        {
            Next = dead.menuu;
        }
    }
// Update is called once per frame
public void GoDI() {
        if (LevelComplete.Nexx > 6)
        {
            Next = 0;
        }
        if (Next == 1)
        {
            SceneManager.LoadScene("Destiny Island");
        }
        else if (Next == 2)
        {
            SceneManager.LoadScene("Agrabah");
        }
        else if (Next == 3)
        {
            SceneManager.LoadScene("Atlantica");
        }
        else if (Next == 4)
        {
            SceneManager.LoadScene("Monstro");
        }
        else if (Next == 5)
        {
            SceneManager.LoadScene("Wonderland");
        }
        else if (LevelComplete.Nexx == 7)
        {
            SceneManager.LoadScene("Olympus Coliseum");
        }
        else if (LevelComplete.Nexx == 8)
        {
            SceneManager.LoadScene("Halloween Town");
        }
        else if (LevelComplete.Nexx == 9)
        {
            SceneManager.LoadScene("Hollow Bastion");
        }
        else if (LevelComplete.Nexx == 10)
        {
            SceneManager.LoadScene("Space Paranoids");
        }
        else if (LevelComplete.Nexx == 11)
        {
            SceneManager.LoadScene("Neverland");
        }
        else if (LevelComplete.Nexx == 12)
        {
            SceneManager.LoadScene("Twilight Town");
        }
        else if (LevelComplete.Nexx == 13)
        {
            SceneManager.LoadScene("Traverse Town");
        }
        else if (LevelComplete.Nexx == 14)
        {
            SceneManager.LoadScene("Deep Jungle");
        }
        else if (LevelComplete.Nexx == 15)
        {
            
            SceneManager.LoadScene("Disney Castle");
        }
        else if (LevelComplete.Nexx == 16)
        {
            
            SceneManager.LoadScene("Timeless River");
        }
        else if (LevelComplete.Nexx == 17)
        {
            //15
            SceneManager.LoadScene("Port Royal");
        }
        else if (LevelComplete.Nexx == 18)
        {
            //15
            SceneManager.LoadScene("End of the World");
        }
        else if (LevelComplete.Nexx == 19)
        {
            //16
            SceneManager.LoadScene("Castle Oblivion");
        }
        else if (LevelComplete.Nexx == 20)
        {
            //17
            SceneManager.LoadScene("Station of Awakening");
        }
        else if (LevelComplete.Nexx == 21)
        {
            //17
            SceneManager.LoadScene("Unknown");
        }
        else if (LevelComplete.Nexx == 22)
        {
            //17
            SceneManager.LoadScene("Battle Report");
        }
    }
}
