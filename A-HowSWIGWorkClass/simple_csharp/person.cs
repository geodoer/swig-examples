/* 提供给C#客户端调用的接口 */
/* Person是外部（C++）提供的对象，所以是托管对象，要实现IDisposable接口 */
public class Person : global::System.IDisposable
{
    /// <summary>
    /// C指针
    /// </summary>
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    /// <summary>
    /// this是否属于C的内存
    /// </summary>
    protected bool swigCMemOwn;

    /// <summary>
    /// 拷贝构造函数
    /// </summary>
    internal Person(global::System.IntPtr cPtr, bool cMemoryOwn)
    {
        swigCMemOwn = cMemoryOwn;
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }

    /// <summary>
    /// 获得C指针
    /// </summary>
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Person obj)
    {
        return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }

    /// <summary>
    /// 析构函数
    /// </summary>
    ~Person()
    {
        Dispose(false);
    }

    /// <summary>
    /// 释放this
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        global::System.GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        lock (this)
        {
            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                //释放这个C指针
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    simplePINVOKE.delete_Person(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }
        }
    }

    /// <summary>
    /// Person的构造函数
    /// </summary>
    public Person(int guid) : this(simplePINVOKE.new_Person(guid), true)
    {
    }

    public int Guid()
    {
        int ret = simplePINVOKE.Person_Guid(swigCPtr);
        return ret;
    }

    public char GetName()
    {
        char ret = simplePINVOKE.Person_GetName(swigCPtr);
        return ret;
    }

    public void SetName(char name)
    {
        simplePINVOKE.Person_SetName(swigCPtr, name);
    }

    public void Print()
    {
        simplePINVOKE.Person_Print(swigCPtr);
    }
}