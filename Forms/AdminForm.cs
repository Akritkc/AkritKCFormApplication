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
    public partial class AdminForm : Form
    {
        FileHelp filerhelper = new FileHelp();
        List<String> criteriaData = new List<string>();
        List<String> criterias = new List<string>();
        List<String> reviewData = new List<String>();
        List<String[]> reviews = new List<String[]>();
        SerializeJson serializeJson = new SerializeJson();
        QuickSort quickSort = new QuickSort();
        Calculate calculate = new Calculate();
        String criteraAddTxt;
        String criteraRemoveTxt;
        public AdminForm()
        {
            InitializeComponent();
            comboBoxAdminForm.Text = "Select order";
            comboBoxAdminForm.Items.Add("Higest to lowest");
            comboBoxAdminForm.Items.Add("Lowest to highest");
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            criterias = getCriterias();
            reviews = getReviews();


            initCriteriaList(criterias);
            initReportGrid(getReviewObject());
            initChart();

        }

        private void initChart()
        {
            String rate1 = "Excellent";
            String rate2 = "Good";
            String rate3 = "Average";
            String rate4 = "Dissatisfied";

            HashSet<String> uniqueCriterias = new HashSet<String>();
            List<Review> reviews = getReviewObject();
              
            reportGraphAdminForm.Series.Add(rate1);
            reportGraphAdminForm.Series.Add(rate2);
            reportGraphAdminForm.Series.Add(rate3);
            reportGraphAdminForm.Series.Add(rate4);

           /* List<String> data = filerhelper.ReadFromFile(Environment.CurrentDirectory + @"\Data\Reviews.csv");
            
            List<Review> reviews = new List<Review>();

            Review r = null;
            

            foreach (String row in data)
            { 
                filerhelper.WriteToFile(Environment.CurrentDirectory + @"\Data\EachRow.Json", row, false);
                r = serializeJson.JsonDeserialize(typeof(Review), Environment.CurrentDirectory + @"\Data\EachRow.Json") as Review;
                reviews.Add(r);
            }
*/
            
            
            foreach (Review review in reviews)
            {
                for (int i = 0; i < review.criterias.Count; i++)
                {
                    uniqueCriterias.Add(review.criterias[i].criteriaName);
                }

            }

            foreach (String c in uniqueCriterias)
            {
                int[] matrix = calculate.CountInstances(reviews, c);
                reportGraphAdminForm.Series[rate1].Points.AddXY(c, matrix[0]);
                reportGraphAdminForm.Series[rate2].Points.AddXY(c, matrix[1]);
                reportGraphAdminForm.Series[rate3].Points.AddXY(c, matrix[2]);
                reportGraphAdminForm.Series[rate4].Points.AddXY(c, matrix[3]);
            }
        }

        private void initCriteriaList(List<String> criterias) 
        {
            criteriaListViewAdminForm.Clear();
            criteriaListViewAdminForm.View = View.Details;
            criteriaListViewAdminForm.GridLines = true;
            criteriaListViewAdminForm.Columns.Add("SN", 30, HorizontalAlignment.Center);
            criteriaListViewAdminForm.Columns.Add("Criteria", criteriaListViewAdminForm.Width - 30, HorizontalAlignment.Center);

            for (int i = 0; i < criterias.Count; i++)
            {
                int index = i + 1;
                ListViewItem row = new ListViewItem(index.ToString());
                row.SubItems.Add(criterias[i]);

                criteriaListViewAdminForm.Items.Add(row);
            }
        }

        private void initReportGrid(List<Review> gridreviews)
        {
            reportListViewAdminForm.Clear();
            reportListViewAdminForm.View = View.Details;
            reportListViewAdminForm.GridLines = true;
            reportListViewAdminForm.Columns.Add("SN", 30, HorizontalAlignment.Center);
            reportListViewAdminForm.Columns.Add("Average Score", 100, HorizontalAlignment.Center);
            reportListViewAdminForm.Columns.Add("Name", 100, HorizontalAlignment.Center);
            reportListViewAdminForm.Columns.Add("Number", 100, HorizontalAlignment.Center);
            reportListViewAdminForm.Columns.Add("Email", 100, HorizontalAlignment.Center);
            HashSet<String> headers = new HashSet<String>();
            List<Double> averages = new List<Double>();

            String unrated = null;

            foreach (Review review in gridreviews)
            {
                for (int i = 0; i < review.criterias.Count; i++)
                {
                    headers.Add(review.criterias[i].criteriaName);
                }

            }
            foreach (String head in headers)
            {
                reportListViewAdminForm.Columns.Add(head, 100, HorizontalAlignment.Center);
            }
            reportListViewAdminForm.Columns.Add("Time", 100, HorizontalAlignment.Center);
            reportListViewAdminForm.Columns.Add("Date", 100, HorizontalAlignment.Center);


            int index = 1;
            
            foreach (Review reviewEach in gridreviews)
            {
                averages.Add(calculate.countScore(reviewEach));
                ListViewItem eachRow = new ListViewItem(index.ToString());
                eachRow.SubItems.Add(calculate.countScore(reviewEach).ToString());
                eachRow.SubItems.Add(reviewEach.Customer.customerName);
                eachRow.SubItems.Add(reviewEach.Customer.customerNumber);
                eachRow.SubItems.Add(reviewEach.Customer.customerEmail);
                foreach (String head in headers)
                {
                    Boolean hasCriteraBeenRated = false;
                    for (int i = 0; i < reviewEach.criterias.Count; i++)
                    {
                        if (head == reviewEach.criterias[i].criteriaName)
                        {
                            eachRow.SubItems.Add(reviewEach.CriteriaRated(reviewEach.criterias[i]));
                            hasCriteraBeenRated = true;
                        }
                        
                    }

                    if (hasCriteraBeenRated == false)
                    {
                        eachRow.SubItems.Add(unrated);
                    }
                }
                eachRow.SubItems.Add(reviewEach.time.ToString());
                eachRow.SubItems.Add(reviewEach.date.ToString());

                reportListViewAdminForm.Items.Add(eachRow);
                index++;
                
            }

            overallRatingAdminForm.Text = calculate.totalScore(averages).ToString();
   
        }

        private List<String> getCriterias()
        {
            List<String> criterias = new List<string>();
            List<String[]> criteriasSplited = new List<string[]>();
            criteriaData = filerhelper.ReadFromFile(Environment.CurrentDirectory + @"\Data\Criterias.csv");
            criteriasSplited = filerhelper.SplitRow(criteriaData);

            foreach (String[] datarow in criteriasSplited)
            {
                criterias.Add(datarow[0]);
            }

            return criterias;
        }

        private List<String[]> getReviews()
        {
            List<String> reviews = new List<String>();
            List<String[]> reviewsSplited = new List<string[]>();
            reviewData = filerhelper.ReadFromFile(Environment.CurrentDirectory + @"\Data\Reviews.csv");
            reviewsSplited = filerhelper.SplitRow(reviewData);

            return reviewsSplited;
        }

        private List<Review> getReviewObject() 
        {
            List<String> data = filerhelper.ReadFromFile(Environment.CurrentDirectory + @"\Data\Reviews.csv");
            List<Review> reviews = new List<Review>();
            Review review = null;

            foreach (String row in data)
            {
                filerhelper.WriteToFile(Environment.CurrentDirectory + @"\Data\EachRow.Json", row, false);
                review = serializeJson.JsonDeserialize(typeof(Review), Environment.CurrentDirectory + @"\Data\EachRow.Json") as Review;
                reviews.Add(review);
            }

            return reviews;
        }

        private void criteriaAddBtnAdminForm_Click(object sender, EventArgs e)
        {
            if (criteraAddTxt != "" && criteraAddTxt != null)
            {
                Console.WriteLine(criteraAddTxt.Length);
                Criteria criteriaToAdd = new Criteria(criteraAddTxt);
                filerhelper.WriteToFile(Environment.CurrentDirectory + @"\Data\Criterias.csv", criteriaToAdd.criteriaName, true);
                reportListViewAdminForm.Clear();
                AdminForm_Load(sender, e);
            }
            else {
                MessageBox.Show("Enter a legit criteria");
            }
            
        }

        private void criteriaTxtBxAdminForm_TextChanged(object sender, EventArgs e)
        {
            criteraAddTxt = criteriaTxtBxAdminForm.Text;
        }

        private void removeCriteriaTxtBxAdminForm_TextChanged(object sender, EventArgs e)
        {
            criteraRemoveTxt = removeCriteriaTxtBxAdminForm.Text;
        }

        private void removeCriteriaBtnAdminForm_Click(object sender, EventArgs e)
        {
            List<String> criterias = getCriterias();
            String removedItem = null;
            try
            {
                Boolean removed = false;
                try
                {
                    int sn = int.Parse(criteraRemoveTxt);
                    for (int i = 0; i < criterias.Count; i++)
                    {
                        if (sn == i + 1)
                        {
                            removedItem = criterias[i];
                            criterias.RemoveAt(i);
                            removed = true;
                        }
                    }
                }
                catch (ArgumentNullException Ne)
                {
                    Console.WriteLine(Ne);
                }
                
                
                if (removed == true)
                {
                    filerhelper.DeleteFile(Environment.CurrentDirectory + @"\Data\Criterias.csv");
                    foreach (String datarow in criterias)
                    {
                        Console.WriteLine(datarow);
                        filerhelper.WriteToFile(Environment.CurrentDirectory + @"\Data\Criterias.csv", datarow);
                    }

                    initCriteriaList(criterias);
                    MessageBox.Show(removedItem + " has been deleted", "Message");
                    

                }
                else
                {
                    MessageBox.Show("Item not on the list, try again","Error");
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Try inputing the number " + fe, "Error");
            }          
        }

        private void generateReportBtnAdminForm_Click(object sender, EventArgs e)
        {
            if (comboBoxAdminForm.SelectedIndex == 0)
            {
                List<String> data = filerhelper.ReadFromFile(Environment.CurrentDirectory + @"\Data\Reviews.csv");
                List<Review> reviews = new List<Review>();
                Review r = null;

                foreach (String row in data)
                {
                    filerhelper.WriteToFile(Environment.CurrentDirectory + @"\Data\EachRow.Json", row, false);
                    r = serializeJson.JsonDeserialize(typeof(Review), Environment.CurrentDirectory + @"\Data\EachRow.Json") as Review;
                    reviews.Add(r);
                }

                quickSort.sort(reviews, 0, reviews.Count()-1);

                reviews = quickSort.reverseList(reviews);

                foreach (Review rx in reviews) {
                    Console.WriteLine(rx.Customer.customerName);
                }

                initReportGrid(reviews);
            }

            if (comboBoxAdminForm.SelectedIndex == 1)
            {
                List<String> data = filerhelper.ReadFromFile(Environment.CurrentDirectory + @"\Data\Reviews.csv");
                List<Review> reviews = new List<Review>();
                Review r = null;

                foreach (String row in data)
                {
                    filerhelper.WriteToFile(Environment.CurrentDirectory + @"\Data\EachRow.Json", row, false);
                    r = serializeJson.JsonDeserialize(typeof(Review), Environment.CurrentDirectory + @"\Data\EachRow.Json") as Review;
                    reviews.Add(r);
                }

                quickSort.sort(reviews, 0, reviews.Count() - 1);

                foreach (Review rx in reviews)
                {
                    Console.WriteLine(rx.Customer.customerName);
                }

                initReportGrid(reviews);
            }
        }
    }
}
