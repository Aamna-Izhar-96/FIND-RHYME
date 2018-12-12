using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gamenfa
{
    class DFA
    {
        int _is;

        public int _is1
        {
            get { return _is; }
            set { _is = value; }
        }
        int[] fs;

        public int[] Fs
        {
            get { return fs; }
            set { fs = value; }
        }
        char[] c;

        public char[] C
        {
            get { return c; }
            set { c = value; }
        }
        public int[,] TT;
        public DFA(int _is, int[] fs, char[] c, int[,] TT)
        {
            this._is = _is;
            this.fs = fs;
            this.c = c;
            this.TT = TT;
        }
        public int transition(char ch, int st)
        {
            int index = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == ch)
                {
                    index = i;
                    break;
                }
            }
            return TT[st, index];
        }
        public bool validate(string str)
        {
            int st = 0;
            for (int i = 0; i < str.Length; i++)
            {
                st = transition(str[i], st);
            }
            for (int i = 0; i < fs.Length; i++)
            {
                if (st == fs[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
