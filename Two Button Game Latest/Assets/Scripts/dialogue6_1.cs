using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dialogue6_1 : MonoBehaviour
{
    public GameObject subs1;

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
        yield return new WaitForSeconds(2f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(true);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Jij eikel… Waar is gimbo... ";
        yield return new WaitForSeconds(2f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = " Volgens mij hebben jullie hem net gemist! ";
        yield return new WaitForSeconds(2f);

        aero.SetActive(true);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Vertel ons onmiddelijk waar die trein naartoe gaat. ";
        yield return new WaitForSeconds(2f);


        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = "Mijn mond is gesnoerd. ";
        yield return new WaitForSeconds(2f);


        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(true);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Dan moeten we hem maar opensnijden.";
        yield return new WaitForSeconds(2f);

        }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
