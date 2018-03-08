using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreater {
    class Password {
        public string CharacterCreate() {
            var sr = new StringBuilder();
            Console.WriteLine("\r\n数字");
            //0~9
            for (int i = 0; i < 10; i++) {
                sr.Append(i);
                Console.Write(i);
            }
            Console.WriteLine("\r\n大文字");
            //大文字
            for (int i = 0x41; i < 0x5B; i++) {
                sr.Append((Char)i);
                Console.Write((Char)i);
            }
            Console.WriteLine("\r\n小文字");
            //小文字
            for (int i = 0x61; i < 0x7B; i++) {
                sr.Append((Char)i);
                Console.Write((Char)i);
            }
            Console.WriteLine("\r\n記号");
            //記号
            for (int i = 0x21; i < 0x2F; i++) {
                sr.Append((Char)i);
                Console.Write((Char)i);
            }

            return sr.ToString();
        }

        //public string CharacterCreate() {
        //    //もはやこっちのほうが簡潔じゃね？
        //    var numChar = "0123456789";
        //    var upeChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //    var lowChar = "abcdefghijklmnopqrstuvwxyz";
        //    var symChar = "!\"#$%&'()*+,-.";

        //    var sr = new StringBuilder();
        //    sr.Append(numChar);
        //    sr.Append(upeChar);
        //    sr.Append(lowChar);
        //    sr.Append(symChar);

        //    return sr.ToString();
        //}
        
        public string PasswdCreate(int pwdLen, string pwdChar) {
            var sr = new StringBuilder(pwdLen);

            var rnd = new Random((int)DateTime.Now.Ticks);

            for (int i = 0; i < pwdLen; i++) {
                sr.Append(pwdChar[rnd.Next(pwdChar.Length)]);
            }

            return sr.ToString();
        }
    }
}
