using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class firstscenetalk : MonoBehaviour
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
        naiden.SetActive(true);
        weazel.SetActive(false);

        subs1.GetComponent<Text>().text = "Kom op! ";
        subs2.GetComponent<Text>().text = "Let’s go already.";
        yield return new WaitForSeconds(1f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(true);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Houd je mond, straks verraad je onze positie.  ";
        subs2.GetComponent<Text>().text = "Quiet kid, you’ll give away our position. ";
        yield return new WaitForSeconds(2.5f);

        aero.SetActive(false);
        beta.SetActive(true);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Weet je zeker dat dat hem is Aero?  ";
        subs2.GetComponent<Text>().text = " Are you sure that’s the guy Aero? ";
        yield return new WaitForSeconds(2.7f);

        aero.SetActive(true);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Ik weet het zeker, dat is Weazel. ";
        subs2.GetComponent<Text>().text = "  No mistake, that’s Weazel.";
        yield return new WaitForSeconds(2.5f);


        aero.SetActive(true);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Hij is een best wel betrouwbare bron in dit gebied, hij weet vast meer.";
        subs2.GetComponent<Text>().text = " He’s a pretty reliable informant around these parts, he would have definitely heard something.";
        yield return new WaitForSeconds(4.4f);


        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(true);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Eens zien hoe goed zijn gehoor is dan!";
        subs2.GetComponent<Text>().text = " Then let’s check how his hearing is!";
        yield return new WaitForSeconds(2f);


        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(true);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "HEY, JIJ DAAR!!! ";
        subs2.GetComponent<Text>().text = " HEY, YOU!";
        yield return new WaitForSeconds(1.7f);


        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = "Huh?";
        subs2.GetComponent<Text>().text = " Huh? ";
        yield return new WaitForSeconds(0.8f);


        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(true);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Hahaha, kijk hem rennen. Endelijk, wat actie!!";
        subs2.GetComponent<Text>().text = " Hahaha, this punk started running. Finally, some action. ";
        yield return new WaitForSeconds(2.8f);


        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(true);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Pak hem, idioot!! ";
        subs2.GetComponent<Text>().text = "Frost: Grab him, moron!";
        yield return new WaitForSeconds(1.7f);

        //maybe here an image switch? battle without hud?


        aero.SetActive(false);
        beta.SetActive(true);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Doodlopend eind, geef het op Weazel! ";
        subs2.GetComponent<Text>().text = " Dead end… nowhere to run Weazel, let it go! ";
        yield return new WaitForSeconds(3.5f);


        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = "NIET DICHTERBIJ KOMEN!!";
        subs2.GetComponent<Text>().text = "  STAY BACK! ";
        yield return new WaitForSeconds(2f);


        aero.SetActive(true);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Dan maar op de moeilijke manier.";
        subs2.GetComponent<Text>().text = " Guess we’re doing this the hard way. ";
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
