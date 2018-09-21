namespace NetflixDatabaseApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.moviesBUTTON = new System.Windows.Forms.Button();
            this.usersBUTTON = new System.Windows.Forms.Button();
            this.listLISTBOX = new System.Windows.Forms.ListBox();
            this.movieIdLABEL = new System.Windows.Forms.Label();
            this.avgRatingLABEL = new System.Windows.Forms.Label();
            this.movieIdTEXTBOX = new System.Windows.Forms.TextBox();
            this.avgRatingTEXTBOX = new System.Windows.Forms.TextBox();
            this.userIdLABEL = new System.Windows.Forms.Label();
            this.occupationLABEL = new System.Windows.Forms.Label();
            this.userIdTEXTBOX = new System.Windows.Forms.TextBox();
            this.occupationTEXTBOX = new System.Windows.Forms.TextBox();
            this.filenameTEXTBOX = new System.Windows.Forms.TextBox();
            this.typeMovieNameTEXTBOX = new System.Windows.Forms.TextBox();
            this.getReviewsBUTTON = new System.Windows.Forms.Button();
            this.displayLISTBOX = new System.Windows.Forms.ListBox();
            this.typeUserNameTEXTBOX = new System.Windows.Forms.TextBox();
            this.userReviewsBUTTON = new System.Windows.Forms.Button();
            this.insertReviewBUTTON = new System.Windows.Forms.Button();
            this.insertReviewUserLABEL = new System.Windows.Forms.Label();
            this.insertReviewUserTEXTBOX = new System.Windows.Forms.TextBox();
            this.insertReviewMovieLABEL = new System.Windows.Forms.Label();
            this.insertReviewMovieTEXTBOX = new System.Windows.Forms.TextBox();
            this.newReviewBUTTON = new System.Windows.Forms.Button();
            this.insertReviewRatingTEXTBOX = new System.Windows.Forms.TextBox();
            this.insertReveiwRatingLABEL = new System.Windows.Forms.Label();
            this.summarizeMovieNameTEXTBOX = new System.Windows.Forms.TextBox();
            this.topNRatingTEXTBOX = new System.Windows.Forms.TextBox();
            this.summarizeMovieBUTTON = new System.Windows.Forms.Button();
            this.getTopNMovieBUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moviesBUTTON
            // 
            this.moviesBUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moviesBUTTON.Location = new System.Drawing.Point(30, 27);
            this.moviesBUTTON.Name = "moviesBUTTON";
            this.moviesBUTTON.Size = new System.Drawing.Size(271, 50);
            this.moviesBUTTON.TabIndex = 0;
            this.moviesBUTTON.Text = "Movies";
            this.moviesBUTTON.UseVisualStyleBackColor = true;
            this.moviesBUTTON.Click += new System.EventHandler(this.moviesBUTTON_Click);
            // 
            // usersBUTTON
            // 
            this.usersBUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersBUTTON.Location = new System.Drawing.Point(30, 241);
            this.usersBUTTON.Name = "usersBUTTON";
            this.usersBUTTON.Size = new System.Drawing.Size(271, 50);
            this.usersBUTTON.TabIndex = 1;
            this.usersBUTTON.Text = "Users";
            this.usersBUTTON.UseVisualStyleBackColor = true;
            this.usersBUTTON.Click += new System.EventHandler(this.usersBUTTON_Click);
            // 
            // listLISTBOX
            // 
            this.listLISTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLISTBOX.FormattingEnabled = true;
            this.listLISTBOX.ItemHeight = 25;
            this.listLISTBOX.Location = new System.Drawing.Point(321, 27);
            this.listLISTBOX.Name = "listLISTBOX";
            this.listLISTBOX.Size = new System.Drawing.Size(428, 729);
            this.listLISTBOX.TabIndex = 2;
            this.listLISTBOX.SelectedIndexChanged += new System.EventHandler(this.listLISTBOX_SelectedIndexChanged);
            // 
            // movieIdLABEL
            // 
            this.movieIdLABEL.AutoSize = true;
            this.movieIdLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieIdLABEL.Location = new System.Drawing.Point(25, 101);
            this.movieIdLABEL.Name = "movieIdLABEL";
            this.movieIdLABEL.Size = new System.Drawing.Size(100, 25);
            this.movieIdLABEL.TabIndex = 3;
            this.movieIdLABEL.Text = "Movie ID: ";
            this.movieIdLABEL.Click += new System.EventHandler(this.movieIdLABEL_Click);
            // 
            // avgRatingLABEL
            // 
            this.avgRatingLABEL.AutoSize = true;
            this.avgRatingLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgRatingLABEL.Location = new System.Drawing.Point(25, 136);
            this.avgRatingLABEL.Name = "avgRatingLABEL";
            this.avgRatingLABEL.Size = new System.Drawing.Size(118, 25);
            this.avgRatingLABEL.TabIndex = 4;
            this.avgRatingLABEL.Text = "Avg Rating: ";
            this.avgRatingLABEL.Click += new System.EventHandler(this.avgRatingLABEL_Click);
            // 
            // movieIdTEXTBOX
            // 
            this.movieIdTEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieIdTEXTBOX.Location = new System.Drawing.Point(146, 98);
            this.movieIdTEXTBOX.Name = "movieIdTEXTBOX";
            this.movieIdTEXTBOX.Size = new System.Drawing.Size(155, 30);
            this.movieIdTEXTBOX.TabIndex = 5;
            this.movieIdTEXTBOX.TextChanged += new System.EventHandler(this.movieIdTEXTBOX_TextChanged);
            // 
            // avgRatingTEXTBOX
            // 
            this.avgRatingTEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgRatingTEXTBOX.Location = new System.Drawing.Point(146, 133);
            this.avgRatingTEXTBOX.Name = "avgRatingTEXTBOX";
            this.avgRatingTEXTBOX.Size = new System.Drawing.Size(155, 30);
            this.avgRatingTEXTBOX.TabIndex = 6;
            this.avgRatingTEXTBOX.TextChanged += new System.EventHandler(this.avgRatingTEXTBOX_TextChanged);
            // 
            // userIdLABEL
            // 
            this.userIdLABEL.AutoSize = true;
            this.userIdLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLABEL.Location = new System.Drawing.Point(25, 311);
            this.userIdLABEL.Name = "userIdLABEL";
            this.userIdLABEL.Size = new System.Drawing.Size(88, 25);
            this.userIdLABEL.TabIndex = 7;
            this.userIdLABEL.Text = "User ID: ";
            // 
            // occupationLABEL
            // 
            this.occupationLABEL.AutoSize = true;
            this.occupationLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupationLABEL.Location = new System.Drawing.Point(25, 347);
            this.occupationLABEL.Name = "occupationLABEL";
            this.occupationLABEL.Size = new System.Drawing.Size(123, 25);
            this.occupationLABEL.TabIndex = 8;
            this.occupationLABEL.Text = "Occupation: ";
            // 
            // userIdTEXTBOX
            // 
            this.userIdTEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdTEXTBOX.Location = new System.Drawing.Point(146, 308);
            this.userIdTEXTBOX.Name = "userIdTEXTBOX";
            this.userIdTEXTBOX.Size = new System.Drawing.Size(155, 30);
            this.userIdTEXTBOX.TabIndex = 9;
            this.userIdTEXTBOX.TextChanged += new System.EventHandler(this.userIdTEXTBOX_TextChanged);
            // 
            // occupationTEXTBOX
            // 
            this.occupationTEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupationTEXTBOX.Location = new System.Drawing.Point(146, 344);
            this.occupationTEXTBOX.Name = "occupationTEXTBOX";
            this.occupationTEXTBOX.Size = new System.Drawing.Size(155, 30);
            this.occupationTEXTBOX.TabIndex = 10;
            this.occupationTEXTBOX.TextChanged += new System.EventHandler(this.occupationTEXTBOX_TextChanged);
            // 
            // filenameTEXTBOX
            // 
            this.filenameTEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filenameTEXTBOX.Location = new System.Drawing.Point(30, 722);
            this.filenameTEXTBOX.Name = "filenameTEXTBOX";
            this.filenameTEXTBOX.Size = new System.Drawing.Size(273, 30);
            this.filenameTEXTBOX.TabIndex = 11;
            this.filenameTEXTBOX.Text = "netflix-200k.mdf";
            this.filenameTEXTBOX.TextChanged += new System.EventHandler(this.filenameTEXTBOX_TextChanged);
            // 
            // typeMovieNameTEXTBOX
            // 
            this.typeMovieNameTEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeMovieNameTEXTBOX.Location = new System.Drawing.Point(766, 28);
            this.typeMovieNameTEXTBOX.Name = "typeMovieNameTEXTBOX";
            this.typeMovieNameTEXTBOX.Size = new System.Drawing.Size(304, 30);
            this.typeMovieNameTEXTBOX.TabIndex = 12;
            this.typeMovieNameTEXTBOX.TextChanged += new System.EventHandler(this.typeMovieNameTEXTBOX_TextChanged);
            // 
            // getReviewsBUTTON
            // 
            this.getReviewsBUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getReviewsBUTTON.Location = new System.Drawing.Point(1075, 21);
            this.getReviewsBUTTON.Name = "getReviewsBUTTON";
            this.getReviewsBUTTON.Size = new System.Drawing.Size(228, 40);
            this.getReviewsBUTTON.TabIndex = 13;
            this.getReviewsBUTTON.Text = "Get movie reviews";
            this.getReviewsBUTTON.UseVisualStyleBackColor = true;
            this.getReviewsBUTTON.Click += new System.EventHandler(this.getReviewsBUTTON_Click);
            // 
            // displayLISTBOX
            // 
            this.displayLISTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLISTBOX.FormattingEnabled = true;
            this.displayLISTBOX.ItemHeight = 25;
            this.displayLISTBOX.Location = new System.Drawing.Point(766, 119);
            this.displayLISTBOX.Name = "displayLISTBOX";
            this.displayLISTBOX.Size = new System.Drawing.Size(538, 554);
            this.displayLISTBOX.TabIndex = 14;
            this.displayLISTBOX.SelectedIndexChanged += new System.EventHandler(this.displayLISTBOX_SelectedIndexChanged);
            // 
            // typeUserNameTEXTBOX
            // 
            this.typeUserNameTEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeUserNameTEXTBOX.Location = new System.Drawing.Point(766, 73);
            this.typeUserNameTEXTBOX.Name = "typeUserNameTEXTBOX";
            this.typeUserNameTEXTBOX.Size = new System.Drawing.Size(304, 30);
            this.typeUserNameTEXTBOX.TabIndex = 15;
            this.typeUserNameTEXTBOX.TextChanged += new System.EventHandler(this.typeUserNameTEXTBOX_TextChanged);
            // 
            // userReviewsBUTTON
            // 
            this.userReviewsBUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userReviewsBUTTON.Location = new System.Drawing.Point(1075, 67);
            this.userReviewsBUTTON.Name = "userReviewsBUTTON";
            this.userReviewsBUTTON.Size = new System.Drawing.Size(228, 41);
            this.userReviewsBUTTON.TabIndex = 16;
            this.userReviewsBUTTON.Text = "Get user reviews";
            this.userReviewsBUTTON.UseVisualStyleBackColor = true;
            this.userReviewsBUTTON.Click += new System.EventHandler(this.userReviewsBUTTON_Click);
            // 
            // insertReviewBUTTON
            // 
            this.insertReviewBUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertReviewBUTTON.Location = new System.Drawing.Point(30, 619);
            this.insertReviewBUTTON.Name = "insertReviewBUTTON";
            this.insertReviewBUTTON.Size = new System.Drawing.Size(271, 50);
            this.insertReviewBUTTON.TabIndex = 17;
            this.insertReviewBUTTON.Text = "Insert this review";
            this.insertReviewBUTTON.UseVisualStyleBackColor = true;
            this.insertReviewBUTTON.Click += new System.EventHandler(this.insertReviewBUTTON_Click);
            // 
            // insertReviewUserLABEL
            // 
            this.insertReviewUserLABEL.AutoSize = true;
            this.insertReviewUserLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertReviewUserLABEL.Location = new System.Drawing.Point(24, 550);
            this.insertReviewUserLABEL.Name = "insertReviewUserLABEL";
            this.insertReviewUserLABEL.Size = new System.Drawing.Size(64, 25);
            this.insertReviewUserLABEL.TabIndex = 18;
            this.insertReviewUserLABEL.Text = "User: ";
            // 
            // insertReviewUserTEXTBOX
            // 
            this.insertReviewUserTEXTBOX.AcceptsReturn = true;
            this.insertReviewUserTEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertReviewUserTEXTBOX.Location = new System.Drawing.Point(94, 547);
            this.insertReviewUserTEXTBOX.Name = "insertReviewUserTEXTBOX";
            this.insertReviewUserTEXTBOX.Size = new System.Drawing.Size(206, 30);
            this.insertReviewUserTEXTBOX.TabIndex = 19;
            this.insertReviewUserTEXTBOX.TextChanged += new System.EventHandler(this.insertReviewUserTEXTBOX_TextChanged);
            // 
            // insertReviewMovieLABEL
            // 
            this.insertReviewMovieLABEL.AutoSize = true;
            this.insertReviewMovieLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertReviewMovieLABEL.Location = new System.Drawing.Point(25, 514);
            this.insertReviewMovieLABEL.Name = "insertReviewMovieLABEL";
            this.insertReviewMovieLABEL.Size = new System.Drawing.Size(71, 25);
            this.insertReviewMovieLABEL.TabIndex = 20;
            this.insertReviewMovieLABEL.Text = "Movie:";
            // 
            // insertReviewMovieTEXTBOX
            // 
            this.insertReviewMovieTEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertReviewMovieTEXTBOX.Location = new System.Drawing.Point(94, 511);
            this.insertReviewMovieTEXTBOX.Name = "insertReviewMovieTEXTBOX";
            this.insertReviewMovieTEXTBOX.Size = new System.Drawing.Size(207, 30);
            this.insertReviewMovieTEXTBOX.TabIndex = 21;
            this.insertReviewMovieTEXTBOX.TextChanged += new System.EventHandler(this.insertReviewMovieTEXTBOX_TextChanged);
            // 
            // newReviewBUTTON
            // 
            this.newReviewBUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newReviewBUTTON.Location = new System.Drawing.Point(32, 455);
            this.newReviewBUTTON.Name = "newReviewBUTTON";
            this.newReviewBUTTON.Size = new System.Drawing.Size(271, 50);
            this.newReviewBUTTON.TabIndex = 22;
            this.newReviewBUTTON.Text = "Create new review";
            this.newReviewBUTTON.UseVisualStyleBackColor = true;
            this.newReviewBUTTON.Click += new System.EventHandler(this.newReviewBUTTON_Click);
            // 
            // insertReviewRatingTEXTBOX
            // 
            this.insertReviewRatingTEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertReviewRatingTEXTBOX.Location = new System.Drawing.Point(146, 583);
            this.insertReviewRatingTEXTBOX.Name = "insertReviewRatingTEXTBOX";
            this.insertReviewRatingTEXTBOX.Size = new System.Drawing.Size(154, 30);
            this.insertReviewRatingTEXTBOX.TabIndex = 23;
            // 
            // insertReveiwRatingLABEL
            // 
            this.insertReveiwRatingLABEL.AutoSize = true;
            this.insertReveiwRatingLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertReveiwRatingLABEL.Location = new System.Drawing.Point(25, 586);
            this.insertReveiwRatingLABEL.Name = "insertReveiwRatingLABEL";
            this.insertReveiwRatingLABEL.Size = new System.Drawing.Size(73, 25);
            this.insertReveiwRatingLABEL.TabIndex = 24;
            this.insertReveiwRatingLABEL.Text = "Rating:";
            // 
            // summarizeMovieNameTEXTBOX
            // 
            this.summarizeMovieNameTEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summarizeMovieNameTEXTBOX.Location = new System.Drawing.Point(764, 680);
            this.summarizeMovieNameTEXTBOX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.summarizeMovieNameTEXTBOX.Name = "summarizeMovieNameTEXTBOX";
            this.summarizeMovieNameTEXTBOX.Size = new System.Drawing.Size(306, 30);
            this.summarizeMovieNameTEXTBOX.TabIndex = 25;
            this.summarizeMovieNameTEXTBOX.TextChanged += new System.EventHandler(this.summarizeMovieNameTEXTBOX_TextChanged);
            // 
            // topNRatingTEXTBOX
            // 
            this.topNRatingTEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topNRatingTEXTBOX.Location = new System.Drawing.Point(764, 722);
            this.topNRatingTEXTBOX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.topNRatingTEXTBOX.Name = "topNRatingTEXTBOX";
            this.topNRatingTEXTBOX.Size = new System.Drawing.Size(304, 30);
            this.topNRatingTEXTBOX.TabIndex = 26;
            this.topNRatingTEXTBOX.TextChanged += new System.EventHandler(this.topNRatingTEXTBOX_TextChanged);
            // 
            // summarizeMovieBUTTON
            // 
            this.summarizeMovieBUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summarizeMovieBUTTON.Location = new System.Drawing.Point(1076, 679);
            this.summarizeMovieBUTTON.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.summarizeMovieBUTTON.Name = "summarizeMovieBUTTON";
            this.summarizeMovieBUTTON.Size = new System.Drawing.Size(227, 36);
            this.summarizeMovieBUTTON.TabIndex = 27;
            this.summarizeMovieBUTTON.Text = "Summarize Movie";
            this.summarizeMovieBUTTON.UseVisualStyleBackColor = true;
            this.summarizeMovieBUTTON.Click += new System.EventHandler(this.summarizeMovieBUTTON_Click);
            // 
            // getTopNMovieBUTTON
            // 
            this.getTopNMovieBUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getTopNMovieBUTTON.Location = new System.Drawing.Point(1076, 719);
            this.getTopNMovieBUTTON.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.getTopNMovieBUTTON.Name = "getTopNMovieBUTTON";
            this.getTopNMovieBUTTON.Size = new System.Drawing.Size(228, 33);
            this.getTopNMovieBUTTON.TabIndex = 28;
            this.getTopNMovieBUTTON.Text = "Get top N movie";
            this.getTopNMovieBUTTON.UseVisualStyleBackColor = true;
            this.getTopNMovieBUTTON.Click += new System.EventHandler(this.getTopNMovieBUTTON_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1328, 775);
            this.Controls.Add(this.getTopNMovieBUTTON);
            this.Controls.Add(this.summarizeMovieBUTTON);
            this.Controls.Add(this.topNRatingTEXTBOX);
            this.Controls.Add(this.summarizeMovieNameTEXTBOX);
            this.Controls.Add(this.insertReveiwRatingLABEL);
            this.Controls.Add(this.insertReviewRatingTEXTBOX);
            this.Controls.Add(this.newReviewBUTTON);
            this.Controls.Add(this.insertReviewMovieTEXTBOX);
            this.Controls.Add(this.insertReviewMovieLABEL);
            this.Controls.Add(this.insertReviewUserTEXTBOX);
            this.Controls.Add(this.insertReviewUserLABEL);
            this.Controls.Add(this.insertReviewBUTTON);
            this.Controls.Add(this.userReviewsBUTTON);
            this.Controls.Add(this.typeUserNameTEXTBOX);
            this.Controls.Add(this.displayLISTBOX);
            this.Controls.Add(this.getReviewsBUTTON);
            this.Controls.Add(this.typeMovieNameTEXTBOX);
            this.Controls.Add(this.filenameTEXTBOX);
            this.Controls.Add(this.occupationTEXTBOX);
            this.Controls.Add(this.userIdTEXTBOX);
            this.Controls.Add(this.occupationLABEL);
            this.Controls.Add(this.userIdLABEL);
            this.Controls.Add(this.avgRatingTEXTBOX);
            this.Controls.Add(this.movieIdTEXTBOX);
            this.Controls.Add(this.avgRatingLABEL);
            this.Controls.Add(this.movieIdLABEL);
            this.Controls.Add(this.listLISTBOX);
            this.Controls.Add(this.usersBUTTON);
            this.Controls.Add(this.moviesBUTTON);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button moviesBUTTON;
        private System.Windows.Forms.Button usersBUTTON;
        private System.Windows.Forms.ListBox listLISTBOX;
        private System.Windows.Forms.Label movieIdLABEL;
        private System.Windows.Forms.Label avgRatingLABEL;
        private System.Windows.Forms.TextBox movieIdTEXTBOX;
        private System.Windows.Forms.TextBox avgRatingTEXTBOX;
        private System.Windows.Forms.Label userIdLABEL;
        private System.Windows.Forms.Label occupationLABEL;
        private System.Windows.Forms.TextBox userIdTEXTBOX;
        private System.Windows.Forms.TextBox occupationTEXTBOX;
        private System.Windows.Forms.TextBox filenameTEXTBOX;
        private System.Windows.Forms.TextBox typeMovieNameTEXTBOX;
        private System.Windows.Forms.Button getReviewsBUTTON;
        private System.Windows.Forms.ListBox displayLISTBOX;
        private System.Windows.Forms.TextBox typeUserNameTEXTBOX;
        private System.Windows.Forms.Button userReviewsBUTTON;
        private System.Windows.Forms.Button insertReviewBUTTON;
        private System.Windows.Forms.Label insertReviewUserLABEL;
        private System.Windows.Forms.TextBox insertReviewUserTEXTBOX;
        private System.Windows.Forms.Label insertReviewMovieLABEL;
        private System.Windows.Forms.TextBox insertReviewMovieTEXTBOX;
        private System.Windows.Forms.Button newReviewBUTTON;
        private System.Windows.Forms.TextBox insertReviewRatingTEXTBOX;
        private System.Windows.Forms.Label insertReveiwRatingLABEL;
        private System.Windows.Forms.TextBox summarizeMovieNameTEXTBOX;
        private System.Windows.Forms.TextBox topNRatingTEXTBOX;
        private System.Windows.Forms.Button summarizeMovieBUTTON;
        private System.Windows.Forms.Button getTopNMovieBUTTON;
    }
}

