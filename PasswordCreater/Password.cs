using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreater {
    class Password {
        //パスワード生成部分
        public string PasswdCreate(int pwdLen, string pwdChar) {
            var sr = new StringBuilder(pwdLen);

            var rnd = new Random((int)DateTime.Now.Ticks);

            for (int i = 0; i < pwdLen; i++) {
                sr.Append(pwdChar[rnd.Next(pwdChar.Length)]);
            }

            return sr.ToString();
        }
        /// <summary>
        /// 大文字作成
        /// </summary>
        /// <param name="s">既存文字列</param>
        /// <returns>既存文字列+大文字</returns>
        public string UpeCharCreate(string s) {
            var sr = new StringBuilder();
            sr.Append(s);
            for (int i = 0x41; i < 0x5B; i++) {
                sr.Append((Char)i);
            }
            return sr.ToString();
        }
        /// <summary>
        /// 小文字作成
        /// </summary>
        /// <param name="s">既存文字列</param>
        /// <returns>既存文字列+小文字</returns>
        public string LowCharCreate(string s) {
            var sr = new StringBuilder();
            sr.Append(s);
            for (int i = 0x61; i < 0x7B; i++) {
                sr.Append((Char)i);
            }
            return sr.ToString();
        }
        /// <summary>
        /// 数字作成
        /// </summary>
        /// <param name="s">既存文字列</param>
        /// <returns>既存文字列+数字</returns>
        public string NumCharCreate(string s) {
            var sr = new StringBuilder();
            sr.Append(s);
            for (int i = 0; i < 10; i++) {
                sr.Append((Char)i);
            }
            return sr.ToString();
        }
        /// <summary>
        /// 記号作成
        /// </summary>
        /// <param name="s">既存文字列</param>
        /// <returns>既存文字列+記号</returns>
        public string SymCharCreate(string s) {
            var sr = new StringBuilder();
            sr.Append(s);
            for (int i = 0x21; i < 0x2F; i++) {
                sr.Append((Char)i);
            }
            return sr.ToString();
        }
    }
}
