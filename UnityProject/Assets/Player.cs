using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("血量")]
    public float Hp = 100;
    [Header("攻擊力")]
    public float Atk;
    [Header("殭屍")]
    public GameObject Zb;
    [Header("喇叭")]
    public AudioSource Aud;
    [Header("音效")]
    public AudioClip SoundAtk;

    private void Start()
    {
        
    }
    private void Update()
    {
        
        if (Input.GetKeyDown("a"))
        {
            Atk = Random.Range(10f, 20f);
            print("殭屍受到的傷害: " + Atk);
        }
        else if (Input.GetKeyDown("d"))
        {
            print("玩家剩餘的血量: " + (Hp - Atk));
        }
        
        

    }
    
}
