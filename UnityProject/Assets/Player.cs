using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("血量")]
    public float Hp = 100;
    [Header("攻擊力")]
    public float Atk;
    [Header("殭屍")]
    public Zombie Zb;  // 可以使用Zombie的參數
    [Header("喇叭")]
    public AudioSource Aud;
    [Header("音效")]
    public AudioClip SoundAtk;


    public void Attake() // 玩家的攻擊與儲存數值
    {
        if (Input.GetKeyDown("a"))
        {
            Atk = Random.Range(10f, 20f);
            print("<color=blue>殭屍受到的傷害: " + Atk + Hp + "</color>");
            Zb.Hurt(Atk);  // 將Atk的數值存到Zombie中的Hurt方法
            Aud.PlayOneShot(SoundAtk, 1f);  //開啟音效
        }
    }

    public void Hurt(float damage) // 玩家的受傷與剩餘血量
    {
        Hp = Hp - damage;   // damage用來讀取Zombie的攻擊數值
        print("<color=red>玩家剩下的血量: " + Hp + "</color>");
    }

    public void Dead() // 玩家的死亡
    {
        if (Hp <= 0)
        {
            print("<color=red>玩家死亡</color>");
        }
    }

    private void Update()
    {
        Attake();
        Dead();
    }
    
}
