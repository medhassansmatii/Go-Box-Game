using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour {

	public AudioMixer audioMixer;

	public void playGame(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}
	public void QuitGame(){
		Debug.Log ("Quit !");
		Application.Quit();
	}
	public void setVolume (float Volume){
	
		audioMixer.SetFloat ("Volume", Volume);
	
	}
}
