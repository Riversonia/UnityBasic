using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  
 *  1 �ӿ��ص�
 *  1) �����������ԣ����ǲ��ܰ���������ʵ�� �ӿڲ����Զ����ֶΣ������ݳ�Ա��
 *  2) ���ܽ�������������Ϊ private
 *  3) �ӿڲ����Ա�ʵ����
 *  4) �ӿ�����һ�̳У�Ҳ������ؼ̳� ��Ҳ���Լ̳нӿ�
 *  5) ��ֻ����̳�һ���࣬���ǿ���ͬʱ�̳ж���ӿ�
 *  
 *  2 �ӿ�������������
 *  1) �ӿڲ�����������Ա�����͹��캯�������������
 *  2���ӿ�ֻ�����������������ǲ������죬��������������������ҿ��Թ��캯��
 *  3) �������η�
 *      �ӿ�      Ĭ���� public  ���ǲ�������privite
 *      ������    Ĭ���� private ����ǰ������� abstract      ��������η��������� private�� 
 *                              ����          ��abstract    �����ĺ�������private ��protected
 *  4) �ӿ�������ؼ̳ж���ӿڣ������಻������ؼ̳ж����
 *  
 *  3 �ӿںͳ��������ͬ��
 *  1) ��������ʵ����
 *  2) ��֧��ֻ��������������������ʵ��
 *  3) ���������ࣩ���������̳У����ǵ��� ������ȥʵ�ֽӿںͳ�����ķ���
 
 */

public interface IBaseInterface1
{
    void ShowWindow();
    void HideWindow();

    //void Show1()
    //{
    //    Debug.Log("1");

    //}
    // 1 �����������ԣ����ǲ��ܰ���������ʵ�� �ӿڲ����Զ����ֶΣ������ݳ�Ա��
    // private void Show3();
    // 2 ���ܽ�������������Ϊ private
}

public interface IBaseInterface2
{
    void PlaySound();
    void CloseSound();
}

public interface IMyInterface: IBaseInterface1,  IBaseInterface2
{

}

public class MyClass4 : IMyInterface
{
    public void CloseSound()
    {
        throw new System.NotImplementedException();
    }

    public void HideWindow()
    {
        throw new System.NotImplementedException();
    }

    public void PlaySound()
    {
        throw new System.NotImplementedException();
    }

    public void ShowWindow()
    {
        throw new System.NotImplementedException();
    }
}


public class TInterface : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // IBaseInterface1 inter = new IBaseInterface();
        // 3 �ӿڲ����Ա�ʵ����

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
