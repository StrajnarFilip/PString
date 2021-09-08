/*
   Copyright 2021 Filip Strajnar

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/
using System;
using System.Linq;

namespace StringConversion
{
    public static class StringExtensions
    {
        public static int Pint(this string input_string, int defautl = 0)
        {
            int parsed = defautl;
            int.TryParse(input_string, out parsed);
            return parsed;
        }
        public static double Pdouble(this string input_string, double defautl = 0)
        {
            double parsed = defautl;
            double.TryParse(input_string, out parsed);
            return parsed;
        }
        public static DateTime PDateTime(this string input_string)
        {
            DateTime parsed = new DateTime();
            DateTime.TryParse(input_string, out parsed);
            return parsed;
        }
        public static DateTime PDateTime(this string input_string, DateTime defautl)
        {
            DateTime parsed = defautl;
            DateTime.TryParse(input_string, out parsed);
            return parsed;
        }
        public static Int64 Pint64(this string input_string, Int64 defautl = 0)
        {
            Int64 parsed = defautl;
            Int64.TryParse(input_string, out parsed);
            return parsed;
        }

        public static TimeSpan PTimeSpan(this string input_string)
        {
            TimeSpan parsed = new TimeSpan();
            TimeSpan.TryParse(input_string, out parsed);
            return parsed;
        }
        public static TimeSpan PTimeSpan(this string input_string, TimeSpan defautl)
        {
            TimeSpan parsed = defautl;
            TimeSpan.TryParse(input_string, out parsed);
            return parsed;
        }

        public static bool PTimeSpan(this string input_string, bool defautl = false)
        {
            bool parsed = defautl;
            bool.TryParse(input_string, out parsed);
            return parsed;
        }

        public static byte[] PHexToBytes(this string input_string)
        {
            try
            {
                return Enumerable.Range(0, input_string.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(input_string.Substring(x, 2), 16))
                .ToArray();
            }
            catch
            {
                return new byte[0];
            }
        }

        public static byte[] PHexToBytesThrowsException(this string input_string)
        {
            return Enumerable.Range(0, input_string.Length)
            .Where(x => x % 2 == 0)
            .Select(x => Convert.ToByte(input_string.Substring(x, 2), 16))
            .ToArray();
        }
    }
}
