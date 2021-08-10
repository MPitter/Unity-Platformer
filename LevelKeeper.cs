using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelKeeper : MonoBehaviour {

    public int LvlKeeper;
    public PlayerHealth ph;
    ///public TimeKeeper tk;
    public Animator deathAnim;
    public Canvas can;

    public Text lvlText;

    public static int DeathCounter;

    float timed = 1.3f;
    float timed2 = .05f;
    bool isDed;
    bool isSlo;

    public AudioSource asr, Sound;
    NextLevel nl;
    // Use this for initialization
    void Start () {
        if (LvlKeeper < 10)
        {
            lvlText.text = "0" + LvlKeeper.ToString();
        }else
        {
            lvlText.text = LvlKeeper.ToString();
        }
        nl = FindObjectOfType<NextLevel>();
        //can = FindObjectOfType<Canvas>();
        //tk = FindObjectOfType<TimeKeeper>();

    }

    // Update is called once per frame
    private void Update()
    {
        float lvld = ph.currentHealth;
        if (lvld <= 0f)
        {
            isDed = true;
            isSlo = true;
            asr.enabled = true;
            nl.isEnd = true;
            //tk.SlowMo();
            can.enabled = false;
            Sound.mute = true;
            deathAnim.SetBool("isDead", true);
        }
        if (isDed == true)
        {
            timed -= Time.deltaTime;
        }
        if (isSlo == true)
        {
            timed2 -= Time.deltaTime;
        }
        if (timed2 < 0)
        {
            //SlowMo();
            isSlo = false;
        }

            if (timed < 0)
        {
            PlayerHealth.actualHealth = PlayerHealth.actualMax;
            DeathCounter += 1;
            if (LvlKeeper == 1)
            {
                SceneManager.LoadScene("Death");
                
            }
            else if (LvlKeeper == 2)
            {
                SceneManager.LoadScene("Death2");
                
            }
            else if (LvlKeeper == 3)
            {
                SceneManager.LoadScene("Death3");
                
            }
            else if (LvlKeeper == 4)
            {
                SceneManager.LoadScene("Death4");
                
            }
            else if (LvlKeeper >= 5)
            {
                SceneManager.LoadScene("Death5");
                
            }
            else if (LvlKeeper == 6)
            {
                SceneManager.LoadScene("Death6");
            }
            else if (LvlKeeper == 7)
            {
                SceneManager.LoadScene("Death7");
            }
            else
            {
                SceneManager.LoadScene("Main Menu");
            }
        }
    }
    void SlowMo()
    {
        Time.timeScale = 0.3f;
        Time.fixedDeltaTime = Time.timeScale * 2f;
    }
}
