using System.Linq;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using Sirenix.Serialization;
using Sirenix.Utilities;
using Sirenix.Utilities.Editor;
using UnityEditor;
using UnityEngine;

public class TestMenuEditor : OdinMenuEditorWindow
{
    protected override OdinMenuTree BuildMenuTree()
    {
        return new OdinMenuTree();
    }
}
