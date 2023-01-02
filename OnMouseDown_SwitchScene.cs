using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // 씬 전환에 필요 

// 터치하면 씬을 전환한다 
public class OnMouseDown_SwitchScene : MonoBehaviour
{
    private AudioSource audio;
    public AudioClip ClickSound;
    public string sceneName;  // 씬 이름：Inspector에 지정

    // Use this for initialization
    void Start()
    {
        this.audio = this.gameObject.AddComponent<AudioSource>();
        this.audio.clip = this.ClickSound;
        this.audio.loop = false;

    }
    

    void OnMouseDown() 
	{ // 터치하면
        // 씬을 전환한다 
        SceneManager.LoadScene (sceneName);
        this.audio.Play();
    }
}
