public class AOTGenericReferences : UnityEngine.MonoBehaviour
{

	// {{ AOT assemblies
	// UnityEngine.AssetBundleModule.dll
	// UnityEngine.CoreModule.dll
	// mscorlib.dll
	// }}

	// {{ constraint implement type
	// }} 

	// {{ AOT generic types
	// System.Collections.Generic.List<HotUpdate.Entry.MyVec3>
	// }}

	public void RefMethods()
	{
		// object UnityEngine.AssetBundle.LoadAsset<object>(string)
		// object UnityEngine.GameObject.AddComponent<object>()
		// object UnityEngine.Object.Instantiate<object>(object)
	}
}