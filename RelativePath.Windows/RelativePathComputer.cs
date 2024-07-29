using System;
using System.Collections.Generic;
using System.IO;

namespace RelativePath.Windows
{
    public static class RelativePathComputer
    {
        /// <summary>
        /// 获取相对路径
        /// <br>目前不支持类似docume~1的写法</br>
        /// </summary>
        /// <param name="inputAbs">输入绝对路径，如果无效 则返回null</param>
        /// <param name="reference">参考绝对路径，.代表的路径，如果无效 则返回输入路径</param>
        /// <param name="tolerance">容忍度绝对路径，如果..找上级路径超越了该路径 则认为再计算无意义、返回绝对路径，如果想正常启用 则需要包含输入路径，如果输入null 则关闭该功能</param>
        /// <param name="outputRela">输出路径，如果输入路径异常 则输出null，如果参考路径异常、跨盘符、超过容忍度 则输出绝对路径，目前不带""</param>
        /// <param name="splitter">输出路径分隔符</param>
        /// <returns>false 输入路径异常、参考路径异常、跨盘符、超过容忍度不计算相对路径；true 能计算出相对路径</returns>
        public static bool GetRelativePath(string inputAbs, string reference, string tolerance, out string outputRela, string splitter = @"\")
        {
            bool ret = false;
            outputRela = null;
            if (inputAbs != null)
            {
                inputAbs = inputAbs.Trim('\"');
            }
            if (reference != null)
            {
                reference = reference.Trim('\"');
            }
            if (tolerance != null)
            {
                tolerance = tolerance.Trim('\"');
            }
            if (string.IsNullOrWhiteSpace(inputAbs)
                || !(File.Exists(inputAbs) || Directory.Exists(inputAbs))
                )
            {
                ret = false;
                outputRela = null;
            }
            else if (string.IsNullOrWhiteSpace(reference)
                     || !Directory.Exists(reference)
                    )
            {
                ret = false;
                outputRela = inputAbs;
            }
            else
            {
                string[] separatorArr = new string[] { @":\", ":/", @"\", @"\\", "/", "//" };
                string[] inputArr = inputAbs.Split(separatorArr, StringSplitOptions.None);
                string[] referArr = reference.Split(separatorArr, StringSplitOptions.RemoveEmptyEntries);
                // 跨盘符
                if (inputArr[0].ToLower() != referArr[0].ToLower())
                {
                    ret = false;
                    outputRela = inputAbs;
                }
                else
                {
                    bool toleranceFlag = true;
                    // 启用tolerance
                    if (!string.IsNullOrWhiteSpace(tolerance)
                        && Directory.Exists(tolerance)
                       )
                    {
                        string[] tolerArr = tolerance.Split(separatorArr, StringSplitOptions.RemoveEmptyEntries);
                        if (tolerArr.Length <= inputArr.Length)
                        {
                            for (int i = 0; i < tolerArr.Length; ++i)
                            {
                                if (tolerArr[i].ToLower() != inputArr[i].ToLower())
                                {
                                    toleranceFlag = false;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            toleranceFlag = false;
                        }
                    }
                    if (!toleranceFlag)
                    {
                        ret = false;
                        outputRela = inputAbs;
                    }
                    // input未超出tolerance范围或者tolerance未启用
                    else
                    {
                        List<string> outputList = new List<string>();
                        int minLen = inputArr.Length < referArr.Length ? inputArr.Length : referArr.Length;
                        int commonIndex = 0;        // 分叉之前的下标
                        for (int i = 0; i < minLen; commonIndex = i, ++i)
                        {
                            if (inputArr[i].ToLower() != referArr[i].ToLower())
                            {
                                break;
                            }
                        }
                        for (int i = commonIndex; i < referArr.Length - 1; ++i)
                        {
                            outputList.Add("..");
                        }
                        if (!outputList.Contains(".."))
                        {
                            outputList.Add(".");
                        }
                        for (int i = commonIndex + 1; i < inputArr.Length; ++i)
                        {
                            outputList.Add(inputArr[i]);
                        }
                        ret = true;
                        outputRela = string.Join(splitter, outputList);
                    }
                }
            }
            return ret;
        }
    }
}
