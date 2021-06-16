using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dialogue6_1 : MonoBehaviour
{
    public GameObject subs1;
    public GameObject subs2;

    public GameObject aero, beta, frost, naiden, weazel;

    void Start()
    {
        StartCoroutine(SubSequence1());
    }
    IEnumerator SubSequence1()
    {
        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);

        subs1.GetComponent<Text>().text = "Kijk, kijk, kijk, als dat Gimbo’s kleine helpertjes niet zijn. Laat jullie treinkaartjes maar zien voordat jullie dichterbij komen.";
        subs2.GetComponent<Text>().text = "Well, well, well if it isn’t Gimbo’s little helpers. I’m gonna need to see some tickets before you come any further. ";
        yield return new WaitForSeconds(9f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(true);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Jij eikel… Waar is gimbo... ";
        subs2.GetComponent<Text>().text = "You Bastard… Where’s Gimbo. ";
        yield return new WaitForSeconds(3f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = " Volgens mij hebben jullie hem net gemist! ";
        subs2.GetComponent<Text>().text = "Sounds like you just missed him.  ";
        yield return new WaitForSeconds(3f);

        aero.SetActive(true);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Vertel ons onmiddelijk waar die trein naartoe gaat. ";
        subs2.GetComponent<Text>().text = "You better tell us where that train is headed right now ";
        yield return new WaitForSeconds(2.3f);


        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = "Mijn mond is gesnoerd. ";
        subs2.GetComponent<Text>().text = "I ain’t telling shit. ";
        yield return new WaitForSeconds(2f);


        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(true);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Dan moeten we hem maar opensnijden.";
        subs2.GetComponent<Text>().text = "Then I guess we’re gonna have to beat it out of you. ";
        yield return new WaitForSeconds(2f);

        }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SceneManager.LoadScene(0);
        }
    }
}
