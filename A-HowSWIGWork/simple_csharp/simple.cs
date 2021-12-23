/* 提供给C#客户端调用的接口 */
public class simple
{
    public static double Foo
    {
        set
        {
            //TODO：将value设置给example.h中的Foo变量
            simplePINVOKE.Foo_set(value);
        }
        get
        {
            //TODO：获取example.h中Foo的值
            double ret = simplePINVOKE.Foo_get();
            return ret;
        }
    }

    public static int gcd(int x, int y)
    {
        //TODO：调用example.h中的gcd函数
        int ret = simplePINVOKE.gcd(x, y);
        return ret;
    }
}