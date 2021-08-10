using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

    public int Next;
    public static int Nexx = 0;
    Windar win;

    ExtraDetect ed;

    // Use this for initialization
    void Start () {
        win = FindObjectOfType<Windar>();
        ed = FindObjectOfType<ExtraDetect>();
    }

    void Update()
    {
        if (Nexx > 6)
        {
            Next = 0;
        }
        if (Next > 5)
        {
            Next = win.menuu + 1;
        }
    }

    // Update is called once per frame
    public void GoNext()
    {
        ed.isGot = false;
        if (Next == 2)
        {
            SceneManager.LoadScene("Agrabah");
        }else if (Next  == 3)
        {
            SceneManager.LoadScene("Atlantica");
        }else if (Next == 4)
        {
            SceneManager.LoadScene("Monstro");
        }
        else if (Next == 5)
        {
            Nexx = 6;
            SceneManager.LoadScene("Wonderland");
        }
        else if (Next == 6)
        {
            Nexx = 7;
            SceneManager.LoadScene("Olympus Coliseum");
        }
        else if (Nexx == 7)
        {
            Nexx = 8;
            SceneManager.LoadScene("Halloween Town");
        }
        else if (Nexx == 8)
        {
            Nexx = 9;
            SceneManager.LoadScene("Hollow Bastion");
        }
        else if (Nexx == 9)
        {
            Nexx = 10;
            SceneManager.LoadScene("Space Paranoids");
        }
        else if (Nexx == 10)
        {
            Nexx = 11;
            SceneManager.LoadScene("Neverland");
        }
        else if (Nexx == 11)
        {
            Nexx = 12;
            SceneManager.LoadScene("Twilight Town");
        }
        else if (Nexx == 12)
        {
            Nexx = 13;
            SceneManager.LoadScene("Traverse Town");
        }
        else if (Nexx == 13)
        {
            Nexx = 14;
            SceneManager.LoadScene("Deep Jungle");
        }
        else if (Nexx == 14)
        {
            Nexx = 15;
            SceneManager.LoadScene("Disney Castle");
        }
        else if (Nexx == 15)
        {
            Nexx = 16;
            SceneManager.LoadScene("Timeless River");
        }
        else if (Nexx == 16)
        {
            //15
            Nexx = 17;
            SceneManager.LoadScene("Port Royal");
        }
        else if (Nexx == 17)
        {
            //15
            Nexx = 18;
            SceneManager.LoadScene("End of the World");
        }
        else if (Nexx == 18)
        {
            //16
            Nexx = 19;
            SceneManager.LoadScene("Castle Oblivion");
        }
        else if (Nexx == 19)
        {
            //17
            Nexx = 20;
            SceneManager.LoadScene("Station of Awakening");
        }
        else if (Nexx == 20)
        {
            Nexx = 21;
            SceneManager.LoadScene("Unknown");
        }
        else if (Nexx == 21)
        {
            SceneManager.LoadScene("Battle Report");
        }
    }
}
