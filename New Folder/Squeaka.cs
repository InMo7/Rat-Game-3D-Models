using UnityEngine;
using System.Collections;

public class RandomSoundPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public float minDelay = 2.0f;
    public float maxDelay = 5.0f;

    void Start()
    {
        StartCoroutine(PlaySoundRandomly());
    }

    IEnumerator PlaySoundRandomly()
    {
        while (true)
        {
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);
            audioSource.Play();
        }
    }
}

