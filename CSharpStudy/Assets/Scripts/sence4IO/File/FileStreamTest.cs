using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using System;

public class FileStreamTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // CreateFile();
        ReadFile();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateFile()
    {
        // 定义文件路径
        string path = @"D:\\github_repo\\Unity\\UnityBasic\\CSharpStudy\\Assets\\Resources\\testfile.txt";    
        
        // 创建FileStream 类的实例
        FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        /*
         1 FileAccess
            Read 以只读方式打开
            Write 以写方式打开
            ReadWrite 以读写方式打开
         2 FileMode
            CreateNew   创建新文件，如果已存在，则会返回异常
            Create      创建文件， 如果文件存在，删除原有文件，并重新建立新文件
            Open        打开已经存在的文件，如果文件不存在，则会返回异常
            OpenOrCreate    打开已经存在的文件，如果文件不存在，则会新建文件
            Truncate    打开已经存在的文件，并清楚文件中的内容，如果文件不存在则会返回异常
            Append      打开文件，用于向文件中追加内容，如果文件不存在则会创建一个新的文件
         3 FlieShare 
            None        谢绝共享当前文件
            Read        允许随后打开读取信息
            ReadWrite   允许随后打开文件读写信息
            Write       允许随后打开文件写入信息
            Delete      允许随后删除文件
            Inheritable 使文件句柄可以由子进程继承
         4 FileOptions
         */


        // 定义文本内容
        string msg = "03190824";
        
        // 将字符串转化为字节数组
        byte[] bytes = Encoding.UTF8.GetBytes(msg);

        // 向文件中写入数据
        fileStream.Write(bytes, 0, bytes.Length);

        // 刷新缓冲区 关闭流
        fileStream.Flush();
        fileStream.Close();
    
    
    }

    void ReadFile()
    {
        string path = @"D:\\github_repo\\Unity\\UnityBasic\\CSharpStudy\\Assets\\Resources\\testfile.txt";

        if (File.Exists(path))
        {
            // 创建FileStream 类的实例
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            /*
             1 FileAccess
                Read 以只读方式打开
                Write 以写方式打开
                ReadWrite 以读写方式打开
             2 FileMode
                CreateNew   创建新文件，如果已存在，则会返回异常
                Create      创建文件， 如果文件存在，删除原有文件，并重新建立新文件
                Open        打开已经存在的文件，如果文件不存在，则会返回异常
                OpenOrCreate    打开已经存在的文件，如果文件不存在，则会新建文件
                Truncate    打开已经存在的文件，并清楚文件中的内容，如果文件不存在则会返回异常
                Append      打开文件，用于向文件中追加内容，如果文件不存在则会创建一个新的文件
             3 FlieShare 
                None        谢绝共享当前文件
                Read        允许随后打开读取信息
                ReadWrite   允许随后打开文件读写信息
                Write       允许随后打开文件写入信息
                Delete      允许随后删除文件
                Inheritable 使文件句柄可以由子进程继承
             4 FileOptions

             */



            // 定义存放文件信息的字节数组
            byte[] bytes = new byte[fileStream.Length];

            // 读取文件信息
            fileStream.Read(bytes, 0, bytes.Length);

            // 将得到的字节型数组重写编码为字符串
            string c = Encoding.UTF8.GetString(bytes);
            Debug.Log(c);

            // 关闭文件
            fileStream.Close();


        }
        else
        {
            Console.WriteLine("File not exist!");
        }


    }
}
