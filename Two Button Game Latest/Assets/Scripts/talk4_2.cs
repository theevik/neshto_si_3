using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class talk4_2 : MonoBehaviour
{
    public GameObject subs1;

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
        yield return new WaitForSeconds(2f);

        aero.SetActive(false);
        beta.SetActive(true);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Hij heft vast een kapotte gefixed die achtergelaten was wanneer de stad in drieën was gesplitst. Meeste ervan waren verplaatst naar de binnen en centrale gebieden voordat reizen ernaar verboden werd.";
        yield return new WaitForSeconds(2f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(true);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Yeah, the rich bastards living there took everything they could and left us in this dump. Inderdaad, rijke klootzakken die daar wonen hebben alles voor hunzelf genomen en ons in de goot gelaten.";
        yield return new WaitForSeconds(2f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(true);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "over klootzakken gesproken; ik zie een van batka’s mannen daar.";
        yield return new WaitForSeconds(2f);


        aero.SetActive(false);
        beta.SetActive(true);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Jongens, aanvallen!";
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
