using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerBag : MonoBehaviour
{
    public GameObject contentObj;
    public GameObject itemObj;

    static int rowCount = 10;
    static int columnCount = 5;

    void Start()
    {
        if (itemObj == null)
            return;

        ScrollRect srt = transform.FindChild("Main").GetComponent<ScrollRect>();
        float wh = 40.0f;
        for (int r = 0; r < rowCount; r++)
        {
            for (int c = 0; c < columnCount; c++)
            {
                GameObject cobj = Instantiate<GameObject>(itemObj);
                cobj.SetActive(true);

                //cobj.en
                cobj.transform.SetParent(contentObj.transform, false);
                RectTransform rtf = cobj.GetComponent<RectTransform>();

                rtf.anchoredPosition = new Vector2(c * wh, r * wh);
            }
        }
        itemObj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
