using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Rand : MonoBehaviour
{
    AudioSource source;
    public AudioClip audio1;
    public AudioClip audio2;
    public AudioClip audio3;
    public AudioClip audio4;

    int id;

    void Start()
    {
    	AudioSource source = GetComponent<AudioSource>();

        System.Random rnd = new System.Random();
		id = rnd.Next(1,5);

		if(id == 1){
			source.clip = audio1;
			source.Play(0);
		}
		if(id == 2){
			source.clip = audio2;
			source.Play(0);
		}
		if(id == 3){
			source.clip = audio3;
			source.Play(0);
		}
		if(id == 4){
			source.clip = audio4;
			source.Play(0);
		}

        Debug.Log("started");
    }

    void Update()
    {

    }
}
