/****************************************************
*	文件：CommonTool.cs
*	作者：Kerven
*	邮箱：1397796710@qq.com
*	日期：2023/05/20 14:22:30
*	功能：Func
*****************************************************/

using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace KGFramework
{
    public static class CommonTool
    {
        public static byte[] ReadBytesFromStreamingAssets(string file)
        {
            // Android平台不支持直接读取StreamingAssets下文件，请自行修改实现
            return File.ReadAllBytes($"{Application.streamingAssetsPath}/{file}");
        }
    }
}