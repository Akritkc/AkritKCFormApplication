using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AkritKCFormApplication.DataObjects;


namespace AkritKCFormApplication.Forms
{
    public partial class FeedbackForm : Form
    {
        FileHelp fileHelper;
        String customerName;
        String customerNumber;
        String customerEmail;
        int latestIndexRow = 0;


        public FeedbackForm()
        {
            InitializeComponent();

        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            reviewCriteriaGrid.DataSource = GetCriterias();
            reviewCriteriaGrid.Columns["criteriaName"].ReadOnly = true;
            reviewCriteriaGrid.Columns["dissatisfied"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            reviewCriteriaGrid.Columns["average"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            reviewCriteriaGrid.Columns["good"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            reviewCriteriaGrid.Columns["excellent"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            reviewCriteriaGrid.RowHeadersVisible = false;
        }

        private List<Criteria> GetCriterias() 
        {
            var criterias = new List<Criteria>();
            Criteria criteria;
            List<String[]> splited; 
            List<String> data;
            fileHelper = new FileHelp();
            data = fileHelper.ReadFromFile(Environment.CurrentDirectory + @"\Data\Criterias.csv");
            splited = fileHelper.SplitRow(data);

            foreach (String[] split in splited)
            {
                try
                {
                    criteria = new Criteria(split[0]);
                    criterias.Add(criteria);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            return criterias;
        }

        private void customerNameTxtBx_TextChanged(object sender, EventArgs e)
        {
            customerName = customerNameTxtBx.Text;
        }

        private void customerNumberTxtBx_TextChanged(object sender, EventArgs e)
        {
            customerNumber = customerNumberTxtBx.Text;
        }

        private void customerEmailTxtBx_TextChanged(object sender, EventArgs e)
        {
            customerEmail = customerEmailTxtBx.Text;
        }

        private void clearBtnReviewForm_Click(object sender, EventArgs e)
        {
            customerName = "";
            customerNumber = "";
            customerEmail = "";

            customerNameTxtBx.Text = customerName;
            customerNumberTxtBx.Text = customerNumber;
            customerEmailTxtBx.Text = customerEmail;
            ReviewForm_Load(sender, e);
        }

        private void submitBtnReviewForm_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(customerName, customerNumber, customerEmail);
            DateTime now;
            now = DateTime.Now;
            


            List<Criteria> c = (List<Criteria>)reviewCriteriaGrid.DataSource;
            SerializeJson jsonS = new SerializeJson();
            Review review = new Review(customer, c, now.Date, now.TimeOfDay);

            jsonS.JsonSerialize(review, Environment.CurrentDirectory + @"\Data\Reviews.json");

            List<String> data = fileHelper.ReadFromFile(Environment.CurrentDirectory + @"\Data\Reviews.json");
            foreach (String row in data)
            {
                fileHelper.WriteToFile(Environment.CurrentDirectory + @"\Data\Reviews.csv", row);
            }

            clearBtnReviewForm_Click(sender, e);
            ReviewForm_Load(sender, e);

            
        }

        private void reviewCriteriaGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (latestIndexRow == e.RowIndex)
            {
                DataGridView grid = (DataGridView)sender;
                Criteria c = (Criteria)grid.Rows[latestIndexRow].DataBoundItem;
                c.disableAll();
                reviewCriteriaGrid.Refresh();
            }
        }

        private void reviewCriteriaGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("New row");
            latestIndexRow = e.RowIndex;

        }

    }
}
