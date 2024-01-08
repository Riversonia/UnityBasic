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
        // �����ļ�·��
        string path = @"D:\\github_repo\\Unity\\UnityBasic\\CSharpStudy\\Assets\\Resources\\testfile.txt";    
        
        // ����FileStream ���ʵ��
        FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        /*
         1 FileAccess
            Read ��ֻ����ʽ��
            Write ��д��ʽ��
            ReadWrite �Զ�д��ʽ��
         2 FileMode
            CreateNew   �������ļ�������Ѵ��ڣ���᷵���쳣
            Create      �����ļ��� ����ļ����ڣ�ɾ��ԭ���ļ��������½������ļ�
            Open        ���Ѿ����ڵ��ļ�������ļ������ڣ���᷵���쳣
            OpenOrCreate    ���Ѿ����ڵ��ļ�������ļ������ڣ�����½��ļ�
            Truncate    ���Ѿ����ڵ��ļ���������ļ��е����ݣ�����ļ���������᷵���쳣
            Append      ���ļ����������ļ���׷�����ݣ�����ļ���������ᴴ��һ���µ��ļ�
         3 FlieShare 
            None        л������ǰ�ļ�
            Read        �������򿪶�ȡ��Ϣ
            ReadWrite   ���������ļ���д��Ϣ
            Write       ���������ļ�д����Ϣ
            Delete      �������ɾ���ļ�
            Inheritable ʹ�ļ�����������ӽ��̼̳�
         4 FileOptions
         */


        // �����ı�����
        string msg = "03190824";
        
        // ���ַ���ת��Ϊ�ֽ�����
        byte[] bytes = Encoding.UTF8.GetBytes(msg);

        // ���ļ���д������
        fileStream.Write(bytes, 0, bytes.Length);

        // ˢ�»����� �ر���
        fileStream.Flush();
        fileStream.Close();
    
    
    }

    void ReadFile()
    {
        string path = @"D:\\github_repo\\Unity\\UnityBasic\\CSharpStudy\\Assets\\Resources\\testfile.txt";

        if (File.Exists(path))
        {
            // ����FileStream ���ʵ��
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            /*
             1 FileAccess
                Read ��ֻ����ʽ��
                Write ��д��ʽ��
                ReadWrite �Զ�д��ʽ��
             2 FileMode
                CreateNew   �������ļ�������Ѵ��ڣ���᷵���쳣
                Create      �����ļ��� ����ļ����ڣ�ɾ��ԭ���ļ��������½������ļ�
                Open        ���Ѿ����ڵ��ļ�������ļ������ڣ���᷵���쳣
                OpenOrCreate    ���Ѿ����ڵ��ļ�������ļ������ڣ�����½��ļ�
                Truncate    ���Ѿ����ڵ��ļ���������ļ��е����ݣ�����ļ���������᷵���쳣
                Append      ���ļ����������ļ���׷�����ݣ�����ļ���������ᴴ��һ���µ��ļ�
             3 FlieShare 
                None        л������ǰ�ļ�
                Read        �������򿪶�ȡ��Ϣ
                ReadWrite   ���������ļ���д��Ϣ
                Write       ���������ļ�д����Ϣ
                Delete      �������ɾ���ļ�
                Inheritable ʹ�ļ�����������ӽ��̼̳�
             4 FileOptions

             */



            // �������ļ���Ϣ���ֽ�����
            byte[] bytes = new byte[fileStream.Length];

            // ��ȡ�ļ���Ϣ
            fileStream.Read(bytes, 0, bytes.Length);

            // ���õ����ֽ���������д����Ϊ�ַ���
            string c = Encoding.UTF8.GetString(bytes);
            Debug.Log(c);

            // �ر��ļ�
            fileStream.Close();


        }
        else
        {
            Console.WriteLine("File not exist!");
        }


    }
}
