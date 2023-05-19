/****************************************************
*	文件：KGEditorTool.cs
*	作者：Kerven
*	邮箱：1397796710@qq.com
*	日期：2023/05/20 15:39:45
*	功能：Func
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace KGFramework.Editor
{
    /// <summary>
    /// 把crlf换行转为lf换行
    /// </summary>
    public static class KGEditorTool
    {
        [MenuItem("Assets/KervenTools/crlf2lf")]
        static void CRLFtoLF()
        {
            Object[] arrs = Selection.GetFiltered(typeof(Object), SelectionMode.Assets);
            foreach (var arr in arrs)
            {
                string assetPath = AssetDatabase.GetAssetPath(arr);
                string filePath = Application.dataPath + "/" + assetPath.Substring(7);
                _CRLFtoLF(filePath);
            }
            AssetDatabase.Refresh();
            Debug.Log("执行完成");
        }

        static void _CRLFtoLF(string filePath)
        {
            string fileContent;
            using (StreamReader reader = new StreamReader(filePath))
            {
                fileContent = reader.ReadToEnd();
            }

            fileContent = fileContent.Replace("\r\n", "\n");

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.Write(fileContent);
            }
        }
    }
}