using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CommonTool
{
    public static byte[] ReadBytesFromStreamingAssets(string file)
    {
        // Android平台不支持直接读取StreamingAssets下文件，请自行修改实现
        return File.ReadAllBytes($"{Application.streamingAssetsPath}/{file}");
    }
}
