
namespace NumberGuessGame
{
    partial class NumberGuessGame
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
            this.btnGenerateSecretNumber = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblNumberGuessingGame = new System.Windows.Forms.Label();
            this.lblLowerLimit = new System.Windows.Forms.Label();
            this.lblUpperLimit = new System.Windows.Forms.Label();
            this.lblMakeAGuess = new System.Windows.Forms.Label();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.lblNumberIs = new System.Windows.Forms.Label();
            this.txtMakeAGuess = new System.Windows.Forms.TextBox();
            this.txtUpperLimit = new System.Windows.Forms.TextBox();
            this.txtLowerLimit = new System.Windows.Forms.TextBox();
            this.lblNumbertxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerateSecretNumber
            // 
            this.btnGenerateSecretNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateSecretNumber.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic);
            this.btnGenerateSecretNumber.Location = new System.Drawing.Point(698, 120);
            this.btnGenerateSecretNumber.Name = "btnGenerateSecretNumber";
            this.btnGenerateSecretNumber.Size = new System.Drawing.Size(329, 59);
            this.btnGenerateSecretNumber.TabIndex = 3;
            this.btnGenerateSecretNumber.Text = "Generate a Secret Number";
            this.btnGenerateSecretNumber.UseVisualStyleBackColor = true;
            this.btnGenerateSecretNumber.Click += new System.EventHandler(this.btnGenerateSecretNumber_Click);
            this.btnGenerateSecretNumber.MouseLeave += new System.EventHandler(this.btnGenerateSecretNumber_MouseLeave);
            this.btnGenerateSecretNumber.MouseHover += new System.EventHandler(this.btnGenerateSecretNumber_MouseHover);
            // 
            // btnPlay
            // 
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic);
            this.btnPlay.Location = new System.Drawing.Point(381, 227);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(86, 48);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            this.btnPlay.MouseHover += new System.EventHandler(this.btnPlay_MouseHover);
            // 
            // lblNumberGuessingGame
            // 
            this.lblNumberGuessingGame.AutoSize = true;
            this.lblNumberGuessingGame.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Italic);
            this.lblNumberGuessingGame.Location = new System.Drawing.Point(239, 24);
            this.lblNumberGuessingGame.Name = "lblNumberGuessingGame";
            this.lblNumberGuessingGame.Size = new System.Drawing.Size(621, 34);
            this.lblNumberGuessingGame.TabIndex = 6;
            this.lblNumberGuessingGame.Text = "WELCOME TO NUMBER GUESSING GAME";
            // 
            // lblLowerLimit
            // 
            this.lblLowerLimit.AutoSize = true;
            this.lblLowerLimit.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic);
            this.lblLowerLimit.Location = new System.Drawing.Point(76, 138);
            this.lblLowerLimit.Name = "lblLowerLimit";
            this.lblLowerLimit.Size = new System.Drawing.Size(150, 29);
            this.lblLowerLimit.TabIndex = 7;
            this.lblLowerLimit.Text = "Lower Limit";
            // 
            // lblUpperLimit
            // 
            this.lblUpperLimit.AutoSize = true;
            this.lblUpperLimit.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic);
            this.lblUpperLimit.Location = new System.Drawing.Point(366, 138);
            this.lblUpperLimit.Name = "lblUpperLimit";
            this.lblUpperLimit.Size = new System.Drawing.Size(151, 29);
            this.lblUpperLimit.TabIndex = 8;
            this.lblUpperLimit.Text = "Upper Limit";
            // 
            // lblMakeAGuess
            // 
            this.lblMakeAGuess.AutoSize = true;
            this.lblMakeAGuess.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic);
            this.lblMakeAGuess.Location = new System.Drawing.Point(76, 237);
            this.lblMakeAGuess.Name = "lblMakeAGuess";
            this.lblMakeAGuess.Size = new System.Drawing.Size(169, 29);
            this.lblMakeAGuess.TabIndex = 9;
            this.lblMakeAGuess.Text = "Make a Guess";
            // 
            // lblAttempts
            // 
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic);
            this.lblAttempts.Location = new System.Drawing.Point(76, 338);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(133, 29);
            this.lblAttempts.TabIndex = 10;
            this.lblAttempts.Text = "Attempts - ";
            // 
            // lblNumberIs
            // 
            this.lblNumberIs.AutoSize = true;
            this.lblNumberIs.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic);
            this.lblNumberIs.Location = new System.Drawing.Point(612, 340);
            this.lblNumberIs.Name = "lblNumberIs";
            this.lblNumberIs.Size = new System.Drawing.Size(0, 29);
            this.lblNumberIs.TabIndex = 7;
            // 
            // txtMakeAGuess
            // 
            this.txtMakeAGuess.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic);
            this.txtMakeAGuess.Location = new System.Drawing.Point(260, 225);
            this.txtMakeAGuess.Multiline = true;
            this.txtMakeAGuess.Name = "txtMakeAGuess";
            this.txtMakeAGuess.Size = new System.Drawing.Size(100, 55);
            this.txtMakeAGuess.TabIndex = 4;
            // 
            // txtUpperLimit
            // 
            this.txtUpperLimit.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic);
            this.txtUpperLimit.Location = new System.Drawing.Point(542, 122);
            this.txtUpperLimit.Multiline = true;
            this.txtUpperLimit.Name = "txtUpperLimit";
            this.txtUpperLimit.Size = new System.Drawing.Size(100, 57);
            this.txtUpperLimit.TabIndex = 2;
            // 
            // txtLowerLimit
            // 
            this.txtLowerLimit.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic);
            this.txtLowerLimit.Location = new System.Drawing.Point(260, 125);
            this.txtLowerLimit.Multiline = true;
            this.txtLowerLimit.Name = "txtLowerLimit";
            this.txtLowerLimit.Size = new System.Drawing.Size(100, 54);
            this.txtLowerLimit.TabIndex = 1;
            // 
            // lblNumbertxt
            // 
            this.lblNumbertxt.AutoSize = true;
            this.lblNumbertxt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic);
            this.lblNumbertxt.Location = new System.Drawing.Point(366, 338);
            this.lblNumbertxt.Name = "lblNumbertxt";
            this.lblNumbertxt.Size = new System.Drawing.Size(179, 29);
            this.lblNumbertxt.TabIndex = 11;
            this.lblNumbertxt.Text = "The Number is";
            // 
            // NumberGuessGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1054, 450);
            this.Controls.Add(this.lblNumbertxt);
            this.Controls.Add(this.txtLowerLimit);
            this.Controls.Add(this.txtUpperLimit);
            this.Controls.Add(this.txtMakeAGuess);
            this.Controls.Add(this.lblNumberIs);
            this.Controls.Add(this.lblAttempts);
            this.Controls.Add(this.lblMakeAGuess);
            this.Controls.Add(this.lblUpperLimit);
            this.Controls.Add(this.lblLowerLimit);
            this.Controls.Add(this.lblNumberGuessingGame);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnGenerateSecretNumber);
            this.Name = "NumberGuessGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Guess Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateSecretNumber;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblNumberGuessingGame;
        private System.Windows.Forms.Label lblLowerLimit;
        private System.Windows.Forms.Label lblUpperLimit;
        private System.Windows.Forms.Label lblMakeAGuess;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.Label lblNumberIs;
        private System.Windows.Forms.TextBox txtMakeAGuess;
        private System.Windows.Forms.TextBox txtUpperLimit;
        private System.Windows.Forms.TextBox txtLowerLimit;
        private System.Windows.Forms.Label lblNumbertxt;
    }
}

