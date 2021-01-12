using UnityEngine.UI;
using UnityEngine;

public class SSM : MonoBehaviour
{
    [Header("分數介面")]
    public Text textScore;
    [Header("分數")]
    public static int score;
    [Header("投進的分數")]
    public int add;
    [Header("進球音效")]
    public AudioClip soundIn;

    private AudioSource aud;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            AddScore();
        }

    }


    private void AddScore()
    {
        score += add;                                   
        textScore.text = "分數：" + score;                   
        aud.PlayOneShot(soundIn, Random.Range(1f, 2f));     
    }
}
