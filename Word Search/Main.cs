namespace Word_Search
{
    public partial class SearchWindow : Form
    {
        public SearchWindow()
        {
            InitializeComponent();
        }

        private void PathButton_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                PathEntry.Text = fbd.SelectedPath;
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(PathEntry.Text) || Directory.GetFiles(PathEntry.Text, "*.txt").Length == 0)
            {
                MessageBox.Show("Invalid Path or Path doesn't contains any text file..", "Error! Invalid input - Word Search");
                return;
            }

            if (String.IsNullOrWhiteSpace(FindEntry.Text))
            {
                MessageBox.Show("Please Enter something to search for..", "Error! Invalid input - Word Search");
                return;
            }

            this.Hide();
            var resultWindow = new ResultWindow();
            resultWindow.algorithmEntry = AlgorithmEntry.Text;
            resultWindow.pathEntry = PathEntry.Text;
            resultWindow.findEntry = FindEntry.Text;
            resultWindow.Show();
            resultWindow.FindQuery(FindEntry.Text, PathEntry.Text, CaseEntry.Checked, WordEntry.Checked);
            //resultWindow.bruteForce(FindEntry.Text, PathEntry.Text);
            //resultWindow.rabinKarp(FindEntry.Text, PathEntry.Text);
            //resultWindow.KMP(FindEntry.Text, PathEntry.Text);

            //string[] files = Directory.GetFiles(PathEntry.Text, "*.txt");
            //MessageBox.Show("Algorithm: " + AlgorithmEntry.Text + "\nPath: " + PathEntry.Text + "\nFiles: " + files.Length.ToString());
        }
    }
}