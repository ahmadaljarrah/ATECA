/*
 * This is a third edition of the program
 * Edited by: Ahmad Al-Jarrah
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace AmerCipher
{
    
    public partial class Form1 : Form
    {
        char[] Factor = null;
        static string DataPath = Application.StartupPath + "\\Data\\";
        int[] MC = { 0, 8, 104, 1260, 2757 };
        static char Sep = (char)0;
        static char SepB = (char)32;
        StringBuilder Token = new StringBuilder();
        //string[] letters = File.ReadAllText(DataPath + "0.txt", Encoding.UTF8).ToLower().Split(Sep);
        string[] letters = File.ReadAllText(DataPath + "arDic0.txt", Encoding.UTF8).Split(Sep);
        string[] TheChar = File.ReadAllText(DataPath + "arDic1.txt", Encoding.UTF8).Split(Sep);
        string TheSpace = "";
        Form2 FRMWait;
        string[] MyWords;
        string[] MyWordsNo;
        string[] MyWordsFile;
        int wordCounter = 0;
        int charcterCounter = 0;
        int textSize = 0;
        int encSize = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            bool F = false;
            string Ans = "";
            int T = 0;
            //Jarrah Start
            /*
            StringBuilder ch = new StringBuilder();
            foreach (string s in letters)
            {
                ch.Append(s + Sep);
            }
            ch.Remove(ch.Length - 1, 1);
            File.WriteAllText(DataPath + "" + "0.txt", ch.ToString(), Encoding.UTF8);
            
            string[] letters = File.ReadAllText(DataPath + "11.txt", Encoding.UTF8).Split(SepB);
            StringBuilder ch = new StringBuilder();
            foreach (string s in letters)
            {
                ch.Append(s + Sep);
            }
            ch.Append(" " + Sep);
            ch.Remove(ch.Length - 1, 1);
            File.WriteAllText(DataPath + "" + "m1.txt", ch.ToString(), Encoding.UTF8);
            
            
            string[] letters2 = File.ReadAllText(DataPath + "22.txt", Encoding.UTF8).Split(SepB);
            StringBuilder ch2 = new StringBuilder();
            //ch2.Append(" " + Sep);
            foreach (string s in letters2)
            {
                if (!s.Equals(""))
                ch2.Append(s + Sep);
            }
            ch2.Append("an" + Sep);
            ch2.Append("the" + Sep);
            ch2.Append("and" + Sep);
            ch2.Append("at" + Sep);
            ch2.Append("he" + Sep);
            ch2.Append("she" + Sep);
            ch2.Append("but" + Sep);
            ch2.Append("from" + Sep);
            ch2.Append("to" + Sep);
            ch2.Append("be" + Sep);
            ch2.Append("of" + Sep);
            ch2.Append("in" + Sep);
            ch2.Append("that" + Sep);
            ch2.Append("have" + Sep);
            ch2.Append("it" + Sep);
            ch2.Append("for" + Sep);
            ch2.Append("not" + Sep);
            ch2.Append("on" + Sep);
            ch2.Append("with" + Sep);
            ch2.Append("as" + Sep);
            ch2.Append("you" + Sep);
            ch2.Append("do" + Sep);
            ch2.Append("at" + Sep);
            ch2.Append("by" + Sep);
            ch2.Append("this" + Sep);
            ch2.Remove(ch2.Length - 1, 1);
            File.WriteAllText(DataPath + "" + "m2.txt", ch2.ToString(), Encoding.UTF8);
            */
            //Jarrah End
            do
            {
                T = T + 1;
                if (T == 4)
                    System.Environment.Exit(0);
                F = false;
                Ans = Interaction.InputBox("please enter your factores");
                Ans = Ans.Trim();
                if (!string.IsNullOrEmpty(Ans))
                {
                    foreach (char p in Ans)
                    {
                        if ("0123456789".Contains(p) == false)
                        {
                            F = true;
                            break; // TODO: might not be correct. Was : Exit For
                        }
                    }
                    if (F)
                    {
                        Interaction.MsgBox("please enter number only", MsgBoxStyle.Exclamation);
                    }
                    else
                    {
                        if (Ans.Length < 14)
                        {
                            Interaction.MsgBox("please enter at least 14 numbers", MsgBoxStyle.Exclamation);
                        }
                        else
                        {
                            break; // TODO: might not be correct. Was : Exit Do
                        }
                    }
                }
            } while (true);

            Factor = Ans.ToArray();
            InitArray(1);
            InitArray(2);
            InitArray(3);
            InitArray(4);
           
            Fill();

        }
        public void InitArray(int p)
        {
            int MatrixCount = MC[p];
            string[,] Matrrix = new string[MatrixCount, MatrixCount];
            int[,] MatrrixNo = new int[MatrixCount, MatrixCount];
            //string[] Words = File.ReadAllText(DataPath + p + ".txt", Encoding.UTF8).ToLower().Split(Sep); \\Jarrah
            string[] Words = File.ReadAllText(DataPath + "arDic" +p + ".txt", Encoding.UTF8).Split(Sep);// Jarrah
            int Z = 0;
            int I = 0;
            int J = 0;
            for (I = 0; I <= MatrixCount - 1; I++)
            {
                for (J = 0; J <= MatrixCount - 1; J++)
                {
                    if (Z < Words.Count())
                    {
                        Matrrix[I, J] = Words[Z];
                    }
                    else
                    {
                        Matrrix[I, J] = "";
                    }
                    MatrrixNo[I, J] = Z;
                    Z = Z + 1;
                }
            }



            /*
            ShiftRow(p, ref Matrrix, ref MatrrixNo, false);
            ShiftCol(p, ref Matrrix,ref MatrrixNo, true);
            ShiftRow(p, ref Matrrix, ref MatrrixNo, true);
            ShiftCol(p, ref Matrrix, ref  MatrrixNo, false);
            ShiftCircular(p, ref Matrrix, ref MatrrixNo, true);
            ShiftDiagonalLeft(p, ref Matrrix, ref  MatrrixNo, false);
            ShiftDiagonalRight(p, ref Matrrix, ref  MatrrixNo, false);
            ShiftDiagonalLeft(p, ref Matrrix, ref  MatrrixNo, true);
            ShiftDiagonalRight(p, ref Matrrix, ref  MatrrixNo, true);
            ShiftCircular(p, ref Matrrix, ref MatrrixNo, false);
            */
            WriteDataFile(p, ref Matrrix, ref MatrrixNo);
            TheSpace = GetSpace();
        }

        public void ShiftDiagonalRight(int FN, ref string[,] Matrrix, ref int[,] MatrrixNo, bool FromUp)
        {
            int MatrixCount = MC[FN];
            string[] TW = new string[MatrixCount];
            int[] TN = new int[MatrixCount];
            int Fac = 0;
            int AA = 0;
            int BB = 0;
            bool Rev = false;
            int V = 0;

            for (int I = 0; I <= (MatrixCount * 2) - 4; I++)
            {
                if (Fac >= Factor.Count())
                    Fac = 0;
                int TheFac = Conversion.Val(Factor[Fac]);
                int X = 0;
                if (Rev == false)
                {
                    AA = MatrixCount - 2 - I;
                    BB = MatrixCount - 1;
                    if (AA == -1)
                        Rev = true;
                }
                if (Rev == true)
                {
                    V = V + 1;
                    AA = 0;
                    BB = V;
                }
                do
                {
                    TW[X] = Matrrix[AA, BB];
                    TN[X] = MatrrixNo[AA, BB];
                    X = X + 1;
                    AA = AA + 1;
                    BB = BB - 1;
                } while (!(AA == MatrixCount || BB == -1));
                ShiftArray(ref TW, ref TN, X, TheFac, FromUp);
                X = 0;
                if (Rev == false)
                {
                    AA = MatrixCount - 2 - I;
                    BB = MatrixCount - 1;
                    if (AA == -1)
                        Rev = true;
                }
                if (Rev == true)
                {
                    AA = 0;
                    BB = V;
                }
                do
                {
                    Matrrix[AA, BB] = TW[X];
                    MatrrixNo[AA, BB] = TN[X];
                    X = X + 1;
                    AA = AA + 1;
                    BB = BB - 1;
                } while (!(AA == MatrixCount || BB == -1));
                Fac = Fac + 1;
            }
        }

        public void ShiftDiagonalLeft(int FN, ref string[,] Matrrix, ref int[,] MatrrixNo, bool FromUp)
        {
            int MatrixCount = MC[FN];
            string[] TW = new string[MatrixCount];
            int[] TN = new int[MatrixCount];
            int Fac = 0;
            int AA = 0;
            int BB = 0;
            bool Rev = false;
            int V = 0;
            for (int I = 0; I <= (MatrixCount * 2) - 4; I++)
            {
                if (Fac >= Factor.Count())
                    Fac = 0;
                int TheFac = Conversion.Val(Factor[Fac]);
                int X = 0;
                if (Rev == false)
                {
                    AA = MatrixCount - 2 - I;
                    BB = 0;
                    if (AA == -1)
                        Rev = true;
                }
                if (Rev == true)
                {
                    V = V + 1;
                    AA = 0;
                    BB = V;
                }
                do
                {
                    TW[X] = Matrrix[AA, BB];
                    TN[X] = MatrrixNo[AA, BB];
                    X = X + 1;
                    AA = AA + 1;
                    BB = BB + 1;
                } while (!(AA == MatrixCount || BB == MatrixCount));
                ShiftArray(ref TW, ref TN, X, TheFac, FromUp);
                X = 0;
                if (Rev == false)
                {
                    AA = MatrixCount - 2 - I;
                    BB = 0;
                    if (AA == -1)
                        Rev = true;
                }
                if (Rev == true)
                {
                    AA = 0;
                    BB = V;
                }
                do
                {
                    Matrrix[AA, BB] = TW[X];
                    MatrrixNo[AA, BB] = TN[X];
                    X = X + 1;
                    AA = AA + 1;
                    BB = BB + 1;
                } while (!(AA == MatrixCount || BB == MatrixCount));
                Fac = Fac + 1;
            }
        }

        public void ShiftRow(int FN, ref string[,] Matrrix, ref int[,] MatrrixNo, bool FromLeft)
        {
            int MatrixCount = MC[FN];
            string[] TW = new string[MatrixCount];
            int[] TN = new int[MatrixCount];
            int Fac = 0;
            for (int I = 0; I <= MatrixCount - 1; I++)
            {
                if (Fac >= Factor.Count())
                    Fac = 0;
                int TheFac = Conversion.Val(Factor[Fac]);
                int X = 0;
                for (int J = 0; J <= MatrixCount - 1; J++)
                {
                    TW[X] = Matrrix[I, J];
                    TN[X] = MatrrixNo[I, J];
                    X = X + 1;
                }
                ShiftArray(ref TW, ref TN, X, TheFac, FromLeft);
                X = 0;
                for (int J = 0; J <= MatrixCount - 1; J++)
                {
                    Matrrix[I, J] = TW[X];
                    MatrrixNo[I, J] = TN[X];
                    X = X + 1;
                }
                Fac = Fac + 1;
            }
        }

        public void ShiftCol(int FN, ref string[,] Matrrix, ref int[,] MatrrixNo, bool FromUp)
        {
            int MatrixCount = MC[FN];
            string[] TW = new string[MatrixCount];
            int[] TN = new int[MatrixCount];
            int Fac = 0;
            for (int I = 0; I <= MatrixCount - 1; I++)
            {
                if (Fac >= Factor.Count())
                    Fac = 0;
                int TheFac = Conversion.Val(Factor[Fac]);
                int X = 0;
                for (int J = 0; J <= MatrixCount - 1; J++)
                {
                    TW[X] = Matrrix[J, I];
                    TN[X] = MatrrixNo[J, I];
                    X = X + 1;
                }
                ShiftArray(ref TW, ref TN, X, TheFac, FromUp);
                X = 0;
                for (int J = 0; J <= MatrixCount - 1; J++)
                {
                    Matrrix[J, I] = TW[X];
                    MatrrixNo[J, I] = TN[X];
                    X = X + 1;
                }
                Fac = Fac + 1;
            }
        }

        public string ToNum(string T)
        {
            int pwrOf2 = 0;
            long ans = 0L;
            foreach (char n in T.Reverse())
            {
                switch (n)
                {
                    case '0':
                        break;
                    case '1':
                        ans += 1L << pwrOf2;
                        break;
                }
                pwrOf2 += 1;
            }
            return ans.ToString();
        }

        public string ToBin(int N, int X)
        {
            int A = N;
            string S = "";
            string Tmp = "";
            while (A != 0)
            {
                if (A % 2 == 0)
                    S = "0";
                else
                    S = "1";
                A = Conversion.Int(A / 2);
                Tmp = S + Tmp;
            }
            int i = 0;
            S = Tmp;
            for (i = Tmp.Length + 1; i <= X; i++)
            {
                S = "0" + S;
            }
            return S;
        }

        public void WriteDataFile(int FN, ref string[,] Matrrix, ref int[,] MatrrixNo)
        {
            StringBuilder W = new StringBuilder();
            StringBuilder N = new StringBuilder();
            int I = 0;
            int J = 0;
            int MatrixCount = MC[FN];
            for (I = 0; I <= MatrixCount - 1; I++)
            {
                for (J = 0; J <= MatrixCount - 1; J++)
                {
                    W.Append(Matrrix[I, J] + Sep);
                    N.Append(MatrrixNo[I, J].ToString() + Sep);
                }
            }
            W.Remove(W.Length - 1, 1);
            N.Remove(N.Length - 1, 1);
            File.WriteAllText(DataPath + "W" + FN + ".dat", W.ToString(), Encoding.UTF8);
            File.WriteAllText(DataPath + FN + ".dat", N.ToString(), Encoding.UTF8);
        }


        private void BTNEncrypt_Click(System.Object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(TXTData.Text.Trim()))
            {
                this.Enabled = false;
                FRMWait = new Form2();
               // FRMWait.Show(this);
                Timer1.Enabled = true;
            }
            else
            {
                Interaction.MsgBox("there is nothing to encrypt", MsgBoxStyle.Exclamation);
            }
        }

        private void BTNDecrypt_Click(System.Object sender, System.EventArgs e)
        {
            this.Enabled = false;
            FRMWait = new Form2();
           // FRMWait.Show(this);
            Timer2.Enabled = true;
        }



        public void ShiftArray(ref string[] Matrrix, ref int[] MatrrixNo, int Count, int TheFac, bool FromStart)
        {
            string[] TW = new string[10];
            int[] TN = new int[10];
            int I = 0;
            int X = 0;
            if (TheFac == 0 || TheFac == Count)
                return;
            if (TheFac > Count)
                TheFac = TheFac % Count;
            if (FromStart)
            {
                X = 0;
                for (I = Count - TheFac; I <= Count - 1; I++)
                {
                    TW[X] = Matrrix[I];
                    TN[X] = MatrrixNo[I];
                    X = X + 1;
                }
                for (I = Count - TheFac - 1; I >= 0; I += -1)
                {
                    Matrrix[I + TheFac] = Matrrix[I];
                    MatrrixNo[I + TheFac] = MatrrixNo[I];
                }
                X = 0;
                for (I = 0; I <= TheFac - 1; I++)
                {
                    Matrrix[I] = TW[X];
                    MatrrixNo[I] = TN[X];
                    X = X + 1;
                }
            }
            else
            {
                X = 0;
                for (I = 0; I <= TheFac - 1; I++)
                {
                    TW[X] = Matrrix[I];
                    TN[X] = MatrrixNo[I];
                    X = X + 1;
                }
                for (I = TheFac; I <= Count - 1; I++)
                {
                    Matrrix[I - TheFac] = Matrrix[I];
                    MatrrixNo[I - TheFac] = MatrrixNo[I];
                }
                X = 0;
                for (I = Count - TheFac; I <= Count - 1; I++)
                {
                    Matrrix[I] = TW[X];
                    MatrrixNo[I] = TN[X];
                    X = X + 1;
                }
            }
        }


        public void AddWord(string T)
        {
            bool F = false;
            string temp;
            temp = T;

            if (MyWords.Contains(temp))
            {
                F = true;
                int N = Convert.ToInt32(MyWordsNo[Array.IndexOf(MyWords, temp)]);
                int FN = Convert.ToInt32(MyWordsFile[Array.IndexOf(MyWords, temp)]);
                if (N <= (MC[FN] * MC[FN] - 1))
                {
                    switch (FN)
                    {
                        case 1:
                            Token.Append("00" + ToBin(N, 6));
                            encSize += 8;
                            break;
                        case 2:
                            Token.Append("10" + ToBin(N, 14));
                            encSize += 16;
                            break;
                        case 3:
                            Token.Append("110" + ToBin(N, 21));
                            encSize += 24;
                            break;
                        case 4:
                            Token.Append("111" + ToBin(N, 23));
                            encSize += 36;
                            break;
                    } 
                    
                }
                else
                {

                    Interaction.MsgBox("Error" + Constants.vbNewLine + "Please Run Program again", MsgBoxStyle.Critical);
                    System.Environment.Exit(0);
                }

            }
           
            if (F == false) //if word doesn't exist, check if it has a prefix or postfix.
            {
                if (T.Length > 1)
                {
                    string s;
                    if (MyWords.Contains(T.Substring(1, T.Length-1)))
                    {
                        s = T.Substring(1, T.Length-1);
                        AddWord(T[0].ToString());
                        Token.Append("0100");
                        encSize += 4;
                        AddWord(s);
                    }
                    else if (MyWords.Contains(T.Substring(2, T.Length-2)))
                    {
                        s = T.Substring(2, T.Length-2);
                        AddWord(T[0].ToString());
                        Token.Append("0100");
                        encSize += 4;
                        AddWord(T[1].ToString());
                        Token.Append("0100");
                        encSize += 4;
                        AddWord(s);
                    }
                    else if (MyWords.Contains(T.Substring(0, T.Length - 1)))
                    {
                        s = T.Substring(0, T.Length - 1);
                        AddWord(s);
                        Token.Append("0100");
                        encSize += 4;
                        AddWord(T[T.Length - 1].ToString());
                    }
                    else if (MyWords.Contains(T.Substring(0, T.Length - 2)))
                    {
                        s = T.Substring(0, T.Length - 2);
                        AddWord(s);
                        Token.Append("0100");
                        encSize += 4;
                        AddWord(T[T.Length - 2].ToString());
                        Token.Append("0100");
                        encSize += 4;
                        AddWord(T[T.Length - 1].ToString());
                    }
                    else
                    {
                        Token.Append("0101"); //Beginning of new word
                        encSize += 4;
                        foreach (char p in T)
                        {
                            AddWord(p.ToString());
                        }
                        Token.Append("0110"); //End of new Word
                        encSize += 4;
                    }
                }
                else
                {
                    File.AppendAllText(DataPath + "arDic" + 1 + ".txt", Sep + T, Encoding.Unicode);
                    InitArray(2);
                    Fill();

                    Interaction.MsgBox("Invalid Character" + Constants.vbNewLine + "\"" + T + "\"", MsgBoxStyle.Critical);
                   // System.Environment.Exit(0);
                }
            }
        }

        private void BTNOpen_Click(System.Object sender, System.EventArgs e)
        {
            string FName = "";
            OpenFileDialog1.FileName = "";
            OpenFileDialog1.Filter = "Text files (*.txt)|*.txt";
            OpenFileDialog1.ShowDialog();
            FName = OpenFileDialog1.FileName;
            if (!string.IsNullOrEmpty(FName))
            {
                TXTData.Text = File.ReadAllText(FName, Encoding.UTF8);
            }
        }

        public void GetMatrixCount(int Count, ref int A, ref int B)
        {
            int N = Count;
            if ((Count % 8) != 0)
            {
                N = Count + 8 - (Count % 8);
                for (int Z = 1; Z <= 8 - (Count % 8); Z++)
                {
                    Token.Append("0");                   
                }
            }
            N = N / 8;
            bool F = false;
            int I = 0;
            for (I = 2; I <= N - 1; I++)
            {
                if (N % I == 0)
                {
                    F = true;
                    break; // TODO: might not be correct. Was : Exit For
                }
            }
            if (F == false)
            {
                N = N + 1;
                Token.Append(TheSpace);
            }
            A = 1;
            B = N;
            int C = Math.Abs(A - B);
            for (I = 2; I <= N - 1; I++)
            {
                if (N % I == 0)
                {
                    if (C > Math.Abs(I - (N / I)))
                    {
                        A = I;
                        B = N / A;
                        C = Math.Abs(A - B);
                    }
                }
            }
        }

        public bool GetMatrixFile(int Count, ref int A, ref int B)
        {
            int N = Count;
            A = 1;
            B = N;
            int C = Math.Abs(A - B);
            for (int I = 2; I <= N - 1; I++)
            {
                if (N % I == 0)
                {
                    if (C > Math.Abs(I - (N / I)))
                    {
                        A = I;
                        B = N / A;
                        C = Math.Abs(A - B);
                    }
                }
            }
            if (A == 1 && B == N)
                return false;
            return true;
        }
        public void ShiftRowB(int A, int B, ref byte[,] Matrrix, bool FromLeft)
        {
            int C = A;
            if (B > A)
                C = B;
            byte[] T = new byte[C];
            int Fac = 0;
            for (int I = 0; I <= A - 1; I++)
            {
                if (Fac >= Factor.Count())
                    Fac = 0;
                int TheFac = Conversion.Val(Factor[Fac]);
                int X = 0;
                for (int J = 0; J <= B - 1; J++)
                {
                    T[X] = Matrrix[I, J];
                    X = X + 1;
                }
                ShiftArrayB(ref T, X, TheFac, FromLeft);
                X = 0;
                for (int J = 0; J <= B - 1; J++)
                {
                    Matrrix[I, J] = T[X];
                    X = X + 1;
                }
                Fac = Fac + 1;
            }
        }

        public string GetSpace()
        {
            int p = 0;
            for (p = 1; p <= 4; p++)
            {
                //string[] Words = File.ReadAllText(DataPath + "W" + p + ".dat", Encoding.UTF8).ToLower().Split(Sep);
                string[] Words = File.ReadAllText(DataPath + "W" + p + ".dat", Encoding.UTF8).Split(Sep);
                //string[] WordsNo = File.ReadAllText(DataPath + p + ".dat", Encoding.UTF8).ToLower().Split(Sep);
                string[] WordsNo = File.ReadAllText(DataPath + p + ".dat", Encoding.UTF8).Split(Sep);
                if (Words.Contains(" "))
                {
                    int N = Convert.ToInt32(WordsNo[Array.IndexOf(Words, " ")]);
                    switch (p)
                    {
                        case 1:
                            return ("00" + ToBin(N, 6));
                        case 2:
                            return ("10" + ToBin(N, 14));
                        case 3:
                            return ("110" + ToBin(N, 21));
                        case 4:
                            return ("111" + ToBin(N, 23));
                    }
                    break; // TODO: might not be correct. Was : Exit For
                }
            }
            return "00000000";
        }
        public void ShiftCircular(int FN, ref string[,] Matrrix, ref int[,] MatrrixNo, bool Clockwise)
        {
            int MatrixCount = MC[FN];
            if (MatrixCount <= 1)
                return;
            string[] TW = new string[MatrixCount * 4 - 4];
            int[] TN = new int[MatrixCount * 4 - 4];
            int Fac = 0;
            for (int I = 0; I <= Conversion.Int(MatrixCount / 2) - 1; I++)
            {
                if (Fac >= Factor.Count())
                    Fac = 0;
                int TheFac = Conversion.Val(Factor[Fac]);
                int X = 0;
                for (int J = I; J <= MatrixCount - 1 - I; J++)
                {
                    TW[X] = Matrrix[I, J];
                    TN[X] = MatrrixNo[I, J];
                    X = X + 1;
                }
                for (int J = I + 1; J <= MatrixCount - 1 - I; J++)
                {
                    TW[X] = Matrrix[J, MatrixCount - 1 - I];
                    TN[X] = MatrrixNo[J, MatrixCount - 1 - I];
                    X = X + 1;
                }
                for (int J = MatrixCount - 2 - I; J >= I; J += -1)
                {
                    TW[X] = Matrrix[MatrixCount - 1 - I, J];
                    TN[X] = MatrrixNo[MatrixCount - 1 - I, J];
                    X = X + 1;
                }
                for (int J = MatrixCount - 2 - I; J >= I + 1; J += -1)
                {
                    TW[X] = Matrrix[J, I];
                    TN[X] = MatrrixNo[J, I];
                    X = X + 1;
                }
                ShiftArray(ref TW, ref TN, X, TheFac, Clockwise);
                X = 0;
                for (int J = I; J <= MatrixCount - 1 - I; J++)
                {
                    Matrrix[I, J] = TW[X];
                    MatrrixNo[I, J] = TN[X];
                    X = X + 1;
                }
                for (int J = I + 1; J <= MatrixCount - 1 - I; J++)
                {
                    Matrrix[J, MatrixCount - 1 - I] = TW[X];
                    MatrrixNo[J, MatrixCount - 1 - I] = TN[X];
                    X = X + 1;
                }
                for (int J = MatrixCount - 2 - I; J >= I; J += -1)
                {
                    Matrrix[MatrixCount - 1 - I, J] = TW[X];
                    MatrrixNo[MatrixCount - 1 - I, J] = TN[X];
                    X = X + 1;
                }
                for (int J = MatrixCount - 2 - I; J >= I + 1; J += -1)
                {
                    Matrrix[J, I] = TW[X];
                    MatrrixNo[J, I] = TN[X];
                    X = X + 1;
                }
                Fac = Fac + 1;
            }
        }
        public void ShiftArrayB(ref byte[] Matrrix, int Count, int TheFac, bool FromStart)
        {
            byte[] T = new byte[10];
            int I = 0;
            int X = 0;
            if (TheFac == 0 || TheFac == Count)
                return;
            if (TheFac > Count)
                TheFac = TheFac % Count;
            if (FromStart)
            {
                X = 0;
                for (I = Count - TheFac; I <= Count - 1; I++)
                {
                    T[X] = Matrrix[I];
                    X = X + 1;
                }
                for (I = Count - TheFac - 1; I >= 0; I += -1)
                {
                    Matrrix[I + TheFac] = Matrrix[I];
                }
                X = 0;
                for (I = 0; I <= TheFac - 1; I++)
                {
                    Matrrix[I] = T[X];
                    X = X + 1;
                }
            }
            else
            {
                X = 0;
                for (I = 0; I <= TheFac - 1; I++)
                {
                    T[X] = Matrrix[I];
                    X = X + 1;
                }
                for (I = TheFac; I <= Count - 1; I++)
                {
                    Matrrix[I - TheFac] = Matrrix[I];
                }
                X = 0;
                for (I = Count - TheFac; I <= Count - 1; I++)
                {
                    Matrrix[I] = T[X];
                    X = X + 1;
                }
            }
        }
        public void ShiftDiagonalLeftB(int A, int B, ref byte[,] Matrrix, bool FromUp)
        {
            int C = A;
            if (B < A)
                C = B;
            byte[] T = new byte[C];
            int Fac = 0;
            int AA = 0;
            int BB = 0;
            bool Rev = false;
            int V = 0;
            for (int I = 0; I <= A + B - 4; I++)
            {
                if (Fac >= Factor.Count())
                    Fac = 0;
                int TheFac = Conversion.Val(Factor[Fac]);
                int X = 0;
                if (Rev == false)
                {
                    AA = A - 2 - I;
                    BB = 0;
                    if (AA == -1)
                        Rev = true;
                }
                if (Rev == true)
                {
                    V = V + 1;
                    AA = 0;
                    BB = V;
                }
                do
                {
                    T[X] = Matrrix[AA, BB];
                    X = X + 1;
                    AA = AA + 1;
                    BB = BB + 1;
                } while (!((AA == A) || (BB == B)));
                ShiftArrayB(ref T, X, TheFac, FromUp);
                X = 0;
                if (Rev == false)
                {
                    AA = A - 2 - I;
                    BB = 0;
                    if (AA == -1)
                    {
                        Rev = true;
                        V = 0;
                    }
                }
                if (Rev == true)
                {
                    AA = 0;
                    BB = V;
                }
                do
                {
                    Matrrix[AA, BB] = T[X];
                    X = X + 1;
                    AA = AA + 1;
                    BB = BB + 1;
                } while (!((AA == A) || (BB == B)));
                Fac = Fac + 1;
            }
        }
        public void ShiftDiagonalRightB(int A, int B, ref byte[,] Matrrix, bool FromUp)
        {
            int C = A;
            if (B < A)
                C = B;
            byte[] T = new byte[C];
            int Fac = 0;
            int AA = 0;
            int BB = 0;
            bool Rev = false;
            int V = 0;
            for (int I = 0; I <= A + B - 4; I++)
            {
                if (Fac >= Factor.Count())
                    Fac = 0;
                int TheFac = Conversion.Val(Factor[Fac]);
                int X = 0;
                if (Rev == false)
                {
                    AA = A - 2 - I;
                    BB = B - 1;
                    if (AA == -1)
                        Rev = true;
                }
                if (Rev == true)
                {
                    V = V + 1;
                    AA = 0;
                    BB = V;
                }
                do
                {
                    T[X] = Matrrix[AA, BB];
                    X = X + 1;
                    AA = AA + 1;
                    BB = BB - 1;
                } while (!(AA == A || BB == -1));
                ShiftArrayB(ref T, X, TheFac, FromUp);
                X = 0;
                if (Rev == false)
                {
                    AA = A - 2 - I;
                    BB = B - 1;
                    if (AA == -1)
                        Rev = true;
                }
                if (Rev == true)
                {
                    AA = 0;
                    BB = V;
                }
                do
                {
                    Matrrix[AA, BB] = T[X];
                    X = X + 1;
                    AA = AA + 1;
                    BB = BB - 1;
                } while (!(AA == A || BB == -1));
                Fac = Fac + 1;
            }
        }
        public void ShiftColB(int A, int B, ref byte[,] Matrrix, bool FromUp)
        {
            int C = A;
            if (B > A)
                C = B;
            byte[] T = new byte[C];
            int Fac = 0;
            for (int I = 0; I <= B - 1; I++)
            {
                if (Fac >= Factor.Count())
                    Fac = 0;
                int TheFac = Conversion.Val(Factor[Fac]);
                int X = 0;
                for (int J = 0; J <= A - 1; J++)
                {
                    T[X] = Matrrix[J, I];
                    X = X + 1;
                }
                ShiftArrayB(ref T, X, TheFac, FromUp);
                X = 0;
                for (int J = 0; J <= A - 1; J++)
                {
                    Matrrix[J, I] = T[X];
                    X = X + 1;
                }
                Fac = Fac + 1;
            }
        }
        public void AddToFile(int p)
        {
            //if (File.ReadAllText(DataPath + p + ".txt", Encoding.UTF8).ToLower().Split(Sep).Count() >= Math.Pow(MC[p], 2))
            if (File.ReadAllText(DataPath + p + ".txt", Encoding.UTF8).Split(Sep).Count() >= Math.Pow(MC[p], 2))
            {
                Interaction.MsgBox("File is Full", MsgBoxStyle.Exclamation);
            }
            else
            {
                //string W = Interaction.InputBox("Enter Your Word").Trim().ToLower();
                string W = Interaction.InputBox("Enter Your Word").Trim();
                if (!string.IsNullOrEmpty(W))
                {
                    bool F = false;
                    int I = 0;
                    for (I = 1; I <= 4; I++)
                    {
                        //string[] Words = File.ReadAllText(DataPath + I + ".txt", Encoding.UTF8).ToLower().Split(Sep);
                        string[] Words = File.ReadAllText(DataPath + I + ".txt", Encoding.UTF8).Split(Sep);
                        if (Words.Contains(W))
                        {
                            F = true;
                            break; // TODO: might not be correct. Was : Exit For
                        }
                    }
                    if (F == false)
                    {
                        File.AppendAllText(DataPath + p + ".txt", Sep + W, Encoding.UTF8);
                        InitArray(p);
                        Fill();
                        Interaction.MsgBox("Added Successfully", MsgBoxStyle.Information);
                    }
                    else
                    {
                        Interaction.MsgBox("Word already Exist in File " + I, MsgBoxStyle.Critical);
                    }
                }
            }
        }
        public void RemoveFromFile()
        {
            //string W = Interaction.InputBox("Enter Your Word").Trim().ToLower();
            string W = Interaction.InputBox("Enter Your Word").Trim();

            if (!string.IsNullOrEmpty(W))
            {
                bool F = false;
                int p = 0;
                for (p = 1; p <= 4; p++)
                {
                    //string[] Words = File.ReadAllText(DataPath + p + ".txt", Encoding.UTF8).ToLower().Split(Sep);
                    string[] Words = File.ReadAllText(DataPath + p + ".txt", Encoding.UTF8).Split(Sep);
                    if (Words.Contains(W))
                    {
                        F = true;
                        StringBuilder Tmp = new StringBuilder();
                        int I = 0;
                        for (I = 0; I <= Words.Count() - 1; I++)
                        {
                            if (Words[I] != W)
                                Tmp.Append(Words[I] + Sep);
                        }
                        if (Tmp.Length != 0)
                            Tmp.Remove(Tmp.Length - 1, 1);
                        File.WriteAllText(DataPath + p + ".txt", Tmp.ToString(), Encoding.UTF8);
                        InitArray(p);
                        Fill();
                        Interaction.MsgBox("Removed Successfully", MsgBoxStyle.Information);
                    }
                }
                if (F == false)
                {
                    Interaction.MsgBox("Word not Exist in Dictionary", MsgBoxStyle.Critical);
                }
            }
        }
        private void BTNAdd1_Click(System.Object sender, System.EventArgs e)
        {
            AddToFile(1);
        }
        private void BTNAdd2_Click(object sender, System.EventArgs e)
        {
            AddToFile(2);
        }
        private void BTNAdd3_Click(object sender, System.EventArgs e)
        {
            AddToFile(3);
        }
        private void BTNAdd4_Click(object sender, System.EventArgs e)
        {
            AddToFile(4);
        }
        private void Timer2_Tick(object sender, System.EventArgs e)
        {
            Timer2.Enabled = false;
            Decrypt(false, false);
            FRMWait.Close();
            this.Enabled = true;
        }
        private void Timer3_Tick(object sender, System.EventArgs e)
        {
            Timer3.Enabled = false;
            Decrypt(true, false);
            FRMWait.Close();
            this.Enabled = true;
        }
        private void Timer4_Tick(object sender, System.EventArgs e)
        {
            Timer4.Enabled = false;
            Decrypt(true, true);
            FRMWait.Close();
            this.Enabled = true;
        }
        private void BTNRemove1_Click(System.Object sender, System.EventArgs e)
        {
            RemoveFromFile();
        }
        private void Timer1_Tick(object sender, System.EventArgs e)
        {
            Timer1.Enabled = false;


            Token = new StringBuilder();
            //TXTData.Text = TXTData.Text.ToLower().Trim() ;
            TXTData.Text = TXTData.Text.Trim();
            bool StartWord = false;
            bool isSymbol = false;
            char symbol = ' ';
            string Tmp = "";
            foreach (char p in TXTData.Text)
            {
                if (letters.Contains(p.ToString()))
                {
                    if (isSymbol)
                    {
                        //Add Symbol
                        AddWord(symbol.ToString());
                        //Add Delete Space
                        Token.Append("0100");
                        encSize += 4;
                        isSymbol = false;
                    }
                    Tmp = Tmp + p;
                    StartWord = true;
                }
                else if (TheChar.Contains(p.ToString()))
                {
                    if (StartWord)
                    {
                        StartWord = false;
                        AddWord(Tmp);
                        Tmp = "";
                        if (p != ' ')
                        {
                            //Add delete space command.
                            Token.Append("0100");
                            encSize += 4;
                            //make symbol count to check next
                            isSymbol = true;
                            symbol = p;

                        }
                    }
                    else
                    {

                        if (p == ' ')
                        {
                            if (isSymbol)
                            {
                                AddWord(symbol.ToString());
                                isSymbol = false;
                            }
                            else
                            {
                                AddWord(p.ToString());
                            }
                        }
                        
                        else if (p != ' ') //Jarrah
                        {
                            if (isSymbol)
                            {
                                
                                //Add Symbol
                                AddWord(symbol.ToString());
                                //Add Delete Space
                                Token.Append("0100");
                                symbol = p;
                            }   
                            else
                            {
                               // AddWord(p.ToString());
                                isSymbol = true;
                                symbol = p;
                            }
                        }
                    }
                }
                else //the letter or symbol does not found, add it
                {
                    Interaction.MsgBox("Invalid Character" + Constants.vbNewLine + "\"" + p.ToString() + "\"", MsgBoxStyle.Critical);
                    File.AppendAllText(DataPath + "arDic" + 0 + ".txt", p.ToString()+Sep, Encoding.Unicode);
                }
                
            }
            if (StartWord)
            {
                AddWord(Tmp);
                Token.Append("0100");
                encSize += 4;
            }
            if (isSymbol)
            {
                AddWord(symbol.ToString());
                Token.Append("0100");
                encSize += 4;
            }

            int A = 0;
            int B = 0;
            GetMatrixCount(Token.Length, ref A, ref B);
            List<byte> ArrByte = new List<byte>();
            string T = Token.ToString();
            int I = 0;
            do
            {
                ArrByte.Add(Convert.ToByte(ToNum(T.Substring(I, 8))));
                I = I + 8;
            } while (!(I == T.Length));
            byte[,] BMatrix = new byte[A, B];
            int Z = 0;
            for (I = 0; I <= A - 1; I++)
            {
                for (int J = 0; J <= B - 1; J++)
                {
                    BMatrix[I, J] = ArrByte[Z];
                    Z = Z + 1;
                }
            }

            // The commented statements are used for encryption
            /*
            ShiftRowB(A, B, ref BMatrix, false);
            ShiftColB(A, B, ref BMatrix, true);
            ShiftRowB(A, B, ref BMatrix, true);
            ShiftColB(A, B, ref BMatrix, false);
            ShiftCircularB(A, B, ref BMatrix, false);
            ShiftDiagonalLeftB(A, B, ref BMatrix, false);
            ShiftDiagonalRightB(A, B, ref BMatrix, false);
            ShiftDiagonalLeftB(A, B, ref BMatrix, true);
            ShiftDiagonalRightB(A, B, ref BMatrix, true);
            ShiftCircularB(A, B, ref BMatrix, true);
            */
            string FName = "";
            SaveFileDialog1.FileName = "";
            SaveFileDialog1.Filter = "Amer files (*.amer)|*.amer";
            SaveFileDialog1.ShowDialog();
            FName = SaveFileDialog1.FileName;
            if (!string.IsNullOrEmpty(FName))
            {
                FileStream FS = new FileStream(FName, FileMode.Create, FileAccess.Write);
                for (I = 0; I <= A - 1; I++)
                {
                    for (int J = 0; J <= B - 1; J++)
                    {
                        FS.WriteByte(BMatrix[I, J]);
                    }
                }
                FS.Close();
                Interaction.MsgBox("Encrypting Successfully", MsgBoxStyle.Information);
            }
            FRMWait.Close();
            this.Enabled = true;

            lblEncSize.Text = "Encryped text size(Bytes): " + (encSize/8).ToString();
            lblEncPerc.Text = "Compression Ratio: " + (((encSize / 8.0)/(float)textSize) * 100.0).ToString() + "%";
        }



        public void Decrypt(bool ToFile, bool WithUTF8)
        {
            string FName = "";
            OpenFileDialog1.FileName = "";
            OpenFileDialog1.Filter = "Amer files (*.amer)|*.amer";
            OpenFileDialog1.ShowDialog();
            FName = OpenFileDialog1.FileName;
            if (!string.IsNullOrEmpty(FName))
            {
                int A = 0;
                int B = 0;
                FileStream FS = new FileStream(FName, FileMode.Open, FileAccess.Read);
                if (GetMatrixFile(Convert.ToInt32(FS.Length), ref A, ref B) == false)
                {
                    FS.Close();
                    Interaction.MsgBox("Invalid File", MsgBoxStyle.Critical);
                    return;
                }
                byte[,] BMatrix = new byte[A, B];
                int I = 0;
                for (I = 0; I <= A - 1; I++)
                {
                    for (int J = 0; J <= B - 1; J++)
                    {
                        BMatrix[I, J] = Convert.ToByte(FS.ReadByte());
                    }
                }
                FS.Close();
                // The commented statements are used for decryption 
                /*
                 ShiftCircularB(A, B, ref BMatrix, false);
                 ShiftDiagonalRightB(A, B, ref BMatrix, false);
                 ShiftDiagonalLeftB(A, B, ref BMatrix, false);
                 ShiftDiagonalRightB(A, B, ref BMatrix, true);
                 ShiftDiagonalLeftB(A, B, ref BMatrix, true);
                 ShiftCircularB(A, B, ref BMatrix, true);
                 ShiftColB(A, B, ref BMatrix, true);
                 ShiftRowB(A, B, ref BMatrix, false);
                 ShiftColB(A, B, ref BMatrix, false);
                 ShiftRowB(A, B, ref BMatrix, true);
                 */
                Token = new StringBuilder();
                for (I = 0; I <= A - 1; I++)
                {
                    for (int J = 0; J <= B - 1; J++)
                    {
                        Token.Append(ToBin(BMatrix[I, J], 8));                        
                    }
                }
                string T = Token.ToString();
                Token = new StringBuilder();
                if (T.Length >= 9)
                {
                    I = 0;
                    int p = 0;
                    int No = 0;
                    bool isCommand = false;
                    int command = 0;
                    int commandType = 0;
                    bool beginNewWord = false;

                    do
                    {
                        if (T.Length < I + 8)
                        {
                            break; // TODO: might not be correct. Was : Exit Do
                        }
                        try
                        {
                            //switch (T.Substring(I, 2))
                            //{
                            //  case ""
                            if (T.Substring(I, 1).Equals("0"))
                            //case "00":
                            {
                                //  p = 1;
                                commandType = Convert.ToInt32(ToNum(T.Substring(I + 1, 3)));
                                if (commandType >= 4)
                                {
                                    switch (commandType)
                                    {
                                        case 4:
                                            isCommand = true;
                                            command = 1; // delete space;
                                            I = I + 4;
                                            break;
                                       case 5:
                                            isCommand = true;
                                            beginNewWord = true;
                                            command = 2; // new word
                                            I = I + 4;
                                            break;
                                        case 6:
                                            isCommand = true;
                                            command = 3;
                                            beginNewWord = false;
                                            Token.Append(" ");
                                            I = I + 4;
                                            break;
                                    }
                                }
                                else // it is a letter. File 1.txt
                                {
                                    p = 1;
                                    isCommand = false;
                                    No = Convert.ToInt32(ToNum(T.Substring(I + 2, 6)));
                                    I = I + 8;
                                }
                            }
                            else if (T.Substring(I, 2).Equals("10"))
                            //case "10":
                            { isCommand = false;
                                p = 2;
                                No = Convert.ToInt32(ToNum(T.Substring(I + 2, 14)));
                                I = I + 16;
                            }
                            //case "10":
                            else if (T.Substring(I, 3).Equals("110"))
                            {
                                isCommand = false;
                                p = 3;
                                No = Convert.ToInt32(ToNum(T.Substring(I + 3, 21)));
                                I = I + 24;
                            }
                            else if (T.Substring(I, 3).Equals("111"))
                            //case "11":
                            {
                                isCommand = false;
                                p = 4;
                                No = Convert.ToInt32(ToNum(T.Substring(I + 3, 23)));
                                I = I + 26;
                            }
                            
                        }
                        catch (Exception ex)
                        {
                            Interaction.MsgBox("Invalid File", MsgBoxStyle.Critical);
                            System.Environment.Exit(0);
                        }
                        //string[] Words = File.ReadAllText(DataPath + "W" + p + ".dat", Encoding.UTF8).ToLower().Split(Sep);
                        //string[] WordsNo = File.ReadAllText(DataPath + p + ".dat", Encoding.UTF8).ToLower().Split(Sep);
                        if (isCommand)
                        {
                            if (command == 1)
                            {
                                Token.Remove(Token.Length - 1, 1);
                                command = 0;
                                isCommand = false;
                            }
                        }
                        else
                        {
                            if (MyWordsNo.Contains(No.ToString()))
                            {
                                int index = 0;
                                int pos = Array.IndexOf(MyWordsNo, No.ToString(), index);
                                if (MyWordsFile[pos] == p.ToString())
                                {
                                    if (beginNewWord)
                                    {
                                        Token.Append(MyWords[pos]);
                                    }
                                    else
                                    {
                                        Token.Append(MyWords[pos]);
                                        if (MyWords[pos]!= " ")
                                            Token.Append(' '); // Jarrah
                                    }
                                }
                                else
                                {
                                    index = pos+1;
                                    pos = Array.IndexOf(MyWordsNo, No.ToString(), index);
                                    if (pos != -1)
                                    {
                                        if (MyWordsFile[pos] == p.ToString())
                                        {
                                            if (beginNewWord)
                                            {
                                                Token.Append(MyWords[pos]);
                                            }
                                            else
                                            {
                                                Token.Append(MyWords[pos]);
                                                if (MyWords[pos] != " ")
                                                    Token.Append(' '); // Jarrah
                                            }
                                        }
                                        else
                                        {
                                            index = pos+1;
                                            pos = Array.IndexOf(MyWordsNo, No.ToString(), index);
                                            if (pos != -1)
                                            {
                                                if (MyWordsFile[pos] == p.ToString())
                                                {
                                                    if (beginNewWord)
                                                    {
                                                        Token.Append(MyWords[pos]);
                                                    }
                                                    else
                                                    {
                                                        Token.Append(MyWords[pos]);
                                                        if (MyWords[pos] != " ")
                                                            Token.Append(' '); // Jarrah
                                                    }
                                                }
                                                else
                                                {
                                                    index = pos+1;
                                                    pos = Array.IndexOf(MyWordsNo, No.ToString(), index);
                                                    if (pos != -1)
                                                    {
                                                        if (MyWordsFile[pos] == p.ToString())
                                                        {
                                                            if (beginNewWord)
                                                            {
                                                                Token.Append(MyWords[pos]);
                                                            }
                                                            else
                                                            {
                                                                Token.Append(MyWords[pos]);
                                                                if (MyWords[pos] != " ")
                                                                    Token.Append(' '); // Jarrah
                                                            }
                                                        }
                                                        else
                                                        {

                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }




                                //Token.Append(MyWords[Array.IndexOf(MyWordsNo, No.ToString())]);
                            }
                            else
                            {
                                Interaction.MsgBox("Invalid File", MsgBoxStyle.Critical);
                                System.Environment.Exit(0);
                            }
                        }
                    } while (!(I == T.Length));
                    TXTData.Text = Token.ToString().Trim();
                    if (ToFile)
                    {
                        string FName2 = "";
                        SaveFileDialog1.FileName = "";
                        SaveFileDialog1.Filter = "Text files (*.txt)|*.txt";
                        SaveFileDialog1.ShowDialog();
                        FName2 = SaveFileDialog1.FileName;
                        if (!string.IsNullOrEmpty(FName2))
                        {
                            if (WithUTF8 == true)
                            {
                                File.WriteAllText(FName2, Token.ToString().Trim(), Encoding.UTF8);
                            }
                            else
                            {
                                File.WriteAllText(FName2, Token.ToString().Trim());
                            }
                        }
                    }
                    Interaction.MsgBox("Decrypting Successfully", MsgBoxStyle.Information);
                }
            }
        }

        private void BTNSave_Click(System.Object sender, System.EventArgs e)
        {
            string FName = "";
            SaveFileDialog1.FileName = "";
            SaveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            SaveFileDialog1.ShowDialog();
            FName = SaveFileDialog1.FileName;
            if (!string.IsNullOrEmpty(FName))
            {
                File.WriteAllText(FName, TXTData.Text.Trim());
                Interaction.MsgBox("Saved Successfully", MsgBoxStyle.Information);
            }
        }

        private void BTNSaveUtf_Click(System.Object sender, System.EventArgs e)
        {
            string FName = "";
            SaveFileDialog1.FileName = "";
            SaveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            SaveFileDialog1.ShowDialog();
            FName = SaveFileDialog1.FileName;
            if (!string.IsNullOrEmpty(FName))
            {
                File.WriteAllText(FName, TXTData.Text.Trim(), Encoding.UTF8);
                Interaction.MsgBox("Saved Successfully", MsgBoxStyle.Information);
            }
        }

        private void BTNDecryptFile_Click(System.Object sender, System.EventArgs e)
        {
            this.Enabled = false;
            FRMWait = new Form2();
            FRMWait.Show(this);
            Timer3.Enabled = true;
        }

        private void BTNDecryptFileUtf_Click(System.Object sender, System.EventArgs e)
        {
            this.Enabled = false;
            FRMWait = new Form2();
            FRMWait.Show(this);
            Timer4.Enabled = true;
        }



        public void ShiftCircularB(int A, int B, ref byte[,] Matrrix, bool Clockwise)
        {
            int C = A;
            if (B < A)
                C = B;
            if (C <= 1)
                return;
            byte[] T = new byte[2 * A + 2 * B - 4];
            int Fac = 0;
            for (int I = 0; I <= Conversion.Int(C / 2) - 1; I++)
            {
                if (Fac >= Factor.Count())
                    Fac = 0;
                int TheFac = Conversion.Val(Factor[Fac]);
                int X = 0;
                for (int J = I; J <= B - 1 - I; J++)
                {
                    T[X] = Matrrix[I, J];
                    X = X + 1;
                }
                for (int J = I + 1; J <= A - 1 - I; J++)
                {
                    T[X] = Matrrix[J, B - 1 - I];
                    X = X + 1;
                }
                for (int J = B - 2 - I; J >= I; J += -1)
                {
                    T[X] = Matrrix[A - 1 - I, J];
                    X = X + 1;
                }
                for (int J = A - 2 - I; J >= I + 1; J += -1)
                {
                    T[X] = Matrrix[J, I];
                    X = X + 1;
                }
                ShiftArrayB(ref T, X, TheFac, Clockwise);
                X = 0;
                for (int J = I; J <= B - 1 - I; J++)
                {
                    Matrrix[I, J] = T[X];
                    X = X + 1;
                }
                for (int J = I + 1; J <= A - 1 - I; J++)
                {
                    Matrrix[J, B - 1 - I] = T[X];
                    X = X + 1;
                }
                for (int J = B - 2 - I; J >= I; J += -1)
                {
                    Matrrix[A - 1 - I, J] = T[X];
                    X = X + 1;
                }
                for (int J = A - 2 - I; J >= I + 1; J += -1)
                {
                    Matrrix[J, I] = T[X];
                    X = X + 1;
                }
                Fac = Fac + 1;
            }
        }


        public void Fill()
        {
            MyWords = new string[9199529];
            MyWordsNo = new string[9199529];
            MyWordsFile = new string[9199529];
            int X = 0;
            for (int I = 1; I <= 4; I++)
            {
                //string[] Words = File.ReadAllText(DataPath + "W" + I + ".dat", Encoding.UTF8).ToLower().Split(Sep);
                string[] Words = File.ReadAllText(DataPath + "W" + I + ".dat", Encoding.UTF8).Split(Sep);
                //string[] WordsNo = File.ReadAllText(DataPath + I + ".dat", Encoding.UTF8).ToLower().Split(Sep);
                string[] WordsNo = File.ReadAllText(DataPath + I + ".dat", Encoding.UTF8).Split(Sep);
                int J = 0;
                foreach (string p in Words)
                {
                    MyWords[X] = p;
                    MyWordsNo[X] = WordsNo[J];
                    MyWordsFile[X] = I.ToString();
                    X = X + 1;
                    J = J + 1;
                }
            }

        }

        private void TXTData_TextChanged(object sender, EventArgs e)
        {
            charcterCounter = TXTData.TextLength;
            textSize = charcterCounter * 2;
            lblChar.Text = "Character counter:" + charcterCounter.ToString();
            lblSize.Text = "Size before (bytes):" + textSize.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool StartWord = false;
            int wordCount = 0;
            foreach (char p in TXTData.Text)
            {
                if (letters.Contains(p.ToString()))
                {
                      StartWord = true;
                }
                else if (TheChar.Contains(p.ToString()))
                {
                    if (StartWord)
                    {
                        StartWord = false;
                        wordCount++;
                    }
                }
            }
            if (StartWord)
            {
                wordCount++;
            }

            lblWords.Text = "Number of Words: " + wordCount.ToString();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {            
            int x;
            int size = MyWords.Length;
            Random rand = new Random();         
            for (int i = 0; i < 10000; i++)
            {
                x = rand.Next(1, size);
                TXTData.Text += MyWords[x] + " ";
            }
        }
    }
}
