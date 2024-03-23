using Cysharp.Threading.Tasks;
using Cysharp.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Threading.Tasks;

public class TestFile : MonoBehaviour
{
    [SerializeField]
    private Button button;

    // Start is called before the first frame update
    void Start()
    {

        //    button.OnClickAsObservable()
        //.SelectAwait(async (_, ct) =>
        //{
        //    var req = await UnityWebRequest.Get("https://google.com/").SendWebRequest().WithCancellation(ct);
        //    return req.downloadHandler.text;
        //}, AwaitOperation.Drop)
        //.SubscribeToText(text);
        this.GetCancellationTokenOnDestroy();
    }


    async Task<string> GetTime()
    {
        var ct = this.GetCancellationTokenOnDestroy();
        string url = "http://worldtimeapi.org/api/timezone/Asia/Bangkok";
        var request = await UnityWebRequest.Get(url).SendWebRequest().WithCancellation(ct);
        return  "";

}
// Update is called once per frame
void Update()
    {
        
    }
}
