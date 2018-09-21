//
// Netflix Database Application using N-Tier Design.
//
// Ji Xiao
// U. of Illinois, Chicago
// 
// CS 341, Spring 2018
// Project 08
//


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NetflixDatabaseApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Global variable 
        int LIST_STATUS = 0;     // 1 for movies, 2 for users, 3 for insert

        private bool fileExists(string filename)
        {
            if (!System.IO.File.Exists(filename))
            {
                string msg = string.Format("Input file not found: '{0}'",
                  filename);

                MessageBox.Show(msg);
                return false;
            }

            // exists!
            return true;
        }

        private void avgRatingLABEL_Click(object sender, EventArgs e)
        {

        }

        private void moviesBUTTON_Click(object sender, EventArgs e)
        {
            LIST_STATUS = 1;

            this.listLISTBOX.Items.Clear();
            this.displayLISTBOX.Items.Clear();
            this.userIdTEXTBOX.Text = "";
            this.occupationTEXTBOX.Text = "";
            this.insertReviewMovieTEXTBOX.Text = "";
            this.insertReviewUserTEXTBOX.Text = "";
            this.insertReviewRatingTEXTBOX.Text = "";
            this.typeUserNameTEXTBOX.Text = "";


            // Check to make sure database filename in text box actually exists:
            string filename = this.filenameTEXTBOX.Text;

            if (!fileExists(filename))
                return;
            //

            string version, connectionInfo;
            SqlConnection db;

            version = "MSSQLLocalDB";
            connectionInfo = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Integrated Security=True;", version, filename);

            db = new SqlConnection(connectionInfo);
            db.Open();

            string sql = string.Format(@"SELECT MovieName FROM Movies ORDER BY MovieName ASC;");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.CommandText = sql;
            adapter.Fill(ds);

            db.Close();

            foreach (DataRow row in ds.Tables["TABLE"].Rows)
            {
                string msg = string.Format("{0}", Convert.ToString(row["MovieName"]));

                this.listLISTBOX.Items.Add(msg);
            }

        }

        private void movieIdTEXTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void avgRatingTEXTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void usersBUTTON_Click(object sender, EventArgs e)
        {
            LIST_STATUS = 2;

            this.listLISTBOX.Items.Clear();
            this.displayLISTBOX.Items.Clear();
            this.movieIdTEXTBOX.Text = "";
            this.avgRatingTEXTBOX.Text = "";
            this.insertReviewMovieTEXTBOX.Text = "";
            this.insertReviewUserTEXTBOX.Text = "";
            this.insertReviewRatingTEXTBOX.Text = "";
            this.typeMovieNameTEXTBOX.Text = "";

            // Check to make sure database filename in text box actually exists:
            string filename = this.filenameTEXTBOX.Text;

            if (!fileExists(filename))
                return;
            //

            string version, connectionInfo;
            SqlConnection db;

            version = "MSSQLLocalDB";
            connectionInfo = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Integrated Security=True;", version, filename);

            db = new SqlConnection(connectionInfo);
            db.Open();

            string sql = string.Format(@"SELECT UserName FROM Users ORDER BY UserName ASC;");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.CommandText = sql;
            adapter.Fill(ds);

            db.Close();

            foreach (DataRow row in ds.Tables["TABLE"].Rows)
            {
                string msg = string.Format("{0}", Convert.ToString(row["UserName"]));

                this.listLISTBOX.Items.Add(msg);
            }
        }

        private void userIdTEXTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void occupationTEXTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void filenameTEXTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void listLISTBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LIST_STATUS != 3)
                this.displayLISTBOX.Items.Clear();

            string filename = this.filenameTEXTBOX.Text;

            BusinessTier.Business biztier = new BusinessTier.Business(filename);

            if (LIST_STATUS == 1)           // movie button
            {
                if (this.listLISTBOX != null)
                {
                    // movie name
                    var movie = biztier.GetMovie(this.listLISTBOX.Text);
                    movieIdTEXTBOX.Text = movie.MovieID.ToString();
                    //typeMovieNameTEXTBOX.Text = movie.MovieName.ToString();
                    typeMovieNameTEXTBOX.Text = "";
                    typeUserNameTEXTBOX.Text = "";

                    // avg rating
                    var movie2 = biztier.GetMovieDetail(movie.MovieID);
                    avgRatingTEXTBOX.Text = movie2.AvgRating.ToString();


                    displayLISTBOX.Items.Add(this.listLISTBOX.Text);
                    displayLISTBOX.Items.Add(" ");

                    BusinessTier.MovieDetail movieDetail = biztier.GetMovieDetail(movie.MovieID);
                    
                    foreach (var review in movieDetail.Reviews)
                    {
                        displayLISTBOX.Items.Add(review.UserID + ": " + review.Rating);
                    }

                }
            }
            else if (LIST_STATUS == 2)      // user button
            {
                if (this.listLISTBOX != null)
                {
                    // user id
                    var user = biztier.GetNamedUser(this.listLISTBOX.Text);
                    userIdTEXTBOX.Text = user.UserID.ToString();
                    //typeUserNameTEXTBOX.Text = user.UserName.ToString();
                    typeMovieNameTEXTBOX.Text = "";
                    typeUserNameTEXTBOX.Text = "";

                    // occupation
                    occupationTEXTBOX.Text = user.Occupation.ToString();


                    displayLISTBOX.Items.Add(this.listLISTBOX.Text);
                    displayLISTBOX.Items.Add(" ");

                    BusinessTier.UserDetail userDetail = biztier.GetUserDetail(user.UserID);

                    foreach (var review in userDetail.Reviews)
                    {
                        BusinessTier.Movie movie = biztier.GetMovie(review.MovieID);
                        displayLISTBOX.Items.Add(movie.MovieName + " -> " + review.Rating);
                    }
                }
            }
            else if (LIST_STATUS == 3)
            {
                insertReviewMovieTEXTBOX.Text = this.listLISTBOX.Text;
            }
            
 
        }

        private void typeMovieNameTEXTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void getReviewsBUTTON_Click(object sender, EventArgs e)
        {
            this.displayLISTBOX.Items.Clear();
            //this.typeUserNameTEXTBOX.Text = " ";

            string filename = this.filenameTEXTBOX.Text;

            BusinessTier.Business biztier = new BusinessTier.Business(filename);

            var movie = biztier.GetMovie(this.typeMovieNameTEXTBOX.Text);

            if (movie == null)
            {
                MessageBox.Show("Wrong movie name!");
            }
            else
            {
                var movie2 = biztier.GetMovieDetail(movie.MovieID);

                displayLISTBOX.Items.Add(this.typeMovieNameTEXTBOX.Text);
                displayLISTBOX.Items.Add(" ");

                BusinessTier.MovieDetail movieDetail = biztier.GetMovieDetail(movie.MovieID);

                foreach (var review in movieDetail.Reviews)
                {
                    displayLISTBOX.Items.Add(review.UserID + ": " + review.Rating);
                }
            }

        }

        private void displayLISTBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LIST_STATUS == 3)
            {
                insertReviewUserTEXTBOX.Text = this.displayLISTBOX.Text;
            }
        }

        private void typeUserNameTEXTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void userReviewsBUTTON_Click(object sender, EventArgs e)
        {
            this.displayLISTBOX.Items.Clear();
            //this.typeMovieNameTEXTBOX.Text = " ";

            string filename = this.filenameTEXTBOX.Text;

            BusinessTier.Business biztier = new BusinessTier.Business(filename);

            var user = biztier.GetNamedUser(this.typeUserNameTEXTBOX.Text);

            if (user == null)
            {
                MessageBox.Show("Wrong user name!");
            }
            else
            {
                displayLISTBOX.Items.Add(this.typeUserNameTEXTBOX.Text);
                displayLISTBOX.Items.Add(" ");

                BusinessTier.UserDetail userDetail = biztier.GetUserDetail(user.UserID);

                foreach (var review in userDetail.Reviews)
                {
                    BusinessTier.Movie movie = biztier.GetMovie(review.MovieID);
                    displayLISTBOX.Items.Add(movie.MovieName + " -> " + review.Rating);
                }
            }

        }

        private void newReviewBUTTON_Click(object sender, EventArgs e)
        {
            LIST_STATUS = 3;

            this.displayLISTBOX.Items.Clear();
            this.listLISTBOX.Items.Clear();
            this.movieIdTEXTBOX.Text = "";
            this.avgRatingTEXTBOX.Text = "";
            this.userIdTEXTBOX.Text = "";
            this.occupationTEXTBOX.Text = "";
            this.typeMovieNameTEXTBOX.Text = "";
            this.typeUserNameTEXTBOX.Text = "";
            this.insertReviewMovieTEXTBOX.Text = "";
            this.insertReviewUserTEXTBOX.Text = "";
            this.insertReviewRatingTEXTBOX.Text = "";


            // Check to make sure database filename in text box actually exists:
            string filename = this.filenameTEXTBOX.Text;

            if (!fileExists(filename))
                return;
            //

            string version, connectionInfo;
            SqlConnection db;

            version = "MSSQLLocalDB";
            connectionInfo = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Integrated Security=True;", version, filename);

            db = new SqlConnection(connectionInfo);
            db.Open();

            string sql = string.Format(@"SELECT MovieName FROM Movies ORDER BY MovieName ASC;");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.CommandText = sql;
            adapter.Fill(ds);

            db.Close();

            this.listLISTBOX.Items.Add("Select a movie: ");
            this.listLISTBOX.Items.Add(" ");
            foreach (DataRow row in ds.Tables["TABLE"].Rows)
            {
                string msg = string.Format("{0}", Convert.ToString(row["MovieName"]));

                this.listLISTBOX.Items.Add(msg);
            }

            //string version, connectionInfo;
            SqlConnection db2;

            version = "MSSQLLocalDB";
            connectionInfo = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Integrated Security=True;", version, filename);

            db2 = new SqlConnection(connectionInfo);
            db2.Open();

            string sql2 = string.Format(@"SELECT UserName FROM Users ORDER BY UserName ASC;");

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = db2;
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            DataSet ds2 = new DataSet();

            cmd2.CommandText = sql2;
            adapter2.Fill(ds2);

            db2.Close();

            this.displayLISTBOX.Items.Add("Select a user: ");
            this.displayLISTBOX.Items.Add(" ");
            foreach (DataRow row in ds2.Tables["TABLE"].Rows)
            {
                string msg = string.Format("{0}", Convert.ToString(row["UserName"]));

                this.displayLISTBOX.Items.Add(msg);
            }
        }

        private void insertReviewUserTEXTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertReviewMovieTEXTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertReviewBUTTON_Click(object sender, EventArgs e)
        {
            string insertMovie = insertReviewMovieTEXTBOX.Text;
            string insertUser = insertReviewUserTEXTBOX.Text;
            string insertRating = insertReviewRatingTEXTBOX.Text;
            int insertRate;

            bool m = false;
            bool u = false;
            bool r = false;

            if (int.TryParse(insertReviewRatingTEXTBOX.Text, out insertRate))
            {
                if (insertRate >= 1 && insertRate <= 5)
                    r = true;
            }
            else
            {
                MessageBox.Show("Input ERROR");
            }

            // Check to make sure database filename in text box actually exists:
            string filename = this.filenameTEXTBOX.Text;

            if (!fileExists(filename))
                return;
            //

            // check movie name exist
            string version, connectionInfo;
            SqlConnection db;

            version = "MSSQLLocalDB";
            connectionInfo = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Integrated Security=True;", version, filename);

            db = new SqlConnection(connectionInfo);
            db.Open();

            string sql = string.Format(@"SELECT MovieName FROM Movies ORDER BY MovieName ASC;");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.CommandText = sql;
            adapter.Fill(ds);

            db.Close();

            foreach (DataRow row in ds.Tables["TABLE"].Rows)
            {
                string msg = string.Format("{0}", Convert.ToString(row["MovieName"]));

                if (msg == insertMovie)
                    m = true;
            }

            // check user exist
            SqlConnection db2;

            version = "MSSQLLocalDB";
            connectionInfo = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Integrated Security=True;", version, filename);

            db2 = new SqlConnection(connectionInfo);
            db2.Open();

            string sql2 = string.Format(@"SELECT UserName FROM Users ORDER BY UserName ASC;");

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = db2;
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            DataSet ds2 = new DataSet();

            cmd2.CommandText = sql2;
            adapter2.Fill(ds2);

            db2.Close();

            foreach (DataRow row in ds2.Tables["TABLE"].Rows)
            {
                string msg = string.Format("{0}", Convert.ToString(row["UserName"]));

                if (msg == insertUser)
                    u = true;
            }

            // insert if valid
            if (m && u && r)
            {
                BusinessTier.Business biztier = new BusinessTier.Business(filename);

                var insUser = biztier.GetNamedUser(insertUser);
                int userID = insUser.UserID;

                var insMovie = biztier.GetMovie(insertMovie);
                int movieID = insMovie.MovieID;

                BusinessTier.Review newReview = biztier.AddReview(movieID, userID, insertRate);

                if (newReview != null)
                {
                    MessageBox.Show("Insert Successful");
                }
                else
                {
                    MessageBox.Show("Fail inserting");
                }
            }
            else
            {
                MessageBox.Show("Input ERROR");
            }
        }

        private void movieIdLABEL_Click(object sender, EventArgs e)
        {

        }

        private void summarizeMovieNameTEXTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void topNRatingTEXTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void summarizeMovieBUTTON_Click(object sender, EventArgs e)
        {
            this.displayLISTBOX.Items.Clear();
            this.listLISTBOX.Items.Clear();
            this.movieIdTEXTBOX.Text = "";
            this.avgRatingTEXTBOX.Text = "";
            this.userIdTEXTBOX.Text = "";
            this.occupationTEXTBOX.Text = "";
            this.typeMovieNameTEXTBOX.Text = "";
            this.typeUserNameTEXTBOX.Text = "";
            this.insertReviewMovieTEXTBOX.Text = "";
            this.insertReviewUserTEXTBOX.Text = "";
            this.insertReviewRatingTEXTBOX.Text = "";

            string filename = this.filenameTEXTBOX.Text;

            BusinessTier.Business biztier = new BusinessTier.Business(filename);

            var movie = biztier.GetMovie(this.summarizeMovieNameTEXTBOX.Text);
           
            if (movie == null)
            {
                MessageBox.Show("Movie not found");
            }
            else
            {
                displayLISTBOX.Items.Add(this.summarizeMovieNameTEXTBOX.Text);
                displayLISTBOX.Items.Add(" ");

                BusinessTier.MovieDetail movieDetail = biztier.GetMovieDetail(movie.MovieID);


                int rate5 = 0, rate4 = 0, rate3 = 0, rate2 = 0, rate1 = 0;

                foreach (var review in movieDetail.Reviews)
                {
                    if (review.Rating == 5)
                    {
                        rate5++;
                    }
                    else if (review.Rating == 4)
                    {
                        rate4++;
                    }
                    else if (review.Rating == 3)
                    {
                        rate3++;
                    }
                    else if (review.Rating == 2)
                    {
                        rate2++;
                    }
                    else if (review.Rating == 1)
                    {
                        rate1++;
                    }
                }

                displayLISTBOX.Items.Add("5: " + rate5);
                displayLISTBOX.Items.Add("4: " + rate4);
                displayLISTBOX.Items.Add("3: " + rate3);
                displayLISTBOX.Items.Add("2: " + rate2);
                displayLISTBOX.Items.Add("1: " + rate1);

                displayLISTBOX.Items.Add(" ");

                displayLISTBOX.Items.Add("Total: " + movieDetail.NumReviews);
            }

        }

        private void getTopNMovieBUTTON_Click(object sender, EventArgs e)
        {
            this.displayLISTBOX.Items.Clear();
            this.listLISTBOX.Items.Clear();
            this.movieIdTEXTBOX.Text = "";
            this.avgRatingTEXTBOX.Text = "";
            this.userIdTEXTBOX.Text = "";
            this.occupationTEXTBOX.Text = "";
            this.typeMovieNameTEXTBOX.Text = "";
            this.typeUserNameTEXTBOX.Text = "";
            this.insertReviewMovieTEXTBOX.Text = "";
            this.insertReviewUserTEXTBOX.Text = "";
            this.insertReviewRatingTEXTBOX.Text = "";

            string filename = this.filenameTEXTBOX.Text;

            BusinessTier.Business biztier = new BusinessTier.Business(filename);

            int topN;
            if (int.TryParse(topNRatingTEXTBOX.Text, out topN))
            {
                
            }
            else
            {
                MessageBox.Show("Input ERROR!");
            }


            if (topN <= 1)
            {
                MessageBox.Show("Input ERROR!");
            }
            else
            {
                IReadOnlyList<BusinessTier.Movie> topMovie = biztier.GetTopMoviesByAvgRating(topN);

                foreach (BusinessTier.Movie movie in topMovie)
                {
                    BusinessTier.MovieDetail md = biztier.GetMovieDetail(movie.MovieID);
                    displayLISTBOX.Items.Add(movie.MovieName + ": " + md.AvgRating);
                }
            }
            
        }
    }
}
