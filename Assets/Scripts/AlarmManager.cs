using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using UnityEngine;

public class AlarmManager : MonoBehaviour
{
    [SerializeField] private AlarmFase[] alarmFases;

    private AlarmFase currentAlarmFase;

    private AudioSource audiosource;

    [SerializeField] private AudioClip[] sounds;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>(); //AudioSource koppelen aan script
        
        alarmFases = new AlarmFase[5]; //Opgeven hoeveel alarmfases er zijn
        
        //Alle alarmfases worden van data voorzien
        alarmFases[0] = new AlarmFase(121, "Bedrijfsrestaurant Z. Zijde");
        alarmFases[1] = new AlarmFase(122, "Hoofdgebouw, kantoren");
        alarmFases[2] = new AlarmFase(123, "Gasalarm Terathane", "Begane grond");
        alarmFases[3] = new AlarmFase(124, "Kantoren Z.W. zijde", "Verdieping 1");
        alarmFases[4] = new AlarmFase(125, "Terathane Machinekamer");
        
        //Random alarmfase wordt gekozen
        int random = Random.Range(0, alarmFases.Length - 1);
        currentAlarmFase = alarmFases[random]; //random alarmfase wordt opgeslagen in currentAlarmFase voor makkelijk gebruik
    }

    void SoundAlarm()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
