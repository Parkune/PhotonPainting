using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plate : MonoBehaviour
{
    public Color selectedColor;
    public static Plate instance;
    // 버튼을 클릭하였을 때
    // 클릭한 대상의 라인렌더러의 컬러값을
    // 현재 버튼의 컬러값과 일치시킨다.
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
