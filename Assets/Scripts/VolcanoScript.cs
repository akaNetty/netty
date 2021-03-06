﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class VolcanoScript : MonoBehaviour {
	public GameObject tamevol; 
	public GameObject hunvol; 
	public GameObject vol; 
	public GameObject modoru;
	public Animator animator;
	public AudioSource dogaSound;
	public AudioSource backSound;
	public Text text;
	public Image buttonImage;
	public static float tame = 1;
	public int stame = 0;
	public float jikan = 0.0f;
	public float timer = 0.0f;
	public float nokori = 3.0f;
	public Sprite voltame;
	// Use this for initialization
	void Start () {
		tamevol.SetActive (false);
		hunvol.SetActive (false);
		buttonImage = this.GetComponent<Image>();
		tame = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (stame == 1) {
			
				timer += Time.deltaTime;
				nokori = 3.0f - timer;
			if (nokori <= 0) {
				nokori = 0;
			}
				text.text = nokori.ToString ("f2");

			if (timer >= 3.0f) {
				vol.SetActive (false);
				hunvol.SetActive (true);

			}
		}
	}

	public void renda(){
//		vol.gameObject.transform.localScale = new Vector3 (1.2f, 2.2f, 0);
		buttonImage.sprite = voltame; 
		stame = 1;
		tame++;
		dogaSound.Play ();
		vol.SendMessage ("Vibe");
		animator.SetTrigger ("dokan");
		//		vol.gameObject.transform.localScale = new Vector3 (1.0f, 1.8f, 0);;
	}

	public void back(){
		backSound.Play ();
		SceneManager.LoadScene ("Title");
	}
}
