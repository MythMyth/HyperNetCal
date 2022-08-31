namespace HyperNetCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            List<(string, int)> values = new List<(string, int)> ();
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
    }
}