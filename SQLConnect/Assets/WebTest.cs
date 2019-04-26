using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class WebTest : MonoBehaviour
{

    // Use this for initialization
    IEnumerator Start()
    {
        WWW request = new WWW("http://127.0.0.1/sqlconnect/webtest.php");
        yield return request;
        Debug.Log(request.text);
    }

}
