using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class afterfirstbattletalk : MonoBehaviour
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

        subs1.GetComponent<Text>().text = "Als deze mensen hier zijn dan kan Batka niet ver zijn. Alleen nog steeds niks over Gimbo te zien...";
        subs2.GetComponent<Text>().text = "If these guys are here Batka shouldn’t be too far, still no signs of Gimbo though.";
        yield return new WaitForSeconds(5.5f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(true);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Yo, wat als weasel gelijk had en de baas is... weetjewel... dood? ";
        subs2.GetComponent<Text>().text = "Yo guys, what if what Weazel said is true and big boss got… y’know … smoked";
        yield return new WaitForSeconds(5.7f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(true);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Je zag toch hoe zijn apartmenet eruit zag, hij heeft sowieso teruggevochten.";
        subs2.GetComponent<Text>().text = "You saw the state of his apartment, he was trying to put up a fight.";
        yield return new WaitForSeconds(5f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(true);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Als ze hem dood konden maken dan was het daar op dat moment gebeurd. ";
        subs2.GetComponent<Text>().text = "If they wanted him dead, they could’ve done it right then and there.";
        yield return new WaitForSeconds(3.9f);


        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(true);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Da’s waar, tijd om te zoeken of we iets van hem kunnen vinden. ";
        subs2.GetComponent<Text>().text = "Fair enough, then let’s go see if he’s around. ";
        yield return new WaitForSeconds(2f);


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
