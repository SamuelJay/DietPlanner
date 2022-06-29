using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : BaseBehaviour {
    public static Manager instance;

    public virtual void Setup() {
        if (instance != null) {
            Debug.LogError("Singleton says no!!");
        } else {
            instance = this;
        }
    }
}
