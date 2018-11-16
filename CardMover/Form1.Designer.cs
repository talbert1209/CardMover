namespace CardMover
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
            this.Deck1 = new System.Windows.Forms.ListBox();
            this.Deck2 = new System.Windows.Forms.ListBox();
            this.MoveToDeck2 = new System.Windows.Forms.Button();
            this.MoveToDeck1 = new System.Windows.Forms.Button();
            this.Deck1Label = new System.Windows.Forms.Label();
            this.Deck2Label = new System.Windows.Forms.Label();
            this.ResetDeck1 = new System.Windows.Forms.Button();
            this.ShuffleDeck1 = new System.Windows.Forms.Button();
            this.ResetDeck2 = new System.Windows.Forms.Button();
            this.ShuffleDeck2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Deck1
            // 
            this.Deck1.FormattingEnabled = true;
            this.Deck1.ItemHeight = 16;
            this.Deck1.Location = new System.Drawing.Point(27, 54);
            this.Deck1.Name = "Deck1";
            this.Deck1.Size = new System.Drawing.Size(234, 500);
            this.Deck1.TabIndex = 0;
            // 
            // Deck2
            // 
            this.Deck2.FormattingEnabled = true;
            this.Deck2.ItemHeight = 16;
            this.Deck2.Location = new System.Drawing.Point(341, 54);
            this.Deck2.Name = "Deck2";
            this.Deck2.Size = new System.Drawing.Size(234, 500);
            this.Deck2.TabIndex = 1;
            // 
            // MoveToDeck2
            // 
            this.MoveToDeck2.Location = new System.Drawing.Point(267, 251);
            this.MoveToDeck2.Name = "MoveToDeck2";
            this.MoveToDeck2.Size = new System.Drawing.Size(68, 32);
            this.MoveToDeck2.TabIndex = 2;
            this.MoveToDeck2.Text = ">>";
            this.MoveToDeck2.UseVisualStyleBackColor = true;
            this.MoveToDeck2.Click += new System.EventHandler(this.MoveToDeck2_Click);
            // 
            // MoveToDeck1
            // 
            this.MoveToDeck1.Location = new System.Drawing.Point(267, 298);
            this.MoveToDeck1.Name = "MoveToDeck1";
            this.MoveToDeck1.Size = new System.Drawing.Size(68, 32);
            this.MoveToDeck1.TabIndex = 3;
            this.MoveToDeck1.Text = "<<";
            this.MoveToDeck1.UseVisualStyleBackColor = true;
            this.MoveToDeck1.Click += new System.EventHandler(this.MoveToDeck1_Click);
            // 
            // Deck1Label
            // 
            this.Deck1Label.AutoSize = true;
            this.Deck1Label.Location = new System.Drawing.Point(24, 31);
            this.Deck1Label.Name = "Deck1Label";
            this.Deck1Label.Size = new System.Drawing.Size(60, 17);
            this.Deck1Label.TabIndex = 4;
            this.Deck1Label.Text = "Deck #1";
            // 
            // Deck2Label
            // 
            this.Deck2Label.AutoSize = true;
            this.Deck2Label.Location = new System.Drawing.Point(338, 31);
            this.Deck2Label.Name = "Deck2Label";
            this.Deck2Label.Size = new System.Drawing.Size(60, 17);
            this.Deck2Label.TabIndex = 5;
            this.Deck2Label.Text = "Deck #2";
            // 
            // ResetDeck1
            // 
            this.ResetDeck1.Location = new System.Drawing.Point(27, 570);
            this.ResetDeck1.Name = "ResetDeck1";
            this.ResetDeck1.Size = new System.Drawing.Size(234, 31);
            this.ResetDeck1.TabIndex = 6;
            this.ResetDeck1.Text = "Reset Deck #1";
            this.ResetDeck1.UseVisualStyleBackColor = true;
            this.ResetDeck1.Click += new System.EventHandler(this.ResetDeck1_Click);
            // 
            // ShuffleDeck1
            // 
            this.ShuffleDeck1.Location = new System.Drawing.Point(27, 617);
            this.ShuffleDeck1.Name = "ShuffleDeck1";
            this.ShuffleDeck1.Size = new System.Drawing.Size(234, 31);
            this.ShuffleDeck1.TabIndex = 7;
            this.ShuffleDeck1.Text = "Shuffle Deck #1";
            this.ShuffleDeck1.UseVisualStyleBackColor = true;
            this.ShuffleDeck1.Click += new System.EventHandler(this.ShuffleDeck1_Click);
            // 
            // ResetDeck2
            // 
            this.ResetDeck2.Location = new System.Drawing.Point(341, 570);
            this.ResetDeck2.Name = "ResetDeck2";
            this.ResetDeck2.Size = new System.Drawing.Size(234, 31);
            this.ResetDeck2.TabIndex = 8;
            this.ResetDeck2.Text = "Reset Deck #2";
            this.ResetDeck2.UseVisualStyleBackColor = true;
            this.ResetDeck2.Click += new System.EventHandler(this.ResetDeck2_Click);
            // 
            // ShuffleDeck2
            // 
            this.ShuffleDeck2.Location = new System.Drawing.Point(341, 617);
            this.ShuffleDeck2.Name = "ShuffleDeck2";
            this.ShuffleDeck2.Size = new System.Drawing.Size(234, 31);
            this.ShuffleDeck2.TabIndex = 9;
            this.ShuffleDeck2.Text = "Shuffle Deck #2";
            this.ShuffleDeck2.UseVisualStyleBackColor = true;
            this.ShuffleDeck2.Click += new System.EventHandler(this.ShuffleDeck2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 678);
            this.Controls.Add(this.ShuffleDeck2);
            this.Controls.Add(this.ResetDeck2);
            this.Controls.Add(this.ShuffleDeck1);
            this.Controls.Add(this.ResetDeck1);
            this.Controls.Add(this.Deck2Label);
            this.Controls.Add(this.Deck1Label);
            this.Controls.Add(this.MoveToDeck1);
            this.Controls.Add(this.MoveToDeck2);
            this.Controls.Add(this.Deck2);
            this.Controls.Add(this.Deck1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Deck1;
        private System.Windows.Forms.ListBox Deck2;
        private System.Windows.Forms.Button MoveToDeck2;
        private System.Windows.Forms.Button MoveToDeck1;
        private System.Windows.Forms.Label Deck1Label;
        private System.Windows.Forms.Label Deck2Label;
        private System.Windows.Forms.Button ResetDeck1;
        private System.Windows.Forms.Button ShuffleDeck1;
        private System.Windows.Forms.Button ResetDeck2;
        private System.Windows.Forms.Button ShuffleDeck2;
    }
}

