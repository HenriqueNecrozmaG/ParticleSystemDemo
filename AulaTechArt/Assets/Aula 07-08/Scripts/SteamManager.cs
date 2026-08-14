using System.Collections;
using UnityEngine;


public class SteamManager : MonoBehaviour
{
    private ParticleSystem steam;
    [SerializeField] private float startTimeDelay;
    [SerializeField] private float restartWait;

    void Awake()
    {
        steam = GetComponent<ParticleSystem>();
    }

    void Start()
    {
        StartCoroutine(StartSteamParticle());
    }

    IEnumerator StartSteamParticle()
    {
        yield return new WaitForSeconds(startTimeDelay);

        steam.Play();
        StartCoroutine(RestartSteamParticle());
    }

    IEnumerator RestartSteamParticle()
    {
        yield return new WaitForSeconds (restartWait);

        steam.Play();
        StartCoroutine(RestartSteamParticle());
    }
}
