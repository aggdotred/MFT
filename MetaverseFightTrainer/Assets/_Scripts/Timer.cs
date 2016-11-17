using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

    public Text countDownText;
    public float countDownSeconds = 60;
    public float seconds, minutes;

    private GameObject uke;

	void Start () {
        countDownText = GetComponent<Text>() as Text;
        uke = GameObject.Find("Uke");
	}
	
	
	void Update () {

        countDownSeconds -= Time.deltaTime;
        countDownText.text = "Time Remaining: " + countDownSeconds.ToString("00");
	    if (countDownSeconds <= 0)
        {
            Destroy(uke);
            countDownSeconds = 0;
            countDownText.text = "Time Remaining: " + countDownSeconds.ToString("00");
        }
	}
}
