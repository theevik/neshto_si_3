using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class talk4_2 : MonoBehaviour
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

        subs1.GetComponent<Text>().text = "Ik vraag me af hoe Batka een trein hebben gekregen zo ver aan het randje van de stad.";
        subs2.GetComponent<Text>().text = "I wonder how Batka got his hands on a train here in the outer region of the city. ";
        yield return new WaitForSeconds(6f);

        aero.SetActive(false);
        beta.SetActive(true);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Hij heft vast een kapotte gefixed die achtergelaten was wanneer de stad in drieën was gesplitst.";
        subs2.GetComponent<Text>().text = "He must’ve managed to fix a broken one that was left behind when the city split in three.";
        yield return new WaitForSeconds(5f);

        aero.SetActive(false);
        beta.SetActive(true);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Meeste ervan waren verplaatst naar de binnen en centrale gebieden voordat reizen ernaar verboden werd.";
        subs2.GetComponent<Text>().text = "Most of the trains got moved to the inner and central regions before travel to them became restricted. ";
        yield return new WaitForSeconds(7f);


        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(true);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = " rijke klootzakken die daar wonen hebben alles voor hunzelf genomen en ons in de goot gelaten.";
        subs2.GetComponent<Text>().text = "Yeah, the rich bastards living there took everything they could and left us in this dump.";
        yield return new WaitForSeconds(5f);


        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(true);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "over klootzakken gesproken; ik zie een van batka’s mannen daar.";
        subs2.GetComponent<Text>().text = "Speaking of bastards; I see more of Batka’s men up ahead.";
        yield return new WaitForSeconds(5f);


        aero.SetActive(false);
        beta.SetActive(true);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Jongens, aanvallen!";
        subs2.GetComponent<Text>().text = "Let’s get em boys!";
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
