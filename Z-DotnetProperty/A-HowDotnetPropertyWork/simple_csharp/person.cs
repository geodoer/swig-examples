/* 提供给C#客户端调用的接口 */
public class Person : global::System.IDisposable
{
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;

    internal Person(global::System.IntPtr cPtr, bool cMemoryOwn)
    {
        swigCMemOwn = cMemoryOwn;
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }

    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Person obj)
    {
        return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }

    ~Person()
    {
        Dispose(false);
    }

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
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    simplePINVOKE.delete_Person(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }
        }
    }

    public Person(int guid) : this(simplePINVOKE.new_Person(guid), true)
    {
    }

    public int Guid
    {
        get
        {
            return simplePINVOKE.Person_Guid(swigCPtr);
        }
    }

    public char Name
    {
        get
        {
            return simplePINVOKE.Person_GetName(swigCPtr);
        }
        set
        {
            simplePINVOKE.Person_SetName(swigCPtr, value);
        }
    }

    public void Print()
    {
        simplePINVOKE.Person_Print(swigCPtr);
    }
}
