using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plate : MonoBehaviour
{
    public Color selectedColor;
    public static Plate instance;
    // ��ư�� Ŭ���Ͽ��� ��
    // Ŭ���� ����� ���η������� �÷�����
    // ���� ��ư�� �÷����� ��ġ��Ų��.
    private void Awake()
    {
        instance = this;
    }

    [SerializeField]
    public Color color;



    // Start is called before the first frame update
    void Start()
    {
      
       // color = GetComponent<Color>();
    }

    public void UpdateCorlorChange(int num)
    {

    

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
