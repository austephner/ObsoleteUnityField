# ObsoleteUnityField
#### Summary
An attribute for Unity fields that visually marks them as "obsolete" in the Unity Editor.

# Usage
1. Import the `ObsoleteUnityField` namespace into a C# file. 
2. Put `[ObsoleteUnityField]` on any field. 
3. (OPTIONAL) Give an obsolete message using the attribute's constructor: `[ObsoleteUnityField("Don't use this field!")]`

```c#
using UnityEngine;
using ObsoleteUnityField;

public class MyBehaviour : MonoBehaviour 
{
    [SerializeField, ObsoleteUnityField("Use the min threshold field."), Obsolete]
    private float _threshold = 0.15f; 
    
    [SerializeField] 
    private float _minThreshold = 0.5f; 
}
```

![Example](https://i.imgur.com/M59Yw5D.gif)

# Pitfalls
- Not a replacement for `[Obsolete]`, but useful as a parallel attribute. 