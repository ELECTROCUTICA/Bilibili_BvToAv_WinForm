using System;

namespace Bilibili_BvToAv_WinForm {
    public class Converter {
        public const long sub = 100618342136696320;
        public const string operation = "1010100100111011001100100100";


        public static string ConvertToOlder(string bv) {
            var charlist = new List<char>(bv.ToCharArray());
            var numbers = new List<long>(32);

            for (var i = 2; i <= 11; i++) {
                if (charlist[i] == '1') { numbers.Add(13); }
                if (charlist[i] == '2') { numbers.Add(12); }
                if (charlist[i] == '3') { numbers.Add(46); }
                if (charlist[i] == '4') { numbers.Add(31); }
                if (charlist[i] == '5') { numbers.Add(43); }
                if (charlist[i] == '6') { numbers.Add(18); }
                if (charlist[i] == '7') { numbers.Add(40); }
                if (charlist[i] == '8') { numbers.Add(28); }
                if (charlist[i] == '9') { numbers.Add(5); }
                if (charlist[i] == 'A') { numbers.Add(54); }
                if (charlist[i] == 'B') { numbers.Add(20); }
                if (charlist[i] == 'C') { numbers.Add(15); }
                if (charlist[i] == 'D') { numbers.Add(8); }
                if (charlist[i] == 'E') { numbers.Add(39); }
                if (charlist[i] == 'F') { numbers.Add(57); }
                if (charlist[i] == 'G') { numbers.Add(45); }
                if (charlist[i] == 'H') { numbers.Add(36); }
                if (charlist[i] == 'J') { numbers.Add(38); }
                if (charlist[i] == 'K') { numbers.Add(51); }
                if (charlist[i] == 'L') { numbers.Add(42); }
                if (charlist[i] == 'M') { numbers.Add(49); }
                if (charlist[i] == 'N') { numbers.Add(52); }
                if (charlist[i] == 'P') { numbers.Add(53); }
                if (charlist[i] == 'Q') { numbers.Add(7); }
                if (charlist[i] == 'R') { numbers.Add(4); }
                if (charlist[i] == 'S') { numbers.Add(9); }
                if (charlist[i] == 'T') { numbers.Add(50); }
                if (charlist[i] == 'U') { numbers.Add(10); }
                if (charlist[i] == 'V') { numbers.Add(44); }
                if (charlist[i] == 'W') { numbers.Add(34); }
                if (charlist[i] == 'X') { numbers.Add(6); }
                if (charlist[i] == 'Y') { numbers.Add(25); }
                if (charlist[i] == 'Z') { numbers.Add(1); }
                if (charlist[i] == 'a') { numbers.Add(26); }
                if (charlist[i] == 'b') { numbers.Add(29); }
                if (charlist[i] == 'c') { numbers.Add(56); }
                if (charlist[i] == 'd') { numbers.Add(3); }
                if (charlist[i] == 'e') { numbers.Add(24); }
                if (charlist[i] == 'f') { numbers.Add(0); }
                if (charlist[i] == 'g') { numbers.Add(47); }
                if (charlist[i] == 'h') { numbers.Add(27); }
                if (charlist[i] == 'i') { numbers.Add(22); }
                if (charlist[i] == 'j') { numbers.Add(41); }
                if (charlist[i] == 'k') { numbers.Add(16); }
                if (charlist[i] == 'm') { numbers.Add(11); }
                if (charlist[i] == 'n') { numbers.Add(37); }
                if (charlist[i] == 'o') { numbers.Add(2); }
                if (charlist[i] == 'p') { numbers.Add(35); }
                if (charlist[i] == 'q') { numbers.Add(21); }
                if (charlist[i] == 'r') { numbers.Add(17); }
                if (charlist[i] == 's') { numbers.Add(33); }
                if (charlist[i] == 't') { numbers.Add(30); }
                if (charlist[i] == 'u') { numbers.Add(48); }
                if (charlist[i] == 'v') { numbers.Add(23); }
                if (charlist[i] == 'w') { numbers.Add(55); }
                if (charlist[i] == 'x') { numbers.Add(32); }
                if (charlist[i] == 'y') { numbers.Add(14); }
                if (charlist[i] == 'z') { numbers.Add(19); }
            }

            long Final = numbers[0] * (long)Math.Pow(58, 6) +
                numbers[1] * (long)Math.Pow(58, 2) +
                numbers[2] * (long)Math.Pow(58, 4) +
                numbers[3] * (long)Math.Pow(58, 8) +
                numbers[4] * (long)Math.Pow(58, 5) +
                numbers[5] * (long)Math.Pow(58, 9) +
                numbers[6] * (long)Math.Pow(58, 3) +
                numbers[7] * (long)Math.Pow(58, 7) +
                numbers[8] * (long)Math.Pow(58, 1) +
                numbers[9]
                - sub;



            long av = Final ^ Convert.ToInt64(operation, 2);
            return $"av{av}";
        }
    }
}

