using System;
using System.IO;
using System.Text;

namespace KGFramework.Editor
{
    public class ScriptHead : UnityEditor.AssetModificationProcessor
    {
        private static void OnWillCreateAsset(string path)
        {
            if(path.Contains("Network/Proto"))
                return;
            
            path = path.Replace(".meta", "");
            if (path.EndsWith(".cs"))
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("/****************************************************\n");
                string[] strs = path.Split('/');
                string scriptName = strs[strs.Length - 1];
                sb.Append(string.Format("*	文件：{0}\n", scriptName));
                sb.Append(string.Format("*	作者：{0}\n", "Kerven")); //Environment.UserName
                sb.Append("*	邮箱：1397796710@qq.com\n");
                sb.Append(string.Format("*	日期：{0}\n", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")));
                sb.Append("*	功能：Func\n");
                sb.Append("*****************************************************/\n\n");
                string str = File.ReadAllText(path);
                sb.Append(str);

                File.WriteAllText(path, sb.ToString());
            }
        }
    }
}