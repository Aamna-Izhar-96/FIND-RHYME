using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gamenfa
{
    class NFA
    {
        private char strings;
        private int state;
        public NFA()
        {
        }
        public NFA(char str, int state)
        {
            this.strings = str;
            this.state = state;
        }
        public void setString(char s)
        {
            this.strings = s;
        }
        public char getString()
        {
            return this.strings;
        }
        public void setState(int st)
        {
            this.state = st;
        }
        public int getState()
        {
            return this.state;
        }
       
        
    }
}
