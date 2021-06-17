using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class subs7script : MonoBehaviour
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
        beta.SetActive(true);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);

        subs1.GetComponent<Text>().text = "Genoeg gehad, sterke jongen? ";
        subs2.GetComponent<Text>().text = "Had enough, tough guy?  ";
        yield return new WaitForSeconds(2f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = "Jij… kleine…  ";
        subs2.GetComponent<Text>().text = "You… little…  ";
        yield return new WaitForSeconds(3f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(true);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = " Het is voorbij Batka, vertel ons waar je Gimbo naartoe brengt.?";
        subs2.GetComponent<Text>().text = "It’s over Batka, now where are you taking Gimbo? ";
        yield return new WaitForSeconds(4f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = "Ik zal het aan jullie vertellen… sinds jullie hem toch niet meer kunnen inhalen. ";
        subs2.GetComponent<Text>().text = " Punks… I guess I can tell you… since there’s no way you can get to him now. ";
        yield return new WaitForSeconds(5f);


        aero.SetActive(false);
        beta.SetActive(true);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Daar maken wij ons wel zorgen over, vertel op.";
        subs2.GetComponent<Text>().text = "We’ll worry about that later, now speak. ";
        yield return new WaitForSeconds(3f);


        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = "De trein gaat naar het binnengebied. ";
        subs2.GetComponent<Text>().text = "The train is going to the inner district.  ";
        yield return new WaitForSeconds(4f);


        aero.SetActive(true);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = " Het binnengebied… waarom daar?  ";
        subs2.GetComponent<Text>().text = "The inner district, but why?  ";
        yield return new WaitForSeconds(3f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = " Jouw gok is zo goed als de mijne.";
        subs2.GetComponent<Text>().text = "Your guess is as good as mine. ";
        yield return new WaitForSeconds(2f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = "Ik heb veel geld gekregen hiervoor, en alles wat ik hoefde te doen is Gimbo op die trein zetten. ";
        subs2.GetComponent<Text>().text = "I got offered a lot of money for this job, all I had to do was make sure Gimbo gets on that train.  ";
        yield return new WaitForSeconds(6f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(true);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Wie heeft je dat geld gegeven?";
        subs2.GetComponent<Text>().text = "Who gave you the job?  ";
        yield return new WaitForSeconds(3f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = "Iemand die anoniem was, het was genoeg geld om geen vragen te stellen.";
        subs2.GetComponent<Text>().text = "It was anonymous, the payment was big enough for me not to ask any questions. ";
        yield return new WaitForSeconds(5.5f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = "Dit is het einde, het is onmogelijk om langs de bewaking van het binnengebied te komen!";
        subs2.GetComponent<Text>().text = "Gimbo’s done for, it’s impossible to get pass the district border security. ";
        yield return new WaitForSeconds(6.5f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = "Ik zeg jullie wat… Jullie mogen voor mij komen werken en dan...";
        subs2.GetComponent<Text>().text = "I’ll tell you what, you can come work for me and…   ";
        yield return new WaitForSeconds(4.7f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(true);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Ik heb hier verdomme genoeg van gehad, kom op, weg hier.";
        subs2.GetComponent<Text>().text = "I’ve had enough of his shit, lets get the hell out of here. ";
        yield return new WaitForSeconds(3.7f);

        aero.SetActive(true);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Gimbo is populairder dan we dachten, huh.";
        subs2.GetComponent<Text>().text = "I guess Gimbo’s more popular than we thought.";
        yield return new WaitForSeconds(3f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(true);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Blijkbaar… we moeten een manier vinden om in het binnengebied te komen.";
        subs2.GetComponent<Text>().text = "Guess so… we gotta find a way into the inner district. ";
        yield return new WaitForSeconds(3.5f);

        aero.SetActive(false);
        beta.SetActive(true);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Ik heb wel een idee...";
        subs2.GetComponent<Text>().text = "I might have an idea.";
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SceneManager.LoadScene(0);
        }


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
