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

}
