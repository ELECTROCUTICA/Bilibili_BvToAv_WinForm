using System;
using System.Globalization;

namespace Bilibili_BvToAv_WinForm {
    public class Converter {
        private static int[] MAP => new int[] { 6, 4, 2, 3, 1, 5, 0, 7, 8 };
        private const long XOR = 23442827791579;
        private const long MASK = 2251799813685247;
        private const string chars = "FcwAPNKTMug3GV5Lj7EJnHpWsx4tb8haYeviqBz6rkCy12mUSDQX9RdoZf";
        private const int LENGTH = 9;

        public static string ConvertToAV(string bv) {
            if (!bv.StartsWith("BV1", true, CultureInfo.CurrentCulture) || bv.Length != 12) {
                throw new Exception("无效的BV字符串");
            }

            string code = bv.Substring(3);
            long tmp = 0;
            for (var i = 0; i < LENGTH; i++) {
                int idx = chars.IndexOf(code[MAP[i]]);
                if (idx == -1) {
                    throw new ArgumentException("无效的BV字符串");
                }
                tmp = tmp * 58 + idx;
            }

            return $"av{(tmp & MASK) ^ XOR}";
        }
    }
}

