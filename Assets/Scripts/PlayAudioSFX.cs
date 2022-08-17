using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioSFX : MonoBehaviour
{
    private AudioSource playerAudio;
    public AudioClip FXSound;
    private float soundFX = 0.5f;
    //public GameObject Player;
    //private float maxDist = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Vector3.Distance(Player.transform.position, transform.position) < maxDist)
        //{
        //    playerAudio.PlayOneShot(FXSound, soundFX);
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject player = other.gameObject;
        if (player.CompareTag("Player"))
        {
            playerAudio.PlayOneShot(FXSound, soundFX);
        }

    }

}
