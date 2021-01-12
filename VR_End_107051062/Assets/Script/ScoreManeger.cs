using UnityEngine;
using UnityEngine.UI;   // 引用 介面 API

public class ScoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text textScore;
    [Header("分數")]
    public static int score;
    [Header("投進的分數")]
    public int add ;
    [Header("進球音效")]
    public AudioClip soundIn;

    private AudioSource aud;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    // OTE 條件：
    // 兩個碰撞物件 其中一個 必須勾選 IsTrigger
    // 要偵測此腳本子物件是否產生碰撞
    // 必須添加剛體 Rigidbody
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball" )
        {
            AddScore();
        }
        
    }

    

    /// <summary>
    /// 加分數
    /// </summary>
    private void AddScore()
    {
        score += add;                                   // 分數遞增 投進的分數
        textScore.text = "分數：" + score;                   // 更新介面
        aud.PlayOneShot(soundIn, Random.Range(1f, 2f));     // 音效來源.播放一次(音效片段，音量)
    }
}
