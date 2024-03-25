
using R3;
using R3.Triggers;
using R3.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using ObservableCollections;

public class TestFile : MonoBehaviour
{
    [SerializeField]
    private Button button;
    [SerializeField]
    private Text addedText;
    [SerializeField]
    private Text removededText;

    private ObservableList<int> mockInt = new ObservableList<int>();

    // Start is called before the first frame update
    void Start()
    {
        //create  subscription for mockint add remove
        mockInt.ObserveAdd()
            .Select(x => x.Value)
            .Select(x => x + 1)
            .Select (x => "ADDED " + x)
            .SubscribeToText(addedText);

        mockInt.ObserveRemove() .Select(x => x.Value)
            .Select(x=> "REMOVED " + x)
            .SubscribeToText(removededText);
            
        Observable.Interval(TimeSpan.FromMilliseconds(100))
            .Subscribe(_ =>
        {
            int val = UnityEngine.Random.Range(0, 100);
            mockInt.Add(val);
        }).AddTo(this);

        Observable.Interval(TimeSpan.FromMilliseconds(200))
            .Subscribe(_ =>
            {
                mockInt.RemoveAt(0);
            }).AddTo(this);
    }

}
