using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 충돌하면 카운터를 증가한다 
public class OnCollision_Count : MonoBehaviour
{
	private AudioSource audio;
	public AudioClip collisionSound;

	public string targetObjectName; // 목표 오브젝트 이름 : Inspector에 지정
	public int addValue = 1;    // 증가량：Inspector에 지정

	void Start()
	{
		this.audio = this.gameObject.AddComponent<AudioSource>();
		this.audio.clip = this.collisionSound;
		this.audio.loop = false;

	}

	void OnCollisionEnter2D(Collision2D collision)// 충돌하면
	{ 
		// 만약 충돌한 것의 이름이 목표 오브젝트면 
		if (collision.gameObject.name == targetObjectName)
		{
			// 카운터 값을 증가한다 
			GameCounter.value = GameCounter.value + addValue;
			this.audio.Play();
		}
	}
}
