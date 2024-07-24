namespace HebrewDaysMivdak
{
    public partial class Form1 : Form
    {
        DateFactory dateFactory;
        Dictionary<string, string> daysdic;
        Dictionary<int, string> daysInMonthDic;
        string[] monthes;
        Dictionary<string, string> yearsDic;
        XmlService xmlService;

        public Form1()
        {
            InitializeComponent();
            xmlService = new XmlService("data.xml"); // xml in the bin file
            dateFactory = new DateFactory();
            daysdic = dateFactory.CreateDaysDictionary();
            daysInMonthDic = dateFactory.CreateDaysInMonthDictionary();
            monthes = dateFactory.CreateMonthsArray();
            yearsDic = dateFactory.CreateYearsDictionary();

            LoadAllComboBox();
        }

        private void LoadAllComboBox()
        {

            foreach (string day in daysdic.Keys)
            {
                comboBox_day.Items.Add(day);
            }

            foreach (int i in daysInMonthDic.Keys)
            {
                comboBox_dInMonth.Items.Add(i);
            }

            foreach (string month in monthes)
            {
                comboBox_month.Items.Add(month);
            }

            foreach (string year in yearsDic.Keys)
            {
                comboBox_year.Items.Add(year);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_day.SelectedIndex == -1 || comboBox_dInMonth.SelectedIndex == -1
                || comboBox_month.SelectedIndex == -1 || comboBox_year.SelectedIndex == -1)
            {
                MessageBox.Show("בחר את כל הפרטים");
                return;
            }

            MessageBox.Show(CreateHebrewDate());


        }

        private string CreateHebrewDate()
        {
            //Pull the right values from the dictionary
            // all the keys needed to the xml object

            string dayKey = comboBox_day.SelectedItem.ToString();
            string day = daysdic[dayKey];

            int dayInMonthKey = int.Parse(comboBox_dInMonth.SelectedItem.ToString()); //needed to check if it is 30
            string dayInMonth = daysInMonthDic[dayInMonthKey];

            string month = comboBox_month.SelectedItem.ToString();

            string yearKey = comboBox_year.SelectedItem.ToString();
            string year = yearsDic[yearKey];

            //next month for 30
            int nextMonthIndex = (comboBox_month.SelectedIndex + 1) % monthes.Length;
            string nextMonth;

            if (nextMonthIndex == 6 || nextMonthIndex == 7)
                nextMonth = comboBox_month.Items[8].ToString();
            else nextMonth = comboBox_month.Items[nextMonthIndex].ToString();

            //There is a difference between day 30 and the others
            string monthStringVal = dayInMonthKey == 30 ? $"לחודש {month} שהוא ראש חודש {nextMonth}" : $"לירח {month}";


            string result = @$"ב{day} בשבת {dayInMonth} {monthStringVal} שנת חמשת אלפים ושבע מאות ו{year} לבריאת העולם";

            xmlService.CreateQuery(new HebrewDateModel(
                dayKey,
                dayInMonthKey,
                month,
                yearKey,
                result)
                );

            return result; 
        }
    }
}
