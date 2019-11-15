using UnityEngine;

public class player : MonoBehaviour
{
    [Header ("速度")][Range (0f,100f)]
    public float speed = 3.5f;
    [Header ("跳跃"),Range(100,2000)]
    public int jump = 300;
    [Header("是否在地板上"),Tooltip("用来判定角色是否在地板上。")]
    public bool isGround = false;
    [Header("角色名称")]
    public string name = "弦";
    [Header("元件")]
    public Rigidbody2D r2d;
    public Animator ani;

    private void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");  // 输入，取得轴向（水平），左右与AD。
        r2d.AddForce(new Vector2(speed * h , 0));
        ani.SetBool("跑步开关",h != 0);
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            isGround = false;
            r2d.AddForce(new Vector2(0,jump));
        }
    }

    private void  Dead()
    {

    }

    //事件：在特定事件点以指定次数执行
    //更新事件：一秒执行约60次(60fps)
    private void Update()
    {
        Move();
    }

    private void  OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name=="地板")
        {
            isGround = true;
        }
    }
    
}
