using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class afterfirstbattletalk : MonoBehaviour
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
        beta.SetActive(true);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);

        subs1.GetComponent<Text>().text = "Als deze mensen hier zijn dan kan Batka niet ver zijn. Alleen nog steeds niks over Gimbo te zien...";
        yield return new WaitForSeconds(2f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(true);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Yo, wat als weasel gelijk had en de baas is... weetjewel... dood? ";
        yield return new WaitForSeconds(2f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(true);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Je zag toch hoe zijn apartmenet eruit zag, hij heeft sowieso teruggevochten.";
        yield return new WaitForSeconds(2f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(true);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Als ze hem dood konden maken dan was het daar op dat moment gebeurd. ";
        yield return new WaitForSeconds(2f);


        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(true);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Da’s waar, tijd om te zoeken of we iets van hem kunnen vinden. ";
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
