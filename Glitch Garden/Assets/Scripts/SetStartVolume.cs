﻿using UnityEngine;
using System.Collections;

public class SetStartVolume : MonoBehaviour {

	private MusicManager musicManager;
	// Use this for initialization
	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager> ();
		if (musicManager) {
			float volume = PlayerPrefsManager.GetMasterVolume ();
			musicManager.SetVolume (volume);
		} else {
			Debug.LogWarning ("No music manager found on Start scene, can't set volume");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
