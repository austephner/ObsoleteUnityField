# ObsoleteUnityField
#### Summary
An attribute for Unity fields that visually marks them as "obsolete" in the Unity Editor.

# Usage
#### Getting Started
1. Import the `ObsoleteUnityField` namespace into a C# file. 
2. Put `[ObsoleteUnityField]` on any field. 

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

#### Additional Usages
1. The constructor can take an **optional** `string` message which gets appended to the front of the field's tooltip (if there is one). See the above example.
2. The constructor can take another **optional** `bool` value to denote whether or not the field is editable. 

```c#
[ObsoleteUnityField, SerializeField] 
private int _obsoleteField1 = 10;

[ObsoleteUnityField("Don't use this field.")
private int _obsoleteField2 = 10;

[ObsoleteUnityField(false)]
private int _obsoleteField3 = 10;

[ObsoleteUnityField("This field has been made obsolete.", false)]
private int _obsoleteField4 = 10;
```

# Pitfalls
- Not a replacement for `[Obsolete]`, but useful as a parallel attribute. 