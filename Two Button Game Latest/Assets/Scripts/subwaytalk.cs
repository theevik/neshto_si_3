using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class subwaytalk : MonoBehaviour
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

        subs1.GetComponent<Text>().text = "Weten jullie zeker dat we Weazel kunnen vetrouwen, dit ziet er... verdacht uit.";
        subs2.GetComponent<Text>().text = "Boys are you sure we can trust Weazel, all of this seems kind of… sketchy.";
        yield return new WaitForSeconds(4f);

       
        aero.SetActive(true);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = " Ach, hij is gewoon een klootzak die de meeste van zijn tijd in de bar besteed, niks om je zorgen over te maken.";
        subs2.GetComponent<Text>().text = "He’s Just your average scumbag who spends most his day at the bar, nothing we should be too worried about. ";
        yield return new WaitForSeconds(6f);

        aero.SetActive(false);
        beta.SetActive(true);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Hoe kennen jullie elkaar eigenlijk?";
        subs2.GetComponent<Text>().text = "How do you two know each other anyway?";
        yield return new WaitForSeconds(2f);

        aero.SetActive(true);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Ik besteedde vroeger veel tijd in de bar. ";
        subs2.GetComponent<Text>().text = "I used to spend a lot of time at the bar myself. ";
        yield return new WaitForSeconds(2.2f);

        aero.SetActive(false);
        beta.SetActive(true);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Mooi ";
        subs2.GetComponent<Text>().text = "Classy.";
        yield return new WaitForSeconds(2f);


        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = "HEY! Wat doen jullie hier? Ren maar snel weg nu het nog kan";
        subs2.GetComponent<Text>().text = "HEY! What are you bastards doing here, get lost while you still have the chance.";
        yield return new WaitForSeconds(4.2f);


        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(true);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Oh ja? Laat ons maar eens waar de uitgang is, eikel! ";
        subs2.GetComponent<Text>().text = "Oh yea? Well how about you come show me where the exit is punk. ";
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
