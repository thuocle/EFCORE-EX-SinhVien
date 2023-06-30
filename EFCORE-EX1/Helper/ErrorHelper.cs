using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_EX1.Helper
{
    public enum errType
    {
        ThanhCong, ChuaTonTai, TrungMa, DuLieuTrong, ThatBai
    }
    public class ErrorHelper
    {
        public static void Log(errType errType)
        {
            switch (errType)
            {
                case errType.ThanhCong:
                    Console.WriteLine(Res.ThanhCong);
                    break;
                case errType.ThatBai:
                    Console.WriteLine(Res.ThatBai);
                    break;
                case errType.ChuaTonTai:
                    Console.WriteLine(Res.ChuaTonTai);
                    break;
                case errType.TrungMa:
                    Console.WriteLine(Res.TrungMa);
                    break;
                case errType.DuLieuTrong:
                    Console.WriteLine(Res.DuLieuTrong);
                    break;
                default:
                    break;
            }
        }
    }
}
