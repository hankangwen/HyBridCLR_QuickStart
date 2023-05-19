/****************************************************
*	文件：AssetBundleMgr.cs
*	作者：Kerven
*	邮箱：1397796710@qq.com
*	日期：2023/05/20 14:22:30
*	功能：Func
*****************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KGFramework
{
    public class AssetBundleMgr
    {
        private static Dictionary<string, AssetBundle> _name2AbDict = new Dictionary<string, AssetBundle>();

        public static AssetBundle LoadFromMemory(string file)
        {
            AssetBundle ab;
            if (_name2AbDict.TryGetValue(file, out ab))
            {
                return ab;
            }

            ab = AssetBundle.LoadFromMemory(CommonTool.ReadBytesFromStreamingAssets("prefabs"));
            _name2AbDict.Add(file, ab);
            return ab;
        }

        public static bool UnloadAssetBundle(string file)
        {
            if (_name2AbDict.TryGetValue(file, out AssetBundle ab))
            {
                ab.Unload(true);
                return true;
            }

            return false;
        }
        
        
    }
}