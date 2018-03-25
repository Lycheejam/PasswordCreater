using System;
using System.Security.Cryptography;
using System.Text;

namespace PasswordCreater {
    class Password {
        /// <summary>
        /// パスワード文字列を生成する。
        /// </summary>
        /// <param name="pwdLen">パスワード長</param>
        /// <param name="pwdChar">パスワード使用文字列</param>
        /// <param name="seed">乱数</param>
        /// <returns>パスワード</returns>
        public string CreatePasswd(int pwdLen, string pwdChar, int seed) {
            var sr = new StringBuilder(pwdLen);
            var rnd = new Random(seed);

            for (int i = 0; i < pwdLen; i++) {
                sr.Append(pwdChar[rnd.Next(pwdChar.Length)]);
            }

            return sr.ToString();
        }

        /// <summary>
        /// 乱数を生成する。
        /// </summary>
        /// <returns>乱数</returns>
        public int CreateRandomSeed() {
            var bs = new byte[4];
            //Int32と同じサイズのバイト配列にランダムな値を設定する
            using (var rng = new RNGCryptoServiceProvider()) {
                rng.GetBytes(bs);
            }
            //RNGCryptoServiceProviderで得たbit列をInt32型に変換してシード値とする。
            return BitConverter.ToInt32(bs, 0);
        }

        /// <summary>
        /// 大文字作成
        /// </summary>
        /// <returns>大文字</returns>
        public string CreateUppercases() {
            var sr = new StringBuilder();
            for (int i = 0x41; i < 0x5B; i++) {
                sr.Append((Char)i);
            }
            return sr.ToString();
        }
        /// <summary>
        /// 小文字作成
        /// </summary>
        /// <returns>小文字</returns>
        public string CreateLowercases() {
            var sr = new StringBuilder();
            for (int i = 0x61; i < 0x7B; i++) {
                sr.Append((Char)i);
            }
            return sr.ToString();
        }
        /// <summary>
        /// 数字作成
        /// </summary>
        /// <returns>数字</returns>
        public string CreateNumbers() {
            var sr = new StringBuilder();
            for (int i = 0; i < 10; i++) {
                sr.Append(i.ToString());
            }
            return sr.ToString();
        }
        /// <summary>
        /// 記号作成
        /// </summary>
        /// <returns>記号</returns>
        public string CreateSymbols() {
            var sr = new StringBuilder();
            for (int i = 0x21; i < 0x2F; i++) {
                sr.Append((Char)i);
            }
            return sr.ToString();
        }
    }
}
