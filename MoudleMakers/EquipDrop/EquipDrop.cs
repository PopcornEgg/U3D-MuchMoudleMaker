using UnityEngine;
using System.Collections;

public class Drop : MonoBehaviour {

    static Random rander = new Random();
    public GameObject[] dropList;
	// Use this for initialization
	void Start () {
        //Died();
    }
	
	// Update is called once per frame
	void Update () {
        

    }

   // Can't destroy Transform component of 'Cylinder'. If you want to destroy the game object, please call 'Destroy' on the game object instead. Destroying the transform component is not allowed.

    public void Died() {

        //if (dropList == null)
        //    return;

        //Debug.Log("in Died");
        //Destroy(this);
        //DestroyImmediate(gameObject);

        //UnityEngine.Object obj = Resources.Load("sword");
        //Instantiate(obj);
        //Instantiate<GameObject>("sword");



        int dropNum = Random.Range(1, 5);
        Debug.Log("src   Random :" + dropNum);
        while (dropNum-- > 0) {

            // Debug.Log("Random :" + dropNum);
            transform.Rotate(Vector3.up, 30.0f);
           // transform.rotation.rat
            Instantiate(dropList[Random.Range(0, dropList.Length)], transform.position, transform.rotation);
        }

        
    }

}
