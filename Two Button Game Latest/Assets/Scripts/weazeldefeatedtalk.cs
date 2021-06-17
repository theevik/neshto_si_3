using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class weazeldefeatedtalk : MonoBehaviour
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
        frost.SetActive(true);
        naiden.SetActive(false);
        weazel.SetActive(false);

        subs1.GetComponent<Text>().text = "Genoeg gespeeld, tijd om wat vragen te beantwoorden.";
        subs2.GetComponent<Text>().text = "Playtime is over pal, time to answer some questions.";
        yield return new WaitForSeconds(3f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = "Ik ken jou… Jij werkt voor die eikel Gimbo!";
        subs2.GetComponent<Text>().text = "I know you… You work for that prick Gimbo.";
        yield return new WaitForSeconds(2.8f);

        aero.SetActive(false);
        beta.SetActive(true);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Hey, houd de baas zijn naam uit je mond!!";
        subs2.GetComponent<Text>().text = "Hey, you better keep the boss’s name out your mouth.   ";
        yield return new WaitForSeconds(2.7f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = "Wat moeten jullie met mij, zijn jullie niet op zoek naar hem?";
        subs2.GetComponent<Text>().text = "What business do you have with me, aren’t you busy looking for him.";
        yield return new WaitForSeconds(3.2f);


        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(true);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Luister, vertel ons wat je weet over Gimbo’s verdwijning.";
        subs2.GetComponent<Text>().text = "Listen man, just tell us what you know about Gimbo's disappearance. ";
        yield return new WaitForSeconds(3.2f);


        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = "En waarom denk je dat ik daar iets over zou zeggen? Wat heb ik eraan?";
        subs2.GetComponent<Text>().text = "And why do you think I will open my mouth for you. What’s in it for me?";
        yield return new WaitForSeconds(3.8f);


        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(true);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Dan mag je je andere hand houden... ";
        subs2.GetComponent<Text>().text = "You get to keep your other hand. ";
        yield return new WaitForSeconds(2.5f);


        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = "Kijk, ik heb geen idee wie hier bij betrokken is, veel mensen will Gimbo vermoorden in deze stad.";
        subs2.GetComponent<Text>().text = "Look, I don’t know who’s involved in this, a lot of people in this city want Gimbo dead. ";
        yield return new WaitForSeconds(5.3f);


        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = "Hoe weten jullie zo zeker dat hij niet al aan het rotten is in een goot?";
        subs2.GetComponent<Text>().text = "How do you know he’s not rotting in some ditch already?";
        yield return new WaitForSeconds(4.5f);


        aero.SetActive(false);
        beta.SetActive(true);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Jij stelt hier de vragen niet. ";
        subs2.GetComponent<Text>().text = "You don’t get to ask questions. ";
        yield return new WaitForSeconds(2f);

        
        aero.SetActive(true);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Kom op Weazel, jij en je maatjes zijn altijd aan het rondhangen in de bar, je moet toch wel iets gehoord hebben. ";
        subs2.GetComponent<Text>().text = "Come on Weazel, you and your buddies hang out at the bar all day, you must have heard something suspicious.";
        yield return new WaitForSeconds(6f);


        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = "Nu je het zegt, een van Batka’s mannen hadden het over een “grote bezorging” ergens later vanavond.";
        subs2.GetComponent<Text>().text = "Now that you mention it, I remember last night some of Batka’s men were going on about a big delivery that’s happening later tonight.";
        yield return new WaitForSeconds(6f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(true);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Wat voor bezorging?";
        subs2.GetComponent<Text>().text = "What type of delivery?";
        yield return new WaitForSeconds(2.5f);


        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = "Eerst dacht ik dat het weer over die drugs ging die ze aan het maken zijn, maar een m’n maten...";
        subs2.GetComponent<Text>().text = "At first, I thought it was more of those drugs they’ve been making, but one of the boys told... ";
        yield return new WaitForSeconds(5f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = "...vertelde me dan hij er meerdere zag rondhangen in een verlaten metrostation niet ver van hier.";
        subs2.GetComponent<Text>().text = "...me he saw a bunch of them hanging around the abandoned subway station not far from here.";
        yield return new WaitForSeconds(5f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = "Lijkt erop dat ze een trein gebruiken, rare drugs bezorging als je het mij vraagt.";
        subs2.GetComponent<Text>().text = "Seems like they’ll be using a train this time, pretty irregular for a drug delivery if you ask me.";
        yield return new WaitForSeconds(4f);

        aero.SetActive(true);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Klinkt alsof het het waar is om een kijkje te nemen, wat zeggen jullie?";
        subs2.GetComponent<Text>().text = "What do you say guys, sounds like it’s worth checking out.";
        yield return new WaitForSeconds(3.5f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(true);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Tis beter dan niks, ergste wat er kan gebeuren is dat we meer informatie uit hun slaan.";
        subs2.GetComponent<Text>().text = "Better than nothing, worst case scenario we beat more info out of them.";
        yield return new WaitForSeconds(4.2f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(true);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Ik weet waar het is, volg mij. ";
        subs2.GetComponent<Text>().text = ": I know the place, let’s go.";
        yield return new WaitForSeconds(3.5f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = "Wat dachten jullie van wat financiele compensatie, voor de informatie weetjewel?";
        subs2.GetComponent<Text>().text = "How about a financial compensation…for my troubles.";
        yield return new WaitForSeconds(4.5f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(true);
        naiden.SetActive(false);
        weazel.SetActive(false);
        subs1.GetComponent<Text>().text = "Ik dacht dat we het al eens  waren dat je je arm mocht houden.";
        subs2.GetComponent<Text>().text = "I thought we already settled on you keeping your arm.";
        yield return new WaitForSeconds(4.5f);

        aero.SetActive(false);
        beta.SetActive(false);
        frost.SetActive(false);
        naiden.SetActive(false);
        weazel.SetActive(true);
        subs1.GetComponent<Text>().text = "Klootzakken…";
        subs2.GetComponent<Text>().text = "You assholes…";


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
