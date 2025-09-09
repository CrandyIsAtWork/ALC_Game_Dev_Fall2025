using UnityEngine;

public class Ballon : MonoBehaviour
{
    public int clickToPop = 3; //How many clicks before balloon pops

    public float scaleToIncrease = 0.10f; //Scale to increase each time balloon is clicked
    public int scoreToGive; //Score given for the popped balloon.

    private ScoreManager scoreManager; //A variable to refrence the ScoreManger
    public GameObject popEffect //Reference Pop Effect Particle System

    //Start is called before the first frame update
    void Start()
    {
        //Refrence ScoreManager Component*
        //scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
    void OnMouseDown()
    {
        // Reduce clicks by one
        clickToPop -= 1;
        //Increase balloon size
        transform.localScale += Vector3.one * scaleToIncrease;

        if (clickToPop == 0)
        {
            //scoreManager.IncreaseScoreText(scoreToGiveGive)
        }
    }
}
