using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace gamenfa
{
    class NFA_ 
    {
        public List<List<NFA>> TT;
        public int IS;
        public int[] FS;
        public char[] domain;
        public int TS;
        public string rhyme;
        public int rhymeno;
        public string[] listofrhyme;
        public NFA_()
        {
        }
         public NFA_(List<List<NFA>> TT, int Is, int[] fs, char[] Chars, int ts,string rhyme,int rno,string[]list_of_rhyme)
        {
            this.domain = Chars;
            this.IS = Is;
            this.FS = fs;
            this.TS = ts;
            this.TT = TT;
            this.rhyme = rhyme;
            this.rhymeno = rno;
            this.listofrhyme = list_of_rhyme;
        }
         
         public List<int> getTransitoins(int st, char ch)
         {
             int a;
             List<int> sta = new List<int>();

             for (a = 0; a < TT[st].Count; a++)
             {
                 if (TT[st][a].getString() == ch)
                 {
                     sta.Add(TT[st][a].getState());
                 }


             }



             if (sta.Count > 0)
             {
                 return sta;
             }
             else
             {
                 sta.Add(-1);
                 return sta;
             }
         }
       

        public DFA NFAtoDFA(NFA_ nfa)
        {
            List<List<int>> combinations = new List<List<int>>();
            List<int[]> TT = new List<int[]>();




            int s1 = nfa.IS;


            combinations.Add(new List<int>() { s1 });
            int n = 1;
            int addIndex = 0;
            while (n <= combinations.Count)
            {
                int[] ttArray = new int[domain.Length];
                int i = 0;

                foreach (char item in domain)
                {

                    List<int> tempComb = combinations[n - 1];
                    List<int> s2 = new List<int>();
                    foreach (int state in tempComb)
                    {
                        if (state != -1)
                        {
                            List<int> tempstate = nfa.getTransitoins(state, item);

                            foreach (var trans in tempstate)
                            {

                                s2.Add(trans);
                            }
                        }
                        else s2.Add(-1);

                    }
                    s2.Sort();
                    s2 = s2.Distinct().ToList();

                    int index = 0;
                    if (s2.Count > 1)
                        s2.Remove(-1);
                    if (combinationExists(combinations, s2))
                    {
                        // not add
                        index = getCombinationIndex(combinations, s2);
                        ttArray[i++] = index;
                    }
                    else
                    {
                        combinations.Add
                            (s2);
                        ttArray[i] = ++addIndex;
                        i++;


                    }


                }
                n++;
                TT.Add(ttArray);

            }


            //------------------------------Convert List to Array----------------------------------//
            int[,] finalTT = new int[TT.Count, nfa.domain.Length];
            for (int i = 0; i < finalTT.GetLength(0); i++)
            {
                for (int j = 0; j < finalTT.GetLength(1); j++)
                {
                    finalTT[i, j] = TT[i][j];
                }
            }

            //// ------------ Mark final states of new Dfa --------------------------//

            List<int> tempFs = new List<int>();
            for (int r = 0; r < combinations.Count; r++)
            {

                List<int> tempComb = combinations[r];

                foreach (var item in nfa.FS)
                {
                    if (tempComb.Contains(item))
                    {
                        tempFs.Add(r);
                    }
                }


            }
            tempFs = tempFs.Distinct().ToList();
            tempFs.Sort();

            DFA dfa3 = new DFA(0, tempFs.ToArray(), nfa.domain, finalTT);
            return dfa3;
        }

        int getCombinationIndex(List<List<int>> combinations, List<int> s2)
        {
            for (int i = 0; i < combinations.Count; i++)
            {
                if (combinations[i].SequenceEqual(s2))
                {
                    return i;
                }
            }
            return -1;
        }
        bool combinationExists(List<List<int>> combinations, List<int> s2)
        {
            for (int i = 0; i < combinations.Count; i++)
            {
                if (combinations[i].SequenceEqual(s2))
                {
                    return true;
                }
            }
            return false;
        }
    

        public NFA_ READNFA(string filename)
        {
            List<List<NFA>> list = new List<List<NFA>>();
            StreamReader sr = new StreamReader("levels\\"+filename+".txt");

            string tocheck = sr.ReadLine();


            List<string> rhymelist = new List<string>();
            int rno = int.Parse(sr.ReadLine());
            for (int i = 0; i < rno; i++)
            {
                rhymelist.Add(sr.ReadLine());
            }

            int IS = int.Parse(sr.ReadLine());

            List<int> FS = new List<int>();
            int temp1 = int.Parse(sr.ReadLine());
            //---Write Final States
            for (int i = 0; i < temp1; i++)
            {

                FS.Add(int.Parse(sr.ReadLine()));
            }

            int TS = int.Parse(sr.ReadLine());

            List<char> domain = new List<char>();
            string temp = sr.ReadLine();
            //---Write Characters of Language
            for (int i = 0; i < temp.Count(); i++)
            {
                domain.Add(temp[i]);
            }

            for (int i = 0; i < TS; i++)
            {
                int s = int.Parse(sr.ReadLine());
                list.Add(new List<NFA>());
                int stlen = int.Parse(sr.ReadLine());
                if (stlen != 0)
                {
                    for (int j = 0; j < stlen; j++)
                    {

                        string trans = sr.ReadLine();

                        int st;
                        char ch = trans[0];
                        if (trans.Length > 2)
                        {
                            st = int.Parse(trans.Substring(1, 2));
                        }
                        else
                        {
                            st = int.Parse(trans[1].ToString());
                        }

                        list[s].Add(new NFA(ch, st));

                    }
                }
            }
            return (new NFA_(list, IS, FS.ToArray(), domain.ToArray(), TS, tocheck, rno, rhymelist.ToArray()));
        }
        public void WriteNFA(string filename,int IS,int[]FS,string domains,List<List<string>>list,string tocheck,int TS,int rno,string[]rhymelist,int[] transstates) 
        {

            StreamWriter a = new StreamWriter(filename + ".txt");

            string rhymetocheck = tocheck;
            a.Write(rhymetocheck.ToUpper());
            a.WriteLine();

            int how_many_hide = rno;

            a.Write(how_many_hide);
            a.WriteLine();
            for (int i = 0; i < rhymelist.Length; i++)
            {
                string rhymehide = rhymelist[i];

                a.Write(rhymehide.ToUpper());
                a.WriteLine();
            }

            //--Write Initial State
            
            a.Write(IS);
            a.WriteLine();

            //---Write Final States
            int nofst = FS.Length;

            a.Write(nofst);
            a.WriteLine();

            //int[] FS = new int[nofst];
            for (int i = 0; i < FS.Length; i++)
            {
               
                a.Write(FS[i]);
                a.WriteLine();
            }

            //--Total states
           
            a.Write(TS);
            a.WriteLine();

            //---Write Characters of Language
            

            a.Write(domains.ToLower());

            a.WriteLine();



            //---Write Transition Table

            for (int i = 0; i < TS; i++)
            {
                a.Write(i);
                a.WriteLine();
                //int howmany_trans_sates = int.Parse(Console.ReadLine());
                a.Write(transstates[i]);
                a.WriteLine();
                for (int h = 0; h < transstates[i]; h++)
                {
                    string trans = list[i][h];
                    a.Write(trans);
                    a.WriteLine();
                }


            }

            a.Close();
        }
        // NFA TO DFA

        public int getnotran(NFA_ nfa)
        {
            int st = 0;
            for (int i = 0; i < nfa.TS;i++ )
            {
                st += nfa.TT[i].Count();
            }
            return st;
        }
    }
}
