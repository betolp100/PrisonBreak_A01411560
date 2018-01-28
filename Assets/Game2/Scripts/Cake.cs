using UnityEngine.UI;
using UnityEngine;

public class Cake : MonoBehaviour {
    public Image cakeImage;
    public Text cakeT;
    public GameObject backGround;
    public Color red;
	void Start () {
        cakeT.text = "Alright, it seems that I have to reward you, so . . .\nHere, take this cake: ";

    }

    public void WantCake()
    {
        backGround.GetComponent<Renderer>().material.color = red;
        Destroy(cakeImage);
        cakeT.text = "I LIE, WHY WOULD I GIVE YOU A CAKE WHEN YOU CHEAT,\nNO ONE CAN WIN AT MY GAME.";
    }
}
