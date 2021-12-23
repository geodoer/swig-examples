/* C#中间层
1. 调用C++中间层的代码，完成C#与C++之间的通讯
 */
class simplePINVOKE
{
    static simplePINVOKE()
    {
    }

    /// 从DLL中导入一个外部函数
    /// 
    /// DllImport的参数说明
    /// 1. 第一个参数   simple_wrap          DLL的名称
    /// 2. 第二个参数   CSharp_new_Person    入口点，即函数名称
    [global::System.Runtime.InteropServices.DllImport("simple_wrap", EntryPoint = "CSharp_new_Person")]
    public static extern global::System.IntPtr new_Person(int jarg1);

    [global::System.Runtime.InteropServices.DllImport("simple_wrap", EntryPoint = "CSharp_Person_Guid")]
    public static extern int Person_Guid(global::System.Runtime.InteropServices.HandleRef jarg1);

    [global::System.Runtime.InteropServices.DllImport("simple_wrap", EntryPoint = "CSharp_Person_GetName")]
    public static extern char Person_GetName(global::System.Runtime.InteropServices.HandleRef jarg1);

    [global::System.Runtime.InteropServices.DllImport("simple_wrap", EntryPoint = "CSharp_Person_SetName")]
    public static extern void Person_SetName(global::System.Runtime.InteropServices.HandleRef jarg1, char jarg2);

    [global::System.Runtime.InteropServices.DllImport("simple_wrap", EntryPoint = "CSharp_Person_Print")]
    public static extern void Person_Print(global::System.Runtime.InteropServices.HandleRef jarg1);

    [global::System.Runtime.InteropServices.DllImport("simple_wrap", EntryPoint = "CSharp_delete_Person")]
    public static extern void delete_Person(global::System.Runtime.InteropServices.HandleRef jarg1);
}
