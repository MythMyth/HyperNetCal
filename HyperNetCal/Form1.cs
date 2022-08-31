namespace HyperNetCal
{
    public partial class Form1 : Form
    {
        List<(string, int)> values;
        public Form1()
        {
            InitializeComponent();
            values = new List<(string, int)>();
        }

        private void cal_Click(object sender, EventArgs e)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            string[] t = tickets.Text.ToString().Split('\n');
            foreach(string ticket in t)
            {
                string s = ticket.Trim().ToLower();
                foreach(char c in s)
                {
                    if(map.ContainsKey(c)) { map[c] = map[c] + 1; }
                    else { map.Add(c, 1); }
                }
            }

            values.Clear();

            foreach(string ticket in t)
            {
                string s = ticket.Trim().ToLower();
                int point = 0;
                foreach(char c in s)
                {
                    point += map[c];
                }
                values.Add((ticket.ToUpper(), point));
            }
            values = values.OrderBy(o => o.Item2).ToList();
            Ranking.Items.Clear();
            foreach((string, int) item in values)
            {
                Ranking.Items.Add($"{item.Item1} - {item.Item2}");
            }
        }

        private void Ranking_SelectedIndexChanged(object sender, EventArgs e)
        {
            int total = 0;
            int curr = 0;
            foreach(ListViewItem item in Ranking.SelectedItems)
            {
                int index = Ranking.Items.IndexOf(item);
                curr += values[index].Item2;
            }

            foreach ((string, int) item in values)
            {
                total += item.Item2;
            }

            val.Text = $"{curr}/{total}";
        }
    }
}