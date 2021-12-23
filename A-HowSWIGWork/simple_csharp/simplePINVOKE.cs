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
    /// 1. 第一个参数   simple_wrap      DLL的名称
    /// 2. 第二个参数   CSharp_Foo_set   入口点，即函数名称
    [global::System.Runtime.InteropServices.DllImport("simple_wrap", EntryPoint = "CSharp_Foo_set")]
    public static extern void Foo_set(double jarg1);

    [global::System.Runtime.InteropServices.DllImport("simple_wrap", EntryPoint = "CSharp_Foo_get")]
    public static extern double Foo_get();

    /// 对于simple_csharp模块中的函数      int CSharp_gcd(int jarg1, int jarg2)
    /// 映射到C#中，函数为签名为           int gcd(int jarg1, int jarg2)
    /// 
    /// 不难发现，这里其实做了一个映射
    /// 1. C++的int类型              => C#的int类型
    /// 2. C++的函数名称为CSharp_gcd => C#的函数名称为gcd
    /// 
    /// 这只是基础类型的映射，如果是其他类型（C++模板类、C++STL中的类、自定义结构体、自定义类），该如何映射呢？
    [global::System.Runtime.InteropServices.DllImport("simple_wrap", EntryPoint = "CSharp_gcd")]
    public static extern int gcd(int jarg1, int jarg2);
}
