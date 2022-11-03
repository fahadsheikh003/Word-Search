using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Word_Search
{    public partial class ResultWindow : Form
    {
        public ResultWindow()
        {
            InitializeComponent();
        }

        private void ResultWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is SearchWindow);
            if (formToShow != null)
            {
                formToShow.Show();
            }
        }

        public string algorithmEntry
        {
            get
            {
                return AlgorithmEntry.Text;
            }
            set
            {
                AlgorithmEntry.Text = value;
            }
        }
        
        public string pathEntry
        {
            get
            {
                return PathEntry.Text;
            }
            set
            {
                PathEntry.Text = value;
            }
        }

        public string findEntry
        {
            get
            {
                return FindEntry.Text;
            }
            set
            {
                FindEntry.Text = value;
            }
        }

        private bool word_check(string input, int start, int end)
        {
            if (start > 0 && (/* !Char.IsPunctuation(input[start - 1]) || */ !Char.IsSeparator(input[start - 1])))
                return false;

            if (end + 1 < input.Length && (/* !Char.IsPunctuation(input[end + 1]) || */ !Char.IsSeparator(input[end + 1])))
                return false;

            return true;
        }

        private int wordLength(string input, int m)
        {
            int count = 0;

            for (int i = m; i >= 0; i--)
            {
                if (!Char.IsLetterOrDigit(input[i]))
                    break;
                //if (input[i] == ' ')
                //    break;
                count++;
            }
            for (int i = m+1; i < input.Length; i++)
            {
                if (!Char.IsLetterOrDigit(input[i]))
                    break;
                //if (input[i] == ' ')
                //    break;
                count++;
            }

            return count;
        }

        public void FindQuery(string pattern, string directory, bool _case, bool _word)
        {
            if (!_case)
            {
                pattern = pattern.ToLower();
            }
            switch (AlgorithmEntry.Text)
            {
                case "Brute-Force":
                    bruteForce(pattern, directory, _case, _word);
                    break;
                case "Rabin-Karp":
                    rabinKarp(pattern, directory, _case, _word);
                    break;
                case "Knuth–Morris–Pratt":
                    KMP(pattern, directory, _case, _word);
                    break;
            }
        }
        private void bruteForce(string pattern, string directory, bool _case, bool _word)
        {
            string[] files = Directory.GetFiles(directory, "*.txt");

            int M = pattern.Length;

            foreach (string file in files)
            {
                string fileName = file.Split('\\')[file.Split('\\').Length - 1] + "\n";
                int count = 1;

                string[] rows = File.ReadAllLines(file);
                for (int i = 0; i < rows.Length; i++)
                {
                    string line = rows[i];
                    if (!_case)
                    {
                        line = line.ToLower();
                    }
                    int N = line.Length;

                    for (int j = 0; j <= N - M; j++)
                    {
                        int k;

                        //For current index i, check for pattern match
                        for (k = 0; k < M; k++)
                            if (line[j + k] != pattern[k])
                                break;

                        //if pat[0...M-1] = txt[i, i+1, ...i+M-1]
                        if (k == M)
                        {
                            //if (_word && !(M == wordLength(line, j)))
                            //{
                            //    continue;
                            //}
                            if (_word && !word_check(line, j, j + pattern.Length - 1))
                                continue;

                            var index = ResultEntry.Rows.Add();
                            ResultEntry.Rows[index].Cells[0].Value = fileName;
                            ResultEntry.Rows[index].Cells[1].Value = i + 1;
                            ResultEntry.Rows[index].Cells[2].Value = j + 1;

                            ResultEntry.Rows[index].Cells[3].Value = count++;
                        }

                    }
                }
            }
        }

        private void rabinKarp(string pattern, string directory, bool _case, bool _word)
        {
            int prime = 101;
            
            // d is the number of characters in the input alphabet
            int d = 256;

            int M = pattern.Length;

            string[] files = Directory.GetFiles(directory, "*.txt");

            foreach (string file in files)
            {
                string fileName = file.Split('\\')[file.Split('\\').Length - 1] + "\n";
                int count = 1;

                string[] rows = File.ReadAllLines(file);
                for (int x = 0; x < rows.Length; x++)
                {
                    string line = rows[x];
                    if (!_case)
                    {
                        line = line.ToLower();
                    }

                    int N = line.Length;
                    
                    if (N < M)
                    {
                        continue;
                    }
                    
                    int i, j;
                    int p = 0; // hash value for pattern
                    int t = 0; // hash value for text
                    int h = 1;

                    // The value of h would be "pow(d, M-1)%prime"
                    for (i = 0; i < M - 1; i++)
                        h = (h * d) % prime;

                    // Calculate the hash value of pattern and first
                    // window of text
                    for (i = 0; i < M; i++)
                    {
                        p = (d * p + pattern[i]) % prime;
                        t = (d * t + line[i]) % prime;
                    }

                    // Slide the pattern over text one by one
                    for (i = 0; i <= N - M; i++)
                    {
                        // Check the hash values of current window of
                        // text and pattern. If the hash values match
                        // then only check for characters one by one
                        if (p == t)
                        {
                            /* Check for characters one by one */
                            for (j = 0; j < M; j++)
                            {
                                if (line[i + j] != pattern[j])
                                    break;
                            }

                            // if p == t and pat[0...M-1] = txt[i, i+1,
                            // ...i+M-1]
                            if (j == M)
                            {
                                //Console.WriteLine(
                                //    "Pattern found at index " + i);
                                //if (_word && !(M == wordLength(line, i)))
                                //{
                                //    continue;
                                //}
                                if (_word && !word_check(line, i, i + pattern.Length - 1))
                                    continue;

                                var index = ResultEntry.Rows.Add();
                                ResultEntry.Rows[index].Cells[0].Value = fileName;
                                ResultEntry.Rows[index].Cells[1].Value = x + 1;
                                ResultEntry.Rows[index].Cells[2].Value = i + 1;

                                ResultEntry.Rows[index].Cells[3].Value = count++;
                            }
                        }

                        // Calculate hash value for next window of text:
                        // Remove leading digit, add trailing digit
                        if (i < N - M)
                        {
                            t = (d * (t - line[i] * h) + line[i + M]) % prime;

                            // We might get negative value of t,
                            // converting it to positive
                            if (t < 0)
                                t = (t + prime);
                        }
                    }
                }
            }

               
            
        }

        private void KMP(string pattern, string directory, bool _case, bool _word)
        {
            int M = pattern.Length;

            string[] files = Directory.GetFiles(directory, "*.txt");

            foreach (string file in files)
            {
                string fileName = file.Split('\\')[file.Split('\\').Length - 1] + "\n";
                int count = 1;

                string[] rows = File.ReadAllLines(file);
                for (int x = 0; x < rows.Length; x++)
                {
                    string line = rows[x];
                    if (!_case)
                    {
                        line = line.ToLower();
                    }
                    int N = line.Length;

                    // create lps[] that will hold the longest
                    // prefix suffix values for pattern
                    int[] lps = new int[M];
                    int j = 0; // index for pat[]

                    // Preprocess the pattern (calculate lps[]
                    // array)
                    computeLPSArray(pattern, M, lps);

                    int i = 0; // index for txt[]
                    while ((N - i) >= (M - j))
                    {
                        if (pattern[j] == line[i])
                        {
                            j++;
                            i++;
                        }

                        if (j == M)
                        {
                            //Console.Write("Found pattern "
                            //            + "at index " + (i - j));
                            //if (_word && !(M == wordLength(line, i - j)))
                            //{
                            //    continue;
                            //}
                            if (_word && !word_check(line, i - j, i - j + pattern.Length - 1))
                            {
                                j = lps[j - 1];
                                continue;
                            }

                            var index = ResultEntry.Rows.Add();
                            ResultEntry.Rows[index].Cells[0].Value = fileName;
                            ResultEntry.Rows[index].Cells[1].Value = x + 1;
                            ResultEntry.Rows[index].Cells[2].Value = i - j + 1;

                            ResultEntry.Rows[index].Cells[3].Value = count++;

                            j = lps[j - 1];
                        }

                        // mismatch after j matches
                        else if (i < N && pattern[j] != line[i])
                        {
                            // Do not match lps[0..lps[j-1]] characters,
                            // they will match anyway
                            if (j != 0)
                                j = lps[j - 1];
                            else
                                i = i + 1;
                        }
                    }
                }
            }
        }

        private void computeLPSArray(string pat, int M, int[] lps)
        {
            // length of the previous longest prefix suffix
            int len = 0;
            int i = 1;
            lps[0] = 0; // lps[0] is always 0

            // the loop calculates lps[i] for i = 1 to M-1
            while (i < M)
            {
                if (pat[i] == pat[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else // (pat[i] != pat[len])
                {
                    // This is tricky. Consider the example.
                    // AAACAAAA and i = 7. The idea is similar
                    // to search step.
                    if (len != 0)
                    {
                        len = lps[len - 1];

                        // Also, note that we do not increment
                        // i here
                    }
                    else // if (len == 0)
                    {
                        lps[i] = len;
                        i++;
                    }
                }
            }
        }

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        private void ResultEntry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string path = PathEntry.Text + "\\" + senderGrid.Rows[e.RowIndex].Cells[0].Value;
                path = path.Replace('\n', ' ');
                
                if (NotepadppCheck.Checked)
                {
                    int row = (int)senderGrid.Rows[e.RowIndex].Cells[1].Value;
                    int column = (int)senderGrid.Rows[e.RowIndex].Cells[2].Value;

                    path = path.Replace('\n', ' ');
                    var process = new Process();
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = $"/c start notepad++ \"{path}\" -n{row} -c{column}";
                    process.Start();
                }
                else
                {
                    var process = new Process();
                    process.StartInfo.FileName = "notepad.exe";
                    process.StartInfo.Arguments = $"\"{path}\"";
                    process.Start();

                    Thread.Sleep(1000);
                    if (SetForegroundWindow(process.MainWindowHandle))
                    {
                        SendKeys.Send("^{f}");
                        Thread.Sleep(100);
                        SendKeys.Send(FindEntry.Text);

                        int count = (int)senderGrid.Rows[e.RowIndex].Cells[3].Value;
                        for (int i = 0; i < count; i++)
                        {
                            SendKeys.Send("{ENTER}");
                        }
                    }
                }
            }
        }
    }
}
