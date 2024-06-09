using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EntityCountSystem : MonoBehaviour
{
    public int HenTotal = 0;
    public int ChickTotal = 0;
    public int RoosterTotal = 0;
    public int EggsTotal = 0;

    public TextMeshProUGUI roosterText;
    public TextMeshProUGUI henText;
    public TextMeshProUGUI chickText;
    public TextMeshProUGUI eggText;
   
    void Update()
    {
        GameObject[] henCount = GameObject.FindGameObjectsWithTag("Hen");
        GameObject[] chickCount = GameObject.FindGameObjectsWithTag("Chick");
        GameObject[] roosterCount = GameObject.FindGameObjectsWithTag("Rooster");
        GameObject[] eggCount = GameObject.FindGameObjectsWithTag("Egg");

        HenTotal = henCount.Length;
        ChickTotal = chickCount.Length;
        RoosterTotal = roosterCount.Length;
        EggsTotal = eggCount.Length;

        roosterText.text = RoosterTotal.ToString();
        henText.text = HenTotal.ToString();
        chickText.text = ChickTotal.ToString();
        eggText.text = EggsTotal.ToString();
    }
}
