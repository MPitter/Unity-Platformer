using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemButtons : MonoBehaviour {

    OtherInventory oi;
    PlayerHealth ph;
    NewInventory ni;
    Invincibility inv;
    public RectTransform rt;
    public Animator anim;

    public static int ItemCounter;

    public Image charImage;

    float clicked = 0;
    float clicktime = 0;

    float timed = .55f;
    float timed2 = .5f;
    float timed3 = .5f;
    float timed4 = .5f;
    float timed5 = .5f;

    bool isUse;

    bool isML,isHiPo,isMegPo,isPo;

    // Use this for initialization
    void Start () {
        ni = FindObjectOfType<NewInventory>();
        ph = FindObjectOfType<PlayerHealth>();
        inv = FindObjectOfType<Invincibility>();
        oi = FindObjectOfType<OtherInventory>();
	}
	
	// Update is called once per frame
	void Update () {
        if (isUse == true) {
            timed -= Time.deltaTime;
        }
        if (timed < 0)
        {
            isUse = false;
            anim.SetBool("isItem", false);
            timed = .55f;
        }

        if (isML == true)
        {
            timed2 -= Time.deltaTime;
        }
        if (timed2 < 0)
        {
            SoundKeeper.sndMan.PlayElixirSound();
            timed2 = .5f;
            isML = false;
        }
        if (isMegPo == true)
        {
            timed3 -= Time.deltaTime;
        }
        if (timed3 < 0)
        {
            SoundKeeper.sndMan.PlayMegPotSound();
            timed3 = .5f;
            isMegPo = false;
        }
        if (isHiPo == true)
        {
            timed4 -= Time.deltaTime;
        }
        if (timed4 < 0)
        {
            SoundKeeper.sndMan.PlayHiPotionSound();
            timed4 = .5f;
            isHiPo = false;
        }
        if (isPo == true)
        {
            timed5 -= Time.deltaTime;
        }
        if (timed5 < 0)
        {
            SoundKeeper.sndMan.PlayPotionSound();
            timed5 = .5f;
            isPo = false;
        }
    }

    public void Potion()
    {
        isUse = true;
        ph.currentHealth += 10;
        oi.Potion -= 1;
        ni.txt1.text = oi.Potion.ToString();
        anim.SetBool("isItem", true);
        SoundKeeper.sndMan.PlayHereSound();
        isPo = true;
        ItemCounter += 1;
    }
    public void HiPotion()
    {
        isUse = true;
        ph.currentHealth += 15;
        oi.HiPotion -= 1;
        ni.txt2.text = oi.HiPotion.ToString();
        anim.SetBool("isItem", true);
        SoundKeeper.sndMan.PlayHereSound();
        isHiPo = true;
        ItemCounter += 1;

    }
    public void MegaPotion()
    {
        isUse = true;
        ph.currentHealth += 25;
        oi.MegaPotion -= 1;
        ni.txt3.text = oi.MegaPotion.ToString();
        anim.SetBool("isItem", true);
        SoundKeeper.sndMan.PlayHereSound();
        isMegPo = true;
        ItemCounter += 1;
    }
    public void Elixir()
    {
        isUse = true;
        ph.currentHealth += ph.maxHealth/5;
        oi.Elixir -= 1;
        ni.txt4.text = oi.Elixir.ToString();
        anim.SetBool("isItem", true);
        SoundKeeper.sndMan.PlayHereSound();
        isML = true;
        ItemCounter += 1;
    }
    public void Megalixir()
    {
        isUse = true;
        ph.currentHealth = ph.maxHealth;
        inv.isInvincible = true;
        charImage.color = Color.green;
        oi.Megalixir -= 1;
        ni.txt5.text = oi.Megalixir.ToString();
        anim.SetBool("isItem", true);
        SoundKeeper.sndMan.PlayHereSound();
        isML = true;
        ItemCounter += 1;

    }
    public void Items()
    {
        rt.gameObject.SetActive(true);
 
        SoundKeeper.sndMan.PlayClicSound();
        clicked++;
        if (clicked > 1)
        {
            clicked = 0;
            clicktime = 0;
            rt.gameObject.SetActive(false);

        }
    }
}
