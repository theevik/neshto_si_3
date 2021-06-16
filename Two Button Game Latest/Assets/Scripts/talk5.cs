using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class talk5 : MonoBehaviour
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
        aero.SetActive(true);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);

        subs1.GetComponent<Text>().text = "Nog meer van deze mensen… Volgens mij gaan we de juiste kant op. Misschien hadden we een van hun meer kunnen vragen over deze “grote bezorging”.";
        subs2.GetComponent<Text>().text = "More of these guys…guess we’re going in the right direction. Maybe we should have asked one of them for some more details on this big delivery.";
        yield return new WaitForSeconds(8f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(true);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Dan moeten we het maar zelf uitvinden, als we deze kant op blijven gaan dan komen we ooit wel bij Batka.";
        subs2.GetComponent<Text>().text = "Better to go see for ourselves, if we keep going in the direction these guys came from, we should run into Batka eventually.";
        yield return new WaitForSeconds(5f);

        aero.SetActive(false);
        beta.SetActive(true);   
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Horen jullie dat…?";
        subs2.GetComponent<Text>().text = "Do you guys hear that? ";
        yield return new WaitForSeconds(2f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(true);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Dat is de trein, schiet op!";
        subs2.GetComponent<Text>().text = "The train, let’s hurry up.";
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
